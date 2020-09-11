using Guna.UI2.WinForms;
using Guna.UI.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL_DAL;
namespace GUI
{
    public partial class frmMain : Form
    {
        GunaAdvenceButton btn, btnHoaDon, btnNhanVien, btnSanPham,
            btnKhachHang_1, btnNhaCungCap,
            btnSoQui, btnChi, btnThu, btnTongQuan,
            btnLoiNhuan, btnHangHoa, btnDoanhSo,
            btnNguyenLieu,btnDatHang,btnNhapKho;
        List<Control> lstControl;
        Login_BLL_DAL login = new Login_BLL_DAL();
        QL_NhanSu_BLL_DAL ns = new QL_NhanSu_BLL_DAL();

        QL_NguoiDung nd;

        public frmMain()
        {
            InitializeComponent();
            btnFullMenu.Visible = false;
     
        }

        internal void DangNhapNguoiDung(BLL_DAL.QL_NguoiDung nd)
        {
            this.nd = nd;
        }


        private void thietlapThongTin()
        {
            lbTenDN.Text = nd.TenNguoiDung;
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            frmLogin frmLogin = new frmLogin();
            frmLogin.Show();
            this.Close();
        }


        private void btnCollapseMenu_Click(object sender, EventArgs e)
        {
            pnLeft.Width = 45;
            btnFullMenu.Visible = true;
            btnCollapseMenu.Visible = false;
            //btnLogo.Visible = false;
            btnHidePnTaiKhoan.Visible = false;
        }
        private void btnFullMenu_Click(object sender, EventArgs e)
        {
            pnLeft.Width = 250;
            btnCollapseMenu.Visible = true;
            btnFullMenu.Visible = false;
           // btnLogo.Visible = true;
            btnHidePnTaiKhoan.Visible = true;
        }

        private void btnHidePnTaiKhoan_Click(object sender, EventArgs e)
        {
            if (pnSubTaiKhoan.Visible == false)
            {
                pnSubTaiKhoan.Visible = true;
            }
            else
            {
                pnSubTaiKhoan.Visible = false;
            }
           
        }

        private void picTaiKhoan_Click(object sender, EventArgs e)
        {

            if (pnSubTaiKhoan.Visible == false)
            {
                pnSubTaiKhoan.Visible = true;
            }
            else
            {
                pnSubTaiKhoan.Visible = false;
            }
        }

        public GunaAdvenceButton addButton(string text)
        {
            btn = new GunaAdvenceButton()
            {
                Animated = true,
                AnimationHoverSpeed = 0.07F,
                AnimationSpeed = 0.04F,
                BackColor = Color.Empty,
                BaseColor = Color.Empty,
                BorderColor = Color.Empty,
                CheckedBaseColor = Color.White,
                CheckedBorderColor = Color.White,
                CheckedForeColor = Color.White,
                CheckedImage = null,
                CheckedLineColor = Color.FromArgb(249, 130, 68),
                DialogResult = DialogResult.None,
                FocusedColor = Color.Empty,
                Font = new Font("Segoe UI", 11F),
                ForeColor = Color.FromArgb(64,64,64),
                Image = null,
                ImageSize = new Size(20, 20),
                LineBottom = 3,
                LineColor = Color.FromArgb(227, 227, 227),
                Location = new Point(428, 50),
                OnHoverBaseColor = Color.Empty,
                OnHoverBorderColor = Color.Empty,
                OnHoverForeColor = Color.FromArgb(64,64,64),
                OnHoverImage = null,
                OnHoverLineColor = Color.Tomato,
                OnPressedColor = Color.Black,
                Size = new Size(200, 40),
                TabIndex = 11,
                Text = text,
                TextAlign = HorizontalAlignment.Center,
                Dock = DockStyle.Left

        };
            return btn;
        }


        private void btnPOS_Click(object sender, EventArgs e)
        {
            frmPOS frm = new frmPOS(true);
            frm.WindowState = FormWindowState.Maximized;
            frm.DangNhapNguoiDung(nd);
            frm.Show();
            this.Visible = false;
        }

        private void btnQuanLy_Click(object sender, EventArgs e)
        {
            pnTabHoz.Controls.Clear();

            btnHoaDon =  addButton("Hóa đơn");
            btnHoaDon.Click += BtnHoaDon_Click;

            btnNhanVien = addButton("Nhân viên");
            btnNhanVien.Click += BtnNhanVien_Click;
              

            btnSanPham = addButton("Sản phẩm");
            btnSanPham.Click += BtnSanPham_Click;


            btnPhanQuyen = addButton("Phân Quyền");
            btnPhanQuyen.Click += btnPhanQuyen_Click;

            pnTabHoz.Controls.Add(btnPhanQuyen);
            pnTabHoz.Controls.Add(btnHoaDon);
            pnTabHoz.Controls.Add(btnNhanVien);
            pnTabHoz.Controls.Add(btnSanPham);
            

            BtnSanPham_Click(sender, e);

        }

        void btnPhanQuyen_Click(object sender, EventArgs e)
        {
            addFormInPanel(new frmPhanQuyen());
            btnHoaDon.LineColor = Color.FromArgb(227, 227, 227);
            btnNhanVien.LineColor = Color.FromArgb(227, 227, 227);
            btnSanPham.LineColor = Color.FromArgb(227, 227, 227);
            btnPhanQuyen.LineColor = Color.Tomato; 
        }

        private void btnKhachHang_Click(object sender, EventArgs e)
        {
            pnTabHoz.Controls.Clear();

            btnKhachHang_1 = addButton("Khách hàng");
            btnKhachHang_1.Click += BtnKhachHang_1_Click;

            btnNhaCungCap = addButton("Nhà cung cấp");
            btnNhaCungCap.Click += BtnNhaCungCap_Click;

            pnTabHoz.Controls.Add(btnNhaCungCap);
            pnTabHoz.Controls.Add(btnKhachHang_1);

            BtnKhachHang_1_Click(sender, e);
        }

        private void btnTienBac_Click(object sender, EventArgs e)
        {
            pnTabHoz.Controls.Clear();

            btnSoQui = addButton("Sổ quĩ");
            btnSoQui.Click += BtnSoQui_Click;

            btnThu = addButton("Thu");
            btnThu.Click += BtnThu_Click;

            btnChi = addButton("Chi");
            btnChi.Click += BtnChi_Click;

            btnTongQuan = addButton("Tổng quan");
            btnTongQuan.Click += BtnTongQuan_Click;

            pnTabHoz.Controls.Add(btnSoQui);
            pnTabHoz.Controls.Add(btnThu);
            pnTabHoz.Controls.Add(btnChi);
            pnTabHoz.Controls.Add(btnTongQuan);
            BtnTongQuan_Click(sender, e);
        }

        private void btnBaoCao_Click(object sender, EventArgs e)
        {
            pnTabHoz.Controls.Clear();

            btnLoiNhuan = addButton("Thống kê sản phẩm");
            btnLoiNhuan.Click += BtnLoiNhuan_Click;

            btnHangHoa = addButton("Hàng hóa");
            btnHangHoa.Click += BtnHangHoa_Click;

            btnDoanhSo = addButton("Doanh số");
            btnDoanhSo.Click += BtnDoanhSo_Click;

            pnTabHoz.Controls.Add(btnLoiNhuan);
            pnTabHoz.Controls.Add(btnHangHoa);
            pnTabHoz.Controls.Add(btnDoanhSo);

          
            

            
            BtnDoanhSo_Click(sender, e);
        }

        private void btnKho_Click(object sender, EventArgs e)
        {
            pnTabHoz.Controls.Clear();

            btnNguyenLieu = addButton("Nguyên liệu");
            btnNguyenLieu.Click += BtnNguyenLieu_Click;


            btnDatHang = addButton("Đặt hàng");
            btnDatHang.Click += BtnDatHang_Click;

            if(ns.layNhomtheoMa(nd.MaNhom).TenNhom == "Quản Lý")
            {
                btnDatHang.Enabled = true;
                btnNguyenLieu.Enabled = true;
            }
            else
            {
                btnDatHang.Enabled = false;
                btnNguyenLieu.Enabled = false;
            }

            
            btnNhapKho = addButton("Nhập kho");
            btnNhapKho.Click += BtnNhapKho_Click;

            pnTabHoz.Controls.Add(btnNhapKho);
            pnTabHoz.Controls.Add(btnDatHang);
            pnTabHoz.Controls.Add(btnNguyenLieu);

            BtnNguyenLieu_Click(sender, e);
        }

        private Form activieForm = null;
        private void addFormInPanel(Form form)
        {
            if (activieForm != null)
            {
                activieForm.Close();
            }
            activieForm = form;
            form.TopLevel = false;
            form.Dock = DockStyle.Fill;
            this.pnContainer.Controls.Add(form);
            this.pnContainer.Tag = form;
            form.BringToFront();
            form.Show();
        }

        private void BtnHoaDon_Click(object sender, EventArgs e)
        {
            addFormInPanel(new frmHoaDon());
            btnHoaDon.LineColor = Color.Tomato;
            btnNhanVien.LineColor = Color.FromArgb(227, 227, 227);
            btnSanPham.LineColor = Color.FromArgb(227, 227, 227);
        }

        private void BtnNhanVien_Click(object sender, EventArgs e)
        {
            addFormInPanel(new frmPhanNhomNguoiDung());
            btnHoaDon.LineColor = Color.FromArgb(227, 227, 227);
            btnNhanVien.LineColor = Color.Tomato;
            btnSanPham.LineColor = Color.FromArgb(227, 227, 227);
        }

        //private void BtnKho_Click(object sender, EventArgs e)
        //{
        //    addFormInPanel(new frmKho());
        //    btnHoaDon.LineColor = Color.FromArgb(227, 227, 227);
        //    btnNhanVien.LineColor = Color.FromArgb(227, 227, 227);
        //    btnSanPham.LineColor = Color.FromArgb(227, 227, 227);
        //}

        private void BtnSanPham_Click(object sender, EventArgs e)
        {
            addFormInPanel(new frmSanPham());
            btnHoaDon.LineColor = Color.FromArgb(227, 227, 227);
            btnNhanVien.LineColor = Color.FromArgb(227, 227, 227);
            btnSanPham.LineColor = Color.Tomato;
            btnPhanQuyen.LineColor = Color.FromArgb(227, 227, 227);
        }

        private void BtnNhaCungCap_Click(object sender, EventArgs e)
        {
            addFormInPanel(new frmNhaCungCap());
            btnNhaCungCap.LineColor = Color.Tomato;
            btnKhachHang_1.LineColor = Color.FromArgb(227, 227, 227);
        }

        private void BtnKhachHang_1_Click(object sender, EventArgs e)
        {
            addFormInPanel(new frmKhachHang());
            btnNhaCungCap.LineColor = Color.FromArgb(227, 227, 227);
            btnKhachHang_1.LineColor = Color.Tomato;
        }

        private void BtnTongQuan_Click(object sender, EventArgs e)
        {
            
        }

        private void BtnChi_Click(object sender, EventArgs e)
        {
            
        }

        private void BtnThu_Click(object sender, EventArgs e)
        {
        }

        private void BtnSoQui_Click(object sender, EventArgs e)
        {
            
        }

        private void BtnDoanhSo_Click(object sender, EventArgs e)
        {
            
        }

        private void BtnHangHoa_Click(object sender, EventArgs e)
        {
            
        }

        private void BtnLoiNhuan_Click(object sender, EventArgs e)
        {
            addFormInPanel(new frmThongKeSanPham());
        }

        private void BtnNhapKho_Click(object sender, EventArgs e)
        {
            addFormInPanel(new frmPhieuNhanHang());
            btnNguyenLieu.LineColor = Color.FromArgb(227, 227, 227);
            btnDatHang.LineColor = Color.FromArgb(227, 227, 227);
            btnNhapKho.LineColor = Color.Tomato;
        }

        private void BtnDatHang_Click(object sender, EventArgs e)
        {
            addFormInPanel(new frmPhieuDatHang());
            btnNguyenLieu.LineColor = Color.FromArgb(227, 227, 227);
            btnDatHang.LineColor = Color.Tomato;
            btnNhapKho.LineColor = Color.FromArgb(227, 227, 227);
            
        }

        private void BtnNguyenLieu_Click(object sender, EventArgs e)
        {
            addFormInPanel(new frmNguyenLieu());
            btnNguyenLieu.LineColor = Color.Tomato;
            btnDatHang.LineColor = Color.FromArgb(227, 227, 227);
            btnNhapKho.LineColor = Color.FromArgb(227, 227, 227);
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            thietlapThongTin();
            thietlapPhanQuyen();

        }

        private void thietlapPhanQuyen()
        {
            if (nd == null)
                return;
            List<QL_PhanQuyen> lstPQ = login.lstPQ(nd.MaNhom);
            foreach (GunaGradientButton item in pnControlPQ.Controls)
            {
                if (lstPQ.SingleOrDefault(t => t.MaMH == item.Tag.ToString()).CoQuyen == false)
                {
                    item.Enabled = false;
                }
                else
                {
                    item.Enabled = true;
                }
            }
        }





        public GunaAdvenceButton btnPhanQuyen { get; set; }

        private void guna2ControlBox6_Click(object sender, EventArgs e)
        {

        }

        private void guna2ControlBox5_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button3_Click_1(object sender, EventArgs e)
        {
            frmLogin login = new frmLogin();
            login.Show();
            this.Visible = false;
        }
    }
}
