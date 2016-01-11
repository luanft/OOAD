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
    public partial class frmNhanVienSaleTour : Form
    {
        public frmNhanVienSaleTour()
        {
            InitializeComponent();
        }

        private void frmNhanVienSaleTour_Load(object sender, EventArgs e)
        {
            //this.panelDanhSachTour
            for (int i = 0; i < 10; i++)
            {
                XemTour x = new XemTour();
                x.Size = new Size(370, 249);
                this.panelDanhSachTour.Controls.Add(x);
            }
        }
    }
}
