using BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyDuLich.GUI
{
    class LichTrinhNode : TreeNode
    {
        public LichTrinh lichTrinh;

        public LichTrinh LichTrinh
        {
            get { return lichTrinh; }
            set { lichTrinh = value; }
        }
        public LichTrinhNode(string name, LichTrinh data)
            : base(name)
        {
            lichTrinh = data;
        }
    }
}
