namespace Phòng_thuốc.NhanvienUC
{
    partial class UC_KhachHang
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_KhachHang));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMaKhachHang = new System.Windows.Forms.TextBox();
            this.txtTenKhachHang = new System.Windows.Forms.TextBox();
            this.quanLyNhaThuocDataSet2 = new Phòng_thuốc.QuanLyNhaThuocDataSet2();
            this.nhaCungCapBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nhaCungCapTableAdapter = new Phòng_thuốc.QuanLyNhaThuocDataSet2TableAdapters.NhaCungCapTableAdapter();
            this.khachHangBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.khachHangTableAdapter = new Phòng_thuốc.QuanLyNhaThuocDataSet2TableAdapters.KhachHangTableAdapter();
            this.dgvKhachHang = new Guna.UI2.WinForms.Guna2DataGridView();
            this.khachHangBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnXoa = new Guna.UI2.WinForms.Guna2Button();
            this.btnCapNhat = new Guna.UI2.WinForms.Guna2Button();
            this.btnThem = new Guna.UI2.WinForms.Guna2Button();
            this.maKhachHangDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenKhachHangDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soDienThoaiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label4 = new System.Windows.Forms.Label();
            this.btnReset = new Guna.UI2.WinForms.Guna2Button();
            this.txtTimKiemTheoTen = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnLoad = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyNhaThuocDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhaCungCapBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.khachHangBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKhachHang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.khachHangBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(36, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã khách hàng:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(36, 141);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(171, 27);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên khách hàng:";
            // 
            // txtMaKhachHang
            // 
            this.txtMaKhachHang.Location = new System.Drawing.Point(208, 105);
            this.txtMaKhachHang.Multiline = true;
            this.txtMaKhachHang.Name = "txtMaKhachHang";
            this.txtMaKhachHang.Size = new System.Drawing.Size(212, 27);
            this.txtMaKhachHang.TabIndex = 2;
            // 
            // txtTenKhachHang
            // 
            this.txtTenKhachHang.Location = new System.Drawing.Point(213, 141);
            this.txtTenKhachHang.Multiline = true;
            this.txtTenKhachHang.Name = "txtTenKhachHang";
            this.txtTenKhachHang.Size = new System.Drawing.Size(207, 27);
            this.txtTenKhachHang.TabIndex = 3;
            // 
            // quanLyNhaThuocDataSet2
            // 
            this.quanLyNhaThuocDataSet2.DataSetName = "QuanLyNhaThuocDataSet2";
            this.quanLyNhaThuocDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // nhaCungCapBindingSource
            // 
            this.nhaCungCapBindingSource.DataMember = "NhaCungCap";
            this.nhaCungCapBindingSource.DataSource = this.quanLyNhaThuocDataSet2;
            // 
            // nhaCungCapTableAdapter
            // 
            this.nhaCungCapTableAdapter.ClearBeforeFill = true;
            // 
            // khachHangBindingSource
            // 
            this.khachHangBindingSource.DataMember = "KhachHang";
            this.khachHangBindingSource.DataSource = this.quanLyNhaThuocDataSet2;
            // 
            // khachHangTableAdapter
            // 
            this.khachHangTableAdapter.ClearBeforeFill = true;
            // 
            // dgvKhachHang
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgvKhachHang.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvKhachHang.AutoGenerateColumns = false;
            this.dgvKhachHang.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvKhachHang.BackgroundColor = System.Drawing.Color.White;
            this.dgvKhachHang.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvKhachHang.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvKhachHang.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvKhachHang.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvKhachHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKhachHang.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maKhachHangDataGridViewTextBoxColumn,
            this.tenKhachHangDataGridViewTextBoxColumn,
            this.soDienThoaiDataGridViewTextBoxColumn});
            this.dgvKhachHang.DataSource = this.khachHangBindingSource1;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvKhachHang.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvKhachHang.EnableHeadersVisualStyles = false;
            this.dgvKhachHang.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvKhachHang.Location = new System.Drawing.Point(39, 241);
            this.dgvKhachHang.Name = "dgvKhachHang";
            this.dgvKhachHang.RowHeadersVisible = false;
            this.dgvKhachHang.RowTemplate.Height = 24;
            this.dgvKhachHang.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvKhachHang.Size = new System.Drawing.Size(791, 279);
            this.dgvKhachHang.TabIndex = 4;
            this.dgvKhachHang.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvKhachHang.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvKhachHang.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvKhachHang.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvKhachHang.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvKhachHang.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvKhachHang.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvKhachHang.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgvKhachHang.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvKhachHang.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgvKhachHang.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvKhachHang.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKhachHang.ThemeStyle.HeaderStyle.Height = 27;
            this.dgvKhachHang.ThemeStyle.ReadOnly = false;
            this.dgvKhachHang.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvKhachHang.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvKhachHang.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgvKhachHang.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvKhachHang.ThemeStyle.RowsStyle.Height = 24;
            this.dgvKhachHang.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvKhachHang.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvKhachHang.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvKhachHang_CellClick);
            // 
            // khachHangBindingSource1
            // 
            this.khachHangBindingSource1.DataMember = "KhachHang";
            this.khachHangBindingSource1.DataSource = this.quanLyNhaThuocDataSet2;
            // 
            // txtSDT
            // 
            this.txtSDT.Location = new System.Drawing.Point(585, 105);
            this.txtSDT.Multiline = true;
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(245, 27);
            this.txtSDT.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(436, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(143, 27);
            this.label3.TabIndex = 6;
            this.label3.Text = "Số điện thoại:";
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
            this.btnXoa.Location = new System.Drawing.Point(373, 190);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(149, 45);
            this.btnXoa.TabIndex = 22;
            this.btnXoa.Text = "Xoá";
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.BorderRadius = 19;
            this.btnCapNhat.BorderThickness = 1;
            this.btnCapNhat.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCapNhat.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCapNhat.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCapNhat.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCapNhat.FillColor = System.Drawing.Color.CornflowerBlue;
            this.btnCapNhat.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCapNhat.ForeColor = System.Drawing.Color.White;
            this.btnCapNhat.Image = ((System.Drawing.Image)(resources.GetObject("btnCapNhat.Image")));
            this.btnCapNhat.ImageSize = new System.Drawing.Size(30, 30);
            this.btnCapNhat.Location = new System.Drawing.Point(206, 190);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Size = new System.Drawing.Size(161, 45);
            this.btnCapNhat.TabIndex = 20;
            this.btnCapNhat.Text = "Cập nhật";
            this.btnCapNhat.Click += new System.EventHandler(this.btnCapNhat_Click);
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
            this.btnThem.Location = new System.Drawing.Point(39, 190);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(161, 45);
            this.btnThem.TabIndex = 21;
            this.btnThem.Text = "Thêm";
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // maKhachHangDataGridViewTextBoxColumn
            // 
            this.maKhachHangDataGridViewTextBoxColumn.DataPropertyName = "MaKhachHang";
            this.maKhachHangDataGridViewTextBoxColumn.HeaderText = "Mã khách hàng";
            this.maKhachHangDataGridViewTextBoxColumn.Name = "maKhachHangDataGridViewTextBoxColumn";
            this.maKhachHangDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tenKhachHangDataGridViewTextBoxColumn
            // 
            this.tenKhachHangDataGridViewTextBoxColumn.DataPropertyName = "TenKhachHang";
            this.tenKhachHangDataGridViewTextBoxColumn.HeaderText = "Tên khách hàng";
            this.tenKhachHangDataGridViewTextBoxColumn.Name = "tenKhachHangDataGridViewTextBoxColumn";
            // 
            // soDienThoaiDataGridViewTextBoxColumn
            // 
            this.soDienThoaiDataGridViewTextBoxColumn.DataPropertyName = "SoDienThoai";
            this.soDienThoaiDataGridViewTextBoxColumn.HeaderText = "Số điện thoại";
            this.soDienThoaiDataGridViewTextBoxColumn.Name = "soDienThoaiDataGridViewTextBoxColumn";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(259, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(433, 55);
            this.label4.TabIndex = 23;
            this.label4.Text = "Thông tin khách hàng";
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
            this.btnReset.Location = new System.Drawing.Point(681, 190);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(149, 45);
            this.btnReset.TabIndex = 22;
            this.btnReset.Text = "Reset";
            this.btnReset.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // txtTimKiemTheoTen
            // 
            this.txtTimKiemTheoTen.Location = new System.Drawing.Point(635, 141);
            this.txtTimKiemTheoTen.Multiline = true;
            this.txtTimKiemTheoTen.Name = "txtTimKiemTheoTen";
            this.txtTimKiemTheoTen.Size = new System.Drawing.Size(195, 27);
            this.txtTimKiemTheoTen.TabIndex = 24;
            this.txtTimKiemTheoTen.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(436, 141);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(193, 27);
            this.label5.TabIndex = 25;
            this.label5.Text = "Tìm kiếm theo tên:";
            // 
            // btnLoad
            // 
            this.btnLoad.BorderRadius = 19;
            this.btnLoad.BorderThickness = 1;
            this.btnLoad.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnLoad.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnLoad.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnLoad.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnLoad.FillColor = System.Drawing.Color.CornflowerBlue;
            this.btnLoad.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoad.ForeColor = System.Drawing.Color.White;
            this.btnLoad.Image = ((System.Drawing.Image)(resources.GetObject("btnLoad.Image")));
            this.btnLoad.ImageSize = new System.Drawing.Size(30, 30);
            this.btnLoad.Location = new System.Drawing.Point(528, 190);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(149, 45);
            this.btnLoad.TabIndex = 22;
            this.btnLoad.Text = "Load";
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // UC_KhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtTimKiemTheoTen);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnCapNhat);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtSDT);
            this.Controls.Add(this.dgvKhachHang);
            this.Controls.Add(this.txtTenKhachHang);
            this.Controls.Add(this.txtMaKhachHang);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "UC_KhachHang";
            this.Size = new System.Drawing.Size(955, 561);
            this.Load += new System.EventHandler(this.UC_KhachHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.quanLyNhaThuocDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhaCungCapBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.khachHangBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKhachHang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.khachHangBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMaKhachHang;
        private System.Windows.Forms.TextBox txtTenKhachHang;
        private QuanLyNhaThuocDataSet2 quanLyNhaThuocDataSet2;
        private System.Windows.Forms.BindingSource nhaCungCapBindingSource;
        private QuanLyNhaThuocDataSet2TableAdapters.NhaCungCapTableAdapter nhaCungCapTableAdapter;
        private System.Windows.Forms.BindingSource khachHangBindingSource;
        private QuanLyNhaThuocDataSet2TableAdapters.KhachHangTableAdapter khachHangTableAdapter;
        private Guna.UI2.WinForms.Guna2DataGridView dgvKhachHang;
        private System.Windows.Forms.BindingSource khachHangBindingSource1;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2Button btnXoa;
        private Guna.UI2.WinForms.Guna2Button btnCapNhat;
        private Guna.UI2.WinForms.Guna2Button btnThem;
        private System.Windows.Forms.DataGridViewTextBoxColumn maKhachHangDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenKhachHangDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn soDienThoaiDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2Button btnReset;
        private System.Windows.Forms.TextBox txtTimKiemTheoTen;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2Button btnLoad;
    }
}
