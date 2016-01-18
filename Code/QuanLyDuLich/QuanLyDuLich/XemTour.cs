using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataTranferObject;
using BLL;
using DataAccessLayer;

namespace QuanLyDuLich
{
    public partial class XemTour : UserControl
    {
        private dtoTour tour;
        private NVSale sale = new NVSale();
        public XemTour()
        {
            InitializeComponent();
            llSubmit.Click += btnSubmitTour_Click;
            llDanhDauBan.Click += btnDanhDauDaBan_Click;
        }

        public void init(dtoTour tour)
        {
            this.lbNgayDi.Text = tour.NGAYDI.ToShortDateString();
            this.lbNgayLap.Text = tour.NGAYLAPTOUR.ToShortDateString();
            lbTenTour.Text = tour.TENTOUR;
            lbThoiGianDi.Text = tour.THOIGIAN;
            lbTrangThai.Text = tour.TRANGTHAI;
            this.tour = tour;
            if(tour.TRANGTHAI != "MOI_LAP")
            {
                llSubmit.Enabled = false;
            }
        }
        private void XemTour_Load(object sender, EventArgs e)
        {
            lbTenTour.MaximumSize = this.Size;
        }

        private void btnSubmitTour_Click(object sender, EventArgs e)
        {

            dalTour dal = new dalTour();
            tour.TRANGTHAI = "CHO_DIEU_HANH_DUYET";
            lbTrangThai.Text = "CHO_DIEU_HANH_DUYET";
            if (dal.CapNhatTour(tour))
            {
                llSubmit.Enabled = false;
            }

        }

        private void lbTenTour_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("Hiển thị tour chi tiết ở đây");
        }

        private void btnDanhDauDaBan_Click(object sender, EventArgs e)
        {
            dalTour dal = new dalTour();
            tour.TRANGTHAI = "DA_BAN";
            lbTrangThai.Text = "DA_BAN";
            if (dal.CapNhatTour(tour))
            {
                llDanhDauBan.Enabled = false;
            }
        }

        
    }
}
