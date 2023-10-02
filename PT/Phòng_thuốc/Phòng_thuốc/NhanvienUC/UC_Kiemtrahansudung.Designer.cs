namespace Phòng_thuốc
{
    partial class UC_Kiemtrahansudung
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.labelN = new System.Windows.Forms.Label();
            this.cbxKiemTraHSD = new Guna.UI2.WinForms.Guna2ComboBox();
            this.dgvKiemTraHSD = new Guna.UI2.WinForms.Guna2DataGridView();
            this.maThuocDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenThuocDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maNhaCungCapDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngaySXDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hSDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soLuongDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.giaBanDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.thuocBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.quanLyNhaThuocDataSet1 = new Phòng_thuốc.QuanLyNhaThuocDataSet1();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.nguoiDungBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nguoiDungTableAdapter = new Phòng_thuốc.QuanLyNhaThuocDataSet1TableAdapters.NguoiDungTableAdapter();
            this.thuocTableAdapter = new Phòng_thuốc.QuanLyNhaThuocDataSet1TableAdapters.ThuocTableAdapter();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKiemTraHSD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.thuocBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyNhaThuocDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nguoiDungBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1134, 100);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(394, 26);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(378, 43);
            this.label1.TabIndex = 2;
            this.label1.Text = "Kiểm tra hạn sử dụng";
            // 
            // labelN
            // 
            this.labelN.AutoSize = true;
            this.labelN.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelN.Location = new System.Drawing.Point(164, 114);
            this.labelN.Name = "labelN";
            this.labelN.Size = new System.Drawing.Size(125, 33);
            this.labelN.TabIndex = 2;
            this.labelN.Text = "Kiểm tra :";
            // 
            // cbxKiemTraHSD
            // 
            this.cbxKiemTraHSD.BackColor = System.Drawing.Color.Transparent;
            this.cbxKiemTraHSD.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbxKiemTraHSD.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxKiemTraHSD.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbxKiemTraHSD.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbxKiemTraHSD.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.cbxKiemTraHSD.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbxKiemTraHSD.ItemHeight = 30;
            this.cbxKiemTraHSD.Items.AddRange(new object[] {
            "Thuốc còn hạn sử dụng",
            "Thuốc hết hạn sử dụng",
            "Xem tất cả thuốc"});
            this.cbxKiemTraHSD.Location = new System.Drawing.Point(321, 114);
            this.cbxKiemTraHSD.Name = "cbxKiemTraHSD";
            this.cbxKiemTraHSD.Size = new System.Drawing.Size(631, 36);
            this.cbxKiemTraHSD.TabIndex = 3;
            this.cbxKiemTraHSD.SelectedIndexChanged += new System.EventHandler(this.cbxKiemTraHSD_SelectedIndexChanged);
            // 
            // dgvKiemTraHSD
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgvKiemTraHSD.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvKiemTraHSD.AutoGenerateColumns = false;
            this.dgvKiemTraHSD.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvKiemTraHSD.BackgroundColor = System.Drawing.Color.LightGray;
            this.dgvKiemTraHSD.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvKiemTraHSD.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvKiemTraHSD.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvKiemTraHSD.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvKiemTraHSD.ColumnHeadersHeight = 24;
            this.dgvKiemTraHSD.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maThuocDataGridViewTextBoxColumn,
            this.tenThuocDataGridViewTextBoxColumn,
            this.maNhaCungCapDataGridViewTextBoxColumn,
            this.ngaySXDataGridViewTextBoxColumn,
            this.hSDDataGridViewTextBoxColumn,
            this.soLuongDataGridViewTextBoxColumn,
            this.giaBanDataGridViewTextBoxColumn});
            this.dgvKiemTraHSD.DataSource = this.thuocBindingSource;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvKiemTraHSD.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvKiemTraHSD.EnableHeadersVisualStyles = false;
            this.dgvKiemTraHSD.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvKiemTraHSD.Location = new System.Drawing.Point(35, 187);
            this.dgvKiemTraHSD.Name = "dgvKiemTraHSD";
            this.dgvKiemTraHSD.RowHeadersVisible = false;
            this.dgvKiemTraHSD.RowHeadersWidth = 51;
            this.dgvKiemTraHSD.RowTemplate.Height = 24;
            this.dgvKiemTraHSD.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvKiemTraHSD.Size = new System.Drawing.Size(1039, 408);
            this.dgvKiemTraHSD.TabIndex = 4;
            this.dgvKiemTraHSD.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvKiemTraHSD.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvKiemTraHSD.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvKiemTraHSD.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvKiemTraHSD.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvKiemTraHSD.ThemeStyle.BackColor = System.Drawing.Color.LightGray;
            this.dgvKiemTraHSD.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvKiemTraHSD.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgvKiemTraHSD.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvKiemTraHSD.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvKiemTraHSD.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvKiemTraHSD.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvKiemTraHSD.ThemeStyle.HeaderStyle.Height = 24;
            this.dgvKiemTraHSD.ThemeStyle.ReadOnly = false;
            this.dgvKiemTraHSD.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvKiemTraHSD.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvKiemTraHSD.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvKiemTraHSD.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvKiemTraHSD.ThemeStyle.RowsStyle.Height = 24;
            this.dgvKiemTraHSD.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvKiemTraHSD.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // maThuocDataGridViewTextBoxColumn
            // 
            this.maThuocDataGridViewTextBoxColumn.DataPropertyName = "MaThuoc";
            this.maThuocDataGridViewTextBoxColumn.HeaderText = "MaThuoc";
            this.maThuocDataGridViewTextBoxColumn.Name = "maThuocDataGridViewTextBoxColumn";
            // 
            // tenThuocDataGridViewTextBoxColumn
            // 
            this.tenThuocDataGridViewTextBoxColumn.DataPropertyName = "TenThuoc";
            this.tenThuocDataGridViewTextBoxColumn.HeaderText = "TenThuoc";
            this.tenThuocDataGridViewTextBoxColumn.Name = "tenThuocDataGridViewTextBoxColumn";
            // 
            // maNhaCungCapDataGridViewTextBoxColumn
            // 
            this.maNhaCungCapDataGridViewTextBoxColumn.DataPropertyName = "MaNhaCungCap";
            this.maNhaCungCapDataGridViewTextBoxColumn.HeaderText = "MaNhaCungCap";
            this.maNhaCungCapDataGridViewTextBoxColumn.Name = "maNhaCungCapDataGridViewTextBoxColumn";
            // 
            // ngaySXDataGridViewTextBoxColumn
            // 
            this.ngaySXDataGridViewTextBoxColumn.DataPropertyName = "NgaySX";
            this.ngaySXDataGridViewTextBoxColumn.HeaderText = "NgaySX";
            this.ngaySXDataGridViewTextBoxColumn.Name = "ngaySXDataGridViewTextBoxColumn";
            // 
            // hSDDataGridViewTextBoxColumn
            // 
            this.hSDDataGridViewTextBoxColumn.DataPropertyName = "HSD";
            this.hSDDataGridViewTextBoxColumn.HeaderText = "HSD";
            this.hSDDataGridViewTextBoxColumn.Name = "hSDDataGridViewTextBoxColumn";
            // 
            // soLuongDataGridViewTextBoxColumn
            // 
            this.soLuongDataGridViewTextBoxColumn.DataPropertyName = "SoLuong";
            this.soLuongDataGridViewTextBoxColumn.HeaderText = "SoLuong";
            this.soLuongDataGridViewTextBoxColumn.Name = "soLuongDataGridViewTextBoxColumn";
            // 
            // giaBanDataGridViewTextBoxColumn
            // 
            this.giaBanDataGridViewTextBoxColumn.DataPropertyName = "GiaBan";
            this.giaBanDataGridViewTextBoxColumn.HeaderText = "GiaBan";
            this.giaBanDataGridViewTextBoxColumn.Name = "giaBanDataGridViewTextBoxColumn";
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
            // guna2Elipse1
            // 
            this.guna2Elipse1.TargetControl = this;
            // 
            // nguoiDungBindingSource
            // 
            this.nguoiDungBindingSource.DataMember = "NguoiDung";
            this.nguoiDungBindingSource.DataSource = this.quanLyNhaThuocDataSet1;
            // 
            // nguoiDungTableAdapter
            // 
            this.nguoiDungTableAdapter.ClearBeforeFill = true;
            // 
            // thuocTableAdapter
            // 
            this.thuocTableAdapter.ClearBeforeFill = true;
            // 
            // UC_Kiemtrahansudung
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.dgvKiemTraHSD);
            this.Controls.Add(this.cbxKiemTraHSD);
            this.Controls.Add(this.labelN);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "UC_Kiemtrahansudung";
            this.Size = new System.Drawing.Size(1134, 753);
            this.Load += new System.EventHandler(this.UC_Kiemtrahansudung_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKiemTraHSD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.thuocBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyNhaThuocDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nguoiDungBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelN;
        private Guna.UI2.WinForms.Guna2ComboBox cbxKiemTraHSD;
        private Guna.UI2.WinForms.Guna2DataGridView dgvKiemTraHSD;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private System.Windows.Forms.DataGridViewTextBoxColumn maThuocDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenThuocDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maNhaCungCapDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngaySXDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hSDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn soLuongDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn giaBanDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource thuocBindingSource;
        private QuanLyNhaThuocDataSet1 quanLyNhaThuocDataSet1;
        private System.Windows.Forms.BindingSource nguoiDungBindingSource;
        private QuanLyNhaThuocDataSet1TableAdapters.NguoiDungTableAdapter nguoiDungTableAdapter;
        private QuanLyNhaThuocDataSet1TableAdapters.ThuocTableAdapter thuocTableAdapter;
    }
}
