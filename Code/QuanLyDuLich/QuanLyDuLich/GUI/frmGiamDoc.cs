﻿using BLL;
using DataAccessLayer;
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
    public partial class frmGiamDoc : Form
    {

        GiamDoc giamdoc;
        public frmGiamDoc()
        {
            giamdoc = new GiamDoc();
            InitializeComponent();
        }
        public frmGiamDoc(int manv)
        {

            giamdoc = new GiamDoc();
            giamdoc.pMaNhanVien = manv;

            InitializeComponent();
        }
        private void frmGiamDoc_Load(object sender, EventArgs e)
        {
            textBox_CMND.ShortcutsEnabled = false;
            textBox_SoDienThoai.ShortcutsEnabled = false;
            label_TenGiamDoc.Text = "Xin chào " + giamdoc.LayThongTinNhanVien(giamdoc.pMaNhanVien).HOTEN.ToString() + ". Have a nice day!";

            #region QuanLyPhongBan
            dataGridView_DanhSachPhong.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView_DanhSachPhong.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView_DanhSachPhong.AutoGenerateColumns = false;
            tabPage_QuanLyPhongBan_Click(sender, e);
            #endregion
            #region QuanLyNhanVien

            dataGridView_DanhSachNhanVien.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView_DanhSachNhanVien.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView_DanhSachNhanVien.AutoGenerateColumns = false;
            LockControlValues(tabPage_QuanLyNhanVien);
            tabPage_QuanLyNhanVien_Click(sender, e);
            #endregion
            #region ThongKe

            dataGridView_ThongKe.AutoGenerateColumns = false;
            label_NgayThongKe.Text = DateTime.Now.ToString("dd/MM/yyy");
            #endregion
            #region DinhGiaTour

            tabPage_XetDuyetTour_Click(sender, e);
            #endregion

        }

        public void LockControlValues(System.Windows.Forms.Control Container)
        {
            try
            {

                foreach (Control ctrl in Container.Controls)
                {
                    if (ctrl.GetType() == typeof(TextBox))
                        ((TextBox)ctrl).ReadOnly = true;
                    //if (ctrl.GetType() == typeof(ComboBox))
                    //    ((ComboBox)ctrl).Enabled = false;
                    if (ctrl.GetType() == typeof(CheckBox))
                        ((CheckBox)ctrl).Enabled = false;
                    if (ctrl.GetType() == typeof(RadioButton))
                        ((RadioButton)ctrl).Enabled = false;
                    if (ctrl.GetType() == typeof(DateTimePicker))
                        ((DateTimePicker)ctrl).Enabled = false;

                    if (ctrl.Controls.Count > 0)
                        LockControlValues(ctrl);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        public void UnLockControlValues(System.Windows.Forms.Control Container)
        {
            try
            {
                comboBox2_PhongBan.Enabled = true;
                button_Huy.Enabled = true;
                button_Luu.Enabled = true;
                foreach (Control ctrl in Container.Controls)
                {
                    if (ctrl.GetType() == typeof(TextBox))
                        ((TextBox)ctrl).ReadOnly = false;
                    //if (ctrl.GetType() == typeof(ComboBox))
                    //    ((ComboBox)ctrl).Enabled = false;
                    if (ctrl.GetType() == typeof(CheckBox))
                        ((CheckBox)ctrl).Enabled = true;
                    if (ctrl.GetType() == typeof(RadioButton))
                        ((RadioButton)ctrl).Enabled = true;
                    if (ctrl.GetType() == typeof(DateTimePicker))
                        ((DateTimePicker)ctrl).Enabled = true;

                    if (ctrl.Controls.Count > 0)
                        UnLockControlValues(ctrl);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        public void ClearForm(System.Windows.Forms.Control Container)
        {
            try
            {
                foreach (Control ctrl in Container.Controls)
                {
                    if (ctrl.GetType() == typeof(TextBox))
                        ((TextBox)ctrl).Text = "";

                    if (ctrl.GetType() == typeof(DateTimePicker))
                        ((DateTimePicker)ctrl).Value = DateTime.Now;

                    if (ctrl.Controls.Count > 0)
                        ClearForm(ctrl);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        #region QuanLyNhanVien
        private void tabPage_QuanLyNhanVien_Click(object sender, EventArgs e)
        {
            PhongBan phongban = new PhongBan();
            List<dtoPhongBan> lDTO_phongban = phongban.LayDanhSachPhongBan();
            List<dtoPhongBan> lDTO_phongban2 = phongban.LayDanhSachPhongBan();
            comboBox1_PhongBan.DataSource = lDTO_phongban;
            comboBox1_PhongBan.DisplayMember = "TenPhong";
            comboBox1_PhongBan.ValueMember = "MaPhong";
            comboBox1_PhongBan.SelectedValue = 1;

            comboBox2_PhongBan.DataSource = lDTO_phongban2;
            comboBox2_PhongBan.DisplayMember = "TenPhong";
            comboBox2_PhongBan.ValueMember = "MaPhong";
            comboBox2_PhongBan.SelectedValue = 1;

            NhanVien nhanvien = new NhanVien();
            dataGridView_DanhSachNhanVien.DataSource = nhanvien.LayDanhSachNhanVien(1);
            dataGridView_DanhSachPhong.DataSource = lDTO_phongban;
        }

        private void dataGridView_DanhSachNhanVien_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView_DanhSachNhanVien.SelectedCells.Count > 0)
            {
                int selectedRowIndex = dataGridView_DanhSachNhanVien.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dataGridView_DanhSachNhanVien.Rows[selectedRowIndex];
                NhanVien nhanvien = new NhanVien();

                nhanvien = giamdoc.ChonNhanVien(Int32.Parse(selectedRow.Cells["MaNhanVien"].Value.ToString()));
                if(nhanvien!=null)
                {
                    dtoNhanVien dto_nhanvien = nhanvien.GetDTONhanVien();
                    textBox_HoTen.Text = dto_nhanvien.HOTEN;
                    if (dto_nhanvien.GIOITINH == "Nam")
                    {
                        radioButton_Nam.Checked = true;
                    }
                    else
                    {
                        radioButton_Nu.Checked = true;
                    }
                    dateTimePicker_NgaySinh.Value = dto_nhanvien.NGAYSINH;
                    textBox_CMND.Text = dto_nhanvien.CMND;
                    textBox_DiaChi.Text = dto_nhanvien.DIACHI;
                    textBox_Email.Text = dto_nhanvien.EMAIL;
                    textBox_SoDienThoai.Text = dto_nhanvien.SODT;
                    textBox_QueQuan.Text = dto_nhanvien.QUEQUAN;
                    textBox_MatKhau.Text = dto_nhanvien.MATKHAU;
                    comboBox2_PhongBan.SelectedValue = dto_nhanvien.MAPHONG;

                    label_MaNhanVien.Text = dto_nhanvien.MANHANVIEN.ToString();
                    if (giamdoc.pMaNhanVien.Equals(dto_nhanvien.MANHANVIEN))
                    {
                        button_XoaNhanVien.Enabled = false;
                    }
                    else
                    {
                        button_XoaNhanVien.Enabled = true;
                    }
                }
              
            }
        }

        private void comboBox1_PhongBan_SelectedIndexChanged(object sender, EventArgs e)
        {
            button_ThemNhanVien.Enabled = true;
            button_XoaNhanVien.Enabled = true;
            button_Sua.Enabled = true;
            button_Huy.Enabled = false;
            button_Luu.Enabled = false;
            LockControlValues(tabPage_QuanLyNhanVien);
            dtoPhongBan dto_phongban = new dtoPhongBan();
            dto_phongban = (dtoPhongBan)comboBox1_PhongBan.SelectedItem;
            NhanVien nhanvien = new NhanVien();
            dataGridView_DanhSachNhanVien.DataSource = nhanvien.LayDanhSachNhanVien(dto_phongban.MAPHONG);
            if (dataGridView_DanhSachNhanVien.DataSource == null)
            {
                dataGridView_DanhSachNhanVien.AllowUserToAddRows = false;    
                button_XoaNhanVien.Enabled = false;
                button_Sua.Enabled = false;
                label_MaNhanVien.Text = "#";
                ClearForm(tabPage_QuanLyNhanVien);
            }
        }

        private void button_Sua_Click(object sender, EventArgs e)
        {
            UnLockControlValues(tabPage_QuanLyNhanVien);
            button_Sua.Enabled = false;
            button_ThemNhanVien.Enabled = false;
            button_XoaNhanVien.Enabled = false;
        }

        private void button_Huy_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Những thông tin vừa được thêm vào sẽ không được lưu lại,bạn có muốn hủy không?", "Thông báo", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                comboBox2_PhongBan.Enabled = false;
                button_ThemNhanVien.Enabled = true;
                if (!giamdoc.pMaNhanVien.Equals(Int32.Parse(label_MaNhanVien.Text)))
                {
                    button_XoaNhanVien.Enabled = true;
                }       
                button_Sua.Enabled = true;
                button_Huy.Enabled = false;
                button_Luu.Enabled = false;
                LockControlValues(tabPage_QuanLyNhanVien);
                dataGridView_DanhSachNhanVien_SelectionChanged(sender, e);
            }
            else if (dialogResult == DialogResult.No)
            {
                //do something else
            }
        }

        private void button_ThemNhanVien_Click(object sender, EventArgs e)
        {
            button_ThemNhanVien.Enabled = false;
            ClearForm(tabPage_QuanLyNhanVien);
            UnLockControlValues(tabPage_QuanLyNhanVien);
            button_Sua.Enabled = false;
            button_XoaNhanVien.Enabled = false;
            radioButton_Nam.Checked = true;
            NhanVien nhanvien = new NhanVien();
            List<dtoNhanVien> lDTO_nhanvien = nhanvien.LayDanhSachNhanVien();
            int MaxMaNV = 0;
            foreach (dtoNhanVien dtonv in lDTO_nhanvien)
            {
                if (dtonv.MANHANVIEN > MaxMaNV)
                {
                    MaxMaNV = dtonv.MANHANVIEN;
                }
            }
            label_MaNhanVien.Text = (MaxMaNV + 1).ToString();
        }

        private void button_Luu_Click(object sender, EventArgs e)
        {
            NhanVien nhanvien = new NhanVien();
            nhanvien.pMaNhanVien = Int32.Parse(label_MaNhanVien.Text);
            nhanvien.pHoTen = textBox_HoTen.Text;
            if (radioButton_Nam.Checked)
            {
                nhanvien.pGioiTinh = "Nam";
            }
            else
            {
                nhanvien.pGioiTinh = "Nu";
            }
            nhanvien.pMatKhau = textBox_MatKhau.Text;
            nhanvien.pQueQuan = textBox_QueQuan.Text;
            nhanvien.pSoDT = textBox_SoDienThoai.Text;
            nhanvien.pNgaySinh = dateTimePicker_NgaySinh.Value;
            nhanvien.pCMND = textBox_CMND.Text;
            nhanvien.pDiaChi = textBox_DiaChi.Text;
            nhanvien.pEmail = textBox_Email.Text;
            dtoPhongBan dto_phongban = new dtoPhongBan();
            dto_phongban = (dtoPhongBan)comboBox2_PhongBan.SelectedItem;
            nhanvien.pMaPhong = dto_phongban.MAPHONG;

            if (textBox_CMND.Text == "" || textBox_DiaChi.Text == "" || textBox_Email.Text == "" || textBox_HoTen.Text == ""
                 || textBox_MatKhau.Text == "" || textBox_QueQuan.Text == "" || textBox_SoDienThoai.Text == "")
            {
                MessageBox.Show("Thông tin nhân viên không được trống!");
            }
            else
            {
                bool ok = false;
                if (nhanvien.CoTonTai(nhanvien.pMaNhanVien))
                {
                    if (nhanvien.CapNhat())
                    {
                        ok = true;
                        MessageBox.Show("Thông tin nhân viên đã được cập nhật");
                    }
                    else
                    {
                        MessageBox.Show("Không thể ghi dữ liệu");
                    }

                }
                else
                {
                    if (nhanvien.Luu())
                    {
                        MessageBox.Show("Đã thêm nhân viên");
                    }

                    else
                        MessageBox.Show("Có lỗi xảy ra, không thể thêm nhân viên");
                }
                comboBox1_PhongBan_SelectedIndexChanged(sender, e);
                dataGridView_DanhSachNhanVien_SelectionChanged(sender, e);
                LockControlValues(tabPage_QuanLyNhanVien);
                button_ThemNhanVien.Enabled = true;
                if (!giamdoc.pMaNhanVien.Equals(Int32.Parse(label_MaNhanVien.Text)))
                {
                    button_XoaNhanVien.Enabled = true;
                }                
                button_Sua.Enabled = true;
                button_Huy.Enabled = false;
                button_Luu.Enabled = false;
                comboBox2_PhongBan.Enabled = false;
            }
        }

        private void button_XoaNhanVien_Click(object sender, EventArgs e)
        {
            NhanVien nhanvien = new NhanVien(giamdoc.LayThongTinNhanVien(Int32.Parse(label_MaNhanVien.Text)));
            
         
            DialogResult dialogResult = MessageBox.Show("Chọn Yes để xác nhận xóa nhân viên này", "Thông báo", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                if(nhanvien.Xoa())
                {
                    
                    button_ThemNhanVien.Enabled = true;
                    if (!giamdoc.pMaNhanVien.Equals(Int32.Parse(label_MaNhanVien.Text)))
                    {

                        button_XoaNhanVien.Enabled = true;
                    }
                    button_Sua.Enabled = true;
                    button_Huy.Enabled = false;
                    button_Luu.Enabled = false;
                    LockControlValues(tabPage_QuanLyNhanVien);
                    comboBox1_PhongBan_SelectedIndexChanged(sender, e);
                    dataGridView_DanhSachNhanVien_SelectionChanged(sender, e);
                    MessageBox.Show("Đã xóa nhân viên!");
                }
                else
                {
                    MessageBox.Show("Phải xóa đối tác!");
                }
             
            }
            else if (dialogResult == DialogResult.No)
            {
                //do something else
            }
        }
        #endregion
        #region ThongKe
        private void button_ThongKe_Click(object sender, EventArgs e)
        {
            dalTour dal_tour = new dalTour();
            label_ThoiGianThongKe.Text = dateTimePicker_TuNgay.Value.Date.ToShortDateString() + " - " + dateTimePicker_DenNgay.Value.Date.ToShortDateString();
            DataTable dt_thongke = dal_tour.LayDanhSachTourThongKe(dateTimePicker_TuNgay.Value, dateTimePicker_DenNgay.Value);
            int tongTour = 0;
            int tongDoanhThu = 0;
            if (dt_thongke.Rows.Count < 1)
            {                
                dataGridView_ThongKe.DataSource = dt_thongke;
                label_TongTour.Text = tongTour.ToString() + " tour";
                label_TongDoanhThu.Text = tongDoanhThu.ToString() + " VND";
                MessageBox.Show("Không có tour nào được bán trong khoảng thời gian đã chọn!");
            }
            else
            {
                button_InThongKe.Enabled = true;
                dataGridView_ThongKe.DataSource = dt_thongke;
               
                foreach (DataRow dr in dt_thongke.Rows)
                {
                    tongDoanhThu += Int32.Parse(dr["TONGGIATOUR"].ToString());
                    tongTour++;
                }
                label_TongTour.Text = tongTour.ToString() + " tour";
                label_TongDoanhThu.Text = tongDoanhThu.ToString() + " triệu VND";
            }

        }
        private void dateTimePicker_TuNgay_ValueChanged(object sender, EventArgs e)
        {
            dateTimePicker_DenNgay.MinDate = dateTimePicker_TuNgay.Value;
        }
        Bitmap MemoryImage;
        public void GetPrintArea(Panel pnl)
        {
            MemoryImage = new Bitmap(pnl.Width, pnl.Height);
            pnl.DrawToBitmap(MemoryImage, new Rectangle(0, 0, pnl.Width, pnl.Height));
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            if (MemoryImage != null)
            {
                e.Graphics.DrawImage(MemoryImage, 0, 0);
                base.OnPaint(e);
            }
        }
        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Rectangle pagearea = e.PageBounds;
            e.Graphics.DrawImage(MemoryImage, (pagearea.Width / 2) - (this.panel_ThongKe.Width / 2), this.panel_ThongKe.Location.Y);
        }

        public void Print(Panel pnl)
        {

            GetPrintArea(pnl);
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
        }
        private void button_InThongKe_Click(object sender, EventArgs e)
        {
            Print(panel_ThongKe);
        }



        #endregion
        #region DinhGiaTour
        private void tabPage_XetDuyetTour_Click(object sender, EventArgs e)
        {
            giamdoc.LayDanhSachTourCanDuyet();
            int soTourCanDuyet = 0;
            foreach (Tour t in giamdoc.pDanhSachTourCanDuyet)
            {
                soTourCanDuyet++;
            }
            if (soTourCanDuyet != 0)
            {
                button_BanGiaoTourDaDuyet.Enabled = true;
            }
            else
            {
                button_BanGiaoTourDaDuyet.Enabled = false;
            }
            label_SoTourCanDuyet.Text = soTourCanDuyet.ToString();
            dataGridView_DanhSachTourCanDuyet.AutoGenerateColumns = false;
            dataGridView_DanhSachTourCanDuyet.DataSource = giamdoc.pDanhSachTourCanDuyet;
        }
        private void button_BanGiaoTourDaDuyet_Click(object sender, EventArgs e)
        {
            bool ok = true;
            dalTour dal_tour = new dalTour();
            foreach (Tour t in giamdoc.pDanhSachTourCanDuyet)
            {
                if (!t.CapNhatLanCuoi())
                {
                    ok = false;
                }
            }
            if (!ok)
            {
                MessageBox.Show("Dữ liệu nhập vào không đúng, vui lòng nhập lại.");
            }
            else
            {
                MessageBox.Show("Đã lưu lại những tour đã duyệt");
                tabPage_XetDuyetTour_Click(sender, e);

            }
        }

        private void dataGridView_DanhSachTourCanDuyet_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Tour tourDaChon = new global::BLL.Tour();
            tourDaChon = giamdoc.ChonTourCanDuyet(int.Parse(dataGridView_DanhSachTourCanDuyet.Rows[e.RowIndex].Cells["MaTour"].Value.ToString()));
            frmXemChiTietTour xemChiTietTour = new frmXemChiTietTour(tourDaChon);
            xemChiTietTour.Show();
        }
        #endregion
        #region QuanLyPhongBan
        private void dataGridView_DanhSachPhong_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView_DanhSachPhong.SelectedCells.Count > 0)
            {
                int selectedRowIndex = dataGridView_DanhSachPhong.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dataGridView_DanhSachPhong.Rows[selectedRowIndex];
                PhongBan phongban = new PhongBan();
                dtoPhongBan dto_phongban = phongban.LayThongTinPhong(selectedRow.Cells["MaPhong"].Value.ToString());
                textBox_TenPhong.Text = dto_phongban.TENPHONG;
                label_MaPhong.Text = dto_phongban.MAPHONG.ToString();
                NhanVien nhanvien = new NhanVien();
                List<dtoNhanVien> lDTO_nhanvien = new List<dtoNhanVien>();
                lDTO_nhanvien = nhanvien.LayDanhSachNhanVien(Int32.Parse(selectedRow.Cells["MaPhong"].Value.ToString()));
                if(lDTO_nhanvien!=null)
                {
                    label_SoLuongNhanVien.Text = lDTO_nhanvien.Count.ToString();
                }
                else
                {
                    label_SoLuongNhanVien.Text = "0";
                }
            }
        }
        private void button_LuuLai_Click(object sender, EventArgs e)
        {
            PhongBan phongban = new PhongBan();

            dtoPhongBan dto_phongban = phongban.LayThongTinPhong(label_MaPhong.Text.ToString());
            if (textBox_TenPhong.Text == "")
            {
                MessageBox.Show("Mời nhập tên phòng ban!");
            }
            else
            {

                if (dto_phongban != null)
                {
                    dto_phongban.TENPHONG = textBox_TenPhong.Text;
                    if (phongban.SuaThongTinPhong(dto_phongban))
                    {
                        MessageBox.Show("Đã cập nhật tên phòng");
                        textBox_TenPhong.ReadOnly = true;
                        button_LuuLai.Enabled = false;
                        button_HuySuaPhong.Enabled = false;
                       
                        button_ThemPhong.Enabled = true;
                        button_SuaTenPhong.Enabled = true;
                        tabPage_QuanLyPhongBan_Click(sender, e);
                        tabPage_QuanLyNhanVien_Click(sender, e);
                    }
                    else
                    {
                        MessageBox.Show("Có lỗi trong quá trình kết nối cơ sở dữ liệu");
                    }
                }
                else
                {
                    dto_phongban = new dtoPhongBan();
                    dto_phongban.MAPHONG = Int32.Parse(label_MaPhong.Text.ToString());
                    dto_phongban.TENPHONG = textBox_TenPhong.Text.ToString();
                    if (phongban.ThemPhong(dto_phongban))
                    {
                        MessageBox.Show("Thêm phòng thành công");
                        textBox_TenPhong.ReadOnly = true;
                        button_LuuLai.Enabled = false;
                        button_HuySuaPhong.Enabled = false;
                       
                        button_ThemPhong.Enabled = true;
                        button_SuaTenPhong.Enabled = true;
                        tabPage_QuanLyPhongBan_Click(sender, e);
                        tabPage_QuanLyNhanVien_Click(sender, e);
                    }
                    else
                    {
                        MessageBox.Show("Có lỗi trong quá trình kết nối cơ sở dữ liệu");
                    }
                }
            }
            dataGridView_DanhSachPhong_SelectionChanged(sender, e);

        }

        private void button_SuaTenPhong_Click(object sender, EventArgs e)
        {
            textBox_TenPhong.ReadOnly = false;
            button_LuuLai.Enabled = true;
            button_HuySuaPhong.Enabled = true;
          
            button_ThemPhong.Enabled = false;
        }

        private void button_ThemPhong_Click(object sender, EventArgs e)
        {
            button_LuuLai.Enabled = true;
            button_HuySuaPhong.Enabled = true;
           
            button_SuaTenPhong.Enabled = false;
            textBox_TenPhong.ReadOnly = false;
            textBox_TenPhong.Text = "";
            PhongBan phongban = new PhongBan();
            List<dtoPhongBan> lDTO_phongban = phongban.LayDanhSachPhongBan();
            int maxMaPhong = 0;
            foreach (dtoPhongBan dtopb in lDTO_phongban)
            {
                if (dtopb.MAPHONG > maxMaPhong)
                {
                    maxMaPhong = dtopb.MAPHONG;
                }
            }
            label_MaPhong.Text = (maxMaPhong + 1).ToString();
            label_SoLuongNhanVien.Text = "0";
        }

        private void tabPage_QuanLyPhongBan_Click(object sender, EventArgs e)
        {
            textBox_TenPhong.ReadOnly = true;
            button_LuuLai.Enabled = false;
            button_HuySuaPhong.Enabled = false;
            
            button_ThemPhong.Enabled = true;
            button_SuaTenPhong.Enabled = true;


        }

        private void button_HuySuaPhong_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Những thông tin vừa được thêm vào sẽ không được lưu lại,bạn có muốn hủy không?", "Thông báo", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                tabPage_QuanLyPhongBan_Click(sender, e);
                dataGridView_DanhSachPhong_SelectionChanged(sender, e);
            }
            else if (dialogResult == DialogResult.No)
            {
                //do something else
            }
        }
        #endregion

        private void tabCtrl_ThongKeSaleTour_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabCtrl_ThongKeSaleTour.SelectedTab == tabCtrl_ThongKeSaleTour.TabPages["tabPage_QuanLyNhanVien"])
            {
                tabPage_QuanLyNhanVien_Click(sender, e);
            }
            if (tabCtrl_ThongKeSaleTour.SelectedTab == tabCtrl_ThongKeSaleTour.TabPages["tabPage_QuanLyPhongBan"])
            {
                tabPage_QuanLyPhongBan_Click(sender, e);
            }
            if (tabCtrl_ThongKeSaleTour.SelectedTab == tabCtrl_ThongKeSaleTour.TabPages["tabPage_XetDuyetTour"])
            {
                tabPage_XetDuyetTour_Click(sender, e);
            }
        }

        private void button_DangXuat_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmDangNhap formDangNhap = new frmDangNhap();
            formDangNhap.ShowDialog();
            this.Close();
        }

        private void textBox_CMND_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBox_SoDienThoai_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

    }
}
