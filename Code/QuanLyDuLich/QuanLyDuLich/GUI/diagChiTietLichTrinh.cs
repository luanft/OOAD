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
        private string doiTac;

        public string DoiTac
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

            this.doiTac = this.thoiGian = this.hoatDong = "";
            this.daThem = false;
            this.cbThoiGian.SelectedIndex = 0;
            this.cbDoiTac.SelectedIndex = 0;
            this.txtHoatDong.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.doiTac = cbDoiTac.Text;
            this.hoatDong = this.txtHoatDong.Text;
            this.thoiGian = this.cbThoiGian.Text;
            this.daThem = true;
            this.Close();
        }
    }
}
