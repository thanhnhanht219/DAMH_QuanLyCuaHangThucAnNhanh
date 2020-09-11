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
using System.IO;
using System.Drawing.Imaging;
namespace GUI
{
    public partial class frmSanPham : Form
    {
        #region Properties

        SanPham_BLL_DAL sp_bll = new SanPham_BLL_DAL();
      
        List<QL_NguyenLieu> lstNL = new List<QL_NguyenLieu>();
        List<QL_NguyenLieu> lstNLHienTai;

        bool checkThem = false;
        bool checkSua = false;
        bool checkXoa = false;

        #endregion

        public frmSanPham()
        {
            InitializeComponent();

            loadCBLoai();
            lstNL = sp_bll.LayTatCaNguyenLieu();
            thietlapcontrol();          
            bindingSP();

            gvNguyenLieu.MultiSelect = false;
            gvNguyenLieu.MultiSelect = false;
            gvSanPham.MultiSelect = false;
        }

        private void guna2ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        public void thietlapcontrol()
        {
            foreach (Control item in pnControlSP.Controls)
            {
                if (item.Name == groupMaLoai.Name)
                    continue;
                item.Enabled = false;
            }
            
            btnXoa.Enabled = false;
            btnLuu.Enabled = false;
            btnThemNL.Enabled = false;
            btnXoaNL.Enabled = false;
            btnThem.Enabled = true;
            gvSanPham.Enabled = true;
            btnSua.Enabled = true;
        
        }
        public void loadGridViewSP(List<QL_SanPham> sp)
        {
            gvSanPham.DataSource = sp;
            //gvSPDataBinding();
            
        }

        private void frmSanPham_Resize(object sender, EventArgs e)
        {
            btnspace.Width = gvSanPham.Width;
        }

        public void gvSPDataBinding()
        {
            txtMa.DataBindings.Clear();
            txtTen.DataBindings.Clear();
            txtGia.DataBindings.Clear();
            txtMa.DataBindings.Add("Text", gvSanPham.DataSource, "MaSP");
            txtTen.DataBindings.Add("Text", gvSanPham.DataSource, "TenSanPham");
            //txtGia.DataBindings.Add("Text", gvSanPham.DataSource, "Gia");
            //cbMaLoai.DataBindings.Add("Text", gvNguyenLieu.DataSource, "TinhTrang");
         
        }

        public void loadCBLoai()
        {
            cbMaLoai.DataSource = sp_bll.loadAllLoai();
            cbMaLoai.ValueMember = "MaLoaiSP";
            cbMaLoai.DisplayMember = "TenLoai";
        }

       

        private void cbMaLoai_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadTatCaSP(cbMaLoai.SelectedValue.ToString());
            
           
        }

        public void loadTatCaSP(string maloai)
        {
            List<QL_SanPham> lstSP = sp_bll.getALLSanPhamByLoai(maloai).ToList();
            
            loadGridViewSP(lstSP);
            

        }



        public void LoadGVSP_NL(string maSP)
        {
            gvNL_SP.DataSource = sp_bll.laySP_NL(maSP);
            gvNguyenLieu.DataSource = lstNL_KoThuocSP() ;
        }

        private void gvSanPham_SelectionChanged(object sender, EventArgs e)
        {
            btnXoa.Enabled = true;
            try
            {
                string hinh = gvSanPham.CurrentRow.Cells["Hinh"].Value.ToString();
                pcSp.Image = Image.FromFile("../../img/img_sanpham/" + hinh);
                string masp = gvSanPham.CurrentRow.Cells[0].Value.ToString() ;
                
                LoadGVSP_NL(masp);
                
            }
            catch (Exception)
            {
                pcSp.Image = null;
                return;   
                throw;
            }

            
            
        }


        public List<QL_NguyenLieu> lstNLCuaSP()
        {
            List<QL_NguyenLieu> lst = new List<QL_NguyenLieu>();
            gvNL_SP.AllowUserToAddRows = false;
            if(gvNL_SP.Rows.Count == 0)
            {
                gvNL_SP.AllowUserToAddRows = true;
                return lst;
            }
            foreach (DataGridViewRow item in gvNL_SP.Rows)
            {
                QL_NguyenLieu nl = lstNL.Single(t => t.MaNL == item.Cells["MaNL"].Value.ToString());
                lst.Add(nl);        
            }
            return lst;
        }

        // List Nhung nguyen lieu trong thuoc san phai do
        public List<QL_NguyenLieu> lstNL_KoThuocSP()
        {
            List<QL_NguyenLieu> lstcuasp = lstNLCuaSP();
            List<QL_NguyenLieu> lstkocuasp = new List<QL_NguyenLieu>();

            foreach (QL_NguyenLieu item in lstNL)
            {
                if (!lstcuasp.Contains(item))
                {
                    lstkocuasp.Add(item);
                }
            }
            return lstkocuasp;
        }
        // kiem tra nguyen lieu trong list nguyen lieu



        private void txtTimNL_TextChanged(object sender, EventArgs e)
        {
            //gvNguyenLieu.DataSource = lstNLCuaSP(lstNL).Where(t=>t.TenNL.Contains(txtTimNL.Text));
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            checkThem = true;
            checkSua = false;
            checkXoa = false;
            foreach (Control item in pnControlSP.Controls)
            {
                // khong cho nha maSP
                if (item.Name == "gbMSP")
                {
                    continue;
                }
                else
                    item.Enabled = true;
            }
            resetControlKhiThem();

        }

        // reset cac testbox
        private void resetControlKhiThem()
        {
            txtMa.Text = taoMaSPMoi();    
            txtGia.Text = "";
            txtTen.Text = "";

            btnThemNL.Enabled = true;
            btnXoaNL.Enabled = true;
            btnLuu.Enabled = true;
            gvSanPham.Enabled = false;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;

            lstNLHienTai = new List<QL_NguyenLieu>();
            gvNL_SP.DataSource = loadNL_SP();
            gvNguyenLieu.DataSource = lstNL;
            pcSp.Image = null;
        }

        private string taoMaSPMoi()
        {
            return cbMaLoai.SelectedValue + "SP00" + gvSanPham.Rows.Count.ToString();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            checkXoa = true;
            checkThem = false;
            checkSua = false;
            btnThem.Enabled = false;
            btnSua.Enabled = false;
            if (gvSanPham.SelectedRows.Count == 0)
            {
                MessageBox.Show("Chưa chọn sản phẩm để sửa");
                return;
            }
            DialogResult rs = MessageBox.Show("Bạn có chắc muốn xóa sản phẩm (" + txtTen + ")","Xác nhận",MessageBoxButtons.YesNo);
            if( rs == DialogResult.Yes)
            {
                sp_bll.xoaSP(txtMa.Text);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if(gvSanPham.SelectedRows.Count == 0)
            {
                MessageBox.Show("Chưa chọn sản phẩm để sửa");
                return;
            }
            gvSanPham.Enabled = false;
            checkSua = true;
            checkThem = false;
            checkXoa = true;

            foreach (Control item in pnControlSP.Controls)
            {
                // khong cho nha maSP
                if (item.Name == "gbMSP")
                {
                    continue;
                }
                else
                    item.Enabled = true;
            }
            lstNLHienTai = lstNLCuaSP();
            btnXoa.Enabled = false;
            btnThem.Enabled = false;
            btnThemNL.Enabled = true;
            btnXoaNL.Enabled = true;
            btnLuu.Enabled = true;

            
        }

        private void btnThemNL_Click(object sender, EventArgs e)
        {
            if(gvNguyenLieu.SelectedRows == null)
            {
                MessageBox.Show("Chưa chọn nguyện liệu");
            }
            foreach (DataGridViewRow item in gvNguyenLieu.SelectedRows)
            {
                QL_NguyenLieu nl = lstNL.Single(t => t.MaNL == item.Cells["MaNL"].Value.ToString());
                lstNLHienTai.Add(nl);

                gvNL_SP.DataSource = loadNL_SP();
                gvNguyenLieu.DataSource = lstNL_KoThuocSP();
            }
        }

        private List<QL_NguyenLieu_SanPham> loadNL_SP()
        {
            List<QL_NguyenLieu_SanPham> lst_nlsp = new List<QL_NguyenLieu_SanPham>();
            foreach (QL_NguyenLieu item in lstNLHienTai)
            {
                QL_NguyenLieu_SanPham nlsp = new QL_NguyenLieu_SanPham();
                nlsp.MaNL = item.MaNL;
                nlsp.MaSP = txtMa.Text;
                nlsp.SoLuong = 1;
                lst_nlsp.Add(nlsp);
            }
            return lst_nlsp;
        }

        private void btnXoaNL_Click(object sender, EventArgs e)
        {
            lstNLHienTai.Remove(lstNLHienTai.SingleOrDefault(t => t.MaNL == gvNL_SP.CurrentRow.Cells["MaNL"].Value.ToString()));
            gvNL_SP.DataSource = loadNL_SP();
            gvNguyenLieu.DataSource = lstNL_KoThuocSP();            
        }

        private void gbMSP_Enter(object sender, EventArgs e)
        {
            
        }

        

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if(kiemtraControl() == false)
            {
                MessageBox.Show("Nhập chưa đầy đủ");
                return;
            }

            QL_SanPham sp = new QL_SanPham();
            sp.MaSP = txtMa.Text;
            sp.TenSanPham = txtTen.Text;
            sp.TinhTrang = cbTinhTrang.Text;
            sp.MaLoaiSP = cbMaLoai.SelectedValue.ToString();
            sp.Gia = Convert.ToInt64(txtGia.Text);
            
            try
            {
                sp.Hinh = Path.GetFileName(pcSp.Tag.ToString());
                MessageBox.Show(sp.Hinh);
                System.IO.File.Copy(pcSp.Tag.ToString(), "../../img/img_sanpham/" + sp.Hinh,true);
            }
            catch (Exception)
            {
                sp.Hinh = "no-image.jpg";
            }

            List<QL_NguyenLieu_SanPham> lstNLSP = loadNL_SP();

            if(checkThem == true)
            {               
                bool check = sp_bll.themSanPham(sp, lstNLSP);
                
                if(check)
                {
                    MessageBox.Show("Thêm thành công");
                }
                else
                {
                    MessageBox.Show("Thêm thất bại");
                }
                gvSanPham.Enabled = true;
                checkThem = false;
            }                
            else if(checkSua == true)
            {
                bool check = sp_bll.suaSanPham(sp,lstNLSP);
                if (check)
                {
                    MessageBox.Show("Sửa thành công");
                }
                else
                {
                    MessageBox.Show("Sửa thất bại");
                }
                gvSanPham.Enabled = true;
                checkSua = false;                
            }
            else
            {
                checkXoa = false;
            }
            sp_bll.submitChange();
            btnLuu.Enabled = false;
            thietlapcontrol();
            loadTatCaSP(cbMaLoai.SelectedValue.ToString());
        }

        private bool kiemtraControl()
        {
            if(txtGia.Text == string.Empty || txtMa.Text == string.Empty || txtGia.Text == string.Empty)
            {
                return false;
            }
            return true;
        }

        private void gvSanPham_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            bindingSP();
        }

        public void bindingSP()
        {
            foreach (DataGridViewRow item  in gvSanPham.SelectedRows)
            {
                txtMa.Text = item.Cells[0].Value.ToString();
                txtTen.Text = item.Cells[1].Value.ToString();
                string[] gia = item.Cells[3].Value.ToString().Split('.');
                txtGia.Text = gia[0];
                cbTinhTrang.Text = item.Cells[2].Value.ToString();
                try
                {
                    pcSp.Image = Image.FromFile("../../img/img_sanpham/" + gvSanPham.CurrentRow.Cells[4].Value.ToString());
                }
                catch (Exception)
                {
                    return;
                    throw;
                }
            }
        }

        private void btnChonHinh_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            // image filters  
            open.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";
            if (open.ShowDialog() == DialogResult.OK)
            {
                // display image in picture box  
                pcSp.Image = new Bitmap(open.FileName);
                // image file path  
                pcSp.Tag = open.FileName;
            } 
        }

        private void gvSanPham_Click(object sender, EventArgs e)
        {

        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            thietlapcontrol();
        }


        

    }
}
