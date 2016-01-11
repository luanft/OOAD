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
        public frmXemChiTietTour()
        {
            InitializeComponent();
        }

        private void frmXemChiTietTour_Load(object sender, EventArgs e)
        {
            lbTenDonVi.Text = "kính gửi: Trường đại học vũng tàu".ToUpper();
            lbTenDonVi.Location = new Point((panel1.Size.Width - lbTenDonVi.Size.Width) / 2, lbTenDonVi.Location.Y);
            lbNguoiGui.Text = "người gửi: Trần Thị Tèo - 01657990105".ToUpper();
            lbNguoiGui.Location = new Point((groupBox1.Size.Width - lbNguoiGui.Size.Width - 10), lbNguoiGui.Location.Y);            
            lbTenTour.Text = "Tour đi chơi nhiều ngày nhiều đêm".ToUpper();
            lbTenTour.Location = new Point((panel1.Size.Width - lbTenTour.Size.Width)/2, lbTenTour.Location.Y);
            lbThoiGianDi.Text = "(Thời gian: " + "2 ngày 3 đêm" + ")";
            lbThoiGianDi.Location = new Point((panel1.Size.Width - lbThoiGianDi.Size.Width) / 2, lbTenTour.Size.Height + lbTenTour.Location.Y + 10);
            initElement();
        }

        private void initElement()
        {
            for (int i = 0; i < 3; i++)
            {
                Label lbNgay = new Label();
                lbNgay.Name = "lbNgay" + i;
                lbNgay.Visible = true;
                lbNgay.AutoSize = true;
                int height = 0;
                lbNgay.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                lbNgay.Text = "Ngày 1: Bò sữa Long Thành - Vũng Tàu";
                FlowLayoutPanel fPanel = new FlowLayoutPanel();
                fPanel.Name = "panelNgay" + i;
                height += lbNgay.Size.Height + 15;
                if (i == 0)
                    fPanel.Location = new Point(12, 372);
                else
                    fPanel.Location = new Point(12, panel1.Controls["panelNgay" + (i - 1)].Location.Y + panel1.Controls["panelNgay" + (i - 1)].Size.Height);
                fPanel.Controls.Add(lbNgay);
                for (int j = 0; j < 5; j++)
                {
                    Label lbGio = new Label();
                    lbGio.Name = "lbNgay" + i;
                    lbGio.Visible = true;
                    lbGio.AutoSize = true;
                    lbGio.Text = "7h: Đi chơi tự do ở đâu đó kệ mầy nha. Mọi người cùng nhau chung tay đóng góp bảng so sánh giữa các tool kiểm chứng nào.Mình đã so sánh đc sahi vs selenium rồi, mọi người cùng nhau hoàn thanh giúp nhau qua môn nha.";
                    height += lbGio.Height + 15;
                    fPanel.Controls.Add(lbGio);
                }
                fPanel.Size = new Size(770, height);
                panel1.Controls.Add(fPanel);
            }
        }
    }
}
