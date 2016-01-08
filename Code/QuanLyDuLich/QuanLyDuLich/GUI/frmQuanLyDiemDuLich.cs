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
    public partial class frmQuanLyDiemDuLich : Form
    {
        public frmQuanLyDiemDuLich()
        {
            InitializeComponent();
        }

        private void frmQuanLyDiemDuLich_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < 10; i++)
            {
                DiaDiemDuLich d = new DiaDiemDuLich();
                d.Name = "d" + i;
                d.MouseHover += d_MouseHover;
                d.MouseLeave += d_MouseLeave;
                d.Size = new System.Drawing.Size(800, 100);
                this.flowLayoutPanel1.Controls.Add(d);
            }
        }

        void d_MouseLeave(object sender, EventArgs e)
        {
            DiaDiemDuLich f = (DiaDiemDuLich)sender;
            
            f.BackColor = Color.White;
        }

        void d_MouseHover(object sender, EventArgs e)
        {
            DiaDiemDuLich f = (DiaDiemDuLich)sender;
            f.BackColor = Color.LightGray;
        }
    }
}
