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

namespace QuanLyDuLich
{
    public partial class XemTour : UserControl
    {
        public XemTour()
        {
            InitializeComponent();
        }

        public void init(dtoTour tour)
        {
            this.lbNgayDi.Text = tour.NGAYDI.ToShortDateString();
            this.lbNgayLap.Text = tour.NGAYLAPTOUR.ToShortDateString();
        }
        private void XemTour_Load(object sender, EventArgs e)
        {
            lbTenTour.MaximumSize = this.Size;
        }
    }
}
