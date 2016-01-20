using BLL;
using DataAccessLayer;
using DataTranferObject;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyDuLich.GUI
{
    partial class frmNhanVienSaleTour : Form
    {
        private bool capNhatTour = false;
        int maNhanVien = 1;

        public int MaNhanVien
        {
            get { return maNhanVien; }
            set { maNhanVien = value; }
        }
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
                int ngay = lichTrinhTour.Nodes.Count + 1;

                LichTrinh lichTrinh = new LichTrinh();
                lichTrinh.Ngay = ngay.ToString();
                lichTrinh.TenLichTrinh = diagThemLt.LayTenLichTrinh();
                tour.LichTrinh.Add(lichTrinh);

                TreeNode node = new LichTrinhNode("Ngày " + lichTrinh.Ngay + ": " + lichTrinh.TenLichTrinh, lichTrinh);
                node.ContextMenu = new ContextMenu();
                MenuItem them = new MenuItem("Thêm chi tiết lịch trình");
                MenuItem xoa = new MenuItem("Xóa");
                node.ContextMenu.MenuItems.Add(them);
                node.ContextMenu.MenuItems.Add(xoa);
                them.Click += themChiTiet;
                xoa.Click += xoaLichTrinh;
                this.lichTrinhTour.Nodes.Add(node);
            }
        }

        void xoaLichTrinh(object sender, EventArgs e)
        {
            LichTrinhNode node = (LichTrinhNode)lichTrinhTour.SelectedNode;
            if (node == null) return;
            tour.LichTrinh.Remove(node.LichTrinh);
            node.LichTrinh.Xoa();
            lichTrinhTour.Nodes.Remove(lichTrinhTour.SelectedNode);
        }

        void themChiTiet(object sender, EventArgs e)
        {

            if (lichTrinhTour.SelectedNode == null) return;
            if (lichTrinhTour.SelectedNode.Level == 0)
            {
                LichTrinhNode lichTrinhNode = (LichTrinhNode)lichTrinhTour.SelectedNode;
                diagCTLT.KhoiTaoForm();
                diagCTLT.ShowDialog();
                if (diagCTLT.DaThem)
                {
                    ChiTietLichTrinh chiTiet = new ChiTietLichTrinh();
                    dtoDoiTac dto = this.diagCTLT.DoiTac;
                    if (dto != null)
                    {
                        chiTiet.DoiTac.MaDoiTac = dto.MADOITAC;
                        chiTiet.DoiTac.TenDoiTac = dto.TENDOITAC;
                    }
                    chiTiet.NoiDung = this.diagCTLT.HoatDong;
                    chiTiet.ThoiGian = this.diagCTLT.ThoiGian;

                    TreeNode node = new ChiTietNode(this.diagCTLT.ThoiGian, chiTiet);
                    TreeNode doiTac = new TreeNode("Đối tác: " + chiTiet.DoiTac.TenDoiTac);
                    TreeNode hoatDong = new TreeNode("Hoạt động: " + chiTiet.NoiDung);

                    lichTrinhNode.LichTrinh.pChiTietLichTrinh.Add(chiTiet);

                    node.Nodes.Add(doiTac);
                    node.Nodes.Add(hoatDong);
                    node.ContextMenu = new System.Windows.Forms.ContextMenu();
                    MenuItem xoaItem = new MenuItem("Xóa");
                    xoaItem.Click += xoaChiTiet;
                    node.ContextMenu.MenuItems.Add(xoaItem);
                    lichTrinhTour.SelectedNode.Nodes.Add(node);
                }

            }
        }

        void xoaChiTiet(object sender, EventArgs e)
        {
            if (lichTrinhTour.SelectedNode != null)
            {
                if (lichTrinhTour.SelectedNode.Level == 1)
                {
                    ChiTietNode ctNode = (ChiTietNode)lichTrinhTour.SelectedNode;
                    LichTrinhNode ltNode = (LichTrinhNode)ctNode.Parent;
                    ltNode.LichTrinh.pChiTietLichTrinh.Remove(ctNode.ChiTiet);
                    ctNode.ChiTiet.Xoa();
                    lichTrinhTour.Nodes.Remove(lichTrinhTour.SelectedNode);
                }

            }

        }

        void xoaTatCa(object sender, EventArgs e)
        {
            DialogResult rs = MessageBox.Show("Bạn có chắc không?", "Xác nhận!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (rs == System.Windows.Forms.DialogResult.Yes)
            {
                this.lichTrinhTour.Nodes.Clear();
                tour.LichTrinh.Clear();
            }

        }

        private void ThietLapForm()
        {

            //this.panelDanhSachTour

            dalTour _dalTour = new dalTour();
            
            List<dtoTour> ltour = _dalTour.LayDanhSachTour(MaNhanVien);
            foreach (dtoTour i in ltour)
            {
                XemTour x = new XemTour();
                x.Size = new Size(370, 249);
                this.panelDanhSachTour.Controls.Add(x);                
                x.init(i);
                x.OnEditing += ChinhSuaTour;
                x.OnDeleting += xoaTour;
            }
            
            List<int> years = _dalTour.getYears();
            foreach(int i in years)
            {
                cbYear.Items.Add(i);
            }            



            #region LAP_TOUR

            this.lichTrinhTour.ContextMenu = new ContextMenu();
            MenuItem themRoot = new MenuItem("Thêm lịch trình");
            MenuItem xoaRoots = new MenuItem("Xóa tất cả");
            this.lichTrinhTour.ContextMenu.MenuItems.Add(themRoot);
            this.lichTrinhTour.ContextMenu.MenuItems.Add(xoaRoots);
            xoaRoots.Click += xoaTatCa;
            themRoot.Click += themLichTrinh;
            #endregion


            this.txtNgayLap.Text = DateTime.Now.ToShortDateString();

            dalKhachHang dalKH = new dalKhachHang();
            List<dtoKhachHang> danhSachKhachHang = dalKH.LayDanhSachKhachHang(MaNhanVien);

            foreach (dtoKhachHang k in danhSachKhachHang)
            {
                cbNguoiDaiDien.Items.Add(k);
            }
            cbNguoiDaiDien.DisplayMember = "NGUOIDAIDIEN";
            cbNguoiDaiDien.SelectedIndexChanged += cbNguoiDaiDien_SelectedIndexChanged;


            dalDoiTac doiTac = new dalDoiTac();
            List<dtoDoiTac> huongDanVien = doiTac.LayDanhSachDoiTac("HUONGDANVIEN");
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

        void xoaTour(XemTour tour)
        {
            panelDanhSachTour.Controls.Remove(tour);
        }

        private void ChinhSuaTour(int maTour)
        {
            tabControl.SelectedTab = tabLapTour;

            dalTour dal = new dalTour();

            //them tour
            tour = dal.LoadTour(maTour);
            btnThem.Enabled = false;
            btnLuu.Enabled = true;
            btnHuy.Enabled = true;
            panelLapTour.Enabled = true;

            txtTenTour.Text = tour.TenTour;
            txtGhiChu.Text = tour.GhiChu;
            txtNgayLap.Text = tour.NgayLapTour.ToShortDateString();
            dtNgayDi.Value = tour.NgayDi;
            txtThoiGianDi.Text = tour.ThoiGian;
            txtUuDai.Text = tour.UuDai;
            txtThongTinTour.Text = tour.ThongTinTour;




            foreach (LichTrinh l in tour.LichTrinh)
            {
                TreeNode node = new LichTrinhNode("Ngày " + l.Ngay + ": " + l.TenLichTrinh, l);
                node.ContextMenu = new ContextMenu();
                MenuItem them = new MenuItem("Thêm chi tiết lịch trình");
                MenuItem xoa = new MenuItem("Xóa");
                node.ContextMenu.MenuItems.Add(them);
                node.ContextMenu.MenuItems.Add(xoa);
                them.Click += themChiTiet;
                xoa.Click += xoaLichTrinh;
                this.lichTrinhTour.Nodes.Add(node);
                foreach (ChiTietLichTrinh c in l.pChiTietLichTrinh)
                {
                    TreeNode nd = new ChiTietNode(c.ThoiGian, c);
                    string diemDen = c.DoiTac == null ? "" : c.DoiTac.TenDoiTac;
                    TreeNode doiTac = new TreeNode("Đối tác: " + diemDen);
                    TreeNode hoatDong = new TreeNode("Hoạt động: " + c.NoiDung);

                    nd.Nodes.Add(doiTac);
                    nd.Nodes.Add(hoatDong);
                    nd.ContextMenu = new System.Windows.Forms.ContextMenu();
                    MenuItem xoaItem = new MenuItem("Xóa");
                    xoaItem.Click += xoaChiTiet;
                    nd.ContextMenu.MenuItems.Add(xoaItem);
                    node.Nodes.Add(nd);
                }
            }
            capNhatTour = true;
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
            if (txtThongTinTour.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập thông tin tour!");
                return;
            }
            if (lichTrinhTour.Nodes.Count == 0)
            {
                MessageBox.Show("Bạn chưa soạn lịch trình tour!");
                return;
            }


            tour.NhaXe.MaDoiTac = ((dtoDoiTac)cbNhaXe.SelectedItem).MADOITAC;
            tour.HuongDanVien.MaDoiTac = ((dtoDoiTac)cbHuongDanVien.SelectedItem).MADOITAC;
            tour.TenTour = txtTenTour.Text;
            tour.TenKhachHang = ((dtoKhachHang)cbNguoiDaiDien.SelectedItem).NGUOIDAIDIEN;
            tour.KhachHang.pMaKhachHang = ((dtoKhachHang)cbNguoiDaiDien.SelectedItem).MAKHACHHANG;

            tour.NgayDi = dtNgayDi.Value;
            tour.ThoiGian = txtThoiGianDi.Text;
            tour.TongGiaTour = "0";
            tour.TrangThai = "MOI_LAP";
            tour.UuDai = txtUuDai.Text;
            tour.MaNhanVien = MaNhanVien;
            tour.GhiChu = txtGhiChu.Text;
            tour.NgayLapTour = DateTime.Now;
            tour.ThongTinTour = txtThongTinTour.Text;

            if (capNhatTour)
            {
                if (nhanVienSale.CapNhatTour(tour))
                {                    
                    btnThem.Enabled = true;
                    btnLuu.Enabled = false;
                    btnHuy.Enabled = false;
                    panelLapTour.Enabled = false;
                    txtTenTour.Text = "";
                    txtUuDai.Text = "";
                    txtThoiGianDi.Text = "";
                    txtGhiChu.Text = "";
                    lichTrinhTour.Nodes.Clear();
                    txtThongTinTour.Text = "";
                    capNhatTour = false;
                    frmXemChiTietTour xem = new frmXemChiTietTour(tour);
                    xem.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Đã có lỗi xảy ra với cơ sở dữ liệu!");
                }
            }
            else
            {
                if (nhanVienSale.LapTour(tour))
                {                    
                    btnThem.Enabled = true;
                    btnLuu.Enabled = false;
                    btnHuy.Enabled = false;
                    panelLapTour.Enabled = false;
                    txtTenTour.Text = "";
                    txtUuDai.Text = "";
                    txtThoiGianDi.Text = "";
                    txtGhiChu.Text = "";
                    txtThongTinTour.Text = "";
                    lichTrinhTour.Nodes.Clear();
                    dalTour dal = new dalTour();
                    int ma = dal.GetLastInsert(maNhanVien);
                    if(ma > 0)
                    {
                        frmXemChiTietTour xem = new frmXemChiTietTour(dal.LoadTour(ma));
                        xem.ShowDialog();
                    }
                    dalTour _dalTour = new dalTour();


                    panelDanhSachTour.Controls.Clear();
                    List<dtoTour> ltour = _dalTour.LayDanhSachTour(MaNhanVien);
                    foreach (dtoTour i in ltour)
                    {
                        XemTour x = new XemTour();
                        x.Size = new Size(370, 249);
                        this.panelDanhSachTour.Controls.Add(x);
                        x.init(i);
                        x.OnEditing += ChinhSuaTour;
                        x.OnDeleting += xoaTour;
                    }                    
                }
                else
                {
                    MessageBox.Show("Đã có lỗi xảy ra với cơ sở dữ liệu!");
                }
            }




        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            btnThem.Enabled = true;
            btnLuu.Enabled = false;
            btnHuy.Enabled = false;
            panelLapTour.Enabled = false;
            txtTenTour.Text = "";
            txtUuDai.Text = "";
            txtThoiGianDi.Text = "";
            txtGhiChu.Text = "";
            txtThongTinTour.Text = "";
        }


        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbYear.SelectedItem != null)
            {
                panelDanhSachTour.Controls.Clear();
                dalTour _dalTour = new dalTour();
                int dr = (int)cbYear.SelectedItem;
                List<dtoTour> ltour = _dalTour.LayDanhSachTour(MaNhanVien,dr);
                foreach (dtoTour i in ltour)
                {
                    XemTour x = new XemTour();
                    x.Size = new Size(370, 249);
                    this.panelDanhSachTour.Controls.Add(x);
                    x.init(i);
                    x.OnEditing += ChinhSuaTour;
                    x.OnDeleting += xoaTour;
                }
            }
        }
    }
}
