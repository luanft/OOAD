using BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyDuLich.GUI
{
    class DoiTacLinkLabel : LinkLabel
    {
        private DoiTac doiTac;

        public DoiTacLinkLabel():base()
        { 
        }
        public DoiTac DoiTac
        {
            get { return doiTac; }
            set { doiTac = value; }
        }
    }
}
