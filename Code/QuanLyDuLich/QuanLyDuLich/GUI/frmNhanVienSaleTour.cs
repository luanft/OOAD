using BLL;
using DataAccessLayer;
using DataTranferObject;
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


        private diagThemLichTrinh diagThemLt = new diagThemLichTrinh();
        private diagChiTietLichTrinh diagCTLT = new diagChiTietLichTrinh();

        private void frmNhanVienSaleTour_Load(object sender, EventArgs e)
        {
            this.ThietLapForm();           
        }

      
        private void tb_SoDT_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !((e.KeyChar >= 48 && e.KeyChar <= 57) || e.KeyChar == 8);
        }

        private void bt_ThemKH_Click(object sender, EventArgs e)
        {

        }

        private void bt_CapNhatKhachHang_Click(object sender, EventArgs e)
        {

        }

        private void bt_XoaKH_Click(object sender, EventArgs e)
        {

        }

        private void bt_LuuKH_Click(object sender, EventArgs e)
        {

        }

        private void bt_HuyKH_Click(object sender, EventArgs e)
        {

        }

        private void bt_ThemDiemDL_Click(object sender, EventArgs e)
        {

        }

        private void bt_CapNhatDDL_Click(object sender, EventArgs e)
        {

        }

        
        

        

        
        
        










    }
}
