namespace Phòng_thuốc.NhanvienUC
{
    partial class LoaiThuoc
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoaiThuoc));
            this.txtMaLoai = new System.Windows.Forms.TextBox();
            this.txtTenLoai = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvLoaiThuoc = new Guna.UI2.WinForms.Guna2DataGridView();
            this.btnThem = new Guna.UI2.WinForms.Guna2Button();
            this.btnSua = new Guna.UI2.WinForms.Guna2Button();
            this.btnXoa = new Guna.UI2.WinForms.Guna2Button();
            this.quanLyNhaThuocDataSet3 = new Phòng_thuốc.QuanLyNhaThuocDataSet3();
            this.loaiThuocBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.loaiThuocTableAdapter = new Phòng_thuốc.QuanLyNhaThuocDataSet3TableAdapters.LoaiThuocTableAdapter();
            this.maLoaiThuocDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenLoaiThuocDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLoaiThuoc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyNhaThuocDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loaiThuocBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // txtMaLoai
            // 
            this.txtMaLoai.Location = new System.Drawing.Point(139, 154);
            this.txtMaLoai.Multiline = true;
            this.txtMaLoai.Name = "txtMaLoai";
            this.txtMaLoai.Size = new System.Drawing.Size(335, 27);
            this.txtMaLoai.TabIndex = 0;
            // 
            // txtTenLoai
            // 
            this.txtTenLoai.Location = new System.Drawing.Point(619, 154);
            this.txtTenLoai.Multiline = true;
            this.txtTenLoai.Name = "txtTenLoai";
            this.txtTenLoai.Size = new System.Drawing.Size(313, 27);
            this.txtTenLoai.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(48, 154);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 27);
            this.label1.TabIndex = 2;
            this.label1.Text = "Mã loại";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(496, 154);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 27);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tên loại";
            // 
            // dgvLoaiThuoc
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgvLoaiThuoc.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvLoaiThuoc.AutoGenerateColumns = false;
            this.dgvLoaiThuoc.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvLoaiThuoc.BackgroundColor = System.Drawing.Color.White;
            this.dgvLoaiThuoc.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvLoaiThuoc.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvLoaiThuoc.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvLoaiThuoc.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvLoaiThuoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLoaiThuoc.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maLoaiThuocDataGridViewTextBoxColumn,
            this.tenLoaiThuocDataGridViewTextBoxColumn});
            this.dgvLoaiThuoc.DataSource = this.loaiThuocBindingSource;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvLoaiThuoc.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvLoaiThuoc.EnableHeadersVisualStyles = false;
            this.dgvLoaiThuoc.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvLoaiThuoc.Location = new System.Drawing.Point(53, 240);
            this.dgvLoaiThuoc.Name = "dgvLoaiThuoc";
            this.dgvLoaiThuoc.RowHeadersVisible = false;
            this.dgvLoaiThuoc.RowTemplate.Height = 24;
            this.dgvLoaiThuoc.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLoaiThuoc.Size = new System.Drawing.Size(879, 420);
            this.dgvLoaiThuoc.TabIndex = 4;
            this.dgvLoaiThuoc.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvLoaiThuoc.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvLoaiThuoc.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvLoaiThuoc.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvLoaiThuoc.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvLoaiThuoc.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvLoaiThuoc.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvLoaiThuoc.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgvLoaiThuoc.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvLoaiThuoc.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgvLoaiThuoc.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvLoaiThuoc.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLoaiThuoc.ThemeStyle.HeaderStyle.Height = 27;
            this.dgvLoaiThuoc.ThemeStyle.ReadOnly = false;
            this.dgvLoaiThuoc.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvLoaiThuoc.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvLoaiThuoc.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgvLoaiThuoc.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvLoaiThuoc.ThemeStyle.RowsStyle.Height = 24;
            this.dgvLoaiThuoc.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvLoaiThuoc.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvLoaiThuoc.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLoaiThuoc_CellClick);
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
            this.btnThem.Location = new System.Drawing.Point(53, 187);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(130, 47);
            this.btnThem.TabIndex = 18;
            this.btnThem.Text = "Thêm";
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
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
            this.btnSua.Location = new System.Drawing.Point(189, 187);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(130, 47);
            this.btnSua.TabIndex = 18;
            this.btnSua.Text = "Cập nhật";
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
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
            this.btnXoa.Location = new System.Drawing.Point(325, 187);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(130, 47);
            this.btnXoa.TabIndex = 18;
            this.btnXoa.Text = "Xoá";
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // quanLyNhaThuocDataSet3
            // 
            this.quanLyNhaThuocDataSet3.DataSetName = "QuanLyNhaThuocDataSet3";
            this.quanLyNhaThuocDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // loaiThuocBindingSource
            // 
            this.loaiThuocBindingSource.DataMember = "LoaiThuoc";
            this.loaiThuocBindingSource.DataSource = this.quanLyNhaThuocDataSet3;
            // 
            // loaiThuocTableAdapter
            // 
            this.loaiThuocTableAdapter.ClearBeforeFill = true;
            // 
            // maLoaiThuocDataGridViewTextBoxColumn
            // 
            this.maLoaiThuocDataGridViewTextBoxColumn.DataPropertyName = "MaLoaiThuoc";
            this.maLoaiThuocDataGridViewTextBoxColumn.HeaderText = "MaLoaiThuoc";
            this.maLoaiThuocDataGridViewTextBoxColumn.Name = "maLoaiThuocDataGridViewTextBoxColumn";
            // 
            // tenLoaiThuocDataGridViewTextBoxColumn
            // 
            this.tenLoaiThuocDataGridViewTextBoxColumn.DataPropertyName = "TenLoaiThuoc";
            this.tenLoaiThuocDataGridViewTextBoxColumn.HeaderText = "TenLoaiThuoc";
            this.tenLoaiThuocDataGridViewTextBoxColumn.Name = "tenLoaiThuocDataGridViewTextBoxColumn";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(317, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(327, 45);
            this.label3.TabIndex = 19;
            this.label3.Text = "Quản lý loại thuốc";
            // 
            // LoaiThuoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.dgvLoaiThuoc);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTenLoai);
            this.Controls.Add(this.txtMaLoai);
            this.Name = "LoaiThuoc";
            this.Size = new System.Drawing.Size(964, 686);
            this.Load += new System.EventHandler(this.LoaiThuoc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLoaiThuoc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyNhaThuocDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loaiThuocBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtMaLoai;
        private System.Windows.Forms.TextBox txtTenLoai;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2DataGridView dgvLoaiThuoc;
        private Guna.UI2.WinForms.Guna2Button btnThem;
        private System.Windows.Forms.DataGridViewTextBoxColumn maLoaiThuocDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenLoaiThuocDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource loaiThuocBindingSource;
        private QuanLyNhaThuocDataSet3 quanLyNhaThuocDataSet3;
        private Guna.UI2.WinForms.Guna2Button btnSua;
        private Guna.UI2.WinForms.Guna2Button btnXoa;
        private QuanLyNhaThuocDataSet3TableAdapters.LoaiThuocTableAdapter loaiThuocTableAdapter;
        private System.Windows.Forms.Label label3;
    }
}
