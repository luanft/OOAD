﻿namespace QuanLyDuLich.GUI
{
    partial class diagChiTietLichTrinh
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
            this.label1 = new System.Windows.Forms.Label();
            this.cbThoiGian = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbDoiTac = new System.Windows.Forms.ComboBox();
            this.txtHoatDong = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Thời gian:";
            // 
            // cbThoiGian
            // 
            this.cbThoiGian.FormattingEnabled = true;
            this.cbThoiGian.Items.AddRange(new object[] {
            "0h",
            "1h",
            "2h",
            "3h",
            "4h",
            "5h",
            "6h",
            "7h",
            "8h",
            "9h",
            "10h",
            "11h",
            "12h",
            "13h",
            "14h",
            "15h",
            "16h",
            "17h",
            "18h",
            "19h",
            "20h",
            "21h",
            "22h",
            "23h"});
            this.cbThoiGian.Location = new System.Drawing.Point(84, 26);
            this.cbThoiGian.Name = "cbThoiGian";
            this.cbThoiGian.Size = new System.Drawing.Size(146, 21);
            this.cbThoiGian.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Chương trình:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(239, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Điểm đến:";
            // 
            // cbDoiTac
            // 
            this.cbDoiTac.FormattingEnabled = true;
            this.cbDoiTac.Items.AddRange(new object[] {
            "dfsdfsdf",
            "sdfsdfsdfs",
            "sdfsdfsdfdsf",
            "sdfsdfs",
            "sdfsdfsdf",
            "sdfsdf"});
            this.cbDoiTac.Location = new System.Drawing.Point(300, 26);
            this.cbDoiTac.Name = "cbDoiTac";
            this.cbDoiTac.Size = new System.Drawing.Size(140, 21);
            this.cbDoiTac.TabIndex = 4;
            // 
            // txtHoatDong
            // 
            this.txtHoatDong.Location = new System.Drawing.Point(86, 59);
            this.txtHoatDong.Name = "txtHoatDong";
            this.txtHoatDong.Size = new System.Drawing.Size(354, 82);
            this.txtHoatDong.TabIndex = 5;
            this.txtHoatDong.Text = "";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(253, 158);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Thêm";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(339, 158);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 6;
            this.button2.Text = "Hủy";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // diagChiTietLichTrinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(465, 193);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtHoatDong);
            this.Controls.Add(this.cbDoiTac);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbThoiGian);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "diagChiTietLichTrinh";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Chi tiết lịch trình";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbThoiGian;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbDoiTac;
        private System.Windows.Forms.RichTextBox txtHoatDong;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}