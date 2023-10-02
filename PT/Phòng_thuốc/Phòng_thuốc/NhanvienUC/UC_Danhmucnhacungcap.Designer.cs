namespace Phòng_thuốc.NhanvienUC
{
    partial class UC_Danhmucnhacungcap
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_Danhmucnhacungcap));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtManhacungcap = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtdiachi = new Guna.UI2.WinForms.Guna2TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtsdt = new Guna.UI2.WinForms.Guna2TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnThem = new Guna.UI2.WinForms.Guna2Button();
            this.btnReset = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.txtTenhacungcap = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnCapNhat = new Guna.UI2.WinForms.Guna2Button();
            this.quanLyNhaThuocDataSet1 = new Phòng_thuốc.QuanLyNhaThuocDataSet1();
            this.thuocBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.thuocTableAdapter = new Phòng_thuốc.QuanLyNhaThuocDataSet1TableAdapters.ThuocTableAdapter();
            this.nhaCungCapBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nhaCungCapTableAdapter = new Phòng_thuốc.QuanLyNhaThuocDataSet1TableAdapters.NhaCungCapTableAdapter();
            this.dgvThongTinNhaCungCap = new Guna.UI2.WinForms.Guna2DataGridView();
            this.maNhaCungCapDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenNhaCungCapDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diaChiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soDienThoaiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nhaCungCapBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.btnXoa = new Guna.UI2.WinForms.Guna2Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyNhaThuocDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.thuocBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhaCungCapBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThongTinNhaCungCap)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhaCungCapBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1105, 130);
            this.panel1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Blue;
            this.panel2.Location = new System.Drawing.Point(564, 145);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(6, 550);
            this.panel2.TabIndex = 21;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(350, 40);
            this.label1.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(412, 43);
            this.label1.TabIndex = 2;
            this.label1.Text = "Danh mục nhà cung cấp";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(77, 155);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(219, 33);
            this.label3.TabIndex = 6;
            this.label3.Text = "Mã nhà cung cấp :";
            // 
            // txtManhacungcap
            // 
            this.txtManhacungcap.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtManhacungcap.DefaultText = "";
            this.txtManhacungcap.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtManhacungcap.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtManhacungcap.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtManhacungcap.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtManhacungcap.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtManhacungcap.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtManhacungcap.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtManhacungcap.Location = new System.Drawing.Point(303, 155);
            this.txtManhacungcap.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtManhacungcap.Name = "txtManhacungcap";
            this.txtManhacungcap.PasswordChar = '\0';
            this.txtManhacungcap.PlaceholderText = "";
            this.txtManhacungcap.SelectedText = "";
            this.txtManhacungcap.Size = new System.Drawing.Size(285, 33);
            this.txtManhacungcap.TabIndex = 8;
            // 
            // txtdiachi
            // 
            this.txtdiachi.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtdiachi.DefaultText = "";
            this.txtdiachi.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtdiachi.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtdiachi.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtdiachi.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtdiachi.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtdiachi.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdiachi.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtdiachi.Location = new System.Drawing.Point(727, 155);
            this.txtdiachi.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtdiachi.Name = "txtdiachi";
            this.txtdiachi.PasswordChar = '\0';
            this.txtdiachi.PlaceholderText = "";
            this.txtdiachi.SelectedText = "";
            this.txtdiachi.Size = new System.Drawing.Size(332, 33);
            this.txtdiachi.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(616, 155);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 33);
            this.label4.TabIndex = 11;
            this.label4.Text = "Địa chỉ:";
            // 
            // txtsdt
            // 
            this.txtsdt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtsdt.DefaultText = "";
            this.txtsdt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtsdt.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtsdt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtsdt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtsdt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtsdt.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsdt.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtsdt.Location = new System.Drawing.Point(801, 219);
            this.txtsdt.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtsdt.Name = "txtsdt";
            this.txtsdt.PasswordChar = '\0';
            this.txtsdt.PlaceholderText = "";
            this.txtsdt.SelectedText = "";
            this.txtsdt.Size = new System.Drawing.Size(258, 33);
            this.txtsdt.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(616, 219);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(178, 33);
            this.label5.TabIndex = 13;
            this.label5.Text = "Số điện thoại :";
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
            this.btnThem.Location = new System.Drawing.Point(84, 276);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(161, 45);
            this.btnThem.TabIndex = 18;
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
            this.btnReset.Location = new System.Drawing.Point(576, 276);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(149, 45);
            this.btnReset.TabIndex = 19;
            this.btnReset.Text = "Reset";
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.TargetControl = this;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(77, 219);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(217, 33);
            this.label2.TabIndex = 9;
            this.label2.Text = "Tên nhà cung cấp:";
            // 
            // txtTenhacungcap
            // 
            this.txtTenhacungcap.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTenhacungcap.DefaultText = "";
            this.txtTenhacungcap.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTenhacungcap.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTenhacungcap.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTenhacungcap.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTenhacungcap.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTenhacungcap.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenhacungcap.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTenhacungcap.Location = new System.Drawing.Point(301, 219);
            this.txtTenhacungcap.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtTenhacungcap.Name = "txtTenhacungcap";
            this.txtTenhacungcap.PasswordChar = '\0';
            this.txtTenhacungcap.PlaceholderText = "";
            this.txtTenhacungcap.SelectedText = "";
            this.txtTenhacungcap.Size = new System.Drawing.Size(287, 33);
            this.txtTenhacungcap.TabIndex = 10;
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
            this.btnCapNhat.Location = new System.Drawing.Point(251, 276);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Size = new System.Drawing.Size(161, 45);
            this.btnCapNhat.TabIndex = 18;
            this.btnCapNhat.Text = "Cập nhật";
            this.btnCapNhat.Click += new System.EventHandler(this.btnCapNhat_Click);
            // 
            // quanLyNhaThuocDataSet1
            // 
            this.quanLyNhaThuocDataSet1.DataSetName = "QuanLyNhaThuocDataSet1";
            this.quanLyNhaThuocDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // thuocBindingSource
            // 
            this.thuocBindingSource.DataMember = "Thuoc";
            this.thuocBindingSource.DataSource = this.quanLyNhaThuocDataSet1;
            // 
            // thuocTableAdapter
            // 
            this.thuocTableAdapter.ClearBeforeFill = true;
            // 
            // nhaCungCapBindingSource
            // 
            this.nhaCungCapBindingSource.DataMember = "NhaCungCap";
            this.nhaCungCapBindingSource.DataSource = this.quanLyNhaThuocDataSet1;
            // 
            // nhaCungCapTableAdapter
            // 
            this.nhaCungCapTableAdapter.ClearBeforeFill = true;
            // 
            // dgvThongTinNhaCungCap
            // 
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.dgvThongTinNhaCungCap.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvThongTinNhaCungCap.AutoGenerateColumns = false;
            this.dgvThongTinNhaCungCap.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvThongTinNhaCungCap.BackgroundColor = System.Drawing.Color.DimGray;
            this.dgvThongTinNhaCungCap.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvThongTinNhaCungCap.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvThongTinNhaCungCap.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvThongTinNhaCungCap.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvThongTinNhaCungCap.ColumnHeadersHeight = 24;
            this.dgvThongTinNhaCungCap.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maNhaCungCapDataGridViewTextBoxColumn,
            this.tenNhaCungCapDataGridViewTextBoxColumn,
            this.diaChiDataGridViewTextBoxColumn,
            this.soDienThoaiDataGridViewTextBoxColumn});
            this.dgvThongTinNhaCungCap.DataSource = this.nhaCungCapBindingSource1;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvThongTinNhaCungCap.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvThongTinNhaCungCap.EnableHeadersVisualStyles = false;
            this.dgvThongTinNhaCungCap.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvThongTinNhaCungCap.Location = new System.Drawing.Point(84, 328);
            this.dgvThongTinNhaCungCap.Name = "dgvThongTinNhaCungCap";
            this.dgvThongTinNhaCungCap.RowHeadersVisible = false;
            this.dgvThongTinNhaCungCap.RowTemplate.Height = 24;
            this.dgvThongTinNhaCungCap.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvThongTinNhaCungCap.Size = new System.Drawing.Size(975, 367);
            this.dgvThongTinNhaCungCap.TabIndex = 20;
            this.dgvThongTinNhaCungCap.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvThongTinNhaCungCap.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvThongTinNhaCungCap.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvThongTinNhaCungCap.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvThongTinNhaCungCap.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvThongTinNhaCungCap.ThemeStyle.BackColor = System.Drawing.Color.DimGray;
            this.dgvThongTinNhaCungCap.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvThongTinNhaCungCap.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgvThongTinNhaCungCap.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvThongTinNhaCungCap.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvThongTinNhaCungCap.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvThongTinNhaCungCap.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvThongTinNhaCungCap.ThemeStyle.HeaderStyle.Height = 24;
            this.dgvThongTinNhaCungCap.ThemeStyle.ReadOnly = false;
            this.dgvThongTinNhaCungCap.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvThongTinNhaCungCap.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvThongTinNhaCungCap.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvThongTinNhaCungCap.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvThongTinNhaCungCap.ThemeStyle.RowsStyle.Height = 24;
            this.dgvThongTinNhaCungCap.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvThongTinNhaCungCap.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvThongTinNhaCungCap.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvThongTinNhaCungCap_CellClick);
            // 
            // maNhaCungCapDataGridViewTextBoxColumn
            // 
            this.maNhaCungCapDataGridViewTextBoxColumn.DataPropertyName = "MaNhaCungCap";
            this.maNhaCungCapDataGridViewTextBoxColumn.HeaderText = "Mã nhà cung cấp";
            this.maNhaCungCapDataGridViewTextBoxColumn.Name = "maNhaCungCapDataGridViewTextBoxColumn";
            // 
            // tenNhaCungCapDataGridViewTextBoxColumn
            // 
            this.tenNhaCungCapDataGridViewTextBoxColumn.DataPropertyName = "TenNhaCungCap";
            this.tenNhaCungCapDataGridViewTextBoxColumn.HeaderText = "Tên nhà cung cấp";
            this.tenNhaCungCapDataGridViewTextBoxColumn.Name = "tenNhaCungCapDataGridViewTextBoxColumn";
            // 
            // diaChiDataGridViewTextBoxColumn
            // 
            this.diaChiDataGridViewTextBoxColumn.DataPropertyName = "DiaChi";
            this.diaChiDataGridViewTextBoxColumn.HeaderText = "Địa chỉ";
            this.diaChiDataGridViewTextBoxColumn.Name = "diaChiDataGridViewTextBoxColumn";
            // 
            // soDienThoaiDataGridViewTextBoxColumn
            // 
            this.soDienThoaiDataGridViewTextBoxColumn.DataPropertyName = "SoDienThoai";
            this.soDienThoaiDataGridViewTextBoxColumn.HeaderText = "Số điện thoại";
            this.soDienThoaiDataGridViewTextBoxColumn.Name = "soDienThoaiDataGridViewTextBoxColumn";
            // 
            // nhaCungCapBindingSource1
            // 
            this.nhaCungCapBindingSource1.DataMember = "NhaCungCap";
            this.nhaCungCapBindingSource1.DataSource = this.quanLyNhaThuocDataSet1;
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
            this.btnXoa.Location = new System.Drawing.Point(418, 277);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(149, 45);
            this.btnXoa.TabIndex = 19;
            this.btnXoa.Text = "Xoá";
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // UC_Themnhacungcap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.dgvThongTinNhaCungCap);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnCapNhat);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.txtsdt);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtdiachi);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtTenhacungcap);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtManhacungcap);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "UC_Themnhacungcap";
            this.Size = new System.Drawing.Size(1105, 726);
            this.Load += new System.EventHandler(this.UC_Themnhacungcap_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyNhaThuocDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.thuocBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhaCungCapBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThongTinNhaCungCap)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhaCungCapBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2TextBox txtManhacungcap;
        private Guna.UI2.WinForms.Guna2TextBox txtdiachi;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2TextBox txtsdt;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2Button btnThem;
        private Guna.UI2.WinForms.Guna2Button btnReset;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2TextBox txtTenhacungcap;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2Button btnCapNhat;
        private System.Windows.Forms.BindingSource nhaCungCapBindingSource;
        private QuanLyNhaThuocDataSet1 quanLyNhaThuocDataSet1;
        private System.Windows.Forms.BindingSource thuocBindingSource;
        private QuanLyNhaThuocDataSet1TableAdapters.ThuocTableAdapter thuocTableAdapter;
        private QuanLyNhaThuocDataSet1TableAdapters.NhaCungCapTableAdapter nhaCungCapTableAdapter;
        private Guna.UI2.WinForms.Guna2DataGridView dgvThongTinNhaCungCap;
        private System.Windows.Forms.DataGridViewTextBoxColumn maNhaCungCapDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenNhaCungCapDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn diaChiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn soDienThoaiDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource nhaCungCapBindingSource1;
        private Guna.UI2.WinForms.Guna2Button btnXoa;
    }
}
