
namespace SIPP.view.usercontrols
{
    partial class Cari_User
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
            this.TanggalBeli = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.Tombol_Cari = new Guna.UI2.WinForms.Guna2Button();
            this.label6 = new System.Windows.Forms.Label();
            this.Form_panel = new Guna.UI2.WinForms.Guna2Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.Form_header = new Guna.UI2.WinForms.Guna2Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.NamaBarang = new Guna.UI2.WinForms.Guna2TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.Vertical = new Guna.UI2.WinForms.Guna2VScrollBar();
            this.Horizontal = new Guna.UI2.WinForms.Guna2HScrollBar();
            this.DataTable = new Guna.UI2.WinForms.Guna2DataGridView();
            this.Table_header = new Guna.UI2.WinForms.Guna2Panel();
            this.Table_Panel = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Panel7 = new Guna.UI2.WinForms.Guna2Panel();
            this.LabelHarga = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.guna2Panel6 = new Guna.UI2.WinForms.Guna2Panel();
            this.LabelJumlah = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.guna2Panel5 = new Guna.UI2.WinForms.Guna2Panel();
            this.LabelBarang = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Form_panel.SuspendLayout();
            this.Form_header.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataTable)).BeginInit();
            this.Table_header.SuspendLayout();
            this.Table_Panel.SuspendLayout();
            this.guna2Panel7.SuspendLayout();
            this.guna2Panel6.SuspendLayout();
            this.guna2Panel5.SuspendLayout();
            this.SuspendLayout();
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
            this.TanggalBeli.Location = new System.Drawing.Point(12, 162);
            this.TanggalBeli.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.TanggalBeli.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.TanggalBeli.Name = "TanggalBeli";
            this.TanggalBeli.ShadowDecoration.Parent = this.TanggalBeli;
            this.TanggalBeli.Size = new System.Drawing.Size(390, 40);
            this.TanggalBeli.TabIndex = 3;
            this.TanggalBeli.Value = new System.DateTime(2021, 4, 10, 0, 0, 0, 0);
            // 
            // Tombol_Cari
            // 
            this.Tombol_Cari.CheckedState.Parent = this.Tombol_Cari;
            this.Tombol_Cari.CustomImages.Parent = this.Tombol_Cari;
            this.Tombol_Cari.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(30)))), ((int)(((byte)(133)))));
            this.Tombol_Cari.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Tombol_Cari.ForeColor = System.Drawing.Color.White;
            this.Tombol_Cari.HoverState.Parent = this.Tombol_Cari;
            this.Tombol_Cari.Location = new System.Drawing.Point(12, 208);
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
            this.label6.Location = new System.Drawing.Point(8, 139);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(135, 20);
            this.label6.TabIndex = 10;
            this.label6.Text = "Bulan dan Tahun";
            // 
            // Form_panel
            // 
            this.Form_panel.Controls.Add(this.TanggalBeli);
            this.Form_panel.Controls.Add(this.Tombol_Cari);
            this.Form_panel.Controls.Add(this.label6);
            this.Form_panel.Controls.Add(this.label3);
            this.Form_panel.Controls.Add(this.Form_header);
            this.Form_panel.Controls.Add(this.NamaBarang);
            this.Form_panel.FillColor = System.Drawing.Color.White;
            this.Form_panel.Location = new System.Drawing.Point(1048, 90);
            this.Form_panel.Name = "Form_panel";
            this.Form_panel.ShadowDecoration.Depth = 2;
            this.Form_panel.ShadowDecoration.Enabled = true;
            this.Form_panel.ShadowDecoration.Parent = this.Form_panel;
            this.Form_panel.Size = new System.Drawing.Size(412, 262);
            this.Form_panel.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(55)))), ((int)(((byte)(80)))));
            this.label3.Location = new System.Drawing.Point(8, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Nama Barang";
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(3, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(177, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Form cari pengeluaran";
            // 
            // NamaBarang
            // 
            this.NamaBarang.Animated = true;
            this.NamaBarang.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.NamaBarang.DefaultText = "";
            this.NamaBarang.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.NamaBarang.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.NamaBarang.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.NamaBarang.DisabledState.Parent = this.NamaBarang;
            this.NamaBarang.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.NamaBarang.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.NamaBarang.FocusedState.Parent = this.NamaBarang;
            this.NamaBarang.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.NamaBarang.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.NamaBarang.HoverState.Parent = this.NamaBarang;
            this.NamaBarang.Location = new System.Drawing.Point(12, 84);
            this.NamaBarang.Name = "NamaBarang";
            this.NamaBarang.PasswordChar = '\0';
            this.NamaBarang.PlaceholderText = "";
            this.NamaBarang.SelectedText = "";
            this.NamaBarang.ShadowDecoration.Parent = this.NamaBarang;
            this.NamaBarang.Size = new System.Drawing.Size(390, 40);
            this.NamaBarang.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(55)))), ((int)(((byte)(80)))));
            this.label1.Location = new System.Drawing.Point(12, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(398, 39);
            this.label1.TabIndex = 5;
            this.label1.Text = "Cari Pengeluaran / Bulan";
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
            this.Vertical.Size = new System.Drawing.Size(20, 300);
            this.Vertical.TabIndex = 3;
            this.Vertical.ThumbColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(55)))), ((int)(((byte)(80)))));
            // 
            // Horizontal
            // 
            this.Horizontal.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Horizontal.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(194)))), ((int)(((byte)(231)))));
            this.Horizontal.HoverState.Parent = null;
            this.Horizontal.LargeChange = 10;
            this.Horizontal.Location = new System.Drawing.Point(0, 344);
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
            this.DataTable.Size = new System.Drawing.Size(1016, 320);
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
            // Table_Panel
            // 
            this.Table_Panel.Controls.Add(this.Vertical);
            this.Table_Panel.Controls.Add(this.Horizontal);
            this.Table_Panel.Controls.Add(this.DataTable);
            this.Table_Panel.Controls.Add(this.Table_header);
            this.Table_Panel.Location = new System.Drawing.Point(26, 90);
            this.Table_Panel.Name = "Table_Panel";
            this.Table_Panel.ShadowDecoration.Depth = 2;
            this.Table_Panel.ShadowDecoration.Enabled = true;
            this.Table_Panel.ShadowDecoration.Parent = this.Table_Panel;
            this.Table_Panel.Size = new System.Drawing.Size(1016, 364);
            this.Table_Panel.TabIndex = 3;
            // 
            // guna2Panel7
            // 
            this.guna2Panel7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2Panel7.BackColor = System.Drawing.Color.Transparent;
            this.guna2Panel7.Controls.Add(this.LabelHarga);
            this.guna2Panel7.Controls.Add(this.label10);
            this.guna2Panel7.FillColor = System.Drawing.Color.White;
            this.guna2Panel7.Location = new System.Drawing.Point(26, 703);
            this.guna2Panel7.Name = "guna2Panel7";
            this.guna2Panel7.ShadowDecoration.Depth = 2;
            this.guna2Panel7.ShadowDecoration.Enabled = true;
            this.guna2Panel7.ShadowDecoration.Parent = this.guna2Panel7;
            this.guna2Panel7.Size = new System.Drawing.Size(1016, 100);
            this.guna2Panel7.TabIndex = 12;
            // 
            // LabelHarga
            // 
            this.LabelHarga.AutoSize = true;
            this.LabelHarga.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelHarga.Location = new System.Drawing.Point(9, 41);
            this.LabelHarga.Name = "LabelHarga";
            this.LabelHarga.Size = new System.Drawing.Size(28, 39);
            this.LabelHarga.TabIndex = 7;
            this.LabelHarga.Text = "-";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Dubai", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(154)))), ((int)(((byte)(185)))));
            this.label10.Location = new System.Drawing.Point(12, 17);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(182, 24);
            this.label10.TabIndex = 6;
            this.label10.Text = "Harga pengeluaran yang dicari";
            // 
            // guna2Panel6
            // 
            this.guna2Panel6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2Panel6.BackColor = System.Drawing.Color.Transparent;
            this.guna2Panel6.Controls.Add(this.LabelJumlah);
            this.guna2Panel6.Controls.Add(this.label8);
            this.guna2Panel6.FillColor = System.Drawing.Color.White;
            this.guna2Panel6.Location = new System.Drawing.Point(26, 582);
            this.guna2Panel6.Name = "guna2Panel6";
            this.guna2Panel6.ShadowDecoration.Depth = 2;
            this.guna2Panel6.ShadowDecoration.Enabled = true;
            this.guna2Panel6.ShadowDecoration.Parent = this.guna2Panel6;
            this.guna2Panel6.Size = new System.Drawing.Size(1016, 100);
            this.guna2Panel6.TabIndex = 11;
            // 
            // LabelJumlah
            // 
            this.LabelJumlah.AutoSize = true;
            this.LabelJumlah.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelJumlah.Location = new System.Drawing.Point(9, 41);
            this.LabelJumlah.Name = "LabelJumlah";
            this.LabelJumlah.Size = new System.Drawing.Size(28, 39);
            this.LabelJumlah.TabIndex = 7;
            this.LabelJumlah.Text = "-";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Dubai", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(154)))), ((int)(((byte)(185)))));
            this.label8.Location = new System.Drawing.Point(12, 17);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(187, 24);
            this.label8.TabIndex = 6;
            this.label8.Text = "Jumlah pengeluaran yang dicari";
            // 
            // guna2Panel5
            // 
            this.guna2Panel5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2Panel5.BackColor = System.Drawing.Color.Transparent;
            this.guna2Panel5.Controls.Add(this.LabelBarang);
            this.guna2Panel5.Controls.Add(this.label4);
            this.guna2Panel5.FillColor = System.Drawing.Color.White;
            this.guna2Panel5.Location = new System.Drawing.Point(26, 462);
            this.guna2Panel5.Name = "guna2Panel5";
            this.guna2Panel5.ShadowDecoration.Depth = 2;
            this.guna2Panel5.ShadowDecoration.Enabled = true;
            this.guna2Panel5.ShadowDecoration.Parent = this.guna2Panel5;
            this.guna2Panel5.Size = new System.Drawing.Size(1016, 100);
            this.guna2Panel5.TabIndex = 10;
            // 
            // LabelBarang
            // 
            this.LabelBarang.AutoSize = true;
            this.LabelBarang.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelBarang.Location = new System.Drawing.Point(9, 41);
            this.LabelBarang.Name = "LabelBarang";
            this.LabelBarang.Size = new System.Drawing.Size(28, 39);
            this.LabelBarang.TabIndex = 7;
            this.LabelBarang.Text = "-";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Dubai", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(154)))), ((int)(((byte)(185)))));
            this.label4.Location = new System.Drawing.Point(12, 17);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(144, 24);
            this.label4.TabIndex = 6;
            this.label4.Text = "Pengeluaran yang dicari";
            // 
            // Cari_User
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(247)))), ((int)(((byte)(255)))));
            this.Controls.Add(this.guna2Panel7);
            this.Controls.Add(this.guna2Panel6);
            this.Controls.Add(this.guna2Panel5);
            this.Controls.Add(this.Form_panel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Table_Panel);
            this.Name = "Cari_User";
            this.Size = new System.Drawing.Size(1479, 862);
            this.Load += new System.EventHandler(this.Cari_User_Load);
            this.Form_panel.ResumeLayout(false);
            this.Form_panel.PerformLayout();
            this.Form_header.ResumeLayout(false);
            this.Form_header.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataTable)).EndInit();
            this.Table_header.ResumeLayout(false);
            this.Table_header.PerformLayout();
            this.Table_Panel.ResumeLayout(false);
            this.guna2Panel7.ResumeLayout(false);
            this.guna2Panel7.PerformLayout();
            this.guna2Panel6.ResumeLayout(false);
            this.guna2Panel6.PerformLayout();
            this.guna2Panel5.ResumeLayout(false);
            this.guna2Panel5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI2.WinForms.Guna2DateTimePicker TanggalBeli;
        private Guna.UI2.WinForms.Guna2Button Tombol_Cari;
        private System.Windows.Forms.Label label6;
        private Guna.UI2.WinForms.Guna2Panel Form_panel;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2Panel Form_header;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2TextBox NamaBarang;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private Guna.UI2.WinForms.Guna2VScrollBar Vertical;
        private Guna.UI2.WinForms.Guna2HScrollBar Horizontal;
        private Guna.UI2.WinForms.Guna2DataGridView DataTable;
        private Guna.UI2.WinForms.Guna2Panel Table_header;
        private Guna.UI2.WinForms.Guna2Panel Table_Panel;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel7;
        public System.Windows.Forms.Label LabelHarga;
        private System.Windows.Forms.Label label10;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel6;
        public System.Windows.Forms.Label LabelJumlah;
        private System.Windows.Forms.Label label8;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel5;
        public System.Windows.Forms.Label LabelBarang;
        private System.Windows.Forms.Label label4;
    }
}
