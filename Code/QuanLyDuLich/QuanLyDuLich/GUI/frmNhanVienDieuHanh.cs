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
        Tour tourDaChon;

        public Tour TourDaChon
        {
            get { return tourDaChon; }
            set { tourDaChon = value; }
        }

        public string LoaiFormCon
        {
            get { return loaiFormCon; }
            set { loaiFormCon = value; }
        }

        public List<DoiTac> DsDoiTacCapNhat
        {
            get { return dsDoiTacCapNhat; }
            set { dsDoiTacCapNhat = value; }
        }

        public NVDieuHanh NvDieuHanh
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

        }

        public frmNhanVienDieuHanh(int manv)
        {
            InitializeComponent();
            dgvDoiTac.AutoGenerateColumns = false;
            dgvDuyetTour.AutoGenerateColumns = false;

            nvDieuHanh = new NVDieuHanh(manv);
            dsDoiTac = nvDieuHanh.pDanhSachDoiTac;
            lbTenNhanVien.Text = "Xin chào: " + nvDieuHanh.pHoTen;
        }

        private void frmNhanVienDieuHanh_Load(object sender, EventArgs e)
        {
            List<string> dsLoaiDoiTac = new List<string>();
            foreach (DoiTac dt in dsDoiTac)
            {
                dsLoaiDoiTac.Add(dt.LoaiDoiTac);
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
            dgvDuyetTour.DataSource = nvDieuHanh.pDanhSachTourCanDuyet;
            lbSoTour.Text = "CÓ " + nvDieuHanh.pDanhSachTourCanDuyet.Count + " TOUR CẦN DUYỆT";
            lbSoTour.Location = new Point((this.Size.Width - lbSoTour.Size.Width) / 2, lbSoTour.Location.Y);
        }

        private void btnThemDoiTac_Click(object sender, EventArgs e)
        {
            loaiFormCon = "add";
            frmThemDoiTac frm = new frmThemDoiTac(this);
            frm.Show();
        }

        private void btnXoaDoiTac_Click(object sender, EventArgs e)
        {
            if (dgvDoiTac.SelectedRows.Count != 0)
            {
                DialogResult rs = MessageBox.Show("Bạn có chắc muốn xóa (những) đối tác này?", "Xác nhận xóa", MessageBoxButtons.YesNo);
                if (rs == System.Windows.Forms.DialogResult.Yes)
                    foreach (DataGridViewRow row in dgvDoiTac.SelectedRows)
                    {
                        DoiTac doiTac = nvDieuHanh.ChonDoiTac(int.Parse(row.Cells["col_MaDoiTac"].Value.ToString()));
                        doiTac.Xoa();
                        dgvDoiTac.Rows.Remove(row);
                    }
            }
            else
                MessageBox.Show("Vui lòng chọn 1 hoặc nhiều dòng để xóa!", "Thông báo");
        }

        public void capNhatForm()
        {
            BindingSource bsDanhSachDoiTac = new BindingSource();
            bsDanhSachDoiTac.DataSource = dsDoiTac;
            dgvDoiTac.DataSource = bsDanhSachDoiTac;
            dgvDoiTac.Refresh();
        }

        private void btnSuaDoiTac_Click(object sender, EventArgs e)
        {
            if (dgvDoiTac.SelectedRows.Count != 0)
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
            else
                MessageBox.Show("Vui lòng chọn 1 hoặc nhiều dòng để chỉnh sửa!", "Thông báo");
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dgvDuyetTour.Rows)
            {
                if (nvDieuHanh.ChonTourCanDuyet(int.Parse(row.Cells["col_MaTour"].Value.ToString())).CapNhat())
                {
                    MessageBox.Show("Cập nhật tour thành công!", "Thông báo");
                }
                else
                    MessageBox.Show("Cập nhật tour lỗi!", "Thông báo");
            }
        }

        private void dgvDuyetTour_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            tourDaChon = nvDieuHanh.ChonTourCanDuyet(int.Parse(dgvDuyetTour.Rows[e.RowIndex].Cells["col_MaTour"].Value.ToString()));
            frmXemChiTietTour xemChiTietTour = new frmXemChiTietTour(tourDaChon);
            xemChiTietTour.Show();
        }

        private void llbDangXuat_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DialogResult rs = MessageBox.Show("Bạn có thực sự muốn đăng xuất?", "Thông báo", MessageBoxButtons.YesNo);
            if (rs == System.Windows.Forms.DialogResult.Yes)
            {
                frmDangNhap frmDN = new frmDangNhap();
                this.Hide();
                frmDN.ShowDialog();
                this.Close();
            }
        }


    }
}
