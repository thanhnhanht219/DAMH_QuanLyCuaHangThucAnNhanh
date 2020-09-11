using System;

namespace clb_GUI
{
    partial class usSanPham
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
            this.pnMain = new Guna.UI.WinForms.GunaPanel();
            this.gunaShadowPanel1 = new Guna.UI.WinForms.GunaShadowPanel();
            this.lbTenSanPham = new Guna.UI.WinForms.GunaLabel();
            this.gunaGradient2Panel6 = new Guna.UI.WinForms.GunaGradient2Panel();
            this.lbgia = new Guna.UI.WinForms.GunaLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pnLine = new Guna.UI.WinForms.GunaLinePanel();
            this.pnMain.SuspendLayout();
            this.gunaShadowPanel1.SuspendLayout();
            this.gunaGradient2Panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnMain
            // 
            this.pnMain.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnMain.Controls.Add(this.gunaShadowPanel1);
            this.pnMain.Controls.Add(this.gunaGradient2Panel6);
            this.pnMain.Controls.Add(this.pictureBox1);
            this.pnMain.Controls.Add(this.pnLine);
            this.pnMain.Location = new System.Drawing.Point(11, 10);
            this.pnMain.Margin = new System.Windows.Forms.Padding(11, 10, 11, 10);
            this.pnMain.Name = "pnMain";
            this.pnMain.Size = new System.Drawing.Size(196, 186);
            this.pnMain.TabIndex = 6;
            // 
            // gunaShadowPanel1
            // 
            this.gunaShadowPanel1.BackColor = System.Drawing.Color.Transparent;
            this.gunaShadowPanel1.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.gunaShadowPanel1.Controls.Add(this.lbTenSanPham);
            this.gunaShadowPanel1.Location = new System.Drawing.Point(0, 142);
            this.gunaShadowPanel1.Name = "gunaShadowPanel1";
            this.gunaShadowPanel1.ShadowColor = System.Drawing.Color.Black;
            this.gunaShadowPanel1.ShadowShift = 0;
            this.gunaShadowPanel1.ShadowStyle = Guna.UI.WinForms.ShadowMode.Dropped;
            this.gunaShadowPanel1.Size = new System.Drawing.Size(196, 46);
            this.gunaShadowPanel1.TabIndex = 21;
            // 
            // lbTenSanPham
            // 
            this.lbTenSanPham.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTenSanPham.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbTenSanPham.Location = new System.Drawing.Point(21, 9);
            this.lbTenSanPham.Name = "lbTenSanPham";
            this.lbTenSanPham.Size = new System.Drawing.Size(142, 25);
            this.lbTenSanPham.TabIndex = 9;
            this.lbTenSanPham.Text = "Sandwich Heo";
            this.lbTenSanPham.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // gunaGradient2Panel6
            // 
            this.gunaGradient2Panel6.BackColor = System.Drawing.Color.Transparent;
            this.gunaGradient2Panel6.Controls.Add(this.lbgia);
            this.gunaGradient2Panel6.GradientColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(130)))), ((int)(((byte)(68)))));
            this.gunaGradient2Panel6.GradientColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(72)))), ((int)(((byte)(115)))));
            this.gunaGradient2Panel6.Location = new System.Drawing.Point(5, 10);
            this.gunaGradient2Panel6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gunaGradient2Panel6.Name = "gunaGradient2Panel6";
            this.gunaGradient2Panel6.Radius = 4;
            this.gunaGradient2Panel6.Size = new System.Drawing.Size(73, 27);
            this.gunaGradient2Panel6.TabIndex = 18;
            // 
            // lbgia
            // 
            this.lbgia.AutoSize = true;
            this.lbgia.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lbgia.ForeColor = System.Drawing.Color.White;
            this.lbgia.Location = new System.Drawing.Point(5, 0);
            this.lbgia.Name = "lbgia";
            this.lbgia.Size = new System.Drawing.Size(52, 19);
            this.lbgia.TabIndex = 0;
            this.lbgia.Text = "28,000";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(196, 186);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pnLine
            // 
            this.pnLine.BackColor = System.Drawing.Color.Transparent;
            this.pnLine.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnLine.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnLine.LineColor = System.Drawing.Color.Tomato;
            this.pnLine.LineStyle = System.Windows.Forms.BorderStyle.None;
            this.pnLine.Location = new System.Drawing.Point(0, 0);
            this.pnLine.Margin = new System.Windows.Forms.Padding(4);
            this.pnLine.Name = "pnLine";
            this.pnLine.Size = new System.Drawing.Size(196, 186);
            this.pnLine.TabIndex = 20;
            // 
            // usSanPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnMain);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "usSanPham";
            this.Size = new System.Drawing.Size(239, 225);
            this.Load += new System.EventHandler(this.usSanPham_Load);
            this.pnMain.ResumeLayout(false);
            this.gunaShadowPanel1.ResumeLayout(false);
            this.gunaGradient2Panel6.ResumeLayout(false);
            this.gunaGradient2Panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

    
        #endregion
        public Guna.UI.WinForms.GunaPanel pnMain;
        public System.Windows.Forms.PictureBox pictureBox1;
        private Guna.UI.WinForms.GunaGradient2Panel gunaGradient2Panel6;
        private Guna.UI.WinForms.GunaLabel lbgia;
        public Guna.UI.WinForms.GunaLinePanel pnLine;
        private Guna.UI.WinForms.GunaShadowPanel gunaShadowPanel1;
        private Guna.UI.WinForms.GunaLabel lbTenSanPham;
    }
}
