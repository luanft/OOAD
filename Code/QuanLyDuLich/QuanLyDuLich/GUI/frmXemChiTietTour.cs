using BLL;
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
    public partial class frmXemChiTietTour : Form
    {
        private Tour tour;        
        private string nguoiGui;
        private string sdtNguoiGui;

        public frmXemChiTietTour()
        {
            InitializeComponent();
        }

        public frmXemChiTietTour(Tour tour)
        {
            InitializeComponent();
            this.tour = tour;
            NVSale nvSale = new NVSale();
            dtoNhanVien dto = nvSale.LayThongTinNhanVien(tour.MaNhanVien);
            nguoiGui = dto.HOTEN;
            sdtNguoiGui = dto.SODT;
        }

        private void frmXemChiTietTour_Load(object sender, EventArgs e)
        {
            this.Text = tour.TenTour;
            lbTenDonVi.Text = "KÍNH GỬI: " + tour.KhachHang.pTenDonVi.ToUpper();
            lbTenDonVi.Location = new Point((panel1.Size.Width - lbTenDonVi.Size.Width) / 2, lbTenDonVi.Location.Y);
            lbNguoiGui.Text = "NGƯỜI GỬI: " + nguoiGui.ToUpper() + " - " + sdtNguoiGui;
            lbNguoiGui.Location = new Point((groupBox1.Size.Width - lbNguoiGui.Size.Width - 10), lbNguoiGui.Location.Y);            
            lbTenTour.Text = tour.TenTour.ToUpper();
            lbTenTour.Location = new Point((panel1.Size.Width - lbTenTour.Size.Width)/2, lbTenTour.Location.Y);
            lbThoiGianDi.Text = "(Thời gian: " + tour.ThoiGian + ")";
            lbThoiGianDi.Location = new Point((panel1.Size.Width - lbThoiGianDi.Size.Width) / 2, lbTenTour.Size.Height + lbTenTour.Location.Y + 10);
            initElement();
        }

        private void initElement()
        {            
            int i = 0;
            foreach(LichTrinh lt in tour.LichTrinh)
            {
                Label lbNgay = new Label();
                lbNgay.Name = "lbNgay" + i;
                lbNgay.Visible = true;
                lbNgay.AutoSize = true;
                int height = 0;
                lbNgay.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                lbNgay.Text = "Ngày "+lt.Ngay + ": " + lt.TenLichTrinh;
                FlowLayoutPanel fPanel = new FlowLayoutPanel();
                fPanel.FlowDirection = FlowDirection.TopDown;
                fPanel.Name = "panelNgay" + i;
                height += lbNgay.Size.Height;
                if (i == 0)
                    fPanel.Location = new Point(12, 372);
                else
                    fPanel.Location = new Point(12, panel1.Controls["panelNgay" + (i - 1)].Location.Y + panel1.Controls["panelNgay" + (i - 1)].Size.Height);
                fPanel.Controls.Add(lbNgay);
                
                foreach(ChiTietLichTrinh ctlt in lt.pChiTietLichTrinh)
                {
                    Label lbGio = new Label();
                    lbGio.Name = "lbGio" + i;
                    lbGio.Visible = true;
                    lbGio.AutoSize = true;
                    lbGio.Text = ctlt.ThoiGian + ": " + ctlt.NoiDung;
                    height += lbGio.Height;
                    fPanel.Controls.Add(lbGio);
                }
                fPanel.Size = new Size(770, height);
                panel1.Controls.Add(fPanel);
                i++;
            }
        }      
    }
}
