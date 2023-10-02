namespace Phòng_thuốc.NhanvienUC
{
    partial class UC_HoaDon
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_HoaDon));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtMaHoadon = new System.Windows.Forms.TextBox();
            this.txtMaKhachHang = new System.Windows.Forms.TextBox();
            this.txtNgayBan = new System.Windows.Forms.TextBox();
            this.txtTenKhachHang = new System.Windows.Forms.TextBox();
            this.dgvHoaDon = new Guna.UI2.WinForms.Guna2DataGridView();
            this.maHoaDonDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maKhachHangDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenKhachHangDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngayBanDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tongGiaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hoaDonBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.quanLyNhaThuocDataSet3 = new Phòng_thuốc.QuanLyNhaThuocDataSet3();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtTongGia = new System.Windows.Forms.TextBox();
            this.btnSua = new Guna.UI2.WinForms.Guna2Button();
            this.btnXoa = new Guna.UI2.WinForms.Guna2Button();
            this.hoaDonTableAdapter = new Phòng_thuốc.QuanLyNhaThuocDataSet3TableAdapters.HoaDonTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHoaDon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hoaDonBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyNhaThuocDataSet3)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(377, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(299, 45);
            this.label1.TabIndex = 0;
            this.label1.Text = "Quản lý hoá đơn";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(38, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 26);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mã hoá đơn :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(38, 157);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(166, 26);
            this.label3.TabIndex = 2;
            this.label3.Text = "Mã khách hàng :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(543, 111);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 26);
            this.label4.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(511, 147);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(173, 26);
            this.label5.TabIndex = 4;
            this.label5.Text = "Tên khách hàng :";
            // 
            // txtMaHoadon
            // 
            this.txtMaHoadon.Location = new System.Drawing.Point(184, 114);
            this.txtMaHoadon.Multiline = true;
            this.txtMaHoadon.Name = "txtMaHoadon";
            this.txtMaHoadon.Size = new System.Drawing.Size(248, 27);
            this.txtMaHoadon.TabIndex = 5;
            // 
            // txtMaKhachHang
            // 
            this.txtMaKhachHang.Location = new System.Drawing.Point(216, 157);
            this.txtMaKhachHang.Multiline = true;
            this.txtMaKhachHang.Name = "txtMaKhachHang";
            this.txtMaKhachHang.Size = new System.Drawing.Size(216, 27);
            this.txtMaKhachHang.TabIndex = 6;
            // 
            // txtNgayBan
            // 
            this.txtNgayBan.Location = new System.Drawing.Point(636, 111);
            this.txtNgayBan.Multiline = true;
            this.txtNgayBan.Name = "txtNgayBan";
            this.txtNgayBan.Size = new System.Drawing.Size(364, 27);
            this.txtNgayBan.TabIndex = 7;
            // 
            // txtTenKhachHang
            // 
            this.txtTenKhachHang.Location = new System.Drawing.Point(694, 147);
            this.txtTenKhachHang.Multiline = true;
            this.txtTenKhachHang.Name = "txtTenKhachHang";
            this.txtTenKhachHang.Size = new System.Drawing.Size(306, 27);
            this.txtTenKhachHang.TabIndex = 8;
            // 
            // dgvHoaDon
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgvHoaDon.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvHoaDon.AutoGenerateColumns = false;
            this.dgvHoaDon.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvHoaDon.BackgroundColor = System.Drawing.Color.White;
            this.dgvHoaDon.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvHoaDon.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvHoaDon.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvHoaDon.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvHoaDon.ColumnHeadersHeight = 27;
            this.dgvHoaDon.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maHoaDonDataGridViewTextBoxColumn,
            this.maKhachHangDataGridViewTextBoxColumn,
            this.tenKhachHangDataGridViewTextBoxColumn,
            this.ngayBanDataGridViewTextBoxColumn,
            this.tongGiaDataGridViewTextBoxColumn});
            this.dgvHoaDon.DataSource = this.hoaDonBindingSource;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvHoaDon.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvHoaDon.EnableHeadersVisualStyles = false;
            this.dgvHoaDon.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvHoaDon.Location = new System.Drawing.Point(41, 247);
            this.dgvHoaDon.Name = "dgvHoaDon";
            this.dgvHoaDon.RowHeadersVisible = false;
            this.dgvHoaDon.RowHeadersWidth = 51;
            this.dgvHoaDon.RowTemplate.Height = 24;
            this.dgvHoaDon.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvHoaDon.Size = new System.Drawing.Size(959, 369);
            this.dgvHoaDon.TabIndex = 9;
            this.dgvHoaDon.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvHoaDon.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvHoaDon.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvHoaDon.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvHoaDon.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvHoaDon.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvHoaDon.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvHoaDon.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgvHoaDon.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvHoaDon.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgvHoaDon.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvHoaDon.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvHoaDon.ThemeStyle.HeaderStyle.Height = 27;
            this.dgvHoaDon.ThemeStyle.ReadOnly = false;
            this.dgvHoaDon.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvHoaDon.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvHoaDon.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgvHoaDon.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvHoaDon.ThemeStyle.RowsStyle.Height = 24;
            this.dgvHoaDon.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvHoaDon.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvHoaDon.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvHoaDon_CellClick);
            // 
            // maHoaDonDataGridViewTextBoxColumn
            // 
            this.maHoaDonDataGridViewTextBoxColumn.DataPropertyName = "MaHoaDon";
            this.maHoaDonDataGridViewTextBoxColumn.HeaderText = "MaHoaDon";
            this.maHoaDonDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.maHoaDonDataGridViewTextBoxColumn.Name = "maHoaDonDataGridViewTextBoxColumn";
            // 
            // maKhachHangDataGridViewTextBoxColumn
            // 
            this.maKhachHangDataGridViewTextBoxColumn.DataPropertyName = "MaKhachHang";
            this.maKhachHangDataGridViewTextBoxColumn.HeaderText = "MaKhachHang";
            this.maKhachHangDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.maKhachHangDataGridViewTextBoxColumn.Name = "maKhachHangDataGridViewTextBoxColumn";
            // 
            // tenKhachHangDataGridViewTextBoxColumn
            // 
            this.tenKhachHangDataGridViewTextBoxColumn.DataPropertyName = "TenKhachHang";
            this.tenKhachHangDataGridViewTextBoxColumn.HeaderText = "TenKhachHang";
            this.tenKhachHangDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tenKhachHangDataGridViewTextBoxColumn.Name = "tenKhachHangDataGridViewTextBoxColumn";
            // 
            // ngayBanDataGridViewTextBoxColumn
            // 
            this.ngayBanDataGridViewTextBoxColumn.DataPropertyName = "NgayBan";
            this.ngayBanDataGridViewTextBoxColumn.HeaderText = "NgayBan";
            this.ngayBanDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ngayBanDataGridViewTextBoxColumn.Name = "ngayBanDataGridViewTextBoxColumn";
            // 
            // tongGiaDataGridViewTextBoxColumn
            // 
            this.tongGiaDataGridViewTextBoxColumn.DataPropertyName = "TongGia";
            this.tongGiaDataGridViewTextBoxColumn.HeaderText = "TongGia";
            this.tongGiaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tongGiaDataGridViewTextBoxColumn.Name = "tongGiaDataGridViewTextBoxColumn";
            // 
            // hoaDonBindingSource
            // 
            this.hoaDonBindingSource.DataMember = "HoaDon";
            this.hoaDonBindingSource.DataSource = this.quanLyNhaThuocDataSet3;
            // 
            // quanLyNhaThuocDataSet3
            // 
            this.quanLyNhaThuocDataSet3.DataSetName = "QuanLyNhaThuocDataSet3";
            this.quanLyNhaThuocDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(514, 111);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(112, 26);
            this.label6.TabIndex = 10;
            this.label6.Text = "Ngày bán :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(514, 179);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(106, 26);
            this.label7.TabIndex = 11;
            this.label7.Text = "Tổng giá :";
            // 
            // txtTongGia
            // 
            this.txtTongGia.Location = new System.Drawing.Point(627, 179);
            this.txtTongGia.Multiline = true;
            this.txtTongGia.Name = "txtTongGia";
            this.txtTongGia.Size = new System.Drawing.Size(373, 27);
            this.txtTongGia.TabIndex = 12;
            // 
            // btnSua
            // 
            this.btnSua.BorderRadius = 19;
            this.btnSua.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSua.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSua.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSua.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSua.FillColor = System.Drawing.Color.CornflowerBlue;
            this.btnSua.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.ForeColor = System.Drawing.Color.White;
            this.btnSua.HoverState.BorderColor = System.Drawing.Color.White;
            this.btnSua.Image = ((System.Drawing.Image)(resources.GetObject("btnSua.Image")));
            this.btnSua.ImageSize = new System.Drawing.Size(30, 30);
            this.btnSua.Location = new System.Drawing.Point(39, 196);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(154, 45);
            this.btnSua.TabIndex = 19;
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
            this.btnXoa.FillColor = System.Drawing.Color.CornflowerBlue;
            this.btnXoa.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.ForeColor = System.Drawing.Color.White;
            this.btnXoa.HoverState.BorderColor = System.Drawing.Color.White;
            this.btnXoa.Image = ((System.Drawing.Image)(resources.GetObject("btnXoa.Image")));
            this.btnXoa.ImageSize = new System.Drawing.Size(30, 30);
            this.btnXoa.Location = new System.Drawing.Point(199, 196);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(154, 45);
            this.btnXoa.TabIndex = 20;
            this.btnXoa.Text = "Xoá";
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // hoaDonTableAdapter
            // 
            this.hoaDonTableAdapter.ClearBeforeFill = true;
            // 
            // UC_HoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.txtTongGia);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dgvHoaDon);
            this.Controls.Add(this.txtTenKhachHang);
            this.Controls.Add(this.txtNgayBan);
            this.Controls.Add(this.txtMaKhachHang);
            this.Controls.Add(this.txtMaHoadon);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "UC_HoaDon";
            this.Size = new System.Drawing.Size(1040, 637);
            this.Load += new System.EventHandler(this.UC_HoaDon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHoaDon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hoaDonBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyNhaThuocDataSet3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtMaHoadon;
        private System.Windows.Forms.TextBox txtMaKhachHang;
        private System.Windows.Forms.TextBox txtNgayBan;
        private System.Windows.Forms.TextBox txtTenKhachHang;
        private Guna.UI2.WinForms.Guna2DataGridView dgvHoaDon;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtTongGia;
        private Guna.UI2.WinForms.Guna2Button btnSua;
        private Guna.UI2.WinForms.Guna2Button btnXoa;
        private System.Windows.Forms.BindingSource hoaDonBindingSource;
        private QuanLyNhaThuocDataSet3 quanLyNhaThuocDataSet3;
        private QuanLyNhaThuocDataSet3TableAdapters.HoaDonTableAdapter hoaDonTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn maHoaDonDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maKhachHangDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenKhachHangDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngayBanDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tongGiaDataGridViewTextBoxColumn;
    }
}
