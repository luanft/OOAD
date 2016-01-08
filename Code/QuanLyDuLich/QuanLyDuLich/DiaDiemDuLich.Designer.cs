namespace QuanLyDuLich
{
    partial class DiaDiemDuLich
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lb_moTa = new System.Windows.Forms.Label();
            this.lb_tenDiaDiem = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lb_moTa
            // 
            this.lb_moTa.AutoSize = true;
            this.lb_moTa.Location = new System.Drawing.Point(19, 49);
            this.lb_moTa.Name = "lb_moTa";
            this.lb_moTa.Size = new System.Drawing.Size(94, 13);
            this.lb_moTa.TabIndex = 0;
            this.lb_moTa.Text = "Mô tả điểm du lịch";
            // 
            // lb_tenDiaDiem
            // 
            this.lb_tenDiaDiem.AutoSize = true;
            this.lb_tenDiaDiem.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_tenDiaDiem.Location = new System.Drawing.Point(18, 17);
            this.lb_tenDiaDiem.Name = "lb_tenDiaDiem";
            this.lb_tenDiaDiem.Size = new System.Drawing.Size(124, 22);
            this.lb_tenDiaDiem.TabIndex = 1;
            this.lb_tenDiaDiem.Text = "Tên Địa Điểm";
            // 
            // DiaDiemDuLich
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.lb_tenDiaDiem);
            this.Controls.Add(this.lb_moTa);
            this.Name = "DiaDiemDuLich";
            this.Size = new System.Drawing.Size(532, 117);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_moTa;
        public System.Windows.Forms.Label lb_tenDiaDiem;
    }
}
