
namespace SIPP.view.usercontrols
{
    partial class Laporan_User
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Table_Panel = new Guna.UI2.WinForms.Guna2Panel();
            this.Vertical = new Guna.UI2.WinForms.Guna2VScrollBar();
            this.Horizontal = new Guna.UI2.WinForms.Guna2HScrollBar();
            this.DataTable = new Guna.UI2.WinForms.Guna2DataGridView();
            this.Table_header = new Guna.UI2.WinForms.Guna2Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Form_header = new Guna.UI2.WinForms.Guna2Panel();
            this.Form_panel = new Guna.UI2.WinForms.Guna2Panel();
            this.Tombol_Print = new Guna.UI2.WinForms.Guna2Button();
            this.TanggalBeli = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.Tombol_Excel = new Guna.UI2.WinForms.Guna2Button();
            this.Tombol_Cari = new Guna.UI2.WinForms.Guna2Button();
            this.label6 = new System.Windows.Forms.Label();
            this.guna2Panel5 = new Guna.UI2.WinForms.Guna2Panel();
            this.LabelTotal = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Table_Panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataTable)).BeginInit();
            this.Table_header.SuspendLayout();
            this.Form_header.SuspendLayout();
            this.Form_panel.SuspendLayout();
            this.guna2Panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // Table_Panel
            // 
            this.Table_Panel.Controls.Add(this.Vertical);
            this.Table_Panel.Controls.Add(this.Horizontal);
            this.Table_Panel.Controls.Add(this.DataTable);
            this.Table_Panel.Controls.Add(this.Table_header);
            this.Table_Panel.Location = new System.Drawing.Point(26, 105);
            this.Table_Panel.Name = "Table_Panel";
            this.Table_Panel.ShadowDecoration.Depth = 2;
            this.Table_Panel.ShadowDecoration.Enabled = true;
            this.Table_Panel.ShadowDecoration.Parent = this.Table_Panel;
            this.Table_Panel.Size = new System.Drawing.Size(1016, 514);
            this.Table_Panel.TabIndex = 13;
            // 
            // Vertical
            // 
            this.Vertical.Dock = System.Windows.Forms.DockStyle.Right;
            this.Vertical.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(194)))), ((int)(((byte)(231)))));
            this.Vertical.HoverState.Parent = null;
            this.Vertical.LargeChange = 10;
            this.Vertical.Location = new System.Drawing.Point(996, 44);
            this.Vertical.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Vertical.MouseWheelBarPartitions = 10;
            this.Vertical.Name = "Vertical";
            this.Vertical.PressedState.Parent = this.Vertical;
            this.Vertical.ScrollbarSize = 20;
            this.Vertical.Size = new System.Drawing.Size(20, 450);
            this.Vertical.TabIndex = 3;
            this.Vertical.ThumbColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(55)))), ((int)(((byte)(80)))));
            // 
            // Horizontal
            // 
            this.Horizontal.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Horizontal.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(194)))), ((int)(((byte)(231)))));
            this.Horizontal.HoverState.Parent = null;
            this.Horizontal.LargeChange = 10;
            this.Horizontal.Location = new System.Drawing.Point(0, 494);
            this.Horizontal.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Horizontal.MouseWheelBarPartitions = 10;
            this.Horizontal.Name = "Horizontal";
            this.Horizontal.PressedState.Parent = this.Horizontal;
            this.Horizontal.ScrollbarSize = 20;
            this.Horizontal.Size = new System.Drawing.Size(1016, 20);
            this.Horizontal.TabIndex = 2;
            this.Horizontal.ThumbColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(55)))), ((int)(((byte)(80)))));
            // 
            // DataTable
            // 
            this.DataTable.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.DataTable.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DataTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataTable.BackgroundColor = System.Drawing.Color.White;
            this.DataTable.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DataTable.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DataTable.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DataTable.ColumnHeadersHeight = 4;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(248)))), ((int)(((byte)(249)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(241)))), ((int)(((byte)(243)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DataTable.DefaultCellStyle = dataGridViewCellStyle3;
            this.DataTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DataTable.EnableHeadersVisualStyles = false;
            this.DataTable.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(248)))), ((int)(((byte)(249)))));
            this.DataTable.Location = new System.Drawing.Point(0, 44);
            this.DataTable.Name = "DataTable";
            this.DataTable.RowHeadersVisible = false;
            this.DataTable.RowHeadersWidth = 51;
            this.DataTable.RowTemplate.Height = 24;
            this.DataTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataTable.Size = new System.Drawing.Size(1016, 470);
            this.DataTable.TabIndex = 1;
            this.DataTable.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.White;
            this.DataTable.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.DataTable.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.DataTable.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.DataTable.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.DataTable.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.DataTable.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.DataTable.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(248)))), ((int)(((byte)(249)))));
            this.DataTable.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.White;
            this.DataTable.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.DataTable.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.DataTable.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.Black;
            this.DataTable.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.DataTable.ThemeStyle.HeaderStyle.Height = 4;
            this.DataTable.ThemeStyle.ReadOnly = false;
            this.DataTable.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(248)))), ((int)(((byte)(249)))));
            this.DataTable.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DataTable.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.DataTable.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.DataTable.ThemeStyle.RowsStyle.Height = 24;
            this.DataTable.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(241)))), ((int)(((byte)(243)))));
            this.DataTable.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            // 
            // Table_header
            // 
            this.Table_header.BackColor = System.Drawing.Color.Transparent;
            this.Table_header.Controls.Add(this.label7);
            this.Table_header.Dock = System.Windows.Forms.DockStyle.Top;
            this.Table_header.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(30)))), ((int)(((byte)(133)))));
            this.Table_header.Location = new System.Drawing.Point(0, 0);
            this.Table_header.Name = "Table_header";
            this.Table_header.ShadowDecoration.Parent = this.Table_header;
            this.Table_header.Size = new System.Drawing.Size(1016, 44);
            this.Table_header.TabIndex = 0;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(3, 13);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(146, 20);
            this.label7.TabIndex = 4;
            this.label7.Text = "Table pengeluaran";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(55)))), ((int)(((byte)(80)))));
            this.label1.Location = new System.Drawing.Point(12, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(460, 39);
            this.label1.TabIndex = 15;
            this.label1.Text = "Laporan Pengeluaran / Bulan";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(3, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(204, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Form laporan pengeluaran";
            // 
            // Form_header
            // 
            this.Form_header.BackColor = System.Drawing.Color.Transparent;
            this.Form_header.Controls.Add(this.label2);
            this.Form_header.Dock = System.Windows.Forms.DockStyle.Top;
            this.Form_header.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(30)))), ((int)(((byte)(133)))));
            this.Form_header.Location = new System.Drawing.Point(0, 0);
            this.Form_header.Name = "Form_header";
            this.Form_header.ShadowDecoration.Parent = this.Form_header;
            this.Form_header.Size = new System.Drawing.Size(412, 44);
            this.Form_header.TabIndex = 1;
            // 
            // Form_panel
            // 
            this.Form_panel.Controls.Add(this.Tombol_Print);
            this.Form_panel.Controls.Add(this.TanggalBeli);
            this.Form_panel.Controls.Add(this.Tombol_Excel);
            this.Form_panel.Controls.Add(this.Tombol_Cari);
            this.Form_panel.Controls.Add(this.label6);
            this.Form_panel.Controls.Add(this.Form_header);
            this.Form_panel.FillColor = System.Drawing.Color.White;
            this.Form_panel.Location = new System.Drawing.Point(1048, 105);
            this.Form_panel.Name = "Form_panel";
            this.Form_panel.ShadowDecoration.Depth = 2;
            this.Form_panel.ShadowDecoration.Enabled = true;
            this.Form_panel.ShadowDecoration.Parent = this.Form_panel;
            this.Form_panel.Size = new System.Drawing.Size(412, 273);
            this.Form_panel.TabIndex = 14;
            // 
            // Tombol_Print
            // 
            this.Tombol_Print.CheckedState.Parent = this.Tombol_Print;
            this.Tombol_Print.CustomImages.Parent = this.Tombol_Print;
            this.Tombol_Print.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(157)))), ((int)(((byte)(182)))));
            this.Tombol_Print.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Tombol_Print.ForeColor = System.Drawing.Color.White;
            this.Tombol_Print.HoverState.Parent = this.Tombol_Print;
            this.Tombol_Print.Location = new System.Drawing.Point(12, 218);
            this.Tombol_Print.Name = "Tombol_Print";
            this.Tombol_Print.ShadowDecoration.Parent = this.Tombol_Print;
            this.Tombol_Print.Size = new System.Drawing.Size(390, 40);
            this.Tombol_Print.TabIndex = 18;
            this.Tombol_Print.Text = "Print Pengeluaran";
            this.Tombol_Print.Click += new System.EventHandler(this.Tombol_Print_Click);
            // 
            // TanggalBeli
            // 
            this.TanggalBeli.Animated = true;
            this.TanggalBeli.BorderColor = System.Drawing.Color.Silver;
            this.TanggalBeli.BorderThickness = 1;
            this.TanggalBeli.CheckedState.Parent = this.TanggalBeli;
            this.TanggalBeli.FillColor = System.Drawing.Color.White;
            this.TanggalBeli.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TanggalBeli.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.TanggalBeli.HoverState.Parent = this.TanggalBeli;
            this.TanggalBeli.Location = new System.Drawing.Point(12, 80);
            this.TanggalBeli.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.TanggalBeli.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.TanggalBeli.Name = "TanggalBeli";
            this.TanggalBeli.ShadowDecoration.Parent = this.TanggalBeli;
            this.TanggalBeli.Size = new System.Drawing.Size(390, 40);
            this.TanggalBeli.TabIndex = 3;
            this.TanggalBeli.Value = new System.DateTime(2021, 4, 10, 0, 0, 0, 0);
            // 
            // Tombol_Excel
            // 
            this.Tombol_Excel.CheckedState.Parent = this.Tombol_Excel;
            this.Tombol_Excel.CustomImages.Parent = this.Tombol_Excel;
            this.Tombol_Excel.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(101)))), ((int)(((byte)(166)))));
            this.Tombol_Excel.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Tombol_Excel.ForeColor = System.Drawing.Color.White;
            this.Tombol_Excel.HoverState.Parent = this.Tombol_Excel;
            this.Tombol_Excel.Location = new System.Drawing.Point(12, 172);
            this.Tombol_Excel.Name = "Tombol_Excel";
            this.Tombol_Excel.ShadowDecoration.Parent = this.Tombol_Excel;
            this.Tombol_Excel.Size = new System.Drawing.Size(390, 40);
            this.Tombol_Excel.TabIndex = 17;
            this.Tombol_Excel.Text = "Simpan ke Excel";
            this.Tombol_Excel.Click += new System.EventHandler(this.Tombol_Excel_Click);
            // 
            // Tombol_Cari
            // 
            this.Tombol_Cari.CheckedState.Parent = this.Tombol_Cari;
            this.Tombol_Cari.CustomImages.Parent = this.Tombol_Cari;
            this.Tombol_Cari.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(30)))), ((int)(((byte)(133)))));
            this.Tombol_Cari.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Tombol_Cari.ForeColor = System.Drawing.Color.White;
            this.Tombol_Cari.HoverState.Parent = this.Tombol_Cari;
            this.Tombol_Cari.Location = new System.Drawing.Point(12, 126);
            this.Tombol_Cari.Name = "Tombol_Cari";
            this.Tombol_Cari.ShadowDecoration.Parent = this.Tombol_Cari;
            this.Tombol_Cari.Size = new System.Drawing.Size(390, 40);
            this.Tombol_Cari.TabIndex = 11;
            this.Tombol_Cari.Text = "Cari";
            this.Tombol_Cari.Click += new System.EventHandler(this.Tombol_Cari_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(55)))), ((int)(((byte)(80)))));
            this.label6.Location = new System.Drawing.Point(8, 57);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(135, 20);
            this.label6.TabIndex = 10;
            this.label6.Text = "Bulan dan Tahun";
            // 
            // guna2Panel5
            // 
            this.guna2Panel5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2Panel5.BackColor = System.Drawing.Color.Transparent;
            this.guna2Panel5.Controls.Add(this.LabelTotal);
            this.guna2Panel5.Controls.Add(this.label4);
            this.guna2Panel5.FillColor = System.Drawing.Color.White;
            this.guna2Panel5.Location = new System.Drawing.Point(26, 625);
            this.guna2Panel5.Name = "guna2Panel5";
            this.guna2Panel5.ShadowDecoration.Depth = 2;
            this.guna2Panel5.ShadowDecoration.Enabled = true;
            this.guna2Panel5.ShadowDecoration.Parent = this.guna2Panel5;
            this.guna2Panel5.Size = new System.Drawing.Size(1016, 100);
            this.guna2Panel5.TabIndex = 16;
            // 
            // LabelTotal
            // 
            this.LabelTotal.AutoSize = true;
            this.LabelTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelTotal.Location = new System.Drawing.Point(9, 41);
            this.LabelTotal.Name = "LabelTotal";
            this.LabelTotal.Size = new System.Drawing.Size(28, 39);
            this.LabelTotal.TabIndex = 7;
            this.LabelTotal.Text = "-";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Dubai", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(154)))), ((int)(((byte)(185)))));
            this.label4.Location = new System.Drawing.Point(12, 17);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(165, 24);
            this.label4.TabIndex = 6;
            this.label4.Text = "Total Pengeluaran Bulan Ini";
            // 
            // Laporan_User
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(247)))), ((int)(((byte)(255)))));
            this.Controls.Add(this.guna2Panel5);
            this.Controls.Add(this.Table_Panel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Form_panel);
            this.Name = "Laporan_User";
            this.Size = new System.Drawing.Size(1479, 862);
            this.Load += new System.EventHandler(this.Laporan_User_Load);
            this.Table_Panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DataTable)).EndInit();
            this.Table_header.ResumeLayout(false);
            this.Table_header.PerformLayout();
            this.Form_header.ResumeLayout(false);
            this.Form_header.PerformLayout();
            this.Form_panel.ResumeLayout(false);
            this.Form_panel.PerformLayout();
            this.guna2Panel5.ResumeLayout(false);
            this.guna2Panel5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Panel Table_Panel;
        private Guna.UI2.WinForms.Guna2VScrollBar Vertical;
        private Guna.UI2.WinForms.Guna2HScrollBar Horizontal;
        private Guna.UI2.WinForms.Guna2DataGridView DataTable;
        private Guna.UI2.WinForms.Guna2Panel Table_header;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2Panel Form_header;
        private Guna.UI2.WinForms.Guna2Panel Form_panel;
        private Guna.UI2.WinForms.Guna2DateTimePicker TanggalBeli;
        private Guna.UI2.WinForms.Guna2Button Tombol_Cari;
        private System.Windows.Forms.Label label6;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel5;
        public System.Windows.Forms.Label LabelTotal;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2Button Tombol_Print;
        private Guna.UI2.WinForms.Guna2Button Tombol_Excel;
    }
}
