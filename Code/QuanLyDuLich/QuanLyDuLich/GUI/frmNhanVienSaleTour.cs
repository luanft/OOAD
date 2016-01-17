﻿using DataAccessLayer;
using DataTranferObject;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyDuLich.GUI
{
    public partial class frmNhanVienSaleTour : Form
    {
        public frmNhanVienSaleTour()
        {
            InitializeComponent();
        }


        private diagThemLichTrinh diagThemLt = new diagThemLichTrinh();
        private diagChiTietLichTrinh diagCTLT = new diagChiTietLichTrinh();

        private void frmNhanVienSaleTour_Load(object sender, EventArgs e)
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
            xoaRoots.Click += xoaRoots_Click;
            themRoot.Click += themRoot_Click;
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

        void cbNguoiDaiDien_SelectedIndexChanged(object sender, EventArgs e)
        {
            dtoKhachHang kh = (dtoKhachHang)cbNguoiDaiDien.SelectedItem;
            String maKhachHang = kh.MAKHACHHANG + "";
            this.txtMaKhachHang.Text = maKhachHang;
        }

        void themRoot_Click(object sender, EventArgs e)
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
                them.Click += them_Click;
                xoa.Click += xoa_Click;
                this.treelichTrinh.Nodes.Add(node);
            }
        }

        void xoa_Click(object sender, EventArgs e)
        {
            treelichTrinh.Nodes.Remove(treelichTrinh.SelectedNode);
        }

        void them_Click(object sender, EventArgs e)
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
                    xoaItem.Click += xoaItem_Click;
                    node.ContextMenu.MenuItems.Add(xoaItem);
                    treelichTrinh.SelectedNode.Nodes.Add(node);
                }

            }
        }

        void xoaItem_Click(object sender, EventArgs e)
        {
            treelichTrinh.Nodes.Remove(treelichTrinh.SelectedNode);
        }

        void xoaRoots_Click(object sender, EventArgs e)
        {
            DialogResult rs = MessageBox.Show("Bạn có chắc không?", "Xác nhận!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (rs == System.Windows.Forms.DialogResult.Yes)
            {
                this.treelichTrinh.Nodes.Clear();
            }

        }
        private void tb_SoDT_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !((e.KeyChar >= 48 && e.KeyChar <= 57) || e.KeyChar == 8);
        }
        










    }
}
