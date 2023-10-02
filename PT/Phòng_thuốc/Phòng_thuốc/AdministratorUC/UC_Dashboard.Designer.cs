namespace Phòng_thuốc.AdministratorUC
{
    partial class UC_Dashboard
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series10 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series11 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series12 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.chartDashBoardAdmin = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.lblKhachHang = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.lblAdmin = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.lblNhanVien = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.lblSoDonTHuoc = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.lbltonggia = new System.Windows.Forms.Label();
            this.panel8 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartDashBoardAdmin)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel8.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(468, 12);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(197, 43);
            this.label1.TabIndex = 0;
            this.label1.Text = "Dashboard";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1110, 67);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Controls.Add(this.tableLayoutPanel1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 67);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1110, 689);
            this.panel2.TabIndex = 2;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.chartDashBoardAdmin);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(0, 121);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1110, 568);
            this.panel5.TabIndex = 2;
            // 
            // chartDashBoardAdmin
            // 
            chartArea4.Name = "ChartArea1";
            this.chartDashBoardAdmin.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            this.chartDashBoardAdmin.Legends.Add(legend4);
            this.chartDashBoardAdmin.Location = new System.Drawing.Point(50, 54);
            this.chartDashBoardAdmin.Name = "chartDashBoardAdmin";
            this.chartDashBoardAdmin.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            series10.ChartArea = "ChartArea1";
            series10.Legend = "Legend1";
            series10.Name = "Administrator";
            series11.ChartArea = "ChartArea1";
            series11.Legend = "Legend1";
            series11.Name = "Nhân viên";
            series12.ChartArea = "ChartArea1";
            series12.Legend = "Legend1";
            series12.Name = "Khách hàng";
            this.chartDashBoardAdmin.Series.Add(series10);
            this.chartDashBoardAdmin.Series.Add(series11);
            this.chartDashBoardAdmin.Series.Add(series12);
            this.chartDashBoardAdmin.Size = new System.Drawing.Size(779, 430);
            this.chartDashBoardAdmin.TabIndex = 0;
            this.chartDashBoardAdmin.Text = "chart1";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 218F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 180F));
            this.tableLayoutPanel1.Controls.Add(this.panel8, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel6, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel3, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel4, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel7, 3, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1110, 121);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.Red;
            this.panel6.Controls.Add(this.lblKhachHang);
            this.panel6.Controls.Add(this.label8);
            this.panel6.Location = new System.Drawing.Point(0, 0);
            this.panel6.Margin = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(233, 111);
            this.panel6.TabIndex = 3;
            // 
            // lblKhachHang
            // 
            this.lblKhachHang.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblKhachHang.AutoSize = true;
            this.lblKhachHang.BackColor = System.Drawing.Color.Lime;
            this.lblKhachHang.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKhachHang.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblKhachHang.Location = new System.Drawing.Point(84, 53);
            this.lblKhachHang.Name = "lblKhachHang";
            this.lblKhachHang.Size = new System.Drawing.Size(71, 32);
            this.lblKhachHang.TabIndex = 3;
            this.lblKhachHang.Text = "4563";
            this.lblKhachHang.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(19, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(200, 35);
            this.label8.TabIndex = 2;
            this.label8.Text = "Số khách hàng";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.LightPink;
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.lblAdmin);
            this.panel3.Location = new System.Drawing.Point(237, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(0, 0, 10, 10);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(227, 111);
            this.panel3.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(4, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(232, 35);
            this.label2.TabIndex = 2;
            this.label2.Text = "Số Administrator";
            // 
            // lblAdmin
            // 
            this.lblAdmin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblAdmin.AutoSize = true;
            this.lblAdmin.BackColor = System.Drawing.Color.GreenYellow;
            this.lblAdmin.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdmin.ForeColor = System.Drawing.Color.Red;
            this.lblAdmin.Location = new System.Drawing.Point(70, 55);
            this.lblAdmin.Name = "lblAdmin";
            this.lblAdmin.Size = new System.Drawing.Size(71, 32);
            this.lblAdmin.TabIndex = 1;
            this.lblAdmin.Text = "4563";
            this.lblAdmin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Teal;
            this.panel4.Controls.Add(this.label4);
            this.panel4.Controls.Add(this.lblNhanVien);
            this.panel4.Location = new System.Drawing.Point(474, 0);
            this.panel4.Margin = new System.Windows.Forms.Padding(0, 0, 10, 10);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(205, 111);
            this.panel4.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(15, 3);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(177, 35);
            this.label4.TabIndex = 2;
            this.label4.Text = "Số nhân viên";
            // 
            // lblNhanVien
            // 
            this.lblNhanVien.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNhanVien.AutoSize = true;
            this.lblNhanVien.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.lblNhanVien.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblNhanVien.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNhanVien.ForeColor = System.Drawing.Color.Red;
            this.lblNhanVien.Location = new System.Drawing.Point(59, 53);
            this.lblNhanVien.Name = "lblNhanVien";
            this.lblNhanVien.Size = new System.Drawing.Size(73, 34);
            this.lblNhanVien.TabIndex = 1;
            this.lblNhanVien.Text = "4563";
            this.lblNhanVien.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblNhanVien.Click += new System.EventHandler(this.lblNhanVien_Click);
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.Gray;
            this.panel7.Controls.Add(this.lblSoDonTHuoc);
            this.panel7.Controls.Add(this.label3);
            this.panel7.Location = new System.Drawing.Point(714, 3);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(200, 108);
            this.panel7.TabIndex = 4;
            // 
            // lblSoDonTHuoc
            // 
            this.lblSoDonTHuoc.AutoSize = true;
            this.lblSoDonTHuoc.BackColor = System.Drawing.Color.Snow;
            this.lblSoDonTHuoc.Location = new System.Drawing.Point(84, 82);
            this.lblSoDonTHuoc.Name = "lblSoDonTHuoc";
            this.lblSoDonTHuoc.Size = new System.Drawing.Size(40, 22);
            this.lblSoDonTHuoc.TabIndex = 1;
            this.lblSoDonTHuoc.Text = "123";
            this.lblSoDonTHuoc.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(15, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(171, 82);
            this.label3.TabIndex = 0;
            this.label3.Text = "Số đơn thuốc bán được";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.TargetControl = this;
            // 
            // lbltonggia
            // 
            this.lbltonggia.AutoSize = true;
            this.lbltonggia.Location = new System.Drawing.Point(22, 82);
            this.lbltonggia.Name = "lbltonggia";
            this.lbltonggia.Size = new System.Drawing.Size(126, 22);
            this.lbltonggia.TabIndex = 1;
            this.lbltonggia.Text = "Tổng giá thuốc";
            this.lbltonggia.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbltonggia.Click += new System.EventHandler(this.label5_Click);
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.Gainsboro;
            this.panel8.Controls.Add(this.label5);
            this.panel8.Controls.Add(this.lbltonggia);
            this.panel8.Location = new System.Drawing.Point(932, 3);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(175, 108);
            this.panel8.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.label5.Location = new System.Drawing.Point(5, 4);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(167, 75);
            this.label5.TabIndex = 2;
            this.label5.Text = "Tổng giá các đơn thuốc";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label5.Click += new System.EventHandler(this.label5_Click_1);
            // 
            // UC_Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "UC_Dashboard";
            this.Size = new System.Drawing.Size(1110, 756);
            this.Load += new System.EventHandler(this.UC_Dashboard_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartDashBoardAdmin)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartDashBoardAdmin;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label lblKhachHang;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblAdmin;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblNhanVien;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label lblSoDonTHuoc;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbltonggia;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Label label5;
    }
}
