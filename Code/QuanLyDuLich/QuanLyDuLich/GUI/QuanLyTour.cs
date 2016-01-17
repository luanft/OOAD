using BLL;
using DataAccessLayer;
using DataTranferObject;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyDuLich.GUI
{
    partial class frmNhanVienSaleTour : Form
    {

        private Tour tour;
        void cbNguoiDaiDien_SelectedIndexChanged(object sender, EventArgs e)
        {
            dtoKhachHang kh = (dtoKhachHang)cbNguoiDaiDien.SelectedItem;
            String maKhachHang = kh.MAKHACHHANG + "";
            this.txtMaKhachHang.Text = maKhachHang;
        }

        void themLichTrinh(object sender, EventArgs e)
        {
            this.diagThemLt.KhoiTaoForm();
            this.diagThemLt.ShowDialog();
            if (this.diagThemLt.DaThem())
            {
                int ngay = treelichTrinh.Nodes.Count + 1;
                TreeNode node = new TreeNode("Ngày " + ngay + ": " + diagThemLt.LayTenLichTrinh());
                node.ContextMenu = new ContextMenu();
                MenuItem them = new MenuItem("Thêm chi tiết lịch trình");
                MenuItem xoa = new MenuItem("Xóa");
                node.ContextMenu.MenuItems.Add(them);
                node.ContextMenu.MenuItems.Add(xoa);
                them.Click += themChiTiet;
                xoa.Click += xoaLichTrinh;
                this.treelichTrinh.Nodes.Add(node);
            }
        }

        void xoaLichTrinh(object sender, EventArgs e)
        {
            treelichTrinh.Nodes.Remove(treelichTrinh.SelectedNode);
        }

        void themChiTiet(object sender, EventArgs e)
        {
            if (treelichTrinh.SelectedNode.Level == 0)
            {
                diagCTLT.KhoiTaoForm();
                diagCTLT.ShowDialog();
                if (diagCTLT.DaThem)
                {
                    TreeNode node = new TreeNode(this.diagCTLT.ThoiGian);
                    TreeNode doiTac = new TreeNode("Điểm đến: " + this.diagCTLT.DoiTac);
                    TreeNode hoatDong = new TreeNode("Hoạt động: " + this.diagCTLT.HoatDong);
                    node.Nodes.Add(doiTac);
                    node.Nodes.Add(hoatDong);
                    node.ContextMenu = new System.Windows.Forms.ContextMenu();
                    MenuItem xoaItem = new MenuItem("Xóa");
                    xoaItem.Click += xoaChiTiet;
                    node.ContextMenu.MenuItems.Add(xoaItem);
                    treelichTrinh.SelectedNode.Nodes.Add(node);
                }

            }
        }

        void xoaChiTiet(object sender, EventArgs e)
        {
            treelichTrinh.Nodes.Remove(treelichTrinh.SelectedNode);
        }

        void xoaTatCa(object sender, EventArgs e)
        {
            DialogResult rs = MessageBox.Show("Bạn có chắc không?", "Xác nhận!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (rs == System.Windows.Forms.DialogResult.Yes)
            {
                this.treelichTrinh.Nodes.Clear();
            }

        }

        private void ThietLapForm()
        {

            //this.panelDanhSachTour
            for (int i = 0; i < 10; i++)
            {
                XemTour x = new XemTour();
                x.Size = new Size(370, 249);
                this.panelDanhSachTour.Controls.Add(x);
            }
            #region LAP_TOUR

            this.treelichTrinh.ContextMenu = new ContextMenu();
            MenuItem themRoot = new MenuItem("Thêm lịch trình");
            MenuItem xoaRoots = new MenuItem("Xóa tất cả");
            this.treelichTrinh.ContextMenu.MenuItems.Add(themRoot);
            this.treelichTrinh.ContextMenu.MenuItems.Add(xoaRoots);
            xoaRoots.Click += xoaTatCa;
            themRoot.Click += themLichTrinh;
            #endregion


            this.txtNgayLap.Text = DateTime.Now.ToShortDateString();

            dalKhachHang dalKH = new dalKhachHang();
            List<dtoKhachHang> danhSachKhachHang = dalKH.LayDanhSachKhachHang(1);

            foreach (dtoKhachHang k in danhSachKhachHang)
            {
                cbNguoiDaiDien.Items.Add(k);
            }
            cbNguoiDaiDien.DisplayMember = "NGUOIDAIDIEN";
            cbNguoiDaiDien.SelectedIndexChanged += cbNguoiDaiDien_SelectedIndexChanged;


            dalDoiTac doiTac = new dalDoiTac();
            List<dtoDoiTac> huongDanVien = doiTac.LayDanhSachDoiTac("HDV");
            List<dtoDoiTac> nhaXe = doiTac.LayDanhSachDoiTac("NHAXE");
            foreach (dtoDoiTac h in huongDanVien)
            {
                cbHuongDanVien.Items.Add(h);
            }
            foreach (dtoDoiTac nx in nhaXe)
            {
                cbNhaXe.Items.Add(nx);
            }
            cbHuongDanVien.DisplayMember = "NGUOILIENHE";
            cbNhaXe.DisplayMember = "TENDOITAC";
        }


        private void btnThem_Click(object sender, EventArgs e)
        {
            tour = new Tour();
            btnThem.Enabled = false;
            btnLuu.Enabled = true;
            btnHuy.Enabled = true;
            panelLapTour.Enabled = true;
        }


        private void btnLuu_Click(object sender, EventArgs e)
        {
            btnThem.Enabled = true;
            btnLuu.Enabled = false;
            btnHuy.Enabled = false;
            panelLapTour.Enabled = false;

            if (cbHuongDanVien.SelectedItem == null)
            {
                MessageBox.Show("Bạn chưa chọn hướng dẫn viên!");
                return;
            }

            if (cbNguoiDaiDien.SelectedItem == null)
            {
                MessageBox.Show("Bạn chưa chọn khách hàng!");
                return;
            }

            if (cbNhaXe.SelectedItem == null)
            {
                MessageBox.Show("Bạn chưa chọn nhà xe!");
                return;
            }
            if (txtTenTour.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập tên tour!");
                return;
            }

            if (txtThoiGianDi.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập thời gian đi!");
                return;
            }


            tour.NhaXe = new DoiTac();
            tour.HuongDanVien = new DoiTac();
            tour.KhachHang = new KhachHang();

            tour.NhaXe.MaDoiTac = ((DoiTac)cbNhaXe.SelectedItem).MaDoiTac;
            tour.HuongDanVien.MaDoiTac = ((DoiTac)cbHuongDanVien.SelectedItem).MaDoiTac;
            tour.TenTour = tour.TenTour;
            tour.TenKhachHang = ((dtoKhachHang)cbNguoiDaiDien.SelectedItem).NGUOIDAIDIEN;
            tour.KhachHang.pMaKhachHang = ((dtoKhachHang)cbNguoiDaiDien.SelectedItem).MAKHACHHANG;

            tour.NgayDi = dtNgayDi.Value;
            tour.ThoiGian = txtThoiGianDi.Text;


        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            btnThem.Enabled = true;
            btnLuu.Enabled = false;
            btnHuy.Enabled = false;
            panelLapTour.Enabled = false;
        }

    }
}
