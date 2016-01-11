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
    public partial class diagThemLichTrinh : Form
    {
        private bool daThem;
        private string tenLichTrinh;
        public diagThemLichTrinh()
        {
            InitializeComponent();
        }
        public void KhoiTaoForm()
        {
            daThem = false;
            tenLichTrinh = "";
            txtLichTrinh.Text = "";

        }

        public bool DaThem()
        {
            return daThem;
        }

        public string LayTenLichTrinh()
        {
            return tenLichTrinh;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.tenLichTrinh = this.txtLichTrinh.Text;
            if (tenLichTrinh == "")
            {
                MessageBox.Show("Bạn chưa nhập tên lịch trình!", "Nhắc nhở!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            this.daThem = true;            
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtLichTrinh_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.tenLichTrinh = this.txtLichTrinh.Text;
                if (tenLichTrinh == "")
                {
                    MessageBox.Show("Bạn chưa nhập tên lịch trình!", "Nhắc nhở!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                this.daThem = true;
                this.Close();
            }
        }

        
    }
}
