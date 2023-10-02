namespace Phòng_thuốc
{
    partial class frmadmin
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmadmin));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblTenDangNhap = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.btndangxuat = new System.Windows.Forms.Button();
            this.btnthemnguoidung = new System.Windows.Forms.Button();
            this.btnDashboard = new System.Windows.Forms.Button();
            this.lbadmin = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.uC_Themnguoidung1 = new Phòng_thuốc.AdministratorUC.UC_Thongtinnguoidung();
            this.uC_Bangdieukhien1 = new Phòng_thuốc.AdministratorUC.UC_Dashboard();
            this.guna2Elipse3 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse4 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse2 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.lblTenDangNhap);
            this.panel1.Controls.Add(this.btndangxuat);
            this.panel1.Controls.Add(this.btnthemnguoidung);
            this.panel1.Controls.Add(this.btnDashboard);
            this.panel1.Controls.Add(this.lbadmin);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(275, 770);
            this.panel1.TabIndex = 0;
            // 
            // lblTenDangNhap
            // 
            this.lblTenDangNhap.BackColor = System.Drawing.Color.Transparent;
            this.lblTenDangNhap.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenDangNhap.ForeColor = System.Drawing.Color.Yellow;
            this.lblTenDangNhap.Location = new System.Drawing.Point(101, 675);
            this.lblTenDangNhap.Name = "lblTenDangNhap";
            this.lblTenDangNhap.Size = new System.Drawing.Size(70, 33);
            this.lblTenDangNhap.TabIndex = 7;
            this.lblTenDangNhap.Text = "admin";
            // 
            // btndangxuat
            // 
            this.btndangxuat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btndangxuat.FlatAppearance.BorderSize = 0;
            this.btndangxuat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btndangxuat.ForeColor = System.Drawing.Color.White;
            this.btndangxuat.Image = ((System.Drawing.Image)(resources.GetObject("btndangxuat.Image")));
            this.btndangxuat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btndangxuat.Location = new System.Drawing.Point(48, 602);
            this.btndangxuat.Name = "btndangxuat";
            this.btndangxuat.Size = new System.Drawing.Size(224, 55);
            this.btndangxuat.TabIndex = 6;
            this.btndangxuat.Text = "Đăng xuất";
            this.btndangxuat.UseVisualStyleBackColor = false;
            this.btndangxuat.Click += new System.EventHandler(this.btndangxuat_Click);
            // 
            // btnthemnguoidung
            // 
            this.btnthemnguoidung.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnthemnguoidung.FlatAppearance.BorderSize = 0;
            this.btnthemnguoidung.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnthemnguoidung.ForeColor = System.Drawing.Color.White;
            this.btnthemnguoidung.Image = ((System.Drawing.Image)(resources.GetObject("btnthemnguoidung.Image")));
            this.btnthemnguoidung.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnthemnguoidung.Location = new System.Drawing.Point(30, 352);
            this.btnthemnguoidung.Name = "btnthemnguoidung";
            this.btnthemnguoidung.Size = new System.Drawing.Size(224, 55);
            this.btnthemnguoidung.TabIndex = 3;
            this.btnthemnguoidung.Text = "Thông tin người dùng";
            this.btnthemnguoidung.UseVisualStyleBackColor = false;
            this.btnthemnguoidung.Click += new System.EventHandler(this.btnthemnguoidung_Click);
            // 
            // btnDashboard
            // 
            this.btnDashboard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnDashboard.FlatAppearance.BorderSize = 0;
            this.btnDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDashboard.ForeColor = System.Drawing.Color.White;
            this.btnDashboard.Image = ((System.Drawing.Image)(resources.GetObject("btnDashboard.Image")));
            this.btnDashboard.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDashboard.Location = new System.Drawing.Point(43, 282);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Size = new System.Drawing.Size(224, 55);
            this.btnDashboard.TabIndex = 2;
            this.btnDashboard.Text = "Dashboard";
            this.btnDashboard.UseVisualStyleBackColor = false;
            this.btnDashboard.Click += new System.EventHandler(this.btnDashboard_Click);
            // 
            // lbadmin
            // 
            this.lbadmin.AutoSize = true;
            this.lbadmin.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbadmin.ForeColor = System.Drawing.Color.White;
            this.lbadmin.Location = new System.Drawing.Point(24, 206);
            this.lbadmin.Name = "lbadmin";
            this.lbadmin.Size = new System.Drawing.Size(243, 46);
            this.lbadmin.TabIndex = 1;
            this.lbadmin.Text = "Administrator";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(48, 18);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(183, 173);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.uC_Themnguoidung1);
            this.panel2.Controls.Add(this.uC_Bangdieukhien1);
            this.panel2.Location = new System.Drawing.Point(271, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1110, 756);
            this.panel2.TabIndex = 0;
            // 
            // uC_Themnguoidung1
            // 
            this.uC_Themnguoidung1.BackColor = System.Drawing.Color.White;
            this.uC_Themnguoidung1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uC_Themnguoidung1.Location = new System.Drawing.Point(0, 0);
            this.uC_Themnguoidung1.Margin = new System.Windows.Forms.Padding(4);
            this.uC_Themnguoidung1.Name = "uC_Themnguoidung1";
            this.uC_Themnguoidung1.Size = new System.Drawing.Size(1526, 1040);
            this.uC_Themnguoidung1.TabIndex = 1;
            // 
            // uC_Bangdieukhien1
            // 
            this.uC_Bangdieukhien1.BackColor = System.Drawing.Color.White;
            this.uC_Bangdieukhien1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uC_Bangdieukhien1.Location = new System.Drawing.Point(0, 0);
            this.uC_Bangdieukhien1.Margin = new System.Windows.Forms.Padding(4);
            this.uC_Bangdieukhien1.Name = "uC_Bangdieukhien1";
            this.uC_Bangdieukhien1.Size = new System.Drawing.Size(1515, 1027);
            this.uC_Bangdieukhien1.TabIndex = 0;
            // 
            // guna2Elipse3
            // 
            this.guna2Elipse3.TargetControl = this.panel2;
            // 
            // guna2Elipse4
            // 
            this.guna2Elipse4.TargetControl = this.panel2;
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.TargetControl = this.panel2;
            // 
            // guna2Elipse2
            // 
            this.guna2Elipse2.TargetControl = this.panel2;
            // 
            // frmadmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1380, 733);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmadmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin";
            this.Load += new System.EventHandler(this.frmadmin_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btndangxuat;
        private System.Windows.Forms.Button btnthemnguoidung;
        private System.Windows.Forms.Button btnDashboard;
        private System.Windows.Forms.Label lbadmin;
        private System.Windows.Forms.PictureBox pictureBox1;
        private AdministratorUC.UC_Dashboard uC_Bangdieukhien1;
        private AdministratorUC.UC_Thongtinnguoidung uC_Themnguoidung1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse2;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse3;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse4;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblTenDangNhap;
    }
}