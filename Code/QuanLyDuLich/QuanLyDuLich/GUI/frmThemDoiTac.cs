using BLL;
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
    public partial class frmThemDoiTac : Form
    {
        private frmNhanVienDieuHanh frmNhanVienDieuHanh;
        NVDieuHanh nvDieuHanh;
        public frmThemDoiTac()
        {
            InitializeComponent();
        }

        public frmThemDoiTac(frmNhanVienDieuHanh frmNhanVienDieuHanh)
        {
            InitializeComponent();
            this.frmNhanVienDieuHanh = frmNhanVienDieuHanh;
            if (this.frmNhanVienDieuHanh.LoaiFormCon.Equals("update"))
            {
                btnThemDoiTac.Enabled = false;
                btnCapNhat.Enabled = true;
                dgvDoiTac.AllowUserToAddRows = false;                
                dgvDoiTac.AutoGenerateColumns = false;
                dgvDoiTac.DataSource = this.frmNhanVienDieuHanh.DsDoiTacCapNhat;
                this.Text = "Cập nhật thông tin đối tác";
            }
            else
            {
                btnThemDoiTac.Enabled = true;
                btnCapNhat.Enabled = false;
                dgvDoiTac.AllowUserToAddRows = true;
                this.Text = "Thêm đối tác";
            }
            nvDieuHanh = frmNhanVienDieuHanh.NvDieuHanh;
        }


        private void btnThemDoiTac_Click(object sender, EventArgs e)
        {
            bool status = false;
            int count = 0;
            foreach (DataGridViewRow row in dgvDoiTac.Rows)
            {
                if (!row.IsNewRow)
                {
                    dtoDoiTac dt = new dtoDoiTac();
                    try
                    {
                        dt.TENDOITAC = row.Cells["col_TenDoiTac"].Value.ToString();
                        dt.LOAIDOITAC = row.Cells["col_LoaiDoiTac"].Value.ToString();
                        dt.NGUOILIENHE = row.Cells["col_NguoiLienHe"].Value.ToString();
                        dt.DIACHI = row.Cells["col_DiaChi"].Value.ToString();
                        dt.DIENTHOAI = row.Cells["col_SDT"].Value.ToString();
                        dt.EMAIL = row.Cells["col_Email"].Value.ToString();
                        dt.DANHGIADOITAC = row.Cells["col_DanhGiaDoiTac"].Value.ToString();
                        dt.MANHANVIEN = nvDieuHanh.pMaNhanVien;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Vui lòng nhập đầy đủ thông tin đối tác!", "Thông báo");
                        break;
                    }
                    if (nvDieuHanh.ThemDoiTac(dt))
                    {
                        dgvDoiTac.Rows.Remove(row);
                        dgvDoiTac.Refresh();
                        status = true;
                        count++;
                    }
                }
            }
            if (status)
            {
                MessageBox.Show("Thêm thành công " + count + " đối tác", "Thông báo");

                frmNhanVienDieuHanh.capNhatForm();
            }
            else
                MessageBox.Show("Thêm không thành công", "Thông báo");
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            bool status = false;
            int count = 0;
            int i = 0;
            foreach (DataGridViewRow row in dgvDoiTac.Rows)
            {
                dtoDoiTac dt = new dtoDoiTac();
                try
                {
                    dt.TENDOITAC = row.Cells["col_TenDoiTac"].Value.ToString();
                    dt.LOAIDOITAC = row.Cells["col_LoaiDoiTac"].Value.ToString();
                    dt.NGUOILIENHE = row.Cells["col_NguoiLienHe"].Value.ToString();
                    dt.DIACHI = row.Cells["col_DiaChi"].Value.ToString();
                    dt.DIENTHOAI = row.Cells["col_SDT"].Value.ToString();
                    dt.EMAIL = row.Cells["col_Email"].Value.ToString();
                    dt.DANHGIADOITAC = row.Cells["col_DanhGiaDoiTac"].Value.ToString();
                    dt.MANHANVIEN = nvDieuHanh.pMaNhanVien;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin đối tác!", "Thông báo");
                    break;
                } 
                if (nvDieuHanh.CapNhat(this.frmNhanVienDieuHanh.DsDoiTacCapNhat[i++], dt))
                {
                    status = true;
                    count++;                    
                }

            }
            if (status)
            {
                MessageBox.Show("Cập nhật thành công " + count + " đối tác", "Thông báo");
                frmNhanVienDieuHanh.capNhatForm();
            }
            else
                MessageBox.Show("Cập nhật không thành công", "Thông báo");
        }
    }
}
