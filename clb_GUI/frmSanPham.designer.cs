namespace GUI
{
    partial class frmSanPham
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSanPham));
            this.gvNL_SP = new System.Windows.Forms.DataGridView();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnControlSP = new System.Windows.Forms.Panel();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.txtGia = new Guna.UI2.WinForms.Guna2TextBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.btnChonHinh = new Guna.UI2.WinForms.Guna2Button();
            this.pcSp = new System.Windows.Forms.PictureBox();
            this.groupMaLoai = new System.Windows.Forms.GroupBox();
            this.cbMaLoai = new Guna.UI2.WinForms.Guna2ComboBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cbTinhTrang = new Guna.UI2.WinForms.Guna2ComboBox();
            this.gbTen = new System.Windows.Forms.GroupBox();
            this.txtTen = new Guna.UI2.WinForms.Guna2TextBox();
            this.gbMSP = new System.Windows.Forms.GroupBox();
            this.txtMa = new Guna.UI2.WinForms.Guna2TextBox();
            this.gvNguyenLieu = new System.Windows.Forms.DataGridView();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnThemNL = new Guna.UI.WinForms.GunaAdvenceButton();
            this.btnXoaNL = new Guna.UI.WinForms.GunaAdvenceButton();
            this.btnThemSP = new System.Windows.Forms.ToolStrip();
            this.btnspace = new System.Windows.Forms.ToolStripButton();
            this.btnThem = new System.Windows.Forms.ToolStripButton();
            this.btnXoa = new System.Windows.Forms.ToolStripButton();
            this.btnSua = new System.Windows.Forms.ToolStripButton();
            this.btnLuu = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnThoat = new System.Windows.Forms.ToolStripButton();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.txtTimSP = new Guna.UI2.WinForms.Guna2TextBox();
            this.gunaCircleButton2 = new Guna.UI.WinForms.GunaCircleButton();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.txtTimNL = new Guna.UI2.WinForms.Guna2TextBox();
            this.gunaCircleButton1 = new Guna.UI.WinForms.GunaCircleButton();
            this.gvSanPham = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenSanPham = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TinhTrang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Hinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LoaiSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnLamMoi = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.gvNL_SP)).BeginInit();
            this.pnControlSP.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcSp)).BeginInit();
            this.groupMaLoai.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.gbTen.SuspendLayout();
            this.gbMSP.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvNguyenLieu)).BeginInit();
            this.btnThemSP.SuspendLayout();
            this.guna2Panel1.SuspendLayout();
            this.guna2Panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvSanPham)).BeginInit();
            this.SuspendLayout();
            // 
            // gvNL_SP
            // 
            this.gvNL_SP.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gvNL_SP.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gvNL_SP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvNL_SP.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column5,
            this.Column6});
            this.gvNL_SP.Location = new System.Drawing.Point(347, 293);
            this.gvNL_SP.Name = "gvNL_SP";
            this.gvNL_SP.Size = new System.Drawing.Size(323, 259);
            this.gvNL_SP.TabIndex = 1;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "QL_SanPham";
            this.Column5.HeaderText = "QL_SanPham";
            this.Column5.Name = "Column5";
            this.Column5.Visible = false;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "QL_NguyenLieu";
            this.Column6.HeaderText = "QL_NguyenLieu";
            this.Column6.Name = "Column6";
            this.Column6.Visible = false;
            // 
            // pnControlSP
            // 
            this.pnControlSP.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pnControlSP.Controls.Add(this.groupBox5);
            this.pnControlSP.Controls.Add(this.groupBox6);
            this.pnControlSP.Controls.Add(this.groupMaLoai);
            this.pnControlSP.Controls.Add(this.groupBox3);
            this.pnControlSP.Controls.Add(this.gbTen);
            this.pnControlSP.Controls.Add(this.gbMSP);
            this.pnControlSP.Location = new System.Drawing.Point(347, 28);
            this.pnControlSP.Name = "pnControlSP";
            this.pnControlSP.Size = new System.Drawing.Size(776, 217);
            this.pnControlSP.TabIndex = 3;
            // 
            // groupBox5
            // 
            this.groupBox5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox5.Controls.Add(this.txtGia);
            this.groupBox5.Location = new System.Drawing.Point(397, 69);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(376, 57);
            this.groupBox5.TabIndex = 4;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Giá";
            // 
            // txtGia
            // 
            this.txtGia.Animated = true;
            this.txtGia.AutoRoundedCorners = true;
            this.txtGia.BorderRadius = 18;
            this.txtGia.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtGia.DefaultText = "";
            this.txtGia.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtGia.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtGia.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtGia.DisabledState.Parent = this.txtGia;
            this.txtGia.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtGia.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtGia.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtGia.FocusedState.Parent = this.txtGia;
            this.txtGia.ForeColor = System.Drawing.Color.Black;
            this.txtGia.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtGia.HoverState.Parent = this.txtGia;
            this.txtGia.Location = new System.Drawing.Point(3, 16);
            this.txtGia.Name = "txtGia";
            this.txtGia.PasswordChar = '\0';
            this.txtGia.PlaceholderText = "";
            this.txtGia.SelectedText = "";
            this.txtGia.ShadowDecoration.Parent = this.txtGia;
            this.txtGia.Size = new System.Drawing.Size(370, 38);
            this.txtGia.TabIndex = 1;
            // 
            // groupBox6
            // 
            this.groupBox6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox6.Controls.Add(this.btnChonHinh);
            this.groupBox6.Controls.Add(this.pcSp);
            this.groupBox6.Location = new System.Drawing.Point(397, 132);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(376, 82);
            this.groupBox6.TabIndex = 5;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Hình";
            // 
            // btnChonHinh
            // 
            this.btnChonHinh.Animated = true;
            this.btnChonHinh.AutoRoundedCorners = true;
            this.btnChonHinh.BorderRadius = 27;
            this.btnChonHinh.CheckedState.Parent = this.btnChonHinh;
            this.btnChonHinh.CustomImages.Parent = this.btnChonHinh;
            this.btnChonHinh.FillColor = System.Drawing.Color.Tomato;
            this.btnChonHinh.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnChonHinh.ForeColor = System.Drawing.Color.White;
            this.btnChonHinh.HoverState.Parent = this.btnChonHinh;
            this.btnChonHinh.Location = new System.Drawing.Point(170, 16);
            this.btnChonHinh.Name = "btnChonHinh";
            this.btnChonHinh.ShadowDecoration.Parent = this.btnChonHinh;
            this.btnChonHinh.Size = new System.Drawing.Size(60, 57);
            this.btnChonHinh.TabIndex = 1;
            this.btnChonHinh.Text = "Chọn Hình";
            this.btnChonHinh.Click += new System.EventHandler(this.btnChonHinh_Click);
            // 
            // pcSp
            // 
            this.pcSp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pcSp.Location = new System.Drawing.Point(55, 10);
            this.pcSp.Name = "pcSp";
            this.pcSp.Size = new System.Drawing.Size(109, 66);
            this.pcSp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcSp.TabIndex = 0;
            this.pcSp.TabStop = false;
            // 
            // groupMaLoai
            // 
            this.groupMaLoai.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupMaLoai.Controls.Add(this.cbMaLoai);
            this.groupMaLoai.Location = new System.Drawing.Point(397, 3);
            this.groupMaLoai.Name = "groupMaLoai";
            this.groupMaLoai.Size = new System.Drawing.Size(376, 60);
            this.groupMaLoai.TabIndex = 3;
            this.groupMaLoai.TabStop = false;
            this.groupMaLoai.Text = "Mã Loại";
            // 
            // cbMaLoai
            // 
            this.cbMaLoai.Animated = true;
            this.cbMaLoai.AutoRoundedCorners = true;
            this.cbMaLoai.BackColor = System.Drawing.Color.Transparent;
            this.cbMaLoai.BorderRadius = 17;
            this.cbMaLoai.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbMaLoai.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbMaLoai.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMaLoai.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbMaLoai.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbMaLoai.FocusedState.Parent = this.cbMaLoai;
            this.cbMaLoai.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbMaLoai.ForeColor = System.Drawing.Color.Black;
            this.cbMaLoai.HoverState.Parent = this.cbMaLoai;
            this.cbMaLoai.ItemHeight = 30;
            this.cbMaLoai.ItemsAppearance.Parent = this.cbMaLoai;
            this.cbMaLoai.Location = new System.Drawing.Point(3, 16);
            this.cbMaLoai.Name = "cbMaLoai";
            this.cbMaLoai.ShadowDecoration.Parent = this.cbMaLoai;
            this.cbMaLoai.Size = new System.Drawing.Size(370, 36);
            this.cbMaLoai.TabIndex = 0;
            this.cbMaLoai.SelectedIndexChanged += new System.EventHandler(this.cbMaLoai_SelectedIndexChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.cbTinhTrang);
            this.groupBox3.Location = new System.Drawing.Point(4, 132);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(376, 82);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Tình Trạng";
            // 
            // cbTinhTrang
            // 
            this.cbTinhTrang.Animated = true;
            this.cbTinhTrang.AutoRoundedCorners = true;
            this.cbTinhTrang.BackColor = System.Drawing.Color.Transparent;
            this.cbTinhTrang.BorderRadius = 17;
            this.cbTinhTrang.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbTinhTrang.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbTinhTrang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTinhTrang.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbTinhTrang.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbTinhTrang.FocusedState.Parent = this.cbTinhTrang;
            this.cbTinhTrang.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbTinhTrang.ForeColor = System.Drawing.Color.Black;
            this.cbTinhTrang.HoverState.Parent = this.cbTinhTrang;
            this.cbTinhTrang.ItemHeight = 30;
            this.cbTinhTrang.Items.AddRange(new object[] {
            "Bán",
            "Ngưng Bán"});
            this.cbTinhTrang.ItemsAppearance.Parent = this.cbTinhTrang;
            this.cbTinhTrang.Location = new System.Drawing.Point(3, 16);
            this.cbTinhTrang.Name = "cbTinhTrang";
            this.cbTinhTrang.ShadowDecoration.Parent = this.cbTinhTrang;
            this.cbTinhTrang.Size = new System.Drawing.Size(370, 36);
            this.cbTinhTrang.StartIndex = 0;
            this.cbTinhTrang.TabIndex = 1;
            // 
            // gbTen
            // 
            this.gbTen.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbTen.Controls.Add(this.txtTen);
            this.gbTen.Location = new System.Drawing.Point(4, 69);
            this.gbTen.Name = "gbTen";
            this.gbTen.Size = new System.Drawing.Size(376, 57);
            this.gbTen.TabIndex = 1;
            this.gbTen.TabStop = false;
            this.gbTen.Text = "Tên Sản Phẩm";
            // 
            // txtTen
            // 
            this.txtTen.Animated = true;
            this.txtTen.AutoRoundedCorners = true;
            this.txtTen.BorderRadius = 18;
            this.txtTen.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTen.DefaultText = "";
            this.txtTen.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTen.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTen.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTen.DisabledState.Parent = this.txtTen;
            this.txtTen.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtTen.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTen.FocusedState.Parent = this.txtTen;
            this.txtTen.ForeColor = System.Drawing.Color.Black;
            this.txtTen.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTen.HoverState.Parent = this.txtTen;
            this.txtTen.Location = new System.Drawing.Point(3, 16);
            this.txtTen.Name = "txtTen";
            this.txtTen.PasswordChar = '\0';
            this.txtTen.PlaceholderText = "";
            this.txtTen.SelectedText = "";
            this.txtTen.ShadowDecoration.Parent = this.txtTen;
            this.txtTen.Size = new System.Drawing.Size(370, 38);
            this.txtTen.TabIndex = 1;
            // 
            // gbMSP
            // 
            this.gbMSP.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbMSP.Controls.Add(this.txtMa);
            this.gbMSP.Location = new System.Drawing.Point(4, 3);
            this.gbMSP.Name = "gbMSP";
            this.gbMSP.Size = new System.Drawing.Size(376, 60);
            this.gbMSP.TabIndex = 0;
            this.gbMSP.TabStop = false;
            this.gbMSP.Text = "Mã Sản Phẩm";
            this.gbMSP.Enter += new System.EventHandler(this.gbMSP_Enter);
            // 
            // txtMa
            // 
            this.txtMa.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMa.AutoRoundedCorners = true;
            this.txtMa.BorderRadius = 17;
            this.txtMa.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMa.DefaultText = "";
            this.txtMa.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtMa.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtMa.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMa.DisabledState.Parent = this.txtMa;
            this.txtMa.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMa.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMa.FocusedState.Parent = this.txtMa;
            this.txtMa.ForeColor = System.Drawing.Color.Black;
            this.txtMa.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMa.HoverState.Parent = this.txtMa;
            this.txtMa.Location = new System.Drawing.Point(6, 16);
            this.txtMa.Name = "txtMa";
            this.txtMa.PasswordChar = '\0';
            this.txtMa.PlaceholderText = "";
            this.txtMa.SelectedText = "";
            this.txtMa.ShadowDecoration.Parent = this.txtMa;
            this.txtMa.Size = new System.Drawing.Size(367, 36);
            this.txtMa.TabIndex = 0;
            // 
            // gvNguyenLieu
            // 
            this.gvNguyenLieu.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gvNguyenLieu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvNguyenLieu.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column7,
            this.Column8,
            this.Column9,
            this.Column10});
            this.gvNguyenLieu.Location = new System.Drawing.Point(811, 293);
            this.gvNguyenLieu.Name = "gvNguyenLieu";
            this.gvNguyenLieu.ReadOnly = true;
            this.gvNguyenLieu.Size = new System.Drawing.Size(312, 259);
            this.gvNguyenLieu.TabIndex = 4;
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "SoLuong";
            this.Column7.HeaderText = "SoLuong";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            this.Column7.Visible = false;
            // 
            // Column8
            // 
            this.Column8.DataPropertyName = "ThoiHan";
            this.Column8.HeaderText = "ThoiHan";
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            this.Column8.Visible = false;
            // 
            // Column9
            // 
            this.Column9.DataPropertyName = "QL_LoaiNguyenLieu";
            this.Column9.HeaderText = "QL_LoaiNguyenLieu";
            this.Column9.Name = "Column9";
            this.Column9.ReadOnly = true;
            this.Column9.Visible = false;
            // 
            // Column10
            // 
            this.Column10.DataPropertyName = "maLOAINL";
            this.Column10.HeaderText = "MALOAINL";
            this.Column10.Name = "Column10";
            this.Column10.ReadOnly = true;
            this.Column10.Visible = false;
            // 
            // btnThemNL
            // 
            this.btnThemNL.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnThemNL.AnimationHoverSpeed = 0.07F;
            this.btnThemNL.AnimationSpeed = 0.03F;
            this.btnThemNL.BaseColor = System.Drawing.Color.Tomato;
            this.btnThemNL.BorderColor = System.Drawing.Color.Black;
            this.btnThemNL.BorderSize = 2;
            this.btnThemNL.CheckedBaseColor = System.Drawing.Color.Gray;
            this.btnThemNL.CheckedBorderColor = System.Drawing.Color.Black;
            this.btnThemNL.CheckedForeColor = System.Drawing.Color.White;
            this.btnThemNL.CheckedImage = ((System.Drawing.Image)(resources.GetObject("btnThemNL.CheckedImage")));
            this.btnThemNL.CheckedLineColor = System.Drawing.Color.DimGray;
            this.btnThemNL.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnThemNL.FocusedColor = System.Drawing.Color.Empty;
            this.btnThemNL.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnThemNL.ForeColor = System.Drawing.Color.White;
            this.btnThemNL.Image = ((System.Drawing.Image)(resources.GetObject("btnThemNL.Image")));
            this.btnThemNL.ImageSize = new System.Drawing.Size(50, 50);
            this.btnThemNL.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnThemNL.Location = new System.Drawing.Point(676, 370);
            this.btnThemNL.Name = "btnThemNL";
            this.btnThemNL.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnThemNL.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnThemNL.OnHoverForeColor = System.Drawing.Color.White;
            this.btnThemNL.OnHoverImage = null;
            this.btnThemNL.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnThemNL.OnPressedColor = System.Drawing.Color.Black;
            this.btnThemNL.Size = new System.Drawing.Size(129, 40);
            this.btnThemNL.TabIndex = 5;
            this.btnThemNL.Text = "Thêm NL";
            this.btnThemNL.Click += new System.EventHandler(this.btnThemNL_Click);
            // 
            // btnXoaNL
            // 
            this.btnXoaNL.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnXoaNL.AnimationHoverSpeed = 0.07F;
            this.btnXoaNL.AnimationSpeed = 0.03F;
            this.btnXoaNL.BaseColor = System.Drawing.Color.Tomato;
            this.btnXoaNL.BorderColor = System.Drawing.Color.Black;
            this.btnXoaNL.BorderSize = 2;
            this.btnXoaNL.CheckedBaseColor = System.Drawing.Color.Gray;
            this.btnXoaNL.CheckedBorderColor = System.Drawing.Color.Black;
            this.btnXoaNL.CheckedForeColor = System.Drawing.Color.White;
            this.btnXoaNL.CheckedImage = ((System.Drawing.Image)(resources.GetObject("btnXoaNL.CheckedImage")));
            this.btnXoaNL.CheckedLineColor = System.Drawing.Color.DimGray;
            this.btnXoaNL.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnXoaNL.FocusedColor = System.Drawing.Color.Empty;
            this.btnXoaNL.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoaNL.ForeColor = System.Drawing.Color.White;
            this.btnXoaNL.Image = ((System.Drawing.Image)(resources.GetObject("btnXoaNL.Image")));
            this.btnXoaNL.ImageSize = new System.Drawing.Size(50, 50);
            this.btnXoaNL.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnXoaNL.Location = new System.Drawing.Point(676, 435);
            this.btnXoaNL.Name = "btnXoaNL";
            this.btnXoaNL.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnXoaNL.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnXoaNL.OnHoverForeColor = System.Drawing.Color.White;
            this.btnXoaNL.OnHoverImage = null;
            this.btnXoaNL.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnXoaNL.OnPressedColor = System.Drawing.Color.Black;
            this.btnXoaNL.Size = new System.Drawing.Size(129, 40);
            this.btnXoaNL.TabIndex = 6;
            this.btnXoaNL.Text = "Xóa NL";
            this.btnXoaNL.Click += new System.EventHandler(this.btnXoaNL_Click);
            // 
            // btnThemSP
            // 
            this.btnThemSP.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemSP.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnspace,
            this.btnThem,
            this.btnXoa,
            this.btnSua,
            this.btnLuu,
            this.toolStripSeparator1,
            this.btnLamMoi,
            this.btnThoat});
            this.btnThemSP.Location = new System.Drawing.Point(0, 0);
            this.btnThemSP.Name = "btnThemSP";
            this.btnThemSP.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnThemSP.Size = new System.Drawing.Size(1135, 27);
            this.btnThemSP.TabIndex = 7;
            this.btnThemSP.Text = "Thêm";
            // 
            // btnspace
            // 
            this.btnspace.AutoSize = false;
            this.btnspace.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.None;
            this.btnspace.Enabled = false;
            this.btnspace.Image = ((System.Drawing.Image)(resources.GetObject("btnspace.Image")));
            this.btnspace.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnspace.Name = "btnspace";
            this.btnspace.Size = new System.Drawing.Size(335, 24);
            this.btnspace.Text = "toolStripButton2";
            // 
            // btnThem
            // 
            this.btnThem.Image = ((System.Drawing.Image)(resources.GetObject("btnThem.Image")));
            this.btnThem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(66, 24);
            this.btnThem.Text = "Thêm";
            this.btnThem.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Image = ((System.Drawing.Image)(resources.GetObject("btnXoa.Image")));
            this.btnXoa.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(55, 24);
            this.btnXoa.Text = "Xóa";
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.Image = ((System.Drawing.Image)(resources.GetObject("btnSua.Image")));
            this.btnSua.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(54, 24);
            this.btnSua.Text = "Sửa";
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Image = ((System.Drawing.Image)(resources.GetObject("btnLuu.Image")));
            this.btnLuu.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(53, 24);
            this.btnLuu.Text = "Lưu";
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // btnThoat
            // 
            this.btnThoat.Image = ((System.Drawing.Image)(resources.GetObject("btnThoat.Image")));
            this.btnThoat.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(67, 24);
            this.btnThoat.Text = "Thoát";
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2Panel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2Panel1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(178)))), ((int)(((byte)(178)))));
            this.guna2Panel1.BorderRadius = 20;
            this.guna2Panel1.BorderThickness = 1;
            this.guna2Panel1.Controls.Add(this.txtTimSP);
            this.guna2Panel1.Controls.Add(this.gunaCircleButton2);
            this.guna2Panel1.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(178)))), ((int)(((byte)(178)))));
            this.guna2Panel1.FillColor = System.Drawing.Color.White;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 31);
            this.guna2Panel1.Margin = new System.Windows.Forms.Padding(2);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.ShadowDecoration.Color = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(178)))), ((int)(((byte)(178)))));
            this.guna2Panel1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2Panel1.ShadowDecoration.Parent = this.guna2Panel1;
            this.guna2Panel1.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(0, 0, 5, 5);
            this.guna2Panel1.Size = new System.Drawing.Size(341, 43);
            this.guna2Panel1.TabIndex = 9;
            this.guna2Panel1.UseTransparentBackground = true;
            // 
            // txtTimSP
            // 
            this.txtTimSP.BorderColor = System.Drawing.Color.White;
            this.txtTimSP.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTimSP.DefaultText = "";
            this.txtTimSP.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTimSP.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTimSP.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTimSP.DisabledState.Parent = this.txtTimSP;
            this.txtTimSP.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTimSP.FocusedState.BorderColor = System.Drawing.Color.White;
            this.txtTimSP.FocusedState.Parent = this.txtTimSP;
            this.txtTimSP.HoverState.BorderColor = System.Drawing.Color.White;
            this.txtTimSP.HoverState.Parent = this.txtTimSP;
            this.txtTimSP.Location = new System.Drawing.Point(47, 3);
            this.txtTimSP.Name = "txtTimSP";
            this.txtTimSP.PasswordChar = '\0';
            this.txtTimSP.PlaceholderText = "Nhập Sản phẩm cần tìm";
            this.txtTimSP.SelectedText = "";
            this.txtTimSP.ShadowDecoration.Parent = this.txtTimSP;
            this.txtTimSP.Size = new System.Drawing.Size(265, 36);
            this.txtTimSP.TabIndex = 1;
            // 
            // gunaCircleButton2
            // 
            this.gunaCircleButton2.Animated = true;
            this.gunaCircleButton2.AnimationHoverSpeed = 0.07F;
            this.gunaCircleButton2.AnimationSpeed = 0.03F;
            this.gunaCircleButton2.BaseColor = System.Drawing.Color.White;
            this.gunaCircleButton2.BorderColor = System.Drawing.Color.Black;
            this.gunaCircleButton2.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaCircleButton2.FocusedColor = System.Drawing.Color.Empty;
            this.gunaCircleButton2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaCircleButton2.ForeColor = System.Drawing.Color.White;
            this.gunaCircleButton2.Image = ((System.Drawing.Image)(resources.GetObject("gunaCircleButton2.Image")));
            this.gunaCircleButton2.ImageSize = new System.Drawing.Size(22, 22);
            this.gunaCircleButton2.Location = new System.Drawing.Point(8, 2);
            this.gunaCircleButton2.Margin = new System.Windows.Forms.Padding(2);
            this.gunaCircleButton2.Name = "gunaCircleButton2";
            this.gunaCircleButton2.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.gunaCircleButton2.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaCircleButton2.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaCircleButton2.OnHoverImage = null;
            this.gunaCircleButton2.OnPressedColor = System.Drawing.Color.Black;
            this.gunaCircleButton2.Size = new System.Drawing.Size(34, 37);
            this.gunaCircleButton2.TabIndex = 0;
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2Panel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2Panel2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(178)))), ((int)(((byte)(178)))));
            this.guna2Panel2.BorderRadius = 20;
            this.guna2Panel2.BorderThickness = 1;
            this.guna2Panel2.Controls.Add(this.txtTimNL);
            this.guna2Panel2.Controls.Add(this.gunaCircleButton1);
            this.guna2Panel2.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(178)))), ((int)(((byte)(178)))));
            this.guna2Panel2.FillColor = System.Drawing.Color.White;
            this.guna2Panel2.Location = new System.Drawing.Point(812, 247);
            this.guna2Panel2.Margin = new System.Windows.Forms.Padding(2);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.ShadowDecoration.Color = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(178)))), ((int)(((byte)(178)))));
            this.guna2Panel2.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2Panel2.ShadowDecoration.Parent = this.guna2Panel2;
            this.guna2Panel2.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(0, 0, 5, 5);
            this.guna2Panel2.Size = new System.Drawing.Size(309, 43);
            this.guna2Panel2.TabIndex = 10;
            this.guna2Panel2.UseTransparentBackground = true;
            // 
            // txtTimNL
            // 
            this.txtTimNL.BorderColor = System.Drawing.Color.White;
            this.txtTimNL.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTimNL.DefaultText = "";
            this.txtTimNL.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTimNL.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTimNL.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTimNL.DisabledState.Parent = this.txtTimNL;
            this.txtTimNL.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTimNL.FocusedState.BorderColor = System.Drawing.Color.White;
            this.txtTimNL.FocusedState.Parent = this.txtTimNL;
            this.txtTimNL.ForeColor = System.Drawing.Color.Black;
            this.txtTimNL.HoverState.BorderColor = System.Drawing.Color.White;
            this.txtTimNL.HoverState.Parent = this.txtTimNL;
            this.txtTimNL.Location = new System.Drawing.Point(47, 3);
            this.txtTimNL.Name = "txtTimNL";
            this.txtTimNL.PasswordChar = '\0';
            this.txtTimNL.PlaceholderText = "Nhập nguyên liệu cần tìm";
            this.txtTimNL.SelectedText = "";
            this.txtTimNL.ShadowDecoration.Parent = this.txtTimNL;
            this.txtTimNL.Size = new System.Drawing.Size(236, 37);
            this.txtTimNL.TabIndex = 1;
            this.txtTimNL.TextChanged += new System.EventHandler(this.txtTimNL_TextChanged);
            // 
            // gunaCircleButton1
            // 
            this.gunaCircleButton1.Animated = true;
            this.gunaCircleButton1.AnimationHoverSpeed = 0.07F;
            this.gunaCircleButton1.AnimationSpeed = 0.03F;
            this.gunaCircleButton1.BaseColor = System.Drawing.Color.White;
            this.gunaCircleButton1.BorderColor = System.Drawing.Color.Black;
            this.gunaCircleButton1.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaCircleButton1.FocusedColor = System.Drawing.Color.Empty;
            this.gunaCircleButton1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaCircleButton1.ForeColor = System.Drawing.Color.White;
            this.gunaCircleButton1.Image = ((System.Drawing.Image)(resources.GetObject("gunaCircleButton1.Image")));
            this.gunaCircleButton1.ImageSize = new System.Drawing.Size(22, 22);
            this.gunaCircleButton1.Location = new System.Drawing.Point(8, 2);
            this.gunaCircleButton1.Margin = new System.Windows.Forms.Padding(2);
            this.gunaCircleButton1.Name = "gunaCircleButton1";
            this.gunaCircleButton1.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.gunaCircleButton1.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaCircleButton1.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaCircleButton1.OnHoverImage = null;
            this.gunaCircleButton1.OnPressedColor = System.Drawing.Color.Black;
            this.gunaCircleButton1.Size = new System.Drawing.Size(34, 37);
            this.gunaCircleButton1.TabIndex = 0;
            // 
            // gvSanPham
            // 
            this.gvSanPham.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gvSanPham.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gvSanPham.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvSanPham.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.TenSanPham,
            this.TinhTrang,
            this.Hinh,
            this.LoaiSP,
            this.Column2,
            this.Column3,
            this.Column4});
            this.gvSanPham.Location = new System.Drawing.Point(0, 75);
            this.gvSanPham.Name = "gvSanPham";
            this.gvSanPham.ReadOnly = true;
            this.gvSanPham.Size = new System.Drawing.Size(341, 477);
            this.gvSanPham.TabIndex = 11;
            this.gvSanPham.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvSanPham_CellClick);
            this.gvSanPham.SelectionChanged += new System.EventHandler(this.gvSanPham_SelectionChanged);
            this.gvSanPham.Click += new System.EventHandler(this.gvSanPham_Click);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "MaSP";
            this.Column1.HeaderText = "Mã SP";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // TenSanPham
            // 
            this.TenSanPham.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TenSanPham.DataPropertyName = "TenSanPham";
            this.TenSanPham.HeaderText = "Tên Sản Phẩm";
            this.TenSanPham.Name = "TenSanPham";
            this.TenSanPham.ReadOnly = true;
            // 
            // TinhTrang
            // 
            this.TinhTrang.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.TinhTrang.DataPropertyName = "TinhTrang";
            this.TinhTrang.HeaderText = "Tình Trạng";
            this.TinhTrang.Name = "TinhTrang";
            this.TinhTrang.ReadOnly = true;
            this.TinhTrang.Width = 80;
            // 
            // Hinh
            // 
            this.Hinh.DataPropertyName = "Hinh";
            this.Hinh.HeaderText = "Hình";
            this.Hinh.Name = "Hinh";
            this.Hinh.ReadOnly = true;
            // 
            // LoaiSP
            // 
            this.LoaiSP.DataPropertyName = "TenLoai";
            this.LoaiSP.HeaderText = "Loại";
            this.LoaiSP.Name = "LoaiSP";
            this.LoaiSP.ReadOnly = true;
            this.LoaiSP.Visible = false;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "Gia";
            this.Column2.HeaderText = "Giá";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "QL_LoaiSanPham";
            this.Column3.HeaderText = "QLLoaiSP";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Visible = false;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "MaLoaiSP";
            this.Column4.HeaderText = "MaLoai";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Visible = false;
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.Image = ((System.Drawing.Image)(resources.GetObject("btnLamMoi.Image")));
            this.btnLamMoi.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(87, 24);
            this.btnLamMoi.Text = "Làm Mới";
            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);
            // 
            // frmSanPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1135, 564);
            this.Controls.Add(this.gvSanPham);
            this.Controls.Add(this.guna2Panel2);
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.btnThemSP);
            this.Controls.Add(this.btnXoaNL);
            this.Controls.Add(this.btnThemNL);
            this.Controls.Add(this.gvNguyenLieu);
            this.Controls.Add(this.pnControlSP);
            this.Controls.Add(this.gvNL_SP);
            this.Name = "frmSanPham";
            this.Text = "frmSanPham";
            this.Resize += new System.EventHandler(this.frmSanPham_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.gvNL_SP)).EndInit();
            this.pnControlSP.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pcSp)).EndInit();
            this.groupMaLoai.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.gbTen.ResumeLayout(false);
            this.gbMSP.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gvNguyenLieu)).EndInit();
            this.btnThemSP.ResumeLayout(false);
            this.btnThemSP.PerformLayout();
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gvSanPham)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gvNL_SP;
        private System.Windows.Forms.Panel pnControlSP;
        private System.Windows.Forms.DataGridView gvNguyenLieu;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.GroupBox groupMaLoai;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox gbTen;
        private System.Windows.Forms.GroupBox gbMSP;
        private Guna.UI.WinForms.GunaAdvenceButton btnThemNL;
        private Guna.UI.WinForms.GunaAdvenceButton btnXoaNL;
        private System.Windows.Forms.ToolStrip btnThemSP;
        private System.Windows.Forms.ToolStripButton btnThem;
        private System.Windows.Forms.ToolStripButton btnXoa;
        private System.Windows.Forms.ToolStripButton btnSua;
        private System.Windows.Forms.ToolStripButton btnLuu;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton btnThoat;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2TextBox txtTimSP;
        private Guna.UI.WinForms.GunaCircleButton gunaCircleButton2;
        private System.Windows.Forms.PictureBox pcSp;
        private Guna.UI2.WinForms.Guna2TextBox txtGia;
        private Guna.UI2.WinForms.Guna2TextBox txtTen;
        private Guna.UI2.WinForms.Guna2TextBox txtMa;
        private Guna.UI2.WinForms.Guna2ComboBox cbMaLoai;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private Guna.UI2.WinForms.Guna2TextBox txtTimNL;
        private Guna.UI.WinForms.GunaCircleButton gunaCircleButton1;
        private System.Windows.Forms.DataGridView gvSanPham;
        private System.Windows.Forms.ToolStripButton btnspace;
        private Guna.UI2.WinForms.Guna2ComboBox cbTinhTrang;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenSanPham;
        private System.Windows.Forms.DataGridViewTextBoxColumn TinhTrang;
        private System.Windows.Forms.DataGridViewTextBoxColumn Hinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn LoaiSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private Guna.UI2.WinForms.Guna2Button btnChonHinh;
        private System.Windows.Forms.ToolStripButton btnLamMoi;
    }
}