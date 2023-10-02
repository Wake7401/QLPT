namespace Phòng_thuốc.AdministratorUC
{
    partial class UC_Thongtinnguoidung
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_Thongtinnguoidung));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.lbloainguoidung = new System.Windows.Forms.Label();
            this.lbtennguoidung = new System.Windows.Forms.Label();
            this.lbngaysinh = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cbbloainguoidung = new System.Windows.Forms.ComboBox();
            this.lbsodienthoai = new System.Windows.Forms.Label();
            this.txttennguoidung = new System.Windows.Forms.TextBox();
            this.txtsodienthoai = new System.Windows.Forms.TextBox();
            this.txtdiachi = new System.Windows.Forms.TextBox();
            this.txttentaikhoan = new System.Windows.Forms.TextBox();
            this.txtmatkhau = new System.Windows.Forms.TextBox();
            this.btndangki = new Guna.UI2.WinForms.Guna2Button();
            this.btnreset = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.quanLyNhaThuocDataSet = new Phòng_thuốc.QuanLyNhaThuocDataSet();
            this.nguoiDungBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nguoiDungTableAdapter = new Phòng_thuốc.QuanLyNhaThuocDataSetTableAdapters.NguoiDungTableAdapter();
            this.dgvThemNguoiDung = new Guna.UI2.WinForms.Guna2DataGridView();
            this.maNguoiDungDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.loaiNguoiDungDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenNguoiDungDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngaySinhDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sdtDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diaChiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenDangNhapDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.matKhauDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nguoiDungBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.btnLoadDuLieu = new Guna.UI2.WinForms.Guna2Button();
            this.btnSua = new Guna.UI2.WinForms.Guna2Button();
            this.btnXoa = new Guna.UI2.WinForms.Guna2Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMaNguoiDung = new System.Windows.Forms.TextBox();
            this.txtNgaySinh = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyNhaThuocDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nguoiDungBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThemNguoiDung)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nguoiDungBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(402, 30);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(376, 43);
            this.label1.TabIndex = 0;
            this.label1.Text = "Thông tin người dùng";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.guna2PictureBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1110, 100);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox1.Image")));
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(330, 18);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.Size = new System.Drawing.Size(65, 55);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2PictureBox1.TabIndex = 1;
            this.guna2PictureBox1.TabStop = false;
            // 
            // lbloainguoidung
            // 
            this.lbloainguoidung.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbloainguoidung.AutoSize = true;
            this.lbloainguoidung.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbloainguoidung.Location = new System.Drawing.Point(24, 126);
            this.lbloainguoidung.Name = "lbloainguoidung";
            this.lbloainguoidung.Size = new System.Drawing.Size(214, 33);
            this.lbloainguoidung.TabIndex = 2;
            this.lbloainguoidung.Text = "Loại người dùng :";
            // 
            // lbtennguoidung
            // 
            this.lbtennguoidung.AutoSize = true;
            this.lbtennguoidung.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbtennguoidung.Location = new System.Drawing.Point(24, 188);
            this.lbtennguoidung.Name = "lbtennguoidung";
            this.lbtennguoidung.Size = new System.Drawing.Size(206, 33);
            this.lbtennguoidung.TabIndex = 3;
            this.lbtennguoidung.Text = "Tên người dùng :";
            // 
            // lbngaysinh
            // 
            this.lbngaysinh.AutoSize = true;
            this.lbngaysinh.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbngaysinh.Location = new System.Drawing.Point(24, 245);
            this.lbngaysinh.Name = "lbngaysinh";
            this.lbngaysinh.Size = new System.Drawing.Size(142, 33);
            this.lbngaysinh.TabIndex = 4;
            this.lbngaysinh.Text = "Ngày sinh :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(602, 132);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(111, 33);
            this.label5.TabIndex = 5;
            this.label5.Text = "Địa chỉ :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(602, 188);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(193, 33);
            this.label6.TabIndex = 6;
            this.label6.Text = "Tên đăng nhập :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(602, 245);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(136, 33);
            this.label7.TabIndex = 7;
            this.label7.Text = "Mật khẩu :";
            // 
            // cbbloainguoidung
            // 
            this.cbbloainguoidung.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbloainguoidung.ForeColor = System.Drawing.Color.Black;
            this.cbbloainguoidung.FormattingEnabled = true;
            this.cbbloainguoidung.Items.AddRange(new object[] {
            "Administrator",
            "Nhân viên"});
            this.cbbloainguoidung.Location = new System.Drawing.Point(244, 126);
            this.cbbloainguoidung.Name = "cbbloainguoidung";
            this.cbbloainguoidung.Size = new System.Drawing.Size(340, 39);
            this.cbbloainguoidung.TabIndex = 8;
            // 
            // lbsodienthoai
            // 
            this.lbsodienthoai.AutoSize = true;
            this.lbsodienthoai.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbsodienthoai.Location = new System.Drawing.Point(24, 303);
            this.lbsodienthoai.Name = "lbsodienthoai";
            this.lbsodienthoai.Size = new System.Drawing.Size(178, 33);
            this.lbsodienthoai.TabIndex = 9;
            this.lbsodienthoai.Text = "Số điện thoại :";
            // 
            // txttennguoidung
            // 
            this.txttennguoidung.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttennguoidung.ForeColor = System.Drawing.Color.Black;
            this.txttennguoidung.Location = new System.Drawing.Point(244, 188);
            this.txttennguoidung.Multiline = true;
            this.txttennguoidung.Name = "txttennguoidung";
            this.txttennguoidung.Size = new System.Drawing.Size(340, 30);
            this.txttennguoidung.TabIndex = 10;
            // 
            // txtsodienthoai
            // 
            this.txtsodienthoai.ForeColor = System.Drawing.Color.Black;
            this.txtsodienthoai.Location = new System.Drawing.Point(244, 303);
            this.txtsodienthoai.Name = "txtsodienthoai";
            this.txtsodienthoai.Size = new System.Drawing.Size(340, 30);
            this.txtsodienthoai.TabIndex = 11;
            // 
            // txtdiachi
            // 
            this.txtdiachi.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdiachi.ForeColor = System.Drawing.Color.Black;
            this.txtdiachi.Location = new System.Drawing.Point(733, 135);
            this.txtdiachi.Multiline = true;
            this.txtdiachi.Name = "txtdiachi";
            this.txtdiachi.Size = new System.Drawing.Size(340, 30);
            this.txtdiachi.TabIndex = 12;
            // 
            // txttentaikhoan
            // 
            this.txttentaikhoan.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttentaikhoan.ForeColor = System.Drawing.Color.Black;
            this.txttentaikhoan.Location = new System.Drawing.Point(790, 188);
            this.txttentaikhoan.Multiline = true;
            this.txttentaikhoan.Name = "txttentaikhoan";
            this.txttentaikhoan.Size = new System.Drawing.Size(283, 30);
            this.txttentaikhoan.TabIndex = 13;
            // 
            // txtmatkhau
            // 
            this.txtmatkhau.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtmatkhau.ForeColor = System.Drawing.Color.Black;
            this.txtmatkhau.Location = new System.Drawing.Point(733, 245);
            this.txtmatkhau.Multiline = true;
            this.txtmatkhau.Name = "txtmatkhau";
            this.txtmatkhau.Size = new System.Drawing.Size(340, 30);
            this.txtmatkhau.TabIndex = 14;
            // 
            // btndangki
            // 
            this.btndangki.BorderRadius = 19;
            this.btndangki.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btndangki.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btndangki.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btndangki.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btndangki.FillColor = System.Drawing.Color.Orchid;
            this.btndangki.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndangki.ForeColor = System.Drawing.Color.White;
            this.btndangki.HoverState.BorderColor = System.Drawing.Color.White;
            this.btndangki.Image = ((System.Drawing.Image)(resources.GetObject("btndangki.Image")));
            this.btndangki.ImageSize = new System.Drawing.Size(30, 30);
            this.btndangki.Location = new System.Drawing.Point(187, 354);
            this.btndangki.Name = "btndangki";
            this.btndangki.Size = new System.Drawing.Size(154, 45);
            this.btndangki.TabIndex = 17;
            this.btndangki.Text = "Đăng kí";
            this.btndangki.Click += new System.EventHandler(this.btndangki_Click);
            // 
            // btnreset
            // 
            this.btnreset.BorderRadius = 19;
            this.btnreset.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnreset.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnreset.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnreset.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnreset.FillColor = System.Drawing.Color.Orchid;
            this.btnreset.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnreset.ForeColor = System.Drawing.Color.White;
            this.btnreset.HoverState.BorderColor = System.Drawing.Color.White;
            this.btnreset.Image = ((System.Drawing.Image)(resources.GetObject("btnreset.Image")));
            this.btnreset.ImageSize = new System.Drawing.Size(30, 30);
            this.btnreset.Location = new System.Drawing.Point(508, 354);
            this.btnreset.Name = "btnreset";
            this.btnreset.Size = new System.Drawing.Size(156, 45);
            this.btnreset.TabIndex = 18;
            this.btnreset.Text = "Reset";
            this.btnreset.Click += new System.EventHandler(this.btnreset_Click);
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.TargetControl = this;
            // 
            // quanLyNhaThuocDataSet
            // 
            this.quanLyNhaThuocDataSet.DataSetName = "QuanLyNhaThuocDataSet";
            this.quanLyNhaThuocDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // nguoiDungBindingSource
            // 
            this.nguoiDungBindingSource.DataMember = "NguoiDung";
            this.nguoiDungBindingSource.DataSource = this.quanLyNhaThuocDataSet;
            // 
            // nguoiDungTableAdapter
            // 
            this.nguoiDungTableAdapter.ClearBeforeFill = true;
            // 
            // dgvThemNguoiDung
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgvThemNguoiDung.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvThemNguoiDung.AutoGenerateColumns = false;
            this.dgvThemNguoiDung.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvThemNguoiDung.BackgroundColor = System.Drawing.Color.Silver;
            this.dgvThemNguoiDung.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvThemNguoiDung.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvThemNguoiDung.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvThemNguoiDung.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvThemNguoiDung.ColumnHeadersHeight = 50;
            this.dgvThemNguoiDung.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maNguoiDungDataGridViewTextBoxColumn,
            this.loaiNguoiDungDataGridViewTextBoxColumn,
            this.tenNguoiDungDataGridViewTextBoxColumn,
            this.ngaySinhDataGridViewTextBoxColumn,
            this.sdtDataGridViewTextBoxColumn,
            this.diaChiDataGridViewTextBoxColumn,
            this.tenDangNhapDataGridViewTextBoxColumn,
            this.matKhauDataGridViewTextBoxColumn});
            this.dgvThemNguoiDung.DataSource = this.nguoiDungBindingSource1;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvThemNguoiDung.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvThemNguoiDung.EnableHeadersVisualStyles = false;
            this.dgvThemNguoiDung.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvThemNguoiDung.Location = new System.Drawing.Point(30, 405);
            this.dgvThemNguoiDung.Name = "dgvThemNguoiDung";
            this.dgvThemNguoiDung.ReadOnly = true;
            this.dgvThemNguoiDung.RowHeadersVisible = false;
            this.dgvThemNguoiDung.RowTemplate.Height = 24;
            this.dgvThemNguoiDung.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvThemNguoiDung.Size = new System.Drawing.Size(1043, 338);
            this.dgvThemNguoiDung.TabIndex = 19;
            this.dgvThemNguoiDung.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvThemNguoiDung.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvThemNguoiDung.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvThemNguoiDung.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvThemNguoiDung.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvThemNguoiDung.ThemeStyle.BackColor = System.Drawing.Color.Silver;
            this.dgvThemNguoiDung.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvThemNguoiDung.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgvThemNguoiDung.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvThemNguoiDung.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvThemNguoiDung.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvThemNguoiDung.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvThemNguoiDung.ThemeStyle.HeaderStyle.Height = 50;
            this.dgvThemNguoiDung.ThemeStyle.ReadOnly = true;
            this.dgvThemNguoiDung.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvThemNguoiDung.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvThemNguoiDung.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvThemNguoiDung.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvThemNguoiDung.ThemeStyle.RowsStyle.Height = 24;
            this.dgvThemNguoiDung.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvThemNguoiDung.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvThemNguoiDung.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvThemNguoiDung_CellClick);
            // 
            // maNguoiDungDataGridViewTextBoxColumn
            // 
            this.maNguoiDungDataGridViewTextBoxColumn.DataPropertyName = "MaNguoiDung";
            this.maNguoiDungDataGridViewTextBoxColumn.HeaderText = "Mã Người Dùng";
            this.maNguoiDungDataGridViewTextBoxColumn.Name = "maNguoiDungDataGridViewTextBoxColumn";
            this.maNguoiDungDataGridViewTextBoxColumn.ReadOnly = true;
            this.maNguoiDungDataGridViewTextBoxColumn.Width = 152;
            // 
            // loaiNguoiDungDataGridViewTextBoxColumn
            // 
            this.loaiNguoiDungDataGridViewTextBoxColumn.DataPropertyName = "LoaiNguoiDung";
            this.loaiNguoiDungDataGridViewTextBoxColumn.HeaderText = "Loại Người Dùng";
            this.loaiNguoiDungDataGridViewTextBoxColumn.Name = "loaiNguoiDungDataGridViewTextBoxColumn";
            this.loaiNguoiDungDataGridViewTextBoxColumn.ReadOnly = true;
            this.loaiNguoiDungDataGridViewTextBoxColumn.Width = 161;
            // 
            // tenNguoiDungDataGridViewTextBoxColumn
            // 
            this.tenNguoiDungDataGridViewTextBoxColumn.DataPropertyName = "TenNguoiDung";
            this.tenNguoiDungDataGridViewTextBoxColumn.HeaderText = "Tên Người Dùng";
            this.tenNguoiDungDataGridViewTextBoxColumn.Name = "tenNguoiDungDataGridViewTextBoxColumn";
            this.tenNguoiDungDataGridViewTextBoxColumn.ReadOnly = true;
            this.tenNguoiDungDataGridViewTextBoxColumn.Width = 155;
            // 
            // ngaySinhDataGridViewTextBoxColumn
            // 
            this.ngaySinhDataGridViewTextBoxColumn.DataPropertyName = "NgaySinh";
            this.ngaySinhDataGridViewTextBoxColumn.HeaderText = "Ngày Sinh";
            this.ngaySinhDataGridViewTextBoxColumn.Name = "ngaySinhDataGridViewTextBoxColumn";
            this.ngaySinhDataGridViewTextBoxColumn.ReadOnly = true;
            this.ngaySinhDataGridViewTextBoxColumn.Width = 108;
            // 
            // sdtDataGridViewTextBoxColumn
            // 
            this.sdtDataGridViewTextBoxColumn.DataPropertyName = "Sdt";
            this.sdtDataGridViewTextBoxColumn.HeaderText = "Số điện thoại";
            this.sdtDataGridViewTextBoxColumn.Name = "sdtDataGridViewTextBoxColumn";
            this.sdtDataGridViewTextBoxColumn.ReadOnly = true;
            this.sdtDataGridViewTextBoxColumn.Width = 129;
            // 
            // diaChiDataGridViewTextBoxColumn
            // 
            this.diaChiDataGridViewTextBoxColumn.DataPropertyName = "DiaChi";
            this.diaChiDataGridViewTextBoxColumn.HeaderText = "Địa Chỉ";
            this.diaChiDataGridViewTextBoxColumn.Name = "diaChiDataGridViewTextBoxColumn";
            this.diaChiDataGridViewTextBoxColumn.ReadOnly = true;
            this.diaChiDataGridViewTextBoxColumn.Width = 66;
            // 
            // tenDangNhapDataGridViewTextBoxColumn
            // 
            this.tenDangNhapDataGridViewTextBoxColumn.DataPropertyName = "TenDangNhap";
            this.tenDangNhapDataGridViewTextBoxColumn.HeaderText = "Tên Đăng Nhập";
            this.tenDangNhapDataGridViewTextBoxColumn.Name = "tenDangNhapDataGridViewTextBoxColumn";
            this.tenDangNhapDataGridViewTextBoxColumn.ReadOnly = true;
            this.tenDangNhapDataGridViewTextBoxColumn.Width = 146;
            // 
            // matKhauDataGridViewTextBoxColumn
            // 
            this.matKhauDataGridViewTextBoxColumn.DataPropertyName = "MatKhau";
            this.matKhauDataGridViewTextBoxColumn.HeaderText = "Mật Khẩu";
            this.matKhauDataGridViewTextBoxColumn.Name = "matKhauDataGridViewTextBoxColumn";
            this.matKhauDataGridViewTextBoxColumn.ReadOnly = true;
            this.matKhauDataGridViewTextBoxColumn.Width = 105;
            // 
            // nguoiDungBindingSource1
            // 
            this.nguoiDungBindingSource1.DataMember = "NguoiDung";
            this.nguoiDungBindingSource1.DataSource = this.quanLyNhaThuocDataSet;
            // 
            // btnLoadDuLieu
            // 
            this.btnLoadDuLieu.BorderRadius = 19;
            this.btnLoadDuLieu.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnLoadDuLieu.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnLoadDuLieu.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnLoadDuLieu.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnLoadDuLieu.FillColor = System.Drawing.Color.Orchid;
            this.btnLoadDuLieu.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoadDuLieu.ForeColor = System.Drawing.Color.White;
            this.btnLoadDuLieu.HoverState.BorderColor = System.Drawing.Color.White;
            this.btnLoadDuLieu.Image = ((System.Drawing.Image)(resources.GetObject("btnLoadDuLieu.Image")));
            this.btnLoadDuLieu.ImageSize = new System.Drawing.Size(30, 30);
            this.btnLoadDuLieu.Location = new System.Drawing.Point(670, 354);
            this.btnLoadDuLieu.Name = "btnLoadDuLieu";
            this.btnLoadDuLieu.Size = new System.Drawing.Size(190, 45);
            this.btnLoadDuLieu.TabIndex = 18;
            this.btnLoadDuLieu.Text = "Load Dữ Liệu";
            this.btnLoadDuLieu.Click += new System.EventHandler(this.btnLoadDuLieu_Click);
            // 
            // btnSua
            // 
            this.btnSua.BorderRadius = 19;
            this.btnSua.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSua.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSua.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSua.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSua.FillColor = System.Drawing.Color.Orchid;
            this.btnSua.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.ForeColor = System.Drawing.Color.White;
            this.btnSua.HoverState.BorderColor = System.Drawing.Color.White;
            this.btnSua.Image = ((System.Drawing.Image)(resources.GetObject("btnSua.Image")));
            this.btnSua.ImageSize = new System.Drawing.Size(30, 30);
            this.btnSua.Location = new System.Drawing.Point(30, 354);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(154, 45);
            this.btnSua.TabIndex = 17;
            this.btnSua.Text = "Cập nhật";
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.BorderRadius = 19;
            this.btnXoa.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnXoa.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnXoa.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnXoa.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnXoa.FillColor = System.Drawing.Color.Orchid;
            this.btnXoa.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.ForeColor = System.Drawing.Color.White;
            this.btnXoa.HoverState.BorderColor = System.Drawing.Color.White;
            this.btnXoa.Image = ((System.Drawing.Image)(resources.GetObject("btnXoa.Image")));
            this.btnXoa.ImageSize = new System.Drawing.Size(30, 30);
            this.btnXoa.Location = new System.Drawing.Point(347, 354);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(154, 45);
            this.btnXoa.TabIndex = 17;
            this.btnXoa.Text = "Xoá";
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(608, 303);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(194, 33);
            this.label2.TabIndex = 21;
            this.label2.Text = "Mã người dùng:";
            // 
            // txtMaNguoiDung
            // 
            this.txtMaNguoiDung.Location = new System.Drawing.Point(808, 310);
            this.txtMaNguoiDung.Name = "txtMaNguoiDung";
            this.txtMaNguoiDung.Size = new System.Drawing.Size(264, 30);
            this.txtMaNguoiDung.TabIndex = 22;
            // 
            // txtNgaySinh
            // 
            this.txtNgaySinh.Location = new System.Drawing.Point(244, 252);
            this.txtNgaySinh.Name = "txtNgaySinh";
            this.txtNgaySinh.Size = new System.Drawing.Size(340, 30);
            this.txtNgaySinh.TabIndex = 23;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(913, 350);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(146, 49);
            this.label3.TabIndex = 24;
            this.label3.Text = "*Mã người dùng được tạo tự động";
            // 
            // UC_Themnguoidung
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNgaySinh);
            this.Controls.Add(this.txtMaNguoiDung);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvThemNguoiDung);
            this.Controls.Add(this.btnLoadDuLieu);
            this.Controls.Add(this.btnreset);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btndangki);
            this.Controls.Add(this.txtmatkhau);
            this.Controls.Add(this.txttentaikhoan);
            this.Controls.Add(this.txtdiachi);
            this.Controls.Add(this.txtsodienthoai);
            this.Controls.Add(this.txttennguoidung);
            this.Controls.Add(this.lbsodienthoai);
            this.Controls.Add(this.cbbloainguoidung);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lbngaysinh);
            this.Controls.Add(this.lbtennguoidung);
            this.Controls.Add(this.lbloainguoidung);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "UC_Themnguoidung";
            this.Size = new System.Drawing.Size(1110, 756);
            this.Load += new System.EventHandler(this.UC_Themnguoidung_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyNhaThuocDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nguoiDungBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThemNguoiDung)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nguoiDungBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbloainguoidung;
        private System.Windows.Forms.Label lbtennguoidung;
        private System.Windows.Forms.Label lbngaysinh;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbbloainguoidung;
        private System.Windows.Forms.Label lbsodienthoai;
        private System.Windows.Forms.TextBox txttennguoidung;
        private System.Windows.Forms.TextBox txtsodienthoai;
        private System.Windows.Forms.TextBox txtdiachi;
        private System.Windows.Forms.TextBox txttentaikhoan;
        private System.Windows.Forms.TextBox txtmatkhau;
        private Guna.UI2.WinForms.Guna2Button btndangki;
        private Guna.UI2.WinForms.Guna2Button btnreset;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private System.Windows.Forms.BindingSource nguoiDungBindingSource;
        private QuanLyNhaThuocDataSet quanLyNhaThuocDataSet;
        private QuanLyNhaThuocDataSetTableAdapters.NguoiDungTableAdapter nguoiDungTableAdapter;
        private Guna.UI2.WinForms.Guna2DataGridView dgvThemNguoiDung;
        private System.Windows.Forms.BindingSource nguoiDungBindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn maNguoiDungDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn loaiNguoiDungDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenNguoiDungDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngaySinhDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sdtDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn diaChiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenDangNhapDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn matKhauDataGridViewTextBoxColumn;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private Guna.UI2.WinForms.Guna2Button btnLoadDuLieu;
        private Guna.UI2.WinForms.Guna2Button btnSua;
        private Guna.UI2.WinForms.Guna2Button btnXoa;
        private System.Windows.Forms.TextBox txtMaNguoiDung;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNgaySinh;
        private System.Windows.Forms.Label label3;
    }
}
