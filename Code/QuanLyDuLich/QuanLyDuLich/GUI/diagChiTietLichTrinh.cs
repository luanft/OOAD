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
    public partial class diagChiTietLichTrinh : Form
    {
        private dtoDoiTac doiTac;

        public dtoDoiTac DoiTac
        {
            get { return doiTac; }
            set { doiTac = value; }
        }
        private string thoiGian;

        public string ThoiGian
        {
            get { return thoiGian; }
            set { thoiGian = value; }
        }
        private string hoatDong;

        public string HoatDong
        {
            get { return hoatDong; }
            set { hoatDong = value; }
        }
        private bool daThem;

        public bool DaThem
        {
            get { return daThem; }
            set { daThem = value; }
        }
        public diagChiTietLichTrinh()
        {
            InitializeComponent();
        }

        public void KhoiTaoForm()
        {

            this.doiTac = null;
            this.thoiGian = this.hoatDong = "";
            this.daThem = false;
            txtThoiGian.Text = "";
            this.txtHoatDong.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (cbDoiTac.SelectedItem == null)
            {

                this.doiTac = null;
            }
            else
            {
                this.doiTac = (dtoDoiTac)cbDoiTac.SelectedItem;
            }
            this.hoatDong = this.txtHoatDong.Text;
            this.thoiGian = this.txtThoiGian.Text;
            this.daThem = true;
            this.Close();
        }
        dalDoiTac dalDT = new dalDoiTac();
        private void diagChiTietLichTrinh_Load(object sender, EventArgs e)
        {
            cbDoiTac.Items.Clear();
            List<dtoDoiTac> dt = dalDT.LayDanhSachDoiTac();
            foreach (dtoDoiTac d in dt)
            {
                cbDoiTac.Items.Add(d);
            }
            cbDoiTac.DisplayMember = "TENDOITAC";
        }

        private void cbDoiTac_SelectedIndexChanged(object sender, EventArgs e)
        {
            dtoDoiTac d = (dtoDoiTac)this.cbDoiTac.SelectedItem;
            txtMa.Text = d.MADOITAC.ToString();
            txtDiaChi.Text = d.DIACHI;
            txtDanhGia.Text = d.DANHGIADOITAC;
        }

        

        
    }
}
