using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyDuLich
{
    public partial class XemTour : UserControl
    {
        public XemTour()
        {
            InitializeComponent();
        }

        private void XemTour_Load(object sender, EventArgs e)
        {
            lbTenTour.MaximumSize = this.Size;
        }
    }
}
