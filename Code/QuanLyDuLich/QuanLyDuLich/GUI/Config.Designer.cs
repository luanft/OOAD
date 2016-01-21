namespace QuanLyDuLich.GUI
{
    partial class Config
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
            this.label2 = new System.Windows.Forms.Label();
            this.tb_ServerName = new System.Windows.Forms.TextBox();
            this.tb_DatabaseName = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Server Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Database Name";
            // 
            // tb_ServerName
            // 
            this.tb_ServerName.Location = new System.Drawing.Point(128, 37);
            this.tb_ServerName.Name = "tb_ServerName";
            this.tb_ServerName.Size = new System.Drawing.Size(189, 20);
            this.tb_ServerName.TabIndex = 2;
            // 
            // tb_DatabaseName
            // 
            this.tb_DatabaseName.Location = new System.Drawing.Point(128, 73);
            this.tb_DatabaseName.Name = "tb_DatabaseName";
            this.tb_DatabaseName.Size = new System.Drawing.Size(189, 20);
            this.tb_DatabaseName.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(275, 106);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Xác nhận";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Config
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(362, 141);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tb_DatabaseName);
            this.Controls.Add(this.tb_ServerName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Config";
            this.Text = "Config";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_ServerName;
        private System.Windows.Forms.TextBox tb_DatabaseName;
        private System.Windows.Forms.Button button1;

    }
}