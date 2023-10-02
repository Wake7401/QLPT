namespace Phòng_thuốc
{
    partial class frmlogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmlogin));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbdangnhap = new System.Windows.Forms.Label();
            this.lbtendangnhap = new System.Windows.Forms.Label();
            this.lbmatkhau = new System.Windows.Forms.Label();
            this.txttendangnhap = new System.Windows.Forms.TextBox();
            this.txtmatkhau = new System.Windows.Forms.TextBox();
            this.btndangnhap = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(473, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(319, 407);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lbdangnhap
            // 
            this.lbdangnhap.AutoSize = true;
            this.lbdangnhap.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbdangnhap.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbdangnhap.Location = new System.Drawing.Point(159, 53);
            this.lbdangnhap.Name = "lbdangnhap";
            this.lbdangnhap.Size = new System.Drawing.Size(204, 45);
            this.lbdangnhap.TabIndex = 1;
            this.lbdangnhap.Text = "Đăng nhập";
            // 
            // lbtendangnhap
            // 
            this.lbtendangnhap.AutoSize = true;
            this.lbtendangnhap.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbtendangnhap.Location = new System.Drawing.Point(30, 141);
            this.lbtendangnhap.Name = "lbtendangnhap";
            this.lbtendangnhap.Size = new System.Drawing.Size(163, 26);
            this.lbtendangnhap.TabIndex = 2;
            this.lbtendangnhap.Text = "Tên đăng nhập :";
            // 
            // lbmatkhau
            // 
            this.lbmatkhau.AutoSize = true;
            this.lbmatkhau.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbmatkhau.Location = new System.Drawing.Point(30, 189);
            this.lbmatkhau.Name = "lbmatkhau";
            this.lbmatkhau.Size = new System.Drawing.Size(111, 26);
            this.lbmatkhau.TabIndex = 3;
            this.lbmatkhau.Text = "Mật khẩu :";
            // 
            // txttendangnhap
            // 
            this.txttendangnhap.Location = new System.Drawing.Point(202, 140);
            this.txttendangnhap.Name = "txttendangnhap";
            this.txttendangnhap.Size = new System.Drawing.Size(238, 30);
            this.txttendangnhap.TabIndex = 4;
            // 
            // txtmatkhau
            // 
            this.txtmatkhau.Location = new System.Drawing.Point(202, 186);
            this.txtmatkhau.Name = "txtmatkhau";
            this.txtmatkhau.Size = new System.Drawing.Size(238, 30);
            this.txtmatkhau.TabIndex = 5;
            this.txtmatkhau.UseSystemPasswordChar = true;
            // 
            // btndangnhap
            // 
            this.btndangnhap.BorderRadius = 19;
            this.btndangnhap.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btndangnhap.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btndangnhap.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btndangnhap.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btndangnhap.FillColor = System.Drawing.Color.Crimson;
            this.btndangnhap.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndangnhap.ForeColor = System.Drawing.Color.White;
            this.btndangnhap.HoverState.BorderColor = System.Drawing.Color.White;
            this.btndangnhap.Image = ((System.Drawing.Image)(resources.GetObject("btndangnhap.Image")));
            this.btndangnhap.ImageSize = new System.Drawing.Size(30, 30);
            this.btndangnhap.Location = new System.Drawing.Point(286, 232);
            this.btndangnhap.Name = "btndangnhap";
            this.btndangnhap.Size = new System.Drawing.Size(154, 45);
            this.btndangnhap.TabIndex = 18;
            this.btndangnhap.Text = "Đăng nhập";
            this.btndangnhap.Click += new System.EventHandler(this.btndangnhap_Click);
            // 
            // frmlogin
            // 
            this.AcceptButton = this.btndangnhap;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(803, 423);
            this.Controls.Add(this.btndangnhap);
            this.Controls.Add(this.txtmatkhau);
            this.Controls.Add(this.txttendangnhap);
            this.Controls.Add(this.lbmatkhau);
            this.Controls.Add(this.lbtendangnhap);
            this.Controls.Add(this.lbdangnhap);
            this.Controls.Add(this.pictureBox1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmlogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.frmlogin_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.frmlogin_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbdangnhap;
        private System.Windows.Forms.Label lbtendangnhap;
        private System.Windows.Forms.Label lbmatkhau;
        private System.Windows.Forms.TextBox txttendangnhap;
        private System.Windows.Forms.TextBox txtmatkhau;
        private Guna.UI2.WinForms.Guna2Button btndangnhap;
    }
}