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
    public partial class DiaDiemDuLich : UserControl
    {
        public DiaDiemDuLich()
        {
            InitializeComponent();
        }

        public void GanDiemDuLich(string value)
        {
            this.lb_tenDiaDiem.Text = value;
        }

        public void GanMoTa(string value)
        {
            this.lb_moTa.Text = value;
        }

      
    }
}
