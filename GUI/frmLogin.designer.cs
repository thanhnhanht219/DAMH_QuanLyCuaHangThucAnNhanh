namespace GUI
{
    partial class frmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            this.gunaElipse1 = new Guna.UI.WinForms.GunaElipse(this.components);
            this.guna2ControlBox1 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.grbTenDangNhap = new System.Windows.Forms.GroupBox();
            this.txtUsername = new Guna.UI2.WinForms.Guna2TextBox();
            this.grbMatKhau = new System.Windows.Forms.GroupBox();
            this.btnHidePass = new Guna.UI.WinForms.GunaButton();
            this.txtPassword = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnLogIn = new Guna.UI.WinForms.GunaGradientButton();
            this.gunaCirclePictureBox1 = new Guna.UI.WinForms.GunaCirclePictureBox();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.imgList = new System.Windows.Forms.ImageList(this.components);
            this.btnShowPass = new Guna.UI.WinForms.GunaButton();
            this.grbTenDangNhap.SuspendLayout();
            this.grbMatKhau.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gunaCirclePictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // gunaElipse1
            // 
            this.gunaElipse1.TargetControl = this;
            // 
            // guna2ControlBox1
            // 
            this.guna2ControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox1.FillColor = System.Drawing.Color.White;
            this.guna2ControlBox1.HoverState.Parent = this.guna2ControlBox1;
            this.guna2ControlBox1.IconColor = System.Drawing.Color.Black;
            this.guna2ControlBox1.Location = new System.Drawing.Point(306, 12);
            this.guna2ControlBox1.Name = "guna2ControlBox1";
            this.guna2ControlBox1.ShadowDecoration.Parent = this.guna2ControlBox1;
            this.guna2ControlBox1.Size = new System.Drawing.Size(45, 29);
            this.guna2ControlBox1.TabIndex = 8;
            // 
            // grbTenDangNhap
            // 
            this.grbTenDangNhap.Controls.Add(this.txtUsername);
            this.grbTenDangNhap.Location = new System.Drawing.Point(44, 136);
            this.grbTenDangNhap.Margin = new System.Windows.Forms.Padding(5, 3, 5, 5);
            this.grbTenDangNhap.Name = "grbTenDangNhap";
            this.grbTenDangNhap.Size = new System.Drawing.Size(275, 56);
            this.grbTenDangNhap.TabIndex = 10;
            this.grbTenDangNhap.TabStop = false;
            this.grbTenDangNhap.Text = "Tên đăng nhập";
            // 
            // txtUsername
            // 
            this.txtUsername.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtUsername.BackColor = System.Drawing.Color.Transparent;
            this.txtUsername.BorderColor = System.Drawing.SystemColors.Control;
            this.txtUsername.BorderRadius = 3;
            this.txtUsername.BorderThickness = 0;
            this.txtUsername.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtUsername.DefaultText = "";
            this.txtUsername.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtUsername.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtUsername.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtUsername.DisabledState.Parent = this.txtUsername;
            this.txtUsername.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtUsername.FocusedState.BorderColor = System.Drawing.SystemColors.Control;
            this.txtUsername.FocusedState.Parent = this.txtUsername;
            this.txtUsername.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtUsername.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.txtUsername.HoverState.BorderColor = System.Drawing.SystemColors.Control;
            this.txtUsername.HoverState.Parent = this.txtUsername;
            this.txtUsername.Location = new System.Drawing.Point(7, 22);
            this.txtUsername.Margin = new System.Windows.Forms.Padding(4);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.PasswordChar = '\0';
            this.txtUsername.PlaceholderText = "Tên đăng nhập";
            this.txtUsername.SelectedText = "";
            this.txtUsername.ShadowDecoration.Parent = this.txtUsername;
            this.txtUsername.Size = new System.Drawing.Size(261, 27);
            this.txtUsername.TabIndex = 0;
            // 
            // grbMatKhau
            // 
            this.grbMatKhau.Controls.Add(this.btnHidePass);
            this.grbMatKhau.Controls.Add(this.txtPassword);
            this.grbMatKhau.Controls.Add(this.btnShowPass);
            this.grbMatKhau.Location = new System.Drawing.Point(45, 210);
            this.grbMatKhau.Margin = new System.Windows.Forms.Padding(5, 3, 5, 5);
            this.grbMatKhau.Name = "grbMatKhau";
            this.grbMatKhau.Size = new System.Drawing.Size(274, 56);
            this.grbMatKhau.TabIndex = 11;
            this.grbMatKhau.TabStop = false;
            this.grbMatKhau.Text = "Mật khẩu";
            // 
            // btnHidePass
            // 
            this.btnHidePass.AnimationHoverSpeed = 0.07F;
            this.btnHidePass.AnimationSpeed = 0.03F;
            this.btnHidePass.BaseColor = System.Drawing.Color.Transparent;
            this.btnHidePass.BorderColor = System.Drawing.Color.Transparent;
            this.btnHidePass.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnHidePass.FocusedColor = System.Drawing.Color.Empty;
            this.btnHidePass.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnHidePass.ForeColor = System.Drawing.Color.White;
            this.btnHidePass.Image = ((System.Drawing.Image)(resources.GetObject("btnHidePass.Image")));
            this.btnHidePass.ImageSize = new System.Drawing.Size(20, 20);
            this.btnHidePass.Location = new System.Drawing.Point(218, 19);
            this.btnHidePass.Name = "btnHidePass";
            this.btnHidePass.OnHoverBaseColor = System.Drawing.Color.Transparent;
            this.btnHidePass.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnHidePass.OnHoverForeColor = System.Drawing.Color.White;
            this.btnHidePass.OnHoverImage = null;
            this.btnHidePass.OnPressedColor = System.Drawing.Color.Black;
            this.btnHidePass.Size = new System.Drawing.Size(39, 30);
            this.btnHidePass.TabIndex = 1;
            this.btnHidePass.Visible = false;
            this.btnHidePass.Click += new System.EventHandler(this.btnShowHidePass_Click);
            // 
            // txtPassword
            // 
            this.txtPassword.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPassword.BackColor = System.Drawing.Color.Transparent;
            this.txtPassword.BorderColor = System.Drawing.SystemColors.Control;
            this.txtPassword.BorderRadius = 3;
            this.txtPassword.BorderThickness = 0;
            this.txtPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPassword.DefaultText = "";
            this.txtPassword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtPassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtPassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPassword.DisabledState.Parent = this.txtPassword;
            this.txtPassword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPassword.FocusedState.BorderColor = System.Drawing.SystemColors.Control;
            this.txtPassword.FocusedState.Parent = this.txtPassword;
            this.txtPassword.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.txtPassword.HoverState.BorderColor = System.Drawing.SystemColors.Control;
            this.txtPassword.HoverState.Parent = this.txtPassword;
            this.txtPassword.Location = new System.Drawing.Point(7, 22);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(4);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '\0';
            this.txtPassword.PlaceholderText = "Mật khẩu";
            this.txtPassword.SelectedText = "";
            this.txtPassword.ShadowDecoration.Parent = this.txtPassword;
            this.txtPassword.Size = new System.Drawing.Size(204, 27);
            this.txtPassword.TabIndex = 0;
            // 
            // btnLogIn
            // 
            this.btnLogIn.AnimationHoverSpeed = 0.07F;
            this.btnLogIn.AnimationSpeed = 0.03F;
            this.btnLogIn.BackColor = System.Drawing.Color.Transparent;
            this.btnLogIn.BaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(130)))), ((int)(((byte)(68)))));
            this.btnLogIn.BaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(72)))), ((int)(((byte)(115)))));
            this.btnLogIn.BorderColor = System.Drawing.Color.Black;
            this.btnLogIn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnLogIn.FocusedColor = System.Drawing.Color.Empty;
            this.btnLogIn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnLogIn.ForeColor = System.Drawing.Color.White;
            this.btnLogIn.Image = null;
            this.btnLogIn.ImageSize = new System.Drawing.Size(20, 20);
            this.btnLogIn.Location = new System.Drawing.Point(44, 290);
            this.btnLogIn.Name = "btnLogIn";
            this.btnLogIn.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(145)))), ((int)(((byte)(221)))));
            this.btnLogIn.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(85)))), ((int)(((byte)(255)))));
            this.btnLogIn.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnLogIn.OnHoverForeColor = System.Drawing.Color.White;
            this.btnLogIn.OnHoverImage = null;
            this.btnLogIn.OnPressedColor = System.Drawing.Color.Black;
            this.btnLogIn.Radius = 4;
            this.btnLogIn.Size = new System.Drawing.Size(273, 42);
            this.btnLogIn.TabIndex = 12;
            this.btnLogIn.Text = "Đăng nhập";
            this.btnLogIn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnLogIn.Click += new System.EventHandler(this.btnLogIn_Click);
            // 
            // gunaCirclePictureBox1
            // 
            this.gunaCirclePictureBox1.BaseColor = System.Drawing.Color.White;
            this.gunaCirclePictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("gunaCirclePictureBox1.Image")));
            this.gunaCirclePictureBox1.Location = new System.Drawing.Point(131, 23);
            this.gunaCirclePictureBox1.Name = "gunaCirclePictureBox1";
            this.gunaCirclePictureBox1.Size = new System.Drawing.Size(89, 82);
            this.gunaCirclePictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.gunaCirclePictureBox1.TabIndex = 13;
            this.gunaCirclePictureBox1.TabStop = false;
            this.gunaCirclePictureBox1.UseTransfarantBackground = false;
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel1.ForeColor = System.Drawing.Color.Black;
            this.gunaLabel1.Location = new System.Drawing.Point(127, 97);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(0, 20);
            this.gunaLabel1.TabIndex = 14;
            // 
            // imgList
            // 
            this.imgList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgList.ImageStream")));
            this.imgList.TransparentColor = System.Drawing.Color.Transparent;
            this.imgList.Images.SetKeyName(0, "hidden.png");
            this.imgList.Images.SetKeyName(1, "eye.png");
            // 
            // btnShowPass
            // 
            this.btnShowPass.AnimationHoverSpeed = 0.07F;
            this.btnShowPass.AnimationSpeed = 0.03F;
            this.btnShowPass.BaseColor = System.Drawing.Color.Transparent;
            this.btnShowPass.BorderColor = System.Drawing.Color.Transparent;
            this.btnShowPass.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnShowPass.FocusedColor = System.Drawing.Color.Empty;
            this.btnShowPass.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnShowPass.ForeColor = System.Drawing.Color.White;
            this.btnShowPass.Image = ((System.Drawing.Image)(resources.GetObject("btnShowPass.Image")));
            this.btnShowPass.ImageSize = new System.Drawing.Size(20, 20);
            this.btnShowPass.Location = new System.Drawing.Point(218, 20);
            this.btnShowPass.Name = "btnShowPass";
            this.btnShowPass.OnHoverBaseColor = System.Drawing.Color.Transparent;
            this.btnShowPass.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnShowPass.OnHoverForeColor = System.Drawing.Color.White;
            this.btnShowPass.OnHoverImage = null;
            this.btnShowPass.OnPressedColor = System.Drawing.Color.Black;
            this.btnShowPass.Size = new System.Drawing.Size(39, 30);
            this.btnShowPass.TabIndex = 2;
            this.btnShowPass.Click += new System.EventHandler(this.btnShowPass_Click);
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(354, 378);
            this.Controls.Add(this.gunaLabel1);
            this.Controls.Add(this.gunaCirclePictureBox1);
            this.Controls.Add(this.btnLogIn);
            this.Controls.Add(this.grbMatKhau);
            this.Controls.Add(this.grbTenDangNhap);
            this.Controls.Add(this.guna2ControlBox1);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmLogin";
            this.Text = "frmLogin";
            this.grbTenDangNhap.ResumeLayout(false);
            this.grbMatKhau.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gunaCirclePictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI.WinForms.GunaElipse gunaElipse1;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;
        private System.Windows.Forms.GroupBox grbTenDangNhap;
        private Guna.UI2.WinForms.Guna2TextBox txtUsername;
        private System.Windows.Forms.GroupBox grbMatKhau;
        private Guna.UI2.WinForms.Guna2TextBox txtPassword;
        private Guna.UI.WinForms.GunaGradientButton btnLogIn;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI.WinForms.GunaCirclePictureBox gunaCirclePictureBox1;
        private Guna.UI.WinForms.GunaButton btnHidePass;
        private System.Windows.Forms.ImageList imgList;
        private Guna.UI.WinForms.GunaButton btnShowPass;
    }
}