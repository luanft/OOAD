using BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyDuLich.GUI
{
    class ChiTietNode : TreeNode
    {
        private ChiTietLichTrinh chiTiet;

        public ChiTietLichTrinh ChiTiet
        {
            get { return chiTiet; }
            set { chiTiet = value; }
        }
        public ChiTietNode(string name, ChiTietLichTrinh data)
            : base(name)
        {
            chiTiet = data;
        }
    }
}
