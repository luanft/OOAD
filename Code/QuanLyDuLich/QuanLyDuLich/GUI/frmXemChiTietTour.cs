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
            lbNguoiGui.Location = new Point((groupBox1.Size.Width - lbNguoiGui.Size.Width - 10), lbNguoiGui.Location.Y);

            lbTenTour.Text = tour.TenTour.ToUpper();
            lbTenTour.Location = new Point((panel1.Size.Width - lbTenTour.Size.Width) / 2, lbTenTour.Location.Y);

            lbThoiGianDi.Text = "(Thời gian: " + tour.ThoiGian + ")";
            lbThoiGianDi.Location = new Point((panel1.Size.Width - lbThoiGianDi.Size.Width) / 2, lbTenTour.Size.Height + lbTenTour.Location.Y + 10);

            lbUuDai.MaximumSize = new System.Drawing.Size(groupBox2.Size.Width, 0);
            groupBox2.Location = new Point(12, lbThoiGianDi.Location.Y + 20);
            groupBox2.AutoSize = true;
            groupBox2.MaximumSize = new Size(350, 0);
            if (tour.UuDai != "")
                lbUuDai.Text = "Ưu đãi: " + tour.UuDai;
            else
                groupBox2.Visible = false;

            lbGiaTour.MaximumSize = new System.Drawing.Size(groupBox3.Size.Width, 0);
            lbGiaTour.Text = "Tổng giá tour " + tour.TongGiaTour;
            groupBox3.Location = new Point(panel1.Size.Width - groupBox3.Size.Width - 28, lbThoiGianDi.Location.Y + 20);            

            init_ChiTietTour();

            lbKetThuc.Text = "KẾT THÚC CHƯƠNG TRÌNH THAM QUAN DU LỊCH";
            lbKetThuc.Location = new Point((panel1.Size.Width - lbKetThuc.Size.Width) / 2, fPanel1.Location.Y + fPanel1.Size.Height + 20);            

            fPanel2.Location = new Point(fPanel1.Location.X, lbKetThuc.Location.Y + 40);
            Label lbMore = new Label();
            lbMore.Name = "lbMore";
            lbMore.Visible = true;
            lbMore.AutoSize = true;
            lbMore.MaximumSize = new Size(760, 0);
            lbMore.Text = tour.ThongTinTour;
            fPanel2.Controls.Add(lbMore);

            lbChaoMung.Location = new Point((panel1.Size.Width - lbChaoMung.Size.Width) / 2, fPanel2.Location.Y + fPanel2.Size.Height + 20);            
        }

        private void init_ChiTietTour()
        {
            int i = 0;
            fPanel1.FlowDirection = FlowDirection.TopDown;
            fPanel1.AutoSize = true;
            fPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            fPanel2.FlowDirection = FlowDirection.TopDown;
            fPanel2.AutoSize = true;
            fPanel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
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
                fPanel1.Location = new Point(12, groupBox2.Location.Y + groupBox2.Size.Height + 20);
                fPanel1.Controls.Add(lbNgay);

                foreach (ChiTietLichTrinh ctlt in lt.pChiTietLichTrinh)
                {
                    Label lbGio = new Label();
                    lbGio.Name = "lbGio" + i;
                    lbGio.Visible = true;
                    lbGio.AutoSize = true;
                    lbGio.MaximumSize = new Size(760, 0);
                    lbGio.Text = ctlt.ThoiGian + ":";
                    fPanel1.Controls.Add(lbGio);

                    Label lbGio1 = new Label();
                    lbGio1.Name = "lbGio1" + i;
                    lbGio1.Visible = true;
                    lbGio1.AutoSize = true;
                    lbGio1.MaximumSize = new Size(760, 0);
                    lbGio1.Margin = new System.Windows.Forms.Padding(20, 0, 0, 0);
                    lbGio1.Text = ctlt.NoiDung;
                    fPanel1.Controls.Add(lbGio1);

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
                        fPanel1.Controls.Add(lbDoiTac);
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
    }
}
