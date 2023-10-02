namespace Phòng_thuốc.NhanvienUC
{
    partial class UC_Nhapthuoc
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_Nhapthuoc));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMaThuoc = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtTenThuoc = new Guna.UI2.WinForms.Guna2TextBox();
            this.lbtenthuoc = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtSoLuong = new Guna.UI2.WinForms.Guna2TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtGiaBan = new Guna.UI2.WinForms.Guna2TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.dtpNgaySanXuat = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.dtpHSD = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.btnThem = new Guna.UI2.WinForms.Guna2Button();
            this.btnReset = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.dgvNhapThuoc = new Guna.UI2.WinForms.Guna2DataGridView();
            this.maThuocDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenThuocDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maNhaCungCapDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maLoaiThuocDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngaySXDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hSDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soLuongDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.giaBanDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.thuocBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.quanLyNhaThuocDataSet3 = new Phòng_thuốc.QuanLyNhaThuocDataSet3();
            this.thuocBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.quanLyNhaThuocDataSet1 = new Phòng_thuốc.QuanLyNhaThuocDataSet1();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.txtNhaCungCap = new Guna.UI2.WinForms.Guna2TextBox();
            this.thuocTableAdapter = new Phòng_thuốc.QuanLyNhaThuocDataSet1TableAdapters.ThuocTableAdapter();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMaLoaiThuoc = new System.Windows.Forms.TextBox();
            this.thuocBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.thuocTableAdapter1 = new Phòng_thuốc.QuanLyNhaThuocDataSet3TableAdapters.ThuocTableAdapter();
            this.btnXoa = new Guna.UI2.WinForms.Guna2Button();
            this.btnSua = new Guna.UI2.WinForms.Guna2Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhapThuoc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.thuocBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyNhaThuocDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.thuocBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyNhaThuocDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.thuocBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1105, 100);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(455, 29);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(242, 42);
            this.label1.TabIndex = 2;
            this.label1.Text = "Quản lý thuốc";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(34, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 33);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mã Thuốc :";
            // 
            // txtMaThuoc
            // 
            this.txtMaThuoc.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMaThuoc.DefaultText = "";
            this.txtMaThuoc.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtMaThuoc.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtMaThuoc.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMaThuoc.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMaThuoc.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMaThuoc.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaThuoc.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMaThuoc.Location = new System.Drawing.Point(175, 130);
            this.txtMaThuoc.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtMaThuoc.Name = "txtMaThuoc";
            this.txtMaThuoc.PasswordChar = '\0';
            this.txtMaThuoc.PlaceholderText = "";
            this.txtMaThuoc.SelectedText = "";
            this.txtMaThuoc.Size = new System.Drawing.Size(340, 33);
            this.txtMaThuoc.TabIndex = 2;
            // 
            // txtTenThuoc
            // 
            this.txtTenThuoc.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTenThuoc.DefaultText = "";
            this.txtTenThuoc.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTenThuoc.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTenThuoc.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTenThuoc.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTenThuoc.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTenThuoc.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenThuoc.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTenThuoc.Location = new System.Drawing.Point(182, 178);
            this.txtTenThuoc.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtTenThuoc.Name = "txtTenThuoc";
            this.txtTenThuoc.PasswordChar = '\0';
            this.txtTenThuoc.PlaceholderText = "";
            this.txtTenThuoc.SelectedText = "";
            this.txtTenThuoc.Size = new System.Drawing.Size(333, 33);
            this.txtTenThuoc.TabIndex = 4;
            // 
            // lbtenthuoc
            // 
            this.lbtenthuoc.AutoSize = true;
            this.lbtenthuoc.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbtenthuoc.Location = new System.Drawing.Point(34, 178);
            this.lbtenthuoc.Name = "lbtenthuoc";
            this.lbtenthuoc.Size = new System.Drawing.Size(141, 33);
            this.lbtenthuoc.TabIndex = 3;
            this.lbtenthuoc.Text = "Tên thuốc :";
            this.lbtenthuoc.Click += new System.EventHandler(this.lbtenthuoc_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(584, 283);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(187, 33);
            this.label5.TabIndex = 7;
            this.label5.Text = "Ngày sản xuất :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(584, 229);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(170, 33);
            this.label6.TabIndex = 9;
            this.label6.Text = "Hạn sử dụng :";
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSoLuong.DefaultText = "";
            this.txtSoLuong.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtSoLuong.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtSoLuong.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSoLuong.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSoLuong.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSoLuong.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSoLuong.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSoLuong.Location = new System.Drawing.Point(723, 130);
            this.txtSoLuong.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.PasswordChar = '\0';
            this.txtSoLuong.PlaceholderText = "";
            this.txtSoLuong.SelectedText = "";
            this.txtSoLuong.Size = new System.Drawing.Size(340, 33);
            this.txtSoLuong.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(584, 130);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(132, 33);
            this.label7.TabIndex = 11;
            this.label7.Text = "Số lượng :";
            // 
            // txtGiaBan
            // 
            this.txtGiaBan.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtGiaBan.DefaultText = "";
            this.txtGiaBan.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtGiaBan.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtGiaBan.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtGiaBan.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtGiaBan.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtGiaBan.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGiaBan.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtGiaBan.Location = new System.Drawing.Point(707, 178);
            this.txtGiaBan.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtGiaBan.Name = "txtGiaBan";
            this.txtGiaBan.PasswordChar = '\0';
            this.txtGiaBan.PlaceholderText = "";
            this.txtGiaBan.SelectedText = "";
            this.txtGiaBan.Size = new System.Drawing.Size(356, 33);
            this.txtGiaBan.TabIndex = 14;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(584, 178);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(116, 33);
            this.label8.TabIndex = 13;
            this.label8.Text = "Giá bán :";
            // 
            // dtpNgaySanXuat
            // 
            this.dtpNgaySanXuat.BorderThickness = 1;
            this.dtpNgaySanXuat.Checked = true;
            this.dtpNgaySanXuat.FillColor = System.Drawing.Color.White;
            this.dtpNgaySanXuat.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpNgaySanXuat.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgaySanXuat.Location = new System.Drawing.Point(777, 283);
            this.dtpNgaySanXuat.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpNgaySanXuat.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpNgaySanXuat.Name = "dtpNgaySanXuat";
            this.dtpNgaySanXuat.Size = new System.Drawing.Size(286, 33);
            this.dtpNgaySanXuat.TabIndex = 15;
            this.dtpNgaySanXuat.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.dtpNgaySanXuat.Value = new System.DateTime(2022, 4, 6, 16, 14, 53, 107);
            // 
            // dtpHSD
            // 
            this.dtpHSD.BorderThickness = 1;
            this.dtpHSD.Checked = true;
            this.dtpHSD.FillColor = System.Drawing.Color.White;
            this.dtpHSD.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpHSD.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpHSD.Location = new System.Drawing.Point(760, 229);
            this.dtpHSD.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpHSD.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpHSD.Name = "dtpHSD";
            this.dtpHSD.Size = new System.Drawing.Size(303, 33);
            this.dtpHSD.TabIndex = 16;
            this.dtpHSD.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.dtpHSD.Value = new System.DateTime(2022, 4, 6, 16, 13, 31, 146);
            // 
            // btnThem
            // 
            this.btnThem.BorderRadius = 19;
            this.btnThem.BorderThickness = 1;
            this.btnThem.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnThem.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnThem.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnThem.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnThem.FillColor = System.Drawing.Color.CornflowerBlue;
            this.btnThem.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.ForeColor = System.Drawing.Color.White;
            this.btnThem.Image = ((System.Drawing.Image)(resources.GetObject("btnThem.Image")));
            this.btnThem.ImageSize = new System.Drawing.Size(30, 30);
            this.btnThem.Location = new System.Drawing.Point(39, 329);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(161, 45);
            this.btnThem.TabIndex = 17;
            this.btnThem.Text = "Thêm";
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnReset
            // 
            this.btnReset.BorderRadius = 19;
            this.btnReset.BorderThickness = 1;
            this.btnReset.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnReset.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnReset.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnReset.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnReset.FillColor = System.Drawing.Color.CornflowerBlue;
            this.btnReset.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.ForeColor = System.Drawing.Color.White;
            this.btnReset.Image = ((System.Drawing.Image)(resources.GetObject("btnReset.Image")));
            this.btnReset.ImageSize = new System.Drawing.Size(30, 30);
            this.btnReset.Location = new System.Drawing.Point(516, 329);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(149, 45);
            this.btnReset.TabIndex = 18;
            this.btnReset.Text = "Reset";
            this.btnReset.Click += new System.EventHandler(this.btnreset_Click);
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.TargetControl = this;
            // 
            // dgvNhapThuoc
            // 
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.dgvNhapThuoc.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvNhapThuoc.AutoGenerateColumns = false;
            this.dgvNhapThuoc.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvNhapThuoc.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dgvNhapThuoc.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvNhapThuoc.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvNhapThuoc.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvNhapThuoc.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvNhapThuoc.ColumnHeadersHeight = 24;
            this.dgvNhapThuoc.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maThuocDataGridViewTextBoxColumn,
            this.tenThuocDataGridViewTextBoxColumn,
            this.maNhaCungCapDataGridViewTextBoxColumn,
            this.maLoaiThuocDataGridViewTextBoxColumn,
            this.ngaySXDataGridViewTextBoxColumn,
            this.hSDDataGridViewTextBoxColumn,
            this.soLuongDataGridViewTextBoxColumn,
            this.giaBanDataGridViewTextBoxColumn});
            this.dgvNhapThuoc.DataSource = this.thuocBindingSource2;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvNhapThuoc.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvNhapThuoc.EnableHeadersVisualStyles = false;
            this.dgvNhapThuoc.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvNhapThuoc.Location = new System.Drawing.Point(40, 380);
            this.dgvNhapThuoc.Name = "dgvNhapThuoc";
            this.dgvNhapThuoc.RowHeadersVisible = false;
            this.dgvNhapThuoc.RowHeadersWidth = 51;
            this.dgvNhapThuoc.RowTemplate.Height = 24;
            this.dgvNhapThuoc.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvNhapThuoc.Size = new System.Drawing.Size(1023, 285);
            this.dgvNhapThuoc.TabIndex = 19;
            this.dgvNhapThuoc.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvNhapThuoc.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvNhapThuoc.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvNhapThuoc.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvNhapThuoc.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvNhapThuoc.ThemeStyle.BackColor = System.Drawing.Color.Gainsboro;
            this.dgvNhapThuoc.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvNhapThuoc.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgvNhapThuoc.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvNhapThuoc.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvNhapThuoc.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvNhapThuoc.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvNhapThuoc.ThemeStyle.HeaderStyle.Height = 24;
            this.dgvNhapThuoc.ThemeStyle.ReadOnly = false;
            this.dgvNhapThuoc.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvNhapThuoc.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvNhapThuoc.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvNhapThuoc.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvNhapThuoc.ThemeStyle.RowsStyle.Height = 24;
            this.dgvNhapThuoc.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvNhapThuoc.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvNhapThuoc.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvNhapThuoc_CellClick);
            this.dgvNhapThuoc.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvNhapThuoc_CellContentClick);
            // 
            // maThuocDataGridViewTextBoxColumn
            // 
            this.maThuocDataGridViewTextBoxColumn.DataPropertyName = "MaThuoc";
            this.maThuocDataGridViewTextBoxColumn.HeaderText = "Mã Thuốc";
            this.maThuocDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.maThuocDataGridViewTextBoxColumn.Name = "maThuocDataGridViewTextBoxColumn";
            // 
            // tenThuocDataGridViewTextBoxColumn
            // 
            this.tenThuocDataGridViewTextBoxColumn.DataPropertyName = "TenThuoc";
            this.tenThuocDataGridViewTextBoxColumn.HeaderText = "Tên Thuốc";
            this.tenThuocDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tenThuocDataGridViewTextBoxColumn.Name = "tenThuocDataGridViewTextBoxColumn";
            // 
            // maNhaCungCapDataGridViewTextBoxColumn
            // 
            this.maNhaCungCapDataGridViewTextBoxColumn.DataPropertyName = "MaNhaCungCap";
            this.maNhaCungCapDataGridViewTextBoxColumn.HeaderText = "Mã Nhà Cung Cấp";
            this.maNhaCungCapDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.maNhaCungCapDataGridViewTextBoxColumn.Name = "maNhaCungCapDataGridViewTextBoxColumn";
            // 
            // maLoaiThuocDataGridViewTextBoxColumn
            // 
            this.maLoaiThuocDataGridViewTextBoxColumn.DataPropertyName = "MaLoaiThuoc";
            this.maLoaiThuocDataGridViewTextBoxColumn.HeaderText = "Mã Loại Thuốc";
            this.maLoaiThuocDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.maLoaiThuocDataGridViewTextBoxColumn.Name = "maLoaiThuocDataGridViewTextBoxColumn";
            // 
            // ngaySXDataGridViewTextBoxColumn
            // 
            this.ngaySXDataGridViewTextBoxColumn.DataPropertyName = "NgaySX";
            this.ngaySXDataGridViewTextBoxColumn.HeaderText = "Ngày Sản Xuất";
            this.ngaySXDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ngaySXDataGridViewTextBoxColumn.Name = "ngaySXDataGridViewTextBoxColumn";
            // 
            // hSDDataGridViewTextBoxColumn
            // 
            this.hSDDataGridViewTextBoxColumn.DataPropertyName = "HSD";
            this.hSDDataGridViewTextBoxColumn.HeaderText = "HSD";
            this.hSDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.hSDDataGridViewTextBoxColumn.Name = "hSDDataGridViewTextBoxColumn";
            // 
            // soLuongDataGridViewTextBoxColumn
            // 
            this.soLuongDataGridViewTextBoxColumn.DataPropertyName = "SoLuong";
            this.soLuongDataGridViewTextBoxColumn.HeaderText = "Số Lượng";
            this.soLuongDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.soLuongDataGridViewTextBoxColumn.Name = "soLuongDataGridViewTextBoxColumn";
            // 
            // giaBanDataGridViewTextBoxColumn
            // 
            this.giaBanDataGridViewTextBoxColumn.DataPropertyName = "GiaBan";
            this.giaBanDataGridViewTextBoxColumn.HeaderText = "Giá Bán";
            this.giaBanDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.giaBanDataGridViewTextBoxColumn.Name = "giaBanDataGridViewTextBoxColumn";
            // 
            // thuocBindingSource2
            // 
            this.thuocBindingSource2.DataMember = "Thuoc";
            this.thuocBindingSource2.DataSource = this.quanLyNhaThuocDataSet3;
            // 
            // quanLyNhaThuocDataSet3
            // 
            this.quanLyNhaThuocDataSet3.DataSetName = "QuanLyNhaThuocDataSet3";
            this.quanLyNhaThuocDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // thuocBindingSource
            // 
            this.thuocBindingSource.DataMember = "Thuoc";
            this.thuocBindingSource.DataSource = this.quanLyNhaThuocDataSet1;
            // 
            // quanLyNhaThuocDataSet1
            // 
            this.quanLyNhaThuocDataSet1.DataSetName = "QuanLyNhaThuocDataSet1";
            this.quanLyNhaThuocDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(40, 229);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(177, 33);
            this.guna2HtmlLabel1.TabIndex = 20;
            this.guna2HtmlLabel1.Text = "Nhà Cung Cấp :";
            // 
            // txtNhaCungCap
            // 
            this.txtNhaCungCap.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNhaCungCap.DefaultText = "";
            this.txtNhaCungCap.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtNhaCungCap.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtNhaCungCap.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNhaCungCap.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNhaCungCap.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNhaCungCap.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtNhaCungCap.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNhaCungCap.Location = new System.Drawing.Point(234, 229);
            this.txtNhaCungCap.Name = "txtNhaCungCap";
            this.txtNhaCungCap.PasswordChar = '\0';
            this.txtNhaCungCap.PlaceholderText = "";
            this.txtNhaCungCap.SelectedText = "";
            this.txtNhaCungCap.Size = new System.Drawing.Size(281, 33);
            this.txtNhaCungCap.TabIndex = 21;
            // 
            // thuocTableAdapter
            // 
            this.thuocTableAdapter.ClearBeforeFill = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(40, 283);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(185, 33);
            this.label3.TabIndex = 22;
            this.label3.Text = "Mã Loại Thuốc";
            // 
            // txtMaLoaiThuoc
            // 
            this.txtMaLoaiThuoc.Location = new System.Drawing.Point(234, 283);
            this.txtMaLoaiThuoc.Name = "txtMaLoaiThuoc";
            this.txtMaLoaiThuoc.Size = new System.Drawing.Size(281, 30);
            this.txtMaLoaiThuoc.TabIndex = 23;
            // 
            // thuocBindingSource1
            // 
            this.thuocBindingSource1.DataMember = "Thuoc";
            this.thuocBindingSource1.DataSource = this.quanLyNhaThuocDataSet3;
            // 
            // thuocTableAdapter1
            // 
            this.thuocTableAdapter1.ClearBeforeFill = true;
            // 
            // btnXoa
            // 
            this.btnXoa.BorderRadius = 19;
            this.btnXoa.BorderThickness = 1;
            this.btnXoa.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnXoa.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnXoa.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnXoa.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnXoa.FillColor = System.Drawing.Color.CornflowerBlue;
            this.btnXoa.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.ForeColor = System.Drawing.Color.White;
            this.btnXoa.Image = ((System.Drawing.Image)(resources.GetObject("btnXoa.Image")));
            this.btnXoa.ImageSize = new System.Drawing.Size(30, 30);
            this.btnXoa.Location = new System.Drawing.Point(206, 329);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(149, 45);
            this.btnXoa.TabIndex = 18;
            this.btnXoa.Text = "Xoá";
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.BorderRadius = 19;
            this.btnSua.BorderThickness = 1;
            this.btnSua.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSua.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSua.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSua.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSua.FillColor = System.Drawing.Color.CornflowerBlue;
            this.btnSua.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.ForeColor = System.Drawing.Color.White;
            this.btnSua.Image = ((System.Drawing.Image)(resources.GetObject("btnSua.Image")));
            this.btnSua.ImageSize = new System.Drawing.Size(30, 30);
            this.btnSua.Location = new System.Drawing.Point(361, 329);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(149, 45);
            this.btnSua.TabIndex = 18;
            this.btnSua.Text = "Cập nhật";
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // UC_Nhapthuoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.txtMaLoaiThuoc);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNhaCungCap);
            this.Controls.Add(this.guna2HtmlLabel1);
            this.Controls.Add(this.dgvNhapThuoc);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.dtpHSD);
            this.Controls.Add(this.dtpNgaySanXuat);
            this.Controls.Add(this.txtGiaBan);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtSoLuong);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtTenThuoc);
            this.Controls.Add(this.lbtenthuoc);
            this.Controls.Add(this.txtMaThuoc);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "UC_Nhapthuoc";
            this.Size = new System.Drawing.Size(1105, 684);
            this.Load += new System.EventHandler(this.UC_Nhapthuoc_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhapThuoc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.thuocBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyNhaThuocDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.thuocBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyNhaThuocDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.thuocBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2TextBox txtMaThuoc;
        private Guna.UI2.WinForms.Guna2TextBox txtTenThuoc;
        private System.Windows.Forms.Label lbtenthuoc;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private Guna.UI2.WinForms.Guna2TextBox txtSoLuong;
        private System.Windows.Forms.Label label7;
        private Guna.UI2.WinForms.Guna2TextBox txtGiaBan;
        private System.Windows.Forms.Label label8;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpNgaySanXuat;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpHSD;
        private Guna.UI2.WinForms.Guna2Button btnThem;
        private Guna.UI2.WinForms.Guna2Button btnReset;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private System.IO.Ports.SerialPort serialPort1;
        private Guna.UI2.WinForms.Guna2DataGridView dgvNhapThuoc;
        private Guna.UI2.WinForms.Guna2TextBox txtNhaCungCap;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private System.Windows.Forms.BindingSource thuocBindingSource;
        private QuanLyNhaThuocDataSet1 quanLyNhaThuocDataSet1;
        private QuanLyNhaThuocDataSet1TableAdapters.ThuocTableAdapter thuocTableAdapter;
        private System.Windows.Forms.TextBox txtMaLoaiThuoc;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn maThuocDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenThuocDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maNhaCungCapDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maLoaiThuocDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngaySXDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hSDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn soLuongDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn giaBanDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource thuocBindingSource2;
        private QuanLyNhaThuocDataSet3 quanLyNhaThuocDataSet3;
        private System.Windows.Forms.BindingSource thuocBindingSource1;
        private QuanLyNhaThuocDataSet3TableAdapters.ThuocTableAdapter thuocTableAdapter1;
        private Guna.UI2.WinForms.Guna2Button btnXoa;
        private Guna.UI2.WinForms.Guna2Button btnSua;
    }
}
