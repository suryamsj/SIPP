
namespace SIPP.view.usercontrols
{
    partial class Barang_User
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
            this.NamaBarang = new Guna.UI2.WinForms.Guna2TextBox();
            this.Form_header = new Guna.UI2.WinForms.Guna2Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.HargaBarang = new Guna.UI2.WinForms.Guna2TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Tombol_Simpan = new Guna.UI2.WinForms.Guna2Button();
            this.Tombol_Ubah = new Guna.UI2.WinForms.Guna2Button();
            this.Tombol_Hapus = new Guna.UI2.WinForms.Guna2Button();
            this.TanggalBeli = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.Form_panel = new Guna.UI2.WinForms.Guna2Panel();
            this.JumlahBarang = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.Table_Panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataTable)).BeginInit();
            this.Table_header.SuspendLayout();
            this.Form_header.SuspendLayout();
            this.Form_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.JumlahBarang)).BeginInit();
            this.SuspendLayout();
            // 
            // Table_Panel
            // 
            this.Table_Panel.Controls.Add(this.Vertical);
            this.Table_Panel.Controls.Add(this.Horizontal);
            this.Table_Panel.Controls.Add(this.DataTable);
            this.Table_Panel.Controls.Add(this.Table_header);
            this.Table_Panel.Location = new System.Drawing.Point(19, 93);
            this.Table_Panel.Name = "Table_Panel";
            this.Table_Panel.ShadowDecoration.Depth = 2;
            this.Table_Panel.ShadowDecoration.Enabled = true;
            this.Table_Panel.ShadowDecoration.Parent = this.Table_Panel;
            this.Table_Panel.Size = new System.Drawing.Size(1016, 743);
            this.Table_Panel.TabIndex = 0;
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
            this.Vertical.Size = new System.Drawing.Size(20, 679);
            this.Vertical.TabIndex = 3;
            this.Vertical.ThumbColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(55)))), ((int)(((byte)(80)))));
            // 
            // Horizontal
            // 
            this.Horizontal.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Horizontal.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(194)))), ((int)(((byte)(231)))));
            this.Horizontal.HoverState.Parent = null;
            this.Horizontal.LargeChange = 10;
            this.Horizontal.Location = new System.Drawing.Point(0, 723);
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
            this.DataTable.Size = new System.Drawing.Size(1016, 699);
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
            this.DataTable.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataTable_CellClick);
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
            this.label7.Size = new System.Drawing.Size(187, 20);
            this.label7.TabIndex = 4;
            this.label7.Text = "Table Data pengeluaran";
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
            this.label2.Size = new System.Drawing.Size(146, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Form Pengeluaran";
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
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(55)))), ((int)(((byte)(80)))));
            this.label4.Location = new System.Drawing.Point(8, 147);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Jumlah";
            // 
            // HargaBarang
            // 
            this.HargaBarang.Animated = true;
            this.HargaBarang.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.HargaBarang.DefaultText = "";
            this.HargaBarang.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.HargaBarang.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.HargaBarang.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.HargaBarang.DisabledState.Parent = this.HargaBarang;
            this.HargaBarang.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.HargaBarang.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.HargaBarang.FocusedState.Parent = this.HargaBarang;
            this.HargaBarang.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.HargaBarang.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.HargaBarang.HoverState.Parent = this.HargaBarang;
            this.HargaBarang.Location = new System.Drawing.Point(12, 258);
            this.HargaBarang.Name = "HargaBarang";
            this.HargaBarang.PasswordChar = '\0';
            this.HargaBarang.PlaceholderText = "";
            this.HargaBarang.SelectedText = "";
            this.HargaBarang.ShadowDecoration.Parent = this.HargaBarang;
            this.HargaBarang.Size = new System.Drawing.Size(390, 40);
            this.HargaBarang.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(55)))), ((int)(((byte)(80)))));
            this.label5.Location = new System.Drawing.Point(8, 235);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Harga";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(55)))), ((int)(((byte)(80)))));
            this.label6.Location = new System.Drawing.Point(8, 326);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(151, 20);
            this.label6.TabIndex = 10;
            this.label6.Text = "Tanggal Pembelian";
            // 
            // Tombol_Simpan
            // 
            this.Tombol_Simpan.CheckedState.Parent = this.Tombol_Simpan;
            this.Tombol_Simpan.CustomImages.Parent = this.Tombol_Simpan;
            this.Tombol_Simpan.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(30)))), ((int)(((byte)(133)))));
            this.Tombol_Simpan.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Tombol_Simpan.ForeColor = System.Drawing.Color.White;
            this.Tombol_Simpan.HoverState.Parent = this.Tombol_Simpan;
            this.Tombol_Simpan.Location = new System.Drawing.Point(12, 395);
            this.Tombol_Simpan.Name = "Tombol_Simpan";
            this.Tombol_Simpan.ShadowDecoration.Parent = this.Tombol_Simpan;
            this.Tombol_Simpan.Size = new System.Drawing.Size(390, 40);
            this.Tombol_Simpan.TabIndex = 11;
            this.Tombol_Simpan.Text = "Simpan";
            this.Tombol_Simpan.Click += new System.EventHandler(this.Tombol_Simpan_Click);
            // 
            // Tombol_Ubah
            // 
            this.Tombol_Ubah.CheckedState.Parent = this.Tombol_Ubah;
            this.Tombol_Ubah.CustomImages.Parent = this.Tombol_Ubah;
            this.Tombol_Ubah.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(101)))), ((int)(((byte)(166)))));
            this.Tombol_Ubah.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Tombol_Ubah.ForeColor = System.Drawing.Color.White;
            this.Tombol_Ubah.HoverState.Parent = this.Tombol_Ubah;
            this.Tombol_Ubah.Location = new System.Drawing.Point(12, 441);
            this.Tombol_Ubah.Name = "Tombol_Ubah";
            this.Tombol_Ubah.ShadowDecoration.Parent = this.Tombol_Ubah;
            this.Tombol_Ubah.Size = new System.Drawing.Size(390, 40);
            this.Tombol_Ubah.TabIndex = 12;
            this.Tombol_Ubah.Text = "Ubah";
            this.Tombol_Ubah.Click += new System.EventHandler(this.Tombol_Ubah_Click);
            // 
            // Tombol_Hapus
            // 
            this.Tombol_Hapus.CheckedState.Parent = this.Tombol_Hapus;
            this.Tombol_Hapus.CustomImages.Parent = this.Tombol_Hapus;
            this.Tombol_Hapus.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(157)))), ((int)(((byte)(182)))));
            this.Tombol_Hapus.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Tombol_Hapus.ForeColor = System.Drawing.Color.White;
            this.Tombol_Hapus.HoverState.Parent = this.Tombol_Hapus;
            this.Tombol_Hapus.Location = new System.Drawing.Point(12, 487);
            this.Tombol_Hapus.Name = "Tombol_Hapus";
            this.Tombol_Hapus.ShadowDecoration.Parent = this.Tombol_Hapus;
            this.Tombol_Hapus.Size = new System.Drawing.Size(390, 40);
            this.Tombol_Hapus.TabIndex = 13;
            this.Tombol_Hapus.Text = "Hapus";
            this.Tombol_Hapus.Click += new System.EventHandler(this.Tombol_Hapus_Click);
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
            this.TanggalBeli.Location = new System.Drawing.Point(12, 349);
            this.TanggalBeli.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.TanggalBeli.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.TanggalBeli.Name = "TanggalBeli";
            this.TanggalBeli.ShadowDecoration.Parent = this.TanggalBeli;
            this.TanggalBeli.Size = new System.Drawing.Size(390, 40);
            this.TanggalBeli.TabIndex = 3;
            this.TanggalBeli.Value = new System.DateTime(2021, 4, 10, 0, 0, 0, 0);
            // 
            // Form_panel
            // 
            this.Form_panel.Controls.Add(this.JumlahBarang);
            this.Form_panel.Controls.Add(this.TanggalBeli);
            this.Form_panel.Controls.Add(this.Tombol_Hapus);
            this.Form_panel.Controls.Add(this.Tombol_Ubah);
            this.Form_panel.Controls.Add(this.Tombol_Simpan);
            this.Form_panel.Controls.Add(this.label6);
            this.Form_panel.Controls.Add(this.label5);
            this.Form_panel.Controls.Add(this.HargaBarang);
            this.Form_panel.Controls.Add(this.label4);
            this.Form_panel.Controls.Add(this.label3);
            this.Form_panel.Controls.Add(this.Form_header);
            this.Form_panel.Controls.Add(this.NamaBarang);
            this.Form_panel.FillColor = System.Drawing.Color.White;
            this.Form_panel.Location = new System.Drawing.Point(1048, 92);
            this.Form_panel.Name = "Form_panel";
            this.Form_panel.ShadowDecoration.Depth = 2;
            this.Form_panel.ShadowDecoration.Enabled = true;
            this.Form_panel.ShadowDecoration.Parent = this.Form_panel;
            this.Form_panel.Size = new System.Drawing.Size(412, 539);
            this.Form_panel.TabIndex = 1;
            // 
            // JumlahBarang
            // 
            this.JumlahBarang.BackColor = System.Drawing.Color.Transparent;
            this.JumlahBarang.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.JumlahBarang.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.JumlahBarang.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.JumlahBarang.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.JumlahBarang.DisabledState.Parent = this.JumlahBarang;
            this.JumlahBarang.DisabledState.UpDownButtonFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(177)))), ((int)(((byte)(177)))));
            this.JumlahBarang.DisabledState.UpDownButtonForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(203)))), ((int)(((byte)(203)))));
            this.JumlahBarang.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.JumlahBarang.FocusedState.Parent = this.JumlahBarang;
            this.JumlahBarang.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.JumlahBarang.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.JumlahBarang.Location = new System.Drawing.Point(12, 170);
            this.JumlahBarang.Name = "JumlahBarang";
            this.JumlahBarang.ShadowDecoration.Parent = this.JumlahBarang;
            this.JumlahBarang.Size = new System.Drawing.Size(390, 40);
            this.JumlahBarang.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(55)))), ((int)(((byte)(80)))));
            this.label1.Location = new System.Drawing.Point(12, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(292, 39);
            this.label1.TabIndex = 2;
            this.label1.Text = "Data Pengeluaran";
            // 
            // Barang_User
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(247)))), ((int)(((byte)(255)))));
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Form_panel);
            this.Controls.Add(this.Table_Panel);
            this.Name = "Barang_User";
            this.Size = new System.Drawing.Size(1479, 862);
            this.Load += new System.EventHandler(this.Barang_User_Load);
            this.Table_Panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DataTable)).EndInit();
            this.Table_header.ResumeLayout(false);
            this.Table_header.PerformLayout();
            this.Form_header.ResumeLayout(false);
            this.Form_header.PerformLayout();
            this.Form_panel.ResumeLayout(false);
            this.Form_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.JumlahBarang)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel Table_Panel;
        private Guna.UI2.WinForms.Guna2Panel Table_header;
        private System.Windows.Forms.Label label7;
        private Guna.UI2.WinForms.Guna2DataGridView DataTable;
        private Guna.UI2.WinForms.Guna2HScrollBar Horizontal;
        private Guna.UI2.WinForms.Guna2VScrollBar Vertical;
        private Guna.UI2.WinForms.Guna2TextBox NamaBarang;
        private Guna.UI2.WinForms.Guna2Panel Form_header;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2TextBox HargaBarang;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private Guna.UI2.WinForms.Guna2Button Tombol_Simpan;
        private Guna.UI2.WinForms.Guna2Button Tombol_Ubah;
        private Guna.UI2.WinForms.Guna2Button Tombol_Hapus;
        private Guna.UI2.WinForms.Guna2DateTimePicker TanggalBeli;
        private Guna.UI2.WinForms.Guna2Panel Form_panel;
        private Guna.UI2.WinForms.Guna2NumericUpDown JumlahBarang;
        private System.Windows.Forms.Label label1;
    }
}
