using Guna.UI.WinForms;
using System;
using System.Windows.Forms;
using BLL_DAL;
using System.Collections.Generic;
using System.Drawing;
using clb_GUI;


namespace GUI
{
    public partial class frmPOS : Form
    {
        #region Properties

        SanPham_BLL_DAL sp_bll = new SanPham_BLL_DAL();
        qlKhachHang_BLL_DAL kh_bll = new qlKhachHang_BLL_DAL();
        List<QL_ChiTietHoaDon> lstChiTiet;
        HoaDon_BLL_DLL hd_bll = new HoaDon_BLL_DLL();
        bool checkTienMat;
        int tongtienHd;
        QL_NguoiDung nd;        
        QL_KHACHHANG kh_hientai;
        bool checkfrmHD = false;
        int diemDung;
        string maHD;
        #endregion
        public frmPOS()
        {
            InitializeComponent();
            btnBackToManager.Visible = false;
        }


        public frmPOS(bool show)
        {
            InitializeComponent();
            btnBackToManager.Visible = show;
        }


        private void frmPOS_Load(object sender, EventArgs e)
        {

            Guna.UI.Lib.ScrollBar.PanelScrollHelper flowpanel =
                new Guna.UI.Lib.ScrollBar.PanelScrollHelper(pnHienThiSanPham, gunaVScrollBar1, true);

            hienthiSanPham(sp_bll.getALLSP());
            resetPNThanhToan();
            loadLoaiNguyenLieu();
            btnThanhToan.Enabled = false;
            btnTienMat.BaseColor = Color.Purple;
            btnTienMat.ForeColor = Color.White;
            checkTienMat = true;
            btnThe.BaseColor = Color.White;
            btnThe.ForeColor = Color.Gray;
            tongtienHd = 0;

        }

       

        private void btnBackToManager_Click(object sender, EventArgs e)
        {
            frmMain frm = new frmMain();
            frm.DangNhapNguoiDung(nd);
            frm.WindowState = FormWindowState.Maximized;
            frm.Show();
            this.Close();
        }

        #region Method


        //Hien thi loai nguyen lieu
        public void loadLoaiNguyenLieu()
        {
            List<QL_LoaiNguyenLieu> lstLoai = sp_bll.getALLCateNL();
            int top = 10;

            for (int i = 0; i < lstLoai.Count; i++)
            {
                if (lstLoai[i].Hinh == null)
                {
                    continue;
                }
                try
                {
                    GunaAdvenceTileButton btnLoaiNguyenLieu = new GunaAdvenceTileButton()
                    {
                        Location = new Point(7, top),
                        Text = lstLoai[i].TenLoai,
                        Width = pnLoaiNguyenLieu.Width,
                        Size = new Size(59, 50),
                        Image = Image.FromFile("../../img/icon_loai/" + lstLoai[i].Hinh),
                        ImageSize = new Size(25, 25),
                        BaseColor = Color.Transparent,
                        OnHoverBaseColor = Color.Transparent,
                        BackColor = Color.Transparent,
                        CheckedBaseColor = Color.Transparent,
                        Animated = true,
                        Tag = lstLoai[i].MaLoaiNL,
                        Font = new Font("Microsoft Sans Serif", 9, FontStyle.Regular)
                    };
                    top += btnLoaiNguyenLieu.Height + 5;
                    btnLoaiNguyenLieu.Click += BtnLoaiNguyenLieu_Click; ;

                    pnLoaiNguyenLieu.Controls.Add(btnLoaiNguyenLieu);
                }
                catch (Exception)
                {
                    continue;
                    throw;
                }

            }
        }

        private void BtnLoaiNguyenLieu_Click(object sender, EventArgs e)
        {
            GunaAdvenceTileButton btn = (GunaAdvenceTileButton)sender;
            loadSPTheoLoaiNL(btn.Tag.ToString());
        }

        private void loadSPTheoLoaiNL(string maLoaiNL)
        {
            List<QL_SanPham> lstSP = sp_bll.laySPTheoLoaiNL(maLoaiNL);

            hienthiSanPham(lstSP);
        }

        private void hienthiSanPham(List<QL_SanPham> lstSP)
        {
            pnHienThiSanPham.Controls.Clear();
            foreach (QL_SanPham item in lstSP)
            {
                string path;
                usSanPham itemsp = new usSanPham();

                //itemsp.btnchon.Visible = false;
                itemsp.pnLine.Visible = false;

                if (item.Hinh == null || item.Hinh == string.Empty)
                {
                    path = "../../img/img_sanpham/" + "no-image.jpg";
                }
                else
                {
                    path = "../../img/img_sanpham/" + item.Hinh;
                }

                itemsp.setValueSP((int)item.Gia, path, item.TenSanPham);
                itemsp.setEventForALL();
                itemsp.pictureBox1.Tag = item.MaSP + "," + (int)item.Gia;
                itemsp.pictureBox1.Click += itemsp_picturebox;
                pnHienThiSanPham.Controls.Add(itemsp);
            }

        }

        void itemsp_picturebox(object sender, EventArgs e)
        {
            PictureBox pc = (PictureBox)sender;
            if (lstChiTiet == null)
            {
                MessageBox.Show("Chưa tạo hóa đơn");
                return;
            }
            string[] mavagia = pc.Tag.ToString().Split(',');

            QL_ChiTietHoaDon cthd = new QL_ChiTietHoaDon();
            cthd.MaHD = " ";

            cthd.MaSP = mavagia[0];
            cthd.Soluong = 1;
            cthd.DonGia = Convert.ToInt32(mavagia[1]);

            if (!checkHD(mavagia[0]))
            {
                MessageBox.Show("Đã chọn sản phẩm này !");
                return;
            }

            lstChiTiet.Add(cthd);

            usChiTietHD usChiTiet = new usChiTietHD();
            usChiTiet.setValue(mavagia[0]);
            usChiTiet.Tag = mavagia[0];
            usChiTiet.btnTangGiam.Tag = mavagia[0];
            usChiTiet.btnHuy.Tag = mavagia[0];

            pnChiTietHD.Controls.Add(usChiTiet);
            usChiTiet.btnTangGiam.Click += BtnTangGiam_Click; ;
            usChiTiet.btnHuy.Click += BtnHuy_Click; ;
            capnhapTongTien();
        }

        private void capnhapTongTien()
        {
            if (lstChiTiet.Count == 0 || lstChiTiet == null)
            {
                return;
            }
            int tong = 0;
            foreach (usChiTietHD item in pnChiTietHD.Controls)
            {
                tong += item.TongTien;
            }
            lbTongTien.Text = tong + " ";
            lbThanhTien.Text = tong + " ";

            if(kh_hientai == null)
            {
                return;
            }
            if (checkDungDiem.Checked == true)
            {
                if (kh_hientai.DiemSo >= tong/1000)
                {
                    lbDiem.Text = (kh_hientai.DiemSo - (tong / 1000)).ToString();
                    diemDung = tong / 1000;
                    tong = 0;                    
                }
                else
                {
                    tong = tong - ((int)kh_hientai.DiemSo * 1000);
                    diemDung = (int)kh_hientai.DiemSo;
                    lbDiem.Text = "0";
                    
                }
            }
            else
            {
                lbDiem.Text = kh_hientai.DiemSo.ToString();
                diemDung = 0;
            }


            lbThanhTien.Text = tong + " ";

        }

        private void BtnHuy_Click(object sender, EventArgs e)
        {
            GunaAdvenceTileButton nb = (GunaAdvenceTileButton)sender;
            for (int i = 0; i < pnChiTietHD.Controls.Count; i++)
            {
                if (pnChiTietHD.Controls[i].Tag != null && pnChiTietHD.Controls[i].Tag.ToString() == nb.Tag.ToString())
                {
                    pnChiTietHD.Controls.Remove(pnChiTietHD.Controls[i]);
                    lstChiTiet.RemoveAt(i);
                    capnhapTongTien();
                }
                else
                {
                    continue;
                }
            }
           
        }

        private void BtnTangGiam_Click(object sender, EventArgs e)
        {
            GunaNumeric nb = (GunaNumeric)sender;
            if (nb.Value > 10)
            {
                MessageBox.Show("Một sản phẩm được đặt nhiều nhất là 10");
                nb.Value = 10;
                return;
            }
            foreach (Control item in pnChiTietHD.Controls)
            {
                if (item.Tag != null && item.Tag.ToString() == nb.Tag.ToString())
                {
                    usChiTietHD usChiTiet = (usChiTietHD)item;
                    usChiTiet.capnhapTongTien((int)nb.Value);
                    // Cap nhap so luong don hang                    
                    capnhapSLCT(nb.Tag.ToString(), (int)nb.Value);  
                }
                else
                {
                    continue;
                }
            }
            capnhapTongTien();
        }

        // cap nhap so luong cho chi tiet
        private void capnhapSLCT(string p1, int p2)
        {
            foreach (QL_ChiTietHoaDon item in lstChiTiet)
            {
                if (item.MaSP == p1)
                {
                    item.Soluong = p2;
                    break;
                }
            }
        }

        

        private bool checkHD(string maSP)
        {
            if (lstChiTiet.Count == 0)
            {
                return true;
            }
            foreach (Control control in pnChiTietHD.Controls)
            {

                if (control.Tag.ToString() == maSP)
                {
                    return false;
                }
            }
            return true;
        }

        public string taoMaHD()
        {
            string date = DateTime.Now.Date.ToShortDateString();
            int stt = hd_bll.demHD();
            Random rd = new Random();
            return "HD" + stt + date + rd.Next(0, 100);
        }

        private void btnTatCa_Click(object sender, EventArgs e)
        {
            List<QL_SanPham> lst = sp_bll.getALLSP();
            hienthiSanPham(lst);
        }

        private void btnThucAn_Click(object sender, EventArgs e)
        {
            List<QL_SanPham> lst = sp_bll.getALLByLoaiList("LOAISP01");
            hienthiSanPham(lst);
        }

        private void btnDoUong_Click(object sender, EventArgs e)
        {
            List<QL_SanPham> lst = sp_bll.getALLByLoaiList("LOAISP02");
            hienthiSanPham(lst);
        }

        private void btnThemHD_Click(object sender, EventArgs e)
        {
            if (btnThanhToan.Enabled == false)
            {
                btnThanhToan.Enabled = true;
                btnThemHD.FillColor = Color.Yellow;
                btnThemHD.FillColor2 = Color.SkyBlue;
                resetPNThanhToan();
                txtKhachHang.Enabled = true;
                btnSeachKH.Enabled = true;
                btnThemHD.Text = "-";

                lstChiTiet = new List<QL_ChiTietHoaDon>();


            }
            else
            {
                btnThanhToan.Enabled = false;
                btnThemHD.FillColor = Color.Violet;
                btnThemHD.FillColor2 = Color.SkyBlue;
                btnThemHD.Text = "+";
                resetPNThanhToan();
                pnChiTietHD.Controls.Clear();
                lstChiTiet = null;
            }
        }

        public bool checkTienDua()
        {
            if (txtTienDua.Text == string.Empty)
            {
                return false;
            }
            int tiendua = Convert.ToInt32(txtTienDua.Text);
            int tongtien = Convert.ToInt32(lbThanhTien.Text);
            return tiendua >= tongtien ? true : false;
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            if (lstChiTiet == null || lstChiTiet.Count == 0)
            {
                MessageBox.Show("Chưa có sản phẩm nào");
                return;
            }
            if (!checkTienDua())
            {
                MessageBox.Show("Không hợp lệ");
                return;
            }
            else
            {
                DialogResult rs = MessageBox.Show("Lưu ý", "Xác nhận thanh toán", MessageBoxButtons.YesNo);
                if (rs == DialogResult.No)
                {
                    return;
                }

                string phuongthuc = checkTienMat ? "Tiền Mặt" : "Thẻ";
                int tongtien = Convert.ToInt32(lbThanhTien.Text);
                //double TongTien = ckDiem.Checked ? tongtien : tongtien;
                
                string khach;

                if(txtKhachHang.Text.Length == 0)
                {
                    // khach hang chua dang ky
                    khach = "KHCDK";
                }
                else
                {
                    khach = kh_hientai.MaKH;
                }                

                if(checkDungDiem.Checked)
                {
                    kh_hientai.DiemSo = Convert.ToInt32(lbDiem.Text);
                }

                maHD = hd_bll.taoMaHD();

                bool check = hd_bll.themHoaDon(lstChiTiet, maHD,nd.MaND, khach, phuongthuc, txtTienDua.Text, lbTienDu.Text, Convert.ToInt32(tongtien));

                if (check)
                {
                    MessageBox.Show("Thanh toán thành công !");
                    xuatFileExcel();
                    if (kh_hientai == null)
                    {
                        veTrangThaiBD();
                        return;
                    }                     
                    capnhapdiem();                   
                    veTrangThaiBD();
                    
                    
                }
                else
                {
                    MessageBox.Show("Thanh toán thất bại !");
                }

            }
        }

        private void xuatFileExcel()
        {
            ExcelExport ex = new ExcelExport();
            List<QL_ChiTietHoaDon> dsKhoa = lstChiTiet;

            if (dsKhoa.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu");
            }
            QL_HoaDon_BanHang hdbh = hd_bll.layHD(maHD);
            List<QL_ChiTietHoaDon> pListSP = new List<QL_ChiTietHoaDon>();

            if(checkDungDiem.Checked)
            {
                hdbh.DiemDung = diemDung;           
            }

            hdbh.TongTienThat = Convert.ToInt32(lbTongTien.Text);
           
            // Đỗ dữ liệu vào danh sách
            int Stt = 1;
            foreach (QL_ChiTietHoaDon item in dsKhoa)
            {
                QL_ChiTietHoaDon chitiet = new QL_ChiTietHoaDon();
                QL_SanPham sphientai = sp_bll.laySP(item.MaSP);

                chitiet.TenSanPham = sphientai.TenSanPham;
                chitiet.DonGia = item.DonGia;
                chitiet.Soluong = item.Soluong;
                chitiet.STT = Stt.ToString();                
                Stt++;
                pListSP.Add(chitiet);

            }

            string path = string.Empty;

            ex.ExportKhoa(hdbh,pListSP, ref path, false);

            if (!string.IsNullOrEmpty(path) && MessageBox.Show("Bạn có muốn mở file", "Xác Nhận", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                System.Diagnostics.Process.Start(path);
            }
        }

        private void veTrangThaiBD()
        {
            hienthiSanPham(sp_bll.getALLSP());
            resetPNThanhToan();
            loadLoaiNguyenLieu();
            btnThanhToan.Enabled = false;
            btnTienMat.BaseColor = Color.Purple;
            btnTienMat.ForeColor = Color.White;
            checkTienMat = true;
            txtKhachHang.Text = "";
            btnThe.BaseColor = Color.White;
            btnThe.ForeColor = Color.Gray;
            tongtienHd = 0;
            checkDungDiem.Checked = false;
            lstChiTiet = null;
            pnChiTietHD.Controls.Clear();
            diemDung = 0;
            maHD = "";
            
        }

        private void capnhapdiem()
        {
            int tong = Convert.ToInt32(lbTongTien.Text);
            if (checkDungDiem.Checked == true)
            {
                if (kh_hientai.DiemSo >= tong)
                {
                    tong = 0;
                    kh_hientai.DiemSo = ((kh_hientai.DiemSo) - tong / 1000);
                }
                else
                {
                    kh_hientai.DiemSo = 0;
                }
            }

            int diem = tong / dsHangSo.CHIADIEM;
            if (diem > 0)
            {
                kh_hientai.DiemSo += diem;
                kh_bll.CapNhapDiem(kh_hientai.MaKH, (int)kh_hientai.DiemSo);
            }
        }

        

        public void resetPNThanhToan()
        {
            lbDiem.Text = "0";
            lbTongTien.Text = "0";
            lbTienDu.Text = "0";
            lbThanhTien.Text = "0";
            txtTienDua.Text = "0";
            checkDungDiem.Enabled = false;
            txtKhachHang.Enabled = false;
            btnSeachKH.Enabled = false;
        }

        private void txtTienKhachDua_TextChanged(object sender, EventArgs e)
        {
            capnhaptiendu();
        }

        public void capnhaptiendu()
        {
            try
            {
                if (txtTienDua.Text == string.Empty)
                {
                    lbTienDu.Text = "0";
                    return;
                }
                if(Convert.ToInt32(txtTienDua.Text) >= dsHangSo.SOTIENLONNHAT)
                {
                    MessageBox.Show("Không thanh toán hóa đơn trên 1 tỷ");
                    return;
                }

                int val = Convert.ToInt32(txtTienDua.Text);
                updateTienThua_TienThieu(val, Convert.ToInt32(lbThanhTien.Text));
            }
            catch
            {
                MessageBox.Show("Vượt giới hạn của kiểu dữ liệu");
            }
        }

        public void updateTienThua_TienThieu(int val, int tong)
        {
            ChucNang cn = new ChucNang();
            if (val > tong)
            {

                lbTienDu.Text = (val - tong).ToString();
                lbTienDu.ForeColor = Color.Blue;
                lbTienDuHoacThieu.Text = "Tiền dư:";
            }
            else if (val < tong)
            {


                lbTienDu.Text = (tong - val).ToString();
                lbTienDu.ForeColor = Color.Red;
                lbTienDuHoacThieu.Text = "Tiền thiếu:";
            }
            else
            {
                lbTienDu.Text = "0";
            }
        }

        private void btnThe_Click(object sender, EventArgs e)
        {
            btnThe.BaseColor = Color.Purple;
            btnThe.ForeColor = Color.White;
            checkTienMat = false;
            btnTienMat.BaseColor = Color.White;
            btnTienMat.ForeColor = Color.Gray;
        }

        private void btnTienMat_Click(object sender, EventArgs e)
        {
            lbTienKhachDua.Visible = true;
            txtTienDua.Visible = true;
            lbTienDu.Visible = true;
            lbTienDuHoacThieu.Visible = true;

            btnTienMat.BaseColor = Color.Purple;
            btnTienMat.ForeColor = Color.White;
            checkTienMat = true;
            btnThe.BaseColor = Color.White;
            btnThe.ForeColor = Color.Gray;
        }

        private void txtSearchSP_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void btnSeachKH_Click(object sender, EventArgs e)
        {
            if (txtKhachHang.Text == "KHCDK")
            {
                return; 
            }
            if (txtKhachHang.Enabled == false)
            {
                checkDungDiem.Checked = false;
                txtKhachHang.Text = "";
                txtKhachHang.Enabled = true;
                lbDiem.Text = "0";
                checkDungDiem.Enabled = false;
          
                
                return;
            }
            if (txtKhachHang.Text == string.Empty)
            {
                MessageBox.Show("Chưa nhập mã số khách hàng");
                return;
            }
            else
            {

                string makh = txtKhachHang.Text;
                QL_KHACHHANG kh = kh_bll.loadGridViewTimKiemPOSKhachHang(makh);
                kh_hientai = kh;
                if (kh == null)
                {
                    MessageBox.Show("Khách Hàng này không tồn tại");
                    return;
                }
                txtKhachHang.Text = kh.HoTen;
                txtKhachHang.Enabled = false;
                if (kh.DiemSo == 0 || kh.DiemSo == null)
                {
                    lbDiem.Text = "0";
                    checkDungDiem.Enabled = false;
                    return;
                }
                checkDungDiem.Enabled = true;
                lbDiem.Text = (int)kh.DiemSo + "";
            }
        }

        private void btnThemKhachHang_Click(object sender, EventArgs e)
        {
            usThemKhachHang us = new usThemKhachHang();
            Form window = new Form
            {
                TopLevel = true,
                FormBorderStyle = FormBorderStyle.FixedDialog, //Disables user resizing
                MaximizeBox = false,
                MinimizeBox = false,
                ClientSize = us.Size //size the form to fit the content
            };

            window.Controls.Add(us);
            us.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            window.StartPosition = FormStartPosition.CenterScreen;

            if (us.tag == 0)
            {
                window.ShowDialog();
            }
            else
            {

                window.Close();
                txtKhachHang.Text = us.ma;
            }

        }
        #endregion

        private void btnTatCa_Click_1(object sender, EventArgs e)
        {
            List<QL_SanPham> lst = sp_bll.getALLSP();
            hienthiSanPham(lst);
        }

        private void btnThucAn_Click_1(object sender, EventArgs e)
        {
            List<QL_SanPham> lst = sp_bll.getALLByLoaiList(dsHangSo.DOAN);
            hienthiSanPham(lst);
        }

        private void btnThucUong_Click(object sender, EventArgs e)
        {
            List<QL_SanPham> lst = sp_bll.getALLByLoaiList(dsHangSo.DOUONG);
            hienthiSanPham(lst);
        }

        private void btnSeachKH_Click_1(object sender, EventArgs e)
        {
            if(txtSearchSP.Text == string.Empty)
            {
                MessageBox.Show("Chưa nhập sản phẩm");
                return;
            }
            List<QL_SanPham> lstSP = sp_bll.searchSP(txtSearchSP.Text);
            if (lstSP.Count == 0) 
            {
                MessageBox.Show("Không tìm thấy sản phẩm");
                return;
            }

            hienthiSanPham(lstSP);
        }



        internal void DangNhapNguoiDung(QL_NguoiDung nd)
        {
            this.nd = nd;
            thietLapND();
        }
        public void thietLapND()
        {
            BtnND.Text = nd.TenNguoiDung;
        }

        private void checkDungDiem_CheckedChanged(object sender, EventArgs e)
        {
            capnhapTongTien();
            capnhaptiendu();
        }

        private void txtTienDua_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtKhachHang_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void txtSearchSP_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void gunaAdvenceButton1_Click(object sender, EventArgs e)
        {
            frmHoaDon frmHD = new frmHoaDon();
            if(checkfrmHD == false)
            {                 
                frmHD.Show();
                checkfrmHD = true;
                frmHD.openfromPOS();
            }
            else
            {
                frmHD.Close();
                checkfrmHD = false;
            }
        }

        private void frmPOS_FormClosing(object sender, FormClosingEventArgs e)
        {
           
        }

        private void pnHienThiSanPham_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
