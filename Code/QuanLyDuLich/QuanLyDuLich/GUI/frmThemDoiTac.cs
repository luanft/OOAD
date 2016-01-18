﻿using BLL;
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
        bool status;
        private frmNhanVienDieuHanh frmNhanVienDieuHanh;
        NVDieuHanh nvDieuHanh;
        public frmThemDoiTac()
        {
            InitializeComponent();
            status = false;
        }

        public frmThemDoiTac(frmNhanVienDieuHanh frmNhanVienDieuHanh)
        {
            InitializeComponent();
            this.frmNhanVienDieuHanh = frmNhanVienDieuHanh;
            if (this.frmNhanVienDieuHanh.ploaiFormCon.Equals("update"))
            {
                btnThemDoiTac.Enabled = false;
                btnCapNhat.Enabled = true;
                dgvDoiTac.AllowUserToAddRows = false;
                dgvDoiTac.AutoGenerateColumns = false;
                dgvDoiTac.DataSource = this.frmNhanVienDieuHanh.pdsDoiTacCapNhat;
                this.Text = "Cập nhật thông tin đối tác";
            }
            else
            {
                btnThemDoiTac.Enabled = true;
                btnCapNhat.Enabled = false;
                dgvDoiTac.AllowUserToAddRows = true;
                this.Text = "Thêm đối tác";
            }
            status = false;

            nvDieuHanh = frmNhanVienDieuHanh.pnvDieuHanh;
        }

        private void btnThemDoiTac_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dgvDoiTac.Rows)
            {
                if (!row.IsNewRow)
                {
                    dtoDoiTac dt = new dtoDoiTac();
                    dt.TENDOITAC = row.Cells["col_TenDoiTac"].Value.ToString();
                    dt.LOAIDOITAC = row.Cells["col_LoaiDoiTac"].Value.ToString();
                    dt.NGUOILIENHE = row.Cells["col_NguoiLienHe"].Value.ToString();
                    dt.DIACHI = row.Cells["col_DiaChi"].Value.ToString();
                    dt.DIENTHOAI = row.Cells["col_SDT"].Value.ToString();
                    dt.EMAIL = row.Cells["col_Email"].Value.ToString();
                    dt.DANHGIADOITAC = row.Cells["col_DanhGiaDoiTac"].Value.ToString();
                    dt.MANHANVIEN = 1;
                    if (nvDieuHanh.ThemDoiTac(dt))
                    {
                        status = true;
                    }
                }
            }
            if (status)
            {
                dgvDoiTac.Rows.Clear();
                dgvDoiTac.Refresh();
                MessageBox.Show("Thêm thành công", "Thông báo");
            }
            else
                MessageBox.Show("Thêm không thành công", "Thông báo");
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            int i = 0;
            foreach (DataGridViewRow row in dgvDoiTac.Rows)
            {
                dtoDoiTac dt = new dtoDoiTac();
                dt.TENDOITAC = row.Cells["col_TenDoiTac"].Value.ToString();
                dt.LOAIDOITAC = row.Cells["col_LoaiDoiTac"].Value.ToString();
                dt.NGUOILIENHE = row.Cells["col_NguoiLienHe"].Value.ToString();
                dt.DIACHI = row.Cells["col_DiaChi"].Value.ToString();
                dt.DIENTHOAI = row.Cells["col_SDT"].Value.ToString();
                dt.EMAIL = row.Cells["col_Email"].Value.ToString();
                dt.DANHGIADOITAC = row.Cells["col_DanhGiaDoiTac"].Value.ToString();
                dt.MANHANVIEN = 1;
                if (nvDieuHanh.CapNhat(this.frmNhanVienDieuHanh.pdsDoiTacCapNhat[i++], dt))
                {
                    status = true;
                }

            }
            if (status)
            {
                MessageBox.Show("Cập nhật thành công", "Thông báo");
            }
            else
                MessageBox.Show("Cập nhật không thành công", "Thông báo");
        }
    }
}
