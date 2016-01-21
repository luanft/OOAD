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
        private DoiTac doiTac;
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
            lbNguoiGui.Location = new Point((grbTieuDe.Size.Width - lbNguoiGui.Size.Width - 10), lbNguoiGui.Location.Y);

            lbTenTour.Text = tour.TenTour.ToUpper();
            lbTenTour.Location = new Point((panel1.Size.Width - lbTenTour.Size.Width) / 2, lbTenTour.Location.Y);

            lbThoiGianDi.Text = "(Thời gian: " + tour.ThoiGian + ")";
            lbThoiGianDi.Location = new Point((panel1.Size.Width - lbThoiGianDi.Size.Width) / 2, lbTenTour.Size.Height + lbTenTour.Location.Y + 10);

            lbUuDai.MaximumSize = new System.Drawing.Size(grbUuDai.Size.Width, 0);
            grbUuDai.Location = new Point(12, lbThoiGianDi.Location.Y + 20);
            grbUuDai.AutoSize = true;
            grbUuDai.MaximumSize = new Size(350, 0);
            if (tour.UuDai != "")
                lbUuDai.Text = "Ưu đãi: " + tour.UuDai;
            else
                grbUuDai.Visible = false;

            lbGiaTour.MaximumSize = new System.Drawing.Size(grbGiaTour.Size.Width, 0);
            lbGiaTour.Text = "Tổng giá tour " + tour.TongGiaTour;
            grbGiaTour.Location = new Point(panel1.Size.Width - grbGiaTour.Size.Width - 28, lbThoiGianDi.Location.Y + 20);            

            init_ChiTietTour();

            lbKetThuc.Text = "KẾT THÚC CHƯƠNG TRÌNH THAM QUAN DU LỊCH";
            lbKetThuc.Location = new Point((panel1.Size.Width - lbKetThuc.Size.Width) / 2, fPanelLichTrinh.Location.Y + fPanelLichTrinh.Size.Height + 20);            

            fPanelThongTinPhu.Location = new Point(fPanelLichTrinh.Location.X, lbKetThuc.Location.Y + 40);
            Label lbThongTinPhu = new Label();
            lbThongTinPhu.Name = "lbMore";
            lbThongTinPhu.Visible = true;
            lbThongTinPhu.AutoSize = true;
            lbThongTinPhu.MaximumSize = new Size(760, 0);
            lbThongTinPhu.Text = tour.ThongTinTour;
            fPanelThongTinPhu.Controls.Add(lbThongTinPhu);

            lbChaoMung.Location = new Point((panel1.Size.Width - lbChaoMung.Size.Width) / 2, fPanelThongTinPhu.Location.Y + fPanelThongTinPhu.Size.Height + 20);            
        }

        private void init_ChiTietTour()
        {
            int i = 0;
            fPanelLichTrinh.FlowDirection = FlowDirection.TopDown;
            fPanelLichTrinh.AutoSize = true;
            fPanelLichTrinh.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            fPanelThongTinPhu.FlowDirection = FlowDirection.TopDown;
            fPanelThongTinPhu.AutoSize = true;
            fPanelThongTinPhu.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            foreach (LichTrinh lt in tour.LichTrinh)
            {
                Label lbNgay = new Label();
                lbNgay.Name = "lbNgay" + i;
                lbNgay.Visible = true;
                lbNgay.AutoSize = true;
                lbNgay.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                lbNgay.Text = "Ngày " + lt.Ngay + ": " + lt.TenLichTrinh;                
                lbNgay.MaximumSize = new Size(760, 0);
                lbNgay.Margin = new System.Windows.Forms.Padding(0, 10, 10, 10);
                fPanelLichTrinh.Location = new Point(12, grbUuDai.Location.Y + grbUuDai.Size.Height + 20);
                fPanelLichTrinh.Controls.Add(lbNgay);

                foreach (ChiTietLichTrinh ctlt in lt.pChiTietLichTrinh)
                {
                    Label lbGio = new Label();
                    lbGio.Name = "lbGio" + i;
                    lbGio.Visible = true;
                    lbGio.AutoSize = true;
                    lbGio.MaximumSize = new Size(760, 0);
                    lbGio.Text = ctlt.ThoiGian + ":";
                    fPanelLichTrinh.Controls.Add(lbGio);

                    Label lbGio1 = new Label();
                    lbGio1.Name = "lbGio1" + i;
                    lbGio1.Visible = true;
                    lbGio1.AutoSize = true;
                    lbGio1.MaximumSize = new Size(760, 0);
                    lbGio1.Margin = new System.Windows.Forms.Padding(20, 0, 0, 0);
                    lbGio1.Text = ctlt.NoiDung;
                    fPanelLichTrinh.Controls.Add(lbGio1);

                    if (ctlt.DoiTac != null)
                    {
                        DoiTacLinkLabel lbDoiTac = new DoiTacLinkLabel();
                        lbDoiTac.Name = "lbDoiTac" + i;
                        lbDoiTac.Visible = true;
                        lbDoiTac.AutoSize = true;
                        lbDoiTac.DoiTac = ctlt.DoiTac;
                        lbDoiTac.Text = ctlt.DoiTac.TenDoiTac;
                        lbDoiTac.Margin = new System.Windows.Forms.Padding(20, 0, 0, 0);
                        lbDoiTac.LinkClicked += new LinkLabelLinkClickedEventHandler(this.linkClick_DoiTac);
                        fPanelLichTrinh.Controls.Add(lbDoiTac);
                    }
                }
                i++;
            }

        }

        private void linkClick_DoiTac(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DoiTacLinkLabel dt = (DoiTacLinkLabel)sender;
            MessageBox.Show("Người liên hệ: " + dt.DoiTac.NguoiLienHe + "\nĐịa chỉ: " + dt.DoiTac.DiaChi + "\nSố điện thoại: " + dt.DoiTac.SoDT + "\nEmail: " + dt.DoiTac.Email + "\nĐánh giá đối tác: " + dt.DoiTac.DanhGiaDoiTac, dt.DoiTac.TenDoiTac);
        }

        public void Print(Panel pnl)
        {

            GetPrintArea(pnl);
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
        }

        Bitmap MemoryImage;
        public void GetPrintArea(Panel pnl)
        {
            MemoryImage = new Bitmap(pnl.Width, pnl.Height);
            
            pnl.DrawToBitmap(MemoryImage, new Rectangle(0, 0, pnl.Width, pnl.Height));
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Rectangle pagearea = e.PageBounds;
            e.Graphics.DrawImage(MemoryImage, (pagearea.Width / 2) - (this.panel1.Width / 2), this.panel1.Location.Y);
        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            Print(panel1);
        }
    }
}
