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
    public partial class frmNhanVienDieuHanh : Form
    {
        List<DoiTac> dsDoiTac;
        NVDieuHanh nvDieuHanh;
        List<DoiTac> dsDoiTacCapNhat;
        string loaiFormCon;
        dalTour dal_Tour;

        public string ploaiFormCon
        {
            get { return loaiFormCon; }
            set { loaiFormCon = value; }
        }

        public List<DoiTac> pdsDoiTacCapNhat
        {
            get { return dsDoiTacCapNhat; }
            set { dsDoiTacCapNhat = value; }
        }

        public NVDieuHanh pnvDieuHanh
        {
            get { return nvDieuHanh; }
            set { nvDieuHanh = value; }
        }
        
        public frmNhanVienDieuHanh()
        {
            InitializeComponent();
            dgvDoiTac.AutoGenerateColumns = false;
            dgvDuyetTour.AutoGenerateColumns = false;

            nvDieuHanh = new NVDieuHanh();
            dsDoiTac = nvDieuHanh.pDanhSachDoiTac;
            dal_Tour = new dalTour();
        }

        private void frmNhanVienDieuHanh_Load(object sender, EventArgs e)
        {            
            List<string> dsLoaiDoiTac = new List<string>();
            foreach (DoiTac dt in dsDoiTac)
            {
                dsLoaiDoiTac.Add(dt.pLoaiDoiTac);
            }
            //binding list DoiTac's name to combobox
            BindingSource bsTenDoiTac = new BindingSource();
            bsTenDoiTac.DataSource = dsLoaiDoiTac;
            combLoaiDoiTac.DataSource = bsTenDoiTac;
            
            //binding list DoiTac to datagridview
            BindingSource bsDanhSachDoiTac = new BindingSource();
            bsDanhSachDoiTac.DataSource = dsDoiTac;
            dgvDoiTac.DataSource = bsDanhSachDoiTac;

            //binding list tour to datagridview
            dgvDuyetTour.DataSource = dal_Tour.LayDanhSachTourCanDuyet();

        }

        private void btnThemDoiTac_Click(object sender, EventArgs e)
        {
            loaiFormCon = "add";
            frmThemDoiTac frm = new frmThemDoiTac(this);            
            frm.Show();
        }    

        private void btnXoaDoiTac_Click(object sender, EventArgs e)
        {
            DialogResult rs = MessageBox.Show("Bạn có chắc muốn xóa (những) đối tác này?", "Xác nhận xóa", MessageBoxButtons.YesNo);
            if(rs == System.Windows.Forms.DialogResult.Yes)
            foreach (DataGridViewRow row in dgvDoiTac.SelectedRows)
            {
                DoiTac doiTac = nvDieuHanh.ChonDoiTac(int.Parse(row.Cells["col_MaDoiTac"].Value.ToString()));
                doiTac.Xoa();
                dgvDoiTac.Rows.Remove(row);
            }            
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            BindingSource bsDanhSachDoiTac = new BindingSource();
            bsDanhSachDoiTac.DataSource = dsDoiTac;
            dgvDoiTac.DataSource = bsDanhSachDoiTac;
            dgvDoiTac.Refresh();            
        }

        private void btnSuaDoiTac_Click(object sender, EventArgs e)
        {
            dsDoiTacCapNhat = new List<DoiTac>();
            loaiFormCon = "update";
            foreach (DataGridViewRow row in dgvDoiTac.SelectedRows)
            {
                dsDoiTacCapNhat.Add(nvDieuHanh.ChonDoiTac(int.Parse(row.Cells["col_MaDoiTac"].Value.ToString())));
            }
            frmThemDoiTac frm = new frmThemDoiTac(this);            
            frm.Show();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dgvDuyetTour.Rows)
            {
                nvDieuHanh.ChonTourCanDuyet(int.Parse(row.Cells["col_MaTour"].Value.ToString())).CapNhat();
            }            
        }

    }
}
