namespace QuanLyDuLich.GUI
{
    partial class frmThemDoiTac
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
            this.btnThemDoiTac = new System.Windows.Forms.Button();
            this.dgvDoiTac = new System.Windows.Forms.DataGridView();
            this.btnCapNhat = new System.Windows.Forms.Button();
            this.col_TenDoiTac = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_LoaiDoiTac = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.col_NguoiLienHe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_DiaChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_SDT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_DanhGiaDoiTac = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDoiTac)).BeginInit();
            this.SuspendLayout();
            // 
            // btnThemDoiTac
            // 
            this.btnThemDoiTac.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnThemDoiTac.AutoSize = true;
            this.btnThemDoiTac.Location = new System.Drawing.Point(827, 369);
            this.btnThemDoiTac.Margin = new System.Windows.Forms.Padding(4);
            this.btnThemDoiTac.Name = "btnThemDoiTac";
            this.btnThemDoiTac.Size = new System.Drawing.Size(104, 46);
            this.btnThemDoiTac.TabIndex = 1;
            this.btnThemDoiTac.Text = "Thêm đối tác";
            this.btnThemDoiTac.UseVisualStyleBackColor = true;
            this.btnThemDoiTac.Click += new System.EventHandler(this.btnThemDoiTac_Click);
            // 
            // dgvDoiTac
            // 
            this.dgvDoiTac.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvDoiTac.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDoiTac.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_TenDoiTac,
            this.col_LoaiDoiTac,
            this.col_NguoiLienHe,
            this.col_DiaChi,
            this.col_SDT,
            this.col_Email,
            this.col_DanhGiaDoiTac});
            this.dgvDoiTac.Location = new System.Drawing.Point(20, 19);
            this.dgvDoiTac.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.dgvDoiTac.Name = "dgvDoiTac";
            this.dgvDoiTac.Size = new System.Drawing.Size(911, 347);
            this.dgvDoiTac.TabIndex = 2;
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCapNhat.AutoSize = true;
            this.btnCapNhat.Location = new System.Drawing.Point(645, 369);
            this.btnCapNhat.Margin = new System.Windows.Forms.Padding(4);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Size = new System.Drawing.Size(174, 46);
            this.btnCapNhat.TabIndex = 1;
            this.btnCapNhat.Text = "Cập nhật thông tin đối tác";
            this.btnCapNhat.UseVisualStyleBackColor = true;
            this.btnCapNhat.Click += new System.EventHandler(this.btnCapNhat_Click);
            // 
            // col_TenDoiTac
            // 
            this.col_TenDoiTac.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.col_TenDoiTac.DataPropertyName = "TenDoiTac";
            this.col_TenDoiTac.HeaderText = "Tên đối tác";
            this.col_TenDoiTac.Name = "col_TenDoiTac";
            this.col_TenDoiTac.Width = 102;
            // 
            // col_LoaiDoiTac
            // 
            this.col_LoaiDoiTac.DataPropertyName = "LoaiDoiTac";
            this.col_LoaiDoiTac.HeaderText = "Loại đối tác";
            this.col_LoaiDoiTac.Items.AddRange(new object[] {
            "NHAXE",
            "NHAHANG",
            "HUONGDANVIEN",
            "KHACHSAN"});
            this.col_LoaiDoiTac.MinimumWidth = 180;
            this.col_LoaiDoiTac.Name = "col_LoaiDoiTac";
            this.col_LoaiDoiTac.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.col_LoaiDoiTac.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.col_LoaiDoiTac.Width = 180;
            // 
            // col_NguoiLienHe
            // 
            this.col_NguoiLienHe.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.col_NguoiLienHe.DataPropertyName = "NguoiLienHe";
            this.col_NguoiLienHe.HeaderText = "Người liên hệ";
            this.col_NguoiLienHe.Name = "col_NguoiLienHe";
            // 
            // col_DiaChi
            // 
            this.col_DiaChi.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.col_DiaChi.DataPropertyName = "DiaChi";
            this.col_DiaChi.HeaderText = "Địa chỉ";
            this.col_DiaChi.Name = "col_DiaChi";
            // 
            // col_SDT
            // 
            this.col_SDT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.col_SDT.DataPropertyName = "SoDT";
            this.col_SDT.HeaderText = "Số điện thoại";
            this.col_SDT.Name = "col_SDT";
            this.col_SDT.Width = 113;
            // 
            // col_Email
            // 
            this.col_Email.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.col_Email.DataPropertyName = "Email";
            this.col_Email.HeaderText = "Email";
            this.col_Email.Name = "col_Email";
            // 
            // col_DanhGiaDoiTac
            // 
            this.col_DanhGiaDoiTac.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.col_DanhGiaDoiTac.DataPropertyName = "DanhGiaDoiTac";
            this.col_DanhGiaDoiTac.HeaderText = "Đánh giá đối tác";
            this.col_DanhGiaDoiTac.Name = "col_DanhGiaDoiTac";
            // 
            // frmThemDoiTac
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(951, 421);
            this.Controls.Add(this.dgvDoiTac);
            this.Controls.Add(this.btnCapNhat);
            this.Controls.Add(this.btnThemDoiTac);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmThemDoiTac";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thêm đối tác";
            ((System.ComponentModel.ISupportInitialize)(this.dgvDoiTac)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnThemDoiTac;
        private System.Windows.Forms.DataGridView dgvDoiTac;
        private System.Windows.Forms.Button btnCapNhat;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_TenDoiTac;
        private System.Windows.Forms.DataGridViewComboBoxColumn col_LoaiDoiTac;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_NguoiLienHe;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_DiaChi;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_SDT;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_DanhGiaDoiTac;
    }
}