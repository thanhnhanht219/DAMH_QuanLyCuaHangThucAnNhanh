namespace GUI
{
    partial class frmPhanQuyen
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
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.stripThemNhom = new System.Windows.Forms.ToolStripButton();
            this.stripXoaNhom = new System.Windows.Forms.ToolStripButton();
            this.stripSuaNhom = new System.Windows.Forms.ToolStripButton();
            this.stripLuu = new System.Windows.Forms.ToolStripButton();
            this.stripDong = new System.Windows.Forms.ToolStripButton();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.groupten = new System.Windows.Forms.GroupBox();
            this.txtTenNhom = new Guna.UI2.WinForms.Guna2TextBox();
            this.groupma = new System.Windows.Forms.GroupBox();
            this.txtMaNhom = new Guna.UI2.WinForms.Guna2TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.gvManHinh = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grdNhom = new System.Windows.Forms.DataGridView();
            this.toolStrip1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.groupten.SuspendLayout();
            this.groupma.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvManHinh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdNhom)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stripThemNhom,
            this.stripXoaNhom,
            this.stripSuaNhom,
            this.stripLuu,
            this.stripDong});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(898, 32);
            this.toolStrip1.TabIndex = 3;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // stripThemNhom
            // 
            this.stripThemNhom.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.stripThemNhom.Name = "stripThemNhom";
            this.stripThemNhom.Size = new System.Drawing.Size(117, 29);
            this.stripThemNhom.Text = "Thêm nhóm";
            this.stripThemNhom.Click += new System.EventHandler(this.stripThemNhom_Click);
            // 
            // stripXoaNhom
            // 
            this.stripXoaNhom.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.stripXoaNhom.Name = "stripXoaNhom";
            this.stripXoaNhom.Size = new System.Drawing.Size(102, 29);
            this.stripXoaNhom.Text = "Xóa nhóm";
            this.stripXoaNhom.Click += new System.EventHandler(this.stripXoaNhom_Click);
            // 
            // stripSuaNhom
            // 
            this.stripSuaNhom.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.stripSuaNhom.Name = "stripSuaNhom";
            this.stripSuaNhom.Size = new System.Drawing.Size(101, 29);
            this.stripSuaNhom.Text = "Sửa nhóm";
            this.stripSuaNhom.Click += new System.EventHandler(this.stripSuaNhom_Click);
            // 
            // stripLuu
            // 
            this.stripLuu.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.stripLuu.Name = "stripLuu";
            this.stripLuu.Size = new System.Drawing.Size(47, 29);
            this.stripLuu.Text = "Lưu";
            this.stripLuu.Click += new System.EventHandler(this.stripLuu_Click);
            // 
            // stripDong
            // 
            this.stripDong.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.stripDong.Name = "stripDong";
            this.stripDong.Size = new System.Drawing.Size(62, 29);
            this.stripDong.Text = "Đóng";
            this.stripDong.Click += new System.EventHandler(this.stripDong_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 98.77232F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 35);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(896, 177);
            this.tableLayoutPanel1.TabIndex = 14;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.groupten, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.groupma, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.panel2, 0, 2);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 48F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(890, 171);
            this.tableLayoutPanel2.TabIndex = 15;
            // 
            // groupten
            // 
            this.groupten.Controls.Add(this.txtTenNhom);
            this.groupten.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupten.Location = new System.Drawing.Point(3, 64);
            this.groupten.Name = "groupten";
            this.groupten.Size = new System.Drawing.Size(884, 55);
            this.groupten.TabIndex = 20;
            this.groupten.TabStop = false;
            this.groupten.Text = "Tên Nhóm";
            // 
            // txtTenNhom
            // 
            this.txtTenNhom.AutoRoundedCorners = true;
            this.txtTenNhom.BorderRadius = 17;
            this.txtTenNhom.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTenNhom.DefaultText = "";
            this.txtTenNhom.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTenNhom.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTenNhom.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTenNhom.DisabledState.Parent = this.txtTenNhom;
            this.txtTenNhom.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTenNhom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtTenNhom.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTenNhom.FocusedState.Parent = this.txtTenNhom;
            this.txtTenNhom.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTenNhom.HoverState.Parent = this.txtTenNhom;
            this.txtTenNhom.Location = new System.Drawing.Point(3, 16);
            this.txtTenNhom.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtTenNhom.Name = "txtTenNhom";
            this.txtTenNhom.PasswordChar = '\0';
            this.txtTenNhom.PlaceholderText = "";
            this.txtTenNhom.SelectedText = "";
            this.txtTenNhom.ShadowDecoration.Parent = this.txtTenNhom;
            this.txtTenNhom.Size = new System.Drawing.Size(878, 36);
            this.txtTenNhom.TabIndex = 18;
            // 
            // groupma
            // 
            this.groupma.Controls.Add(this.txtMaNhom);
            this.groupma.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupma.Location = new System.Drawing.Point(3, 3);
            this.groupma.Name = "groupma";
            this.groupma.Size = new System.Drawing.Size(884, 55);
            this.groupma.TabIndex = 19;
            this.groupma.TabStop = false;
            this.groupma.Text = "Mã Nhóm";
            // 
            // txtMaNhom
            // 
            this.txtMaNhom.AutoRoundedCorners = true;
            this.txtMaNhom.BorderRadius = 17;
            this.txtMaNhom.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMaNhom.DefaultText = "";
            this.txtMaNhom.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtMaNhom.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtMaNhom.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMaNhom.DisabledState.Parent = this.txtMaNhom;
            this.txtMaNhom.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMaNhom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtMaNhom.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMaNhom.FocusedState.Parent = this.txtMaNhom;
            this.txtMaNhom.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMaNhom.HoverState.Parent = this.txtMaNhom;
            this.txtMaNhom.Location = new System.Drawing.Point(3, 16);
            this.txtMaNhom.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtMaNhom.Name = "txtMaNhom";
            this.txtMaNhom.PasswordChar = '\0';
            this.txtMaNhom.PlaceholderText = "";
            this.txtMaNhom.SelectedText = "";
            this.txtMaNhom.ShadowDecoration.Parent = this.txtMaNhom;
            this.txtMaNhom.Size = new System.Drawing.Size(878, 36);
            this.txtMaNhom.TabIndex = 17;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.tableLayoutPanel4);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 125);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(884, 43);
            this.panel2.TabIndex = 21;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Controls.Add(this.panel3, 1, 0);
            this.tableLayoutPanel4.Controls.Add(this.panel4, 0, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(884, 43);
            this.tableLayoutPanel4.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label2);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(445, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(436, 37);
            this.panel3.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(145, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Danh Sách Màn Hình";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.label1);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(3, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(436, 37);
            this.panel4.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(162, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Danh Sách Nhóm";
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.panel1, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.grdNhom, 0, 0);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 215);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(894, 265);
            this.tableLayoutPanel3.TabIndex = 15;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.gvManHinh);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(450, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(441, 259);
            this.panel1.TabIndex = 15;
            // 
            // gvManHinh
            // 
            this.gvManHinh.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gvManHinh.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvManHinh.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column5,
            this.Column4,
            this.Column3,
            this.Column2});
            this.gvManHinh.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gvManHinh.Location = new System.Drawing.Point(0, 0);
            this.gvManHinh.Name = "gvManHinh";
            this.gvManHinh.Size = new System.Drawing.Size(441, 259);
            this.gvManHinh.TabIndex = 17;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "QL_ManHinh";
            this.Column1.HeaderText = "QL_ManHinh";
            this.Column1.Name = "Column1";
            this.Column1.Visible = false;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "TenManHinh";
            this.Column5.HeaderText = "Tên Màn Hình";
            this.Column5.Name = "Column5";
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "MaNhom";
            this.Column4.HeaderText = "MaNhom";
            this.Column4.Name = "Column4";
            this.Column4.Visible = false;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "CoQuyen";
            this.Column3.HeaderText = "CoQuyen";
            this.Column3.Name = "Column3";
            this.Column3.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "QL_NhomNguoiDung";
            this.Column2.HeaderText = "QL_NhomNguoIDung";
            this.Column2.Name = "Column2";
            this.Column2.Visible = false;
            // 
            // grdNhom
            // 
            this.grdNhom.AllowUserToAddRows = false;
            this.grdNhom.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grdNhom.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdNhom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdNhom.Location = new System.Drawing.Point(2, 2);
            this.grdNhom.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grdNhom.MultiSelect = false;
            this.grdNhom.Name = "grdNhom";
            this.grdNhom.RowTemplate.Height = 24;
            this.grdNhom.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdNhom.Size = new System.Drawing.Size(443, 261);
            this.grdNhom.TabIndex = 18;
            this.grdNhom.SelectionChanged += new System.EventHandler(this.grdNhom_SelectionChanged);
            // 
            // frmPhanQuyen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(898, 480);
            this.Controls.Add(this.tableLayoutPanel3);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.toolStrip1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmPhanQuyen";
            this.Text = "Phân quyền";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmPhanQuyen_FormClosing);
            this.Load += new System.EventHandler(this.frmPhanQuyen_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.groupten.ResumeLayout(false);
            this.groupma.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gvManHinh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdNhom)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton stripLuu;
        private System.Windows.Forms.ToolStripButton stripDong;
        private System.Windows.Forms.ToolStripButton stripThemNhom;
        private System.Windows.Forms.ToolStripButton stripXoaNhom;
        private System.Windows.Forms.ToolStripButton stripSuaNhom;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.GroupBox groupten;
        private Guna.UI2.WinForms.Guna2TextBox txtTenNhom;
        private System.Windows.Forms.GroupBox groupma;
        private Guna.UI2.WinForms.Guna2TextBox txtMaNhom;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView gvManHinh;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView grdNhom;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
    }
}