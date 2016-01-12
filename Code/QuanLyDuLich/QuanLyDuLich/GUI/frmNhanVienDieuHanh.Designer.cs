namespace QuanLyDuLich.GUI
{
    partial class frmNhanVienDieuHanh
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabQuanLyDoiTac = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnXoaDoiTac = new System.Windows.Forms.Button();
            this.btnSuaDoiTac = new System.Windows.Forms.Button();
            this.btnThemDoiTac = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvDoiTac = new System.Windows.Forms.DataGridView();
            this.col_STT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_LoaiDoiTac = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_TenDoiTac = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_NguoiLienHe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_DiaChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_SDT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_DanhGiaDoiTac = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabXetDuyetTour = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnHuyXetDuyet = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.lbSoTour = new System.Windows.Forms.Label();
            this.dgvDuyetTour = new System.Windows.Forms.DataGridView();
            this.col1_STT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col1_TenTour = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col1_NguoiLap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col1_NgayLap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col1_TrangThai = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.col1_GhiChu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl1.SuspendLayout();
            this.tabQuanLyDoiTac.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDoiTac)).BeginInit();
            this.tabXetDuyetTour.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDuyetTour)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabQuanLyDoiTac);
            this.tabControl1.Controls.Add(this.tabXetDuyetTour);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.Padding = new System.Drawing.Point(0, 0);
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1004, 603);
            this.tabControl1.TabIndex = 0;
            // 
            // tabQuanLyDoiTac
            // 
            this.tabQuanLyDoiTac.Controls.Add(this.panel1);
            this.tabQuanLyDoiTac.Location = new System.Drawing.Point(4, 22);
            this.tabQuanLyDoiTac.Name = "tabQuanLyDoiTac";
            this.tabQuanLyDoiTac.Padding = new System.Windows.Forms.Padding(3);
            this.tabQuanLyDoiTac.Size = new System.Drawing.Size(996, 577);
            this.tabQuanLyDoiTac.TabIndex = 0;
            this.tabQuanLyDoiTac.Text = "Quản lý đối tác";
            this.tabQuanLyDoiTac.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnHuy);
            this.panel1.Controls.Add(this.btnXoaDoiTac);
            this.panel1.Controls.Add(this.btnSuaDoiTac);
            this.panel1.Controls.Add(this.btnThemDoiTac);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.dgvDoiTac);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(990, 571);
            this.panel1.TabIndex = 0;
            // 
            // btnHuy
            // 
            this.btnHuy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnHuy.AutoSize = true;
            this.btnHuy.Location = new System.Drawing.Point(908, 543);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(77, 23);
            this.btnHuy.TabIndex = 4;
            this.btnHuy.Text = "Hủy thay đổi";
            this.btnHuy.UseVisualStyleBackColor = true;
            // 
            // btnXoaDoiTac
            // 
            this.btnXoaDoiTac.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnXoaDoiTac.AutoSize = true;
            this.btnXoaDoiTac.Location = new System.Drawing.Point(827, 543);
            this.btnXoaDoiTac.Name = "btnXoaDoiTac";
            this.btnXoaDoiTac.Size = new System.Drawing.Size(75, 23);
            this.btnXoaDoiTac.TabIndex = 4;
            this.btnXoaDoiTac.Text = "Xóa đối tác";
            this.btnXoaDoiTac.UseVisualStyleBackColor = true;
            // 
            // btnSuaDoiTac
            // 
            this.btnSuaDoiTac.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSuaDoiTac.AutoSize = true;
            this.btnSuaDoiTac.Location = new System.Drawing.Point(681, 543);
            this.btnSuaDoiTac.Name = "btnSuaDoiTac";
            this.btnSuaDoiTac.Size = new System.Drawing.Size(140, 23);
            this.btnSuaDoiTac.TabIndex = 4;
            this.btnSuaDoiTac.Text = "Cập nhật thông tin đối tác";
            this.btnSuaDoiTac.UseVisualStyleBackColor = true;
            // 
            // btnThemDoiTac
            // 
            this.btnThemDoiTac.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnThemDoiTac.AutoSize = true;
            this.btnThemDoiTac.Location = new System.Drawing.Point(595, 543);
            this.btnThemDoiTac.Name = "btnThemDoiTac";
            this.btnThemDoiTac.Size = new System.Drawing.Size(80, 23);
            this.btnThemDoiTac.TabIndex = 4;
            this.btnThemDoiTac.Text = "Thêm đối tác";
            this.btnThemDoiTac.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Chọn loại đối tác";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(98, 65);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(449, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(189, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "DANH SÁCH ĐỐI TÁC";
            // 
            // dgvDoiTac
            // 
            this.dgvDoiTac.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvDoiTac.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDoiTac.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_STT,
            this.col_LoaiDoiTac,
            this.col_TenDoiTac,
            this.col_NguoiLienHe,
            this.col_DiaChi,
            this.col_SDT,
            this.col_Email,
            this.col_DanhGiaDoiTac});
            this.dgvDoiTac.Location = new System.Drawing.Point(0, 92);
            this.dgvDoiTac.Name = "dgvDoiTac";
            this.dgvDoiTac.Size = new System.Drawing.Size(990, 445);
            this.dgvDoiTac.TabIndex = 0;
            // 
            // col_STT
            // 
            this.col_STT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.col_STT.HeaderText = "STT";
            this.col_STT.Name = "col_STT";
            // 
            // col_LoaiDoiTac
            // 
            this.col_LoaiDoiTac.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.col_LoaiDoiTac.HeaderText = "Loại đối tác";
            this.col_LoaiDoiTac.Name = "col_LoaiDoiTac";
            this.col_LoaiDoiTac.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // col_TenDoiTac
            // 
            this.col_TenDoiTac.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.col_TenDoiTac.HeaderText = "Tên đối tác";
            this.col_TenDoiTac.Name = "col_TenDoiTac";
            // 
            // col_NguoiLienHe
            // 
            this.col_NguoiLienHe.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.col_NguoiLienHe.HeaderText = "Người liên hệ";
            this.col_NguoiLienHe.Name = "col_NguoiLienHe";
            // 
            // col_DiaChi
            // 
            this.col_DiaChi.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.col_DiaChi.HeaderText = "Địa chỉ";
            this.col_DiaChi.Name = "col_DiaChi";
            // 
            // col_SDT
            // 
            this.col_SDT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.col_SDT.HeaderText = "Số điện thoại";
            this.col_SDT.Name = "col_SDT";
            // 
            // col_Email
            // 
            this.col_Email.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.col_Email.HeaderText = "Email";
            this.col_Email.Name = "col_Email";
            // 
            // col_DanhGiaDoiTac
            // 
            this.col_DanhGiaDoiTac.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.col_DanhGiaDoiTac.HeaderText = "Đánh giá đối tác";
            this.col_DanhGiaDoiTac.Name = "col_DanhGiaDoiTac";
            // 
            // tabXetDuyetTour
            // 
            this.tabXetDuyetTour.Controls.Add(this.panel2);
            this.tabXetDuyetTour.Location = new System.Drawing.Point(4, 22);
            this.tabXetDuyetTour.Name = "tabXetDuyetTour";
            this.tabXetDuyetTour.Padding = new System.Windows.Forms.Padding(3);
            this.tabXetDuyetTour.Size = new System.Drawing.Size(996, 577);
            this.tabXetDuyetTour.TabIndex = 1;
            this.tabXetDuyetTour.Text = "Xét duyệt tour";
            this.tabXetDuyetTour.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnHuyXetDuyet);
            this.panel2.Controls.Add(this.btnLuu);
            this.panel2.Controls.Add(this.lbSoTour);
            this.panel2.Controls.Add(this.dgvDuyetTour);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(990, 571);
            this.panel2.TabIndex = 3;
            // 
            // btnHuyXetDuyet
            // 
            this.btnHuyXetDuyet.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnHuyXetDuyet.AutoSize = true;
            this.btnHuyXetDuyet.Location = new System.Drawing.Point(910, 543);
            this.btnHuyXetDuyet.Name = "btnHuyXetDuyet";
            this.btnHuyXetDuyet.Size = new System.Drawing.Size(75, 23);
            this.btnHuyXetDuyet.TabIndex = 2;
            this.btnHuyXetDuyet.Text = "Hủy";
            this.btnHuyXetDuyet.UseVisualStyleBackColor = true;
            // 
            // btnLuu
            // 
            this.btnLuu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLuu.AutoSize = true;
            this.btnLuu.Location = new System.Drawing.Point(829, 543);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(75, 23);
            this.btnLuu.TabIndex = 2;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            // 
            // lbSoTour
            // 
            this.lbSoTour.AutoSize = true;
            this.lbSoTour.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSoTour.Location = new System.Drawing.Point(323, 19);
            this.lbSoTour.Name = "lbSoTour";
            this.lbSoTour.Size = new System.Drawing.Size(316, 20);
            this.lbSoTour.TabIndex = 0;
            this.lbSoTour.Text = "CÓ 10 TOUR ĐANG CHỜ XÉT DUYỆT";
            // 
            // dgvDuyetTour
            // 
            this.dgvDuyetTour.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvDuyetTour.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDuyetTour.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col1_STT,
            this.col1_TenTour,
            this.col1_NguoiLap,
            this.col1_NgayLap,
            this.col1_TrangThai,
            this.col1_GhiChu});
            this.dgvDuyetTour.Location = new System.Drawing.Point(0, 92);
            this.dgvDuyetTour.Name = "dgvDuyetTour";
            this.dgvDuyetTour.Size = new System.Drawing.Size(990, 445);
            this.dgvDuyetTour.TabIndex = 1;
            // 
            // col1_STT
            // 
            this.col1_STT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.col1_STT.HeaderText = "STT";
            this.col1_STT.Name = "col1_STT";
            this.col1_STT.ReadOnly = true;
            // 
            // col1_TenTour
            // 
            this.col1_TenTour.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.col1_TenTour.HeaderText = "Tên tour";
            this.col1_TenTour.Name = "col1_TenTour";
            this.col1_TenTour.ReadOnly = true;
            // 
            // col1_NguoiLap
            // 
            this.col1_NguoiLap.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.col1_NguoiLap.HeaderText = "Người lập tour";
            this.col1_NguoiLap.Name = "col1_NguoiLap";
            this.col1_NguoiLap.ReadOnly = true;
            // 
            // col1_NgayLap
            // 
            this.col1_NgayLap.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.col1_NgayLap.HeaderText = "Ngày lập tour";
            this.col1_NgayLap.Name = "col1_NgayLap";
            this.col1_NgayLap.ReadOnly = true;
            // 
            // col1_TrangThai
            // 
            this.col1_TrangThai.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.col1_TrangThai.HeaderText = "Trạng thái";
            this.col1_TrangThai.Name = "col1_TrangThai";
            this.col1_TrangThai.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.col1_TrangThai.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // col1_GhiChu
            // 
            this.col1_GhiChu.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.col1_GhiChu.HeaderText = "Ghi chú";
            this.col1_GhiChu.Name = "col1_GhiChu";
            // 
            // frmNhanVienDieuHanh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1004, 603);
            this.Controls.Add(this.tabControl1);
            this.Name = "frmNhanVienDieuHanh";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nhân viên điều hành";
            this.tabControl1.ResumeLayout(false);
            this.tabQuanLyDoiTac.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDoiTac)).EndInit();
            this.tabXetDuyetTour.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDuyetTour)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabQuanLyDoiTac;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvDoiTac;
        private System.Windows.Forms.TabPage tabXetDuyetTour;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_STT;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_LoaiDoiTac;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_TenDoiTac;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_NguoiLienHe;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_DiaChi;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_SDT;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_DanhGiaDoiTac;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Button btnXoaDoiTac;
        private System.Windows.Forms.Button btnSuaDoiTac;
        private System.Windows.Forms.Button btnThemDoiTac;
        private System.Windows.Forms.DataGridView dgvDuyetTour;
        private System.Windows.Forms.Label lbSoTour;        
        private System.Windows.Forms.DataGridViewTextBoxColumn col1_STT;
        private System.Windows.Forms.DataGridViewTextBoxColumn col1_TenTour;
        private System.Windows.Forms.DataGridViewTextBoxColumn col1_NguoiLap;
        private System.Windows.Forms.DataGridViewTextBoxColumn col1_NgayLap;
        private System.Windows.Forms.DataGridViewComboBoxColumn col1_TrangThai;
        private System.Windows.Forms.DataGridViewTextBoxColumn col1_GhiChu;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnHuyXetDuyet;
    }
}