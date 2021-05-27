
namespace SIPP.view.winform
{
    partial class Login
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.Tombol_Daftar = new Guna.UI2.WinForms.Guna2Button();
            this.LihatPassword = new Guna.UI2.WinForms.Guna2CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Tombol_Masuk = new Guna.UI2.WinForms.Guna2Button();
            this.label7 = new System.Windows.Forms.Label();
            this.Password = new Guna.UI2.WinForms.Guna2TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.Username = new Guna.UI2.WinForms.Guna2TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.Minimize = new Guna.UI2.WinForms.Guna2ControlBox();
            this.Close = new Guna.UI2.WinForms.Guna2ControlBox();
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.guna2ShadowForm1 = new Guna.UI2.WinForms.Guna2ShadowForm(this.components);
            this.ShowPassword = new Guna.UI2.WinForms.Guna2CheckBox();
            this.guna2Panel1.SuspendLayout();
            this.guna2Panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2Panel1.Controls.Add(this.Tombol_Daftar);
            this.guna2Panel1.Controls.Add(this.LihatPassword);
            this.guna2Panel1.Controls.Add(this.label3);
            this.guna2Panel1.Controls.Add(this.Tombol_Masuk);
            this.guna2Panel1.Controls.Add(this.label7);
            this.guna2Panel1.Controls.Add(this.Password);
            this.guna2Panel1.Controls.Add(this.label6);
            this.guna2Panel1.Controls.Add(this.Username);
            this.guna2Panel1.Controls.Add(this.label5);
            this.guna2Panel1.Controls.Add(this.label4);
            this.guna2Panel1.Controls.Add(this.guna2Panel2);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2Panel1.FillColor = System.Drawing.Color.White;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.ShadowDecoration.Parent = this.guna2Panel1;
            this.guna2Panel1.Size = new System.Drawing.Size(430, 513);
            this.guna2Panel1.TabIndex = 2;
            // 
            // Tombol_Daftar
            // 
            this.Tombol_Daftar.Animated = true;
            this.Tombol_Daftar.BorderRadius = 3;
            this.Tombol_Daftar.CheckedState.Parent = this.Tombol_Daftar;
            this.Tombol_Daftar.CustomImages.Parent = this.Tombol_Daftar;
            this.Tombol_Daftar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(101)))), ((int)(((byte)(166)))));
            this.Tombol_Daftar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Tombol_Daftar.ForeColor = System.Drawing.Color.White;
            this.Tombol_Daftar.HoverState.Parent = this.Tombol_Daftar;
            this.Tombol_Daftar.Location = new System.Drawing.Point(23, 401);
            this.Tombol_Daftar.Name = "Tombol_Daftar";
            this.Tombol_Daftar.ShadowDecoration.Parent = this.Tombol_Daftar;
            this.Tombol_Daftar.Size = new System.Drawing.Size(381, 40);
            this.Tombol_Daftar.TabIndex = 14;
            this.Tombol_Daftar.Text = "Daftar";
            this.Tombol_Daftar.Click += new System.EventHandler(this.Tombol_Daftar_Click);
            // 
            // LihatPassword
            // 
            this.LihatPassword.Animated = true;
            this.LihatPassword.AutoSize = true;
            this.LihatPassword.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.LihatPassword.CheckedState.BorderRadius = 0;
            this.LihatPassword.CheckedState.BorderThickness = 0;
            this.LihatPassword.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.LihatPassword.Location = new System.Drawing.Point(278, 319);
            this.LihatPassword.Name = "LihatPassword";
            this.LihatPassword.Size = new System.Drawing.Size(125, 21);
            this.LihatPassword.TabIndex = 13;
            this.LihatPassword.Text = "Lihat password";
            this.LihatPassword.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.LihatPassword.UncheckedState.BorderRadius = 0;
            this.LihatPassword.UncheckedState.BorderThickness = 0;
            this.LihatPassword.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.LihatPassword.CheckedChanged += new System.EventHandler(this.guna2CheckBox1_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label3.Location = new System.Drawing.Point(20, 478);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(273, 19);
            this.label3.TabIndex = 4;
            this.label3.Text = "Dibuat oleh Muhammad Surya Jayadiprana";
            // 
            // Tombol_Masuk
            // 
            this.Tombol_Masuk.Animated = true;
            this.Tombol_Masuk.BorderRadius = 3;
            this.Tombol_Masuk.CheckedState.Parent = this.Tombol_Masuk;
            this.Tombol_Masuk.CustomImages.Parent = this.Tombol_Masuk;
            this.Tombol_Masuk.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(30)))), ((int)(((byte)(133)))));
            this.Tombol_Masuk.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Tombol_Masuk.ForeColor = System.Drawing.Color.White;
            this.Tombol_Masuk.HoverState.Parent = this.Tombol_Masuk;
            this.Tombol_Masuk.Location = new System.Drawing.Point(24, 355);
            this.Tombol_Masuk.Name = "Tombol_Masuk";
            this.Tombol_Masuk.ShadowDecoration.Parent = this.Tombol_Masuk;
            this.Tombol_Masuk.Size = new System.Drawing.Size(380, 40);
            this.Tombol_Masuk.TabIndex = 12;
            this.Tombol_Masuk.Text = "Masuk";
            this.Tombol_Masuk.Click += new System.EventHandler(this.Tombol_Masuk_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(55)))), ((int)(((byte)(80)))));
            this.label7.Location = new System.Drawing.Point(19, 240);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 20);
            this.label7.TabIndex = 8;
            this.label7.Text = "Password";
            // 
            // Password
            // 
            this.Password.Animated = true;
            this.Password.BorderRadius = 3;
            this.Password.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Password.DefaultText = "";
            this.Password.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.Password.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.Password.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Password.DisabledState.Parent = this.Password;
            this.Password.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Password.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(30)))), ((int)(((byte)(133)))));
            this.Password.FocusedState.Parent = this.Password;
            this.Password.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Password.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(30)))), ((int)(((byte)(133)))));
            this.Password.HoverState.Parent = this.Password;
            this.Password.IconLeft = global::SIPP.Properties.Resources.icons8_lock_100px;
            this.Password.IconLeftSize = new System.Drawing.Size(25, 25);
            this.Password.Location = new System.Drawing.Point(23, 268);
            this.Password.Name = "Password";
            this.Password.PasswordChar = '•';
            this.Password.PlaceholderText = "Password";
            this.Password.SelectedText = "";
            this.Password.ShadowDecoration.Parent = this.Password;
            this.Password.Size = new System.Drawing.Size(380, 40);
            this.Password.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.Password.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(55)))), ((int)(((byte)(80)))));
            this.label6.Location = new System.Drawing.Point(19, 148);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 20);
            this.label6.TabIndex = 6;
            this.label6.Text = "Username";
            // 
            // Username
            // 
            this.Username.Animated = true;
            this.Username.BorderRadius = 3;
            this.Username.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Username.DefaultText = "";
            this.Username.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.Username.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.Username.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Username.DisabledState.Parent = this.Username;
            this.Username.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Username.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(30)))), ((int)(((byte)(133)))));
            this.Username.FocusedState.Parent = this.Username;
            this.Username.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Username.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(30)))), ((int)(((byte)(133)))));
            this.Username.HoverState.Parent = this.Username;
            this.Username.IconLeft = global::SIPP.Properties.Resources.icons8_customer_100px;
            this.Username.IconLeftSize = new System.Drawing.Size(25, 25);
            this.Username.Location = new System.Drawing.Point(23, 176);
            this.Username.Name = "Username";
            this.Username.PasswordChar = '\0';
            this.Username.PlaceholderText = "Username";
            this.Username.SelectedText = "";
            this.Username.ShadowDecoration.Parent = this.Username;
            this.Username.Size = new System.Drawing.Size(380, 40);
            this.Username.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.Username.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label5.Location = new System.Drawing.Point(20, 100);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(233, 17);
            this.label5.TabIndex = 2;
            this.label5.Text = "Masuk untuk menggunakan aplikasi";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(18, 70);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 25);
            this.label4.TabIndex = 1;
            this.label4.Text = "Masuk";
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.BackColor = System.Drawing.Color.White;
            this.guna2Panel2.Controls.Add(this.label1);
            this.guna2Panel2.Controls.Add(this.Minimize);
            this.guna2Panel2.Controls.Add(this.Close);
            this.guna2Panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Panel2.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.ShadowDecoration.Parent = this.guna2Panel2;
            this.guna2Panel2.Size = new System.Drawing.Size(430, 53);
            this.guna2Panel2.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(19, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 23);
            this.label1.TabIndex = 13;
            this.label1.Text = "Login SIPP";
            // 
            // Minimize
            // 
            this.Minimize.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox;
            this.Minimize.Dock = System.Windows.Forms.DockStyle.Right;
            this.Minimize.FillColor = System.Drawing.Color.White;
            this.Minimize.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(30)))), ((int)(((byte)(133)))));
            this.Minimize.HoverState.IconColor = System.Drawing.Color.White;
            this.Minimize.HoverState.Parent = this.Minimize;
            this.Minimize.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(55)))), ((int)(((byte)(80)))));
            this.Minimize.Location = new System.Drawing.Point(282, 0);
            this.Minimize.Name = "Minimize";
            this.Minimize.ShadowDecoration.Parent = this.Minimize;
            this.Minimize.Size = new System.Drawing.Size(74, 53);
            this.Minimize.TabIndex = 5;
            // 
            // Close
            // 
            this.Close.Dock = System.Windows.Forms.DockStyle.Right;
            this.Close.FillColor = System.Drawing.Color.White;
            this.Close.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(30)))), ((int)(((byte)(133)))));
            this.Close.HoverState.IconColor = System.Drawing.Color.White;
            this.Close.HoverState.Parent = this.Close;
            this.Close.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(55)))), ((int)(((byte)(80)))));
            this.Close.Location = new System.Drawing.Point(356, 0);
            this.Close.Name = "Close";
            this.Close.ShadowDecoration.Parent = this.Close;
            this.Close.Size = new System.Drawing.Size(74, 53);
            this.Close.TabIndex = 3;
            this.Close.Click += new System.EventHandler(this.Close_Click);
            // 
            // guna2DragControl1
            // 
            this.guna2DragControl1.ContainerControl = this;
            this.guna2DragControl1.TargetControl = this.guna2Panel2;
            // 
            // ShowPassword
            // 
            this.ShowPassword.AutoSize = true;
            this.ShowPassword.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(30)))), ((int)(((byte)(133)))));
            this.ShowPassword.CheckedState.BorderRadius = 0;
            this.ShowPassword.CheckedState.BorderThickness = 0;
            this.ShowPassword.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(30)))), ((int)(((byte)(133)))));
            this.ShowPassword.Location = new System.Drawing.Point(278, 319);
            this.ShowPassword.Name = "ShowPassword";
            this.ShowPassword.Size = new System.Drawing.Size(125, 21);
            this.ShowPassword.TabIndex = 13;
            this.ShowPassword.Text = "Lihat password";
            this.ShowPassword.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.ShowPassword.UncheckedState.BorderRadius = 0;
            this.ShowPassword.UncheckedState.BorderThickness = 0;
            this.ShowPassword.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(430, 513);
            this.Controls.Add(this.guna2Panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            this.guna2Panel2.ResumeLayout(false);
            this.guna2Panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private Guna.UI2.WinForms.Guna2ControlBox Minimize;
        private Guna.UI2.WinForms.Guna2ControlBox Close;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private Guna.UI2.WinForms.Guna2TextBox Username;
        private System.Windows.Forms.Label label7;
        private Guna.UI2.WinForms.Guna2TextBox Password;
        private Guna.UI2.WinForms.Guna2Button Tombol_Masuk;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2ShadowForm guna2ShadowForm1;
        private Guna.UI2.WinForms.Guna2CheckBox LihatPassword;
        private Guna.UI2.WinForms.Guna2CheckBox ShowPassword;
        private Guna.UI2.WinForms.Guna2Button Tombol_Daftar;
    }
}