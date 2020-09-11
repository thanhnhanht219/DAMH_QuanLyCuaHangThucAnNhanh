using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.CodeAnalysis;
using System.Drawing;
using System.Linq;
using System.Security.Authentication.ExtendedProtection;
using System.Security.Policy;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL_DAL;

namespace GUI
{
    public partial class frmPhanNhomNguoiDung : Form
    {
     
        public frmPhanNhomNguoiDung()
        {
            InitializeComponent();
            lstNguoDung = qlns.loadListNhanVien();
        }


        #region properties
        QL_NhanSu_BLL_DAL qlns = new QL_NhanSu_BLL_DAL();
        List<QL_NguoiDung> lstNguoDung;
        #endregion

        #region method
        private void loadDataGridViewNhanVien()
                {
                    dataGridViewNhanVien.DataSource = qlns.loadDataGridViewNhanVien();
                }

        private void loadListNhanVien()
        {
            dataGridViewNhanVien.DataSource = lstNguoDung;
        }

        private void loadCboNguoiDung()
        {
            cboLoaiNhanVien.DataSource = qlns.loadCboNhomNhanVien();
            cboLoaiNhanVien.DisplayMember = "TenNhom";
            cboLoaiNhanVien.ValueMember = "MaNhom";
        }

        TimeSpan getDateDifference(DateTime date1, DateTime date2)
        {
            TimeSpan ts = date1 - date2;
            int differenceInDays = ts.Days;
            string differenceAsString = differenceInDays.ToString();
            return ts;

        }

        public void reset()
        {
            txtMa.Clear();
            txtHoTen.Clear();
            txtSoDienThoai.Clear();
            txtDiaChi.Clear();
            txtEmail.Clear();
            txtMatKhau.Clear();
            txtCMND.Clear();
        }

        public void databingding(int rowindex)
        {
            txtMa.Text = dataGridViewNhanVien.Rows[rowindex].Cells[0].FormattedValue.ToString();
            txtHoTen.Text = dataGridViewNhanVien.Rows[rowindex].Cells[1].FormattedValue.ToString();
            txtSoDienThoai.Text = dataGridViewNhanVien.Rows[rowindex].Cells[2].FormattedValue.ToString();
            txtCMND.Text = dataGridViewNhanVien.Rows[rowindex].Cells[3].FormattedValue.ToString();
            txtDiaChi.Text = dataGridViewNhanVien.Rows[rowindex].Cells[4].FormattedValue.ToString();
            txtEmail.Text = dataGridViewNhanVien.Rows[rowindex].Cells[5].FormattedValue.ToString();
            dateTimePickerNgaySinh.Value = Convert.ToDateTime(dataGridViewNhanVien.Rows[rowindex].Cells["NgaySinh"].FormattedValue.ToString());
            dateTimePickerNgayVL.Value = Convert.ToDateTime(dataGridViewNhanVien.Rows[rowindex].Cells["NgayVL"].FormattedValue.ToString());
            cboLoaiNhanVien.SelectedValue = dataGridViewNhanVien.Rows[rowindex].Cells[8].FormattedValue.ToString();
            ckHoatDong.Checked = Convert.ToBoolean(dataGridViewNhanVien.Rows[rowindex].Cells["HoatDong"].FormattedValue.ToString());
            txtMatKhau.Text = dataGridViewNhanVien.Rows[rowindex].Cells[10].FormattedValue.ToString();
        }

        public Boolean checkHoatDong()
        {
            if (ckHoatDong.Checked)
            {
                return true;
            }
            else
            {
                return false;
            }    
        }
        #endregion

        #region validication
        public bool kiemtraMa()
        {
            string input = txtMa.Text;
            if (string.IsNullOrEmpty(input))
            {
                MessageBox.Show("Mã nhân viên không được bỏ trống");
                return false;
            }
            else
            {
                return true;
            }    
            
        }

        public bool kiemtraTenNhanVien()
        {
            string input = txtHoTen.Text;
            if (string.IsNullOrEmpty(input))
            {
                MessageBox.Show("Tên nhân viên không được bỏ trống");
                return false;
            }
            else
            {
                return true;
            }

        }

        public bool kiemtraSoDienThoai()
        {
            string input = txtSoDienThoai.Text;
            if (string.IsNullOrEmpty(input))
            {
                MessageBox.Show("Số điện thoại không được bỏ trống");
                return false;
            }
            else if(input.Length != 10)
            {
                MessageBox.Show("Số điện thoại bao gồm 10 số.");
                return false;
            }
            else
            {
                return true;
            }

        }

        public bool kiemtraCMND()
        {
            string input = txtCMND.Text;
            if (string.IsNullOrEmpty(input))
            {
                MessageBox.Show("CMND không được bỏ trống");
                return false;
            }
            else if (input.Length != 10)
            {
                MessageBox.Show("CMND bao gồm 10 số.");
                return false;
            }
            else
            {
                return true;
            }
        }

        public bool kiemtraDiaChi()
        {
            string input = txtDiaChi.Text;
            if (string.IsNullOrEmpty(input))
            {
                MessageBox.Show("Địa chỉ không được bỏ trống");
                return false;
            }
            else
            {
                return true;
            }

        }

        public bool kiemtraEmail()
        {
            string input = txtEmail.Text;
            string strRegex = @"^([a-zA-Z0-9_\-\.]+)@((\[[0-9]{1,3}" +
                      @"\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([a-zA-Z0-9\-]+\" +
                      @".)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$";
            Regex re = new Regex(strRegex);

            if (string.IsNullOrEmpty(input))
            {
                MessageBox.Show("Email không được bỏ trống");
                return false;
            }
            else if (!re.IsMatch(input))
            {
                MessageBox.Show("Email không hợp lệ");
                return false;
            }
            else
            {
                return true;
            }

        }

        public bool kiemtraNgaySinh()
        {
            string input = dateTimePickerNgaySinh.Value.ToString();
            TimeSpan difference = getDateDifference(DateTime.Now, dateTimePickerNgaySinh.Value);
            int differenceInDay = difference.Days;
            if (differenceInDay < 18)
            {
                MessageBox.Show("Nhân viên chưa đủ 18 tuổi.");
                return false;
            }
            else
            {
                return true;
            }
        }

        public bool kiemtraNgayVL()
        {
            string input = dateTimePickerNgayVL.Value.ToString();
            TimeSpan difference = getDateDifference(DateTime.Now, dateTimePickerNgayVL.Value);
            int differenceInDay = difference.Days;
            if (differenceInDay < 0 )
            {
                MessageBox.Show("Ngày vào làm không được lớn hơn ngày hiện tại.");
                return false;
            }
            else
            {
                return true;
            }
        }

        public bool kiemtraMatKhau()
        {
            string input = txtMatKhau.Text;
            if (string.IsNullOrEmpty(input))
            {
                MessageBox.Show("Mật khẩu không được bỏ trống");
                return false;
            }
            else
            {
                return true;
            }

        }

        #endregion


        private void frmPhanNhomNguoiDung_Load(object sender, EventArgs e)
        {
            //loadDataGridViewNhanVien();
            reset();
            loadListNhanVien();
            loadCboNguoiDung();
            databingding(0);
            txtCMND.KeyPress += txtCMND_KeyPress;
            txtSoDienThoai.KeyPress += txtCMND_KeyPress;
            btnLuu.Enabled = false;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
        }

        void txtCMND_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void dataGridViewNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            try
            {
                if (dataGridViewNhanVien.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                {
                    dataGridViewNhanVien.CurrentRow.Selected = true;
                    databingding(e.RowIndex);
                }
               
            }
            catch
            {
                return;
            }
           
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            reset();
            int count = qlns.demSoLuong() + 1;
            txtMa.Text = "ND0" + count;
            btnLuu.Enabled = true;
            btnThem.Enabled = false;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            btnLuu.Enabled = true;
        }
        private void btnLuu_Click(object sender, EventArgs e)
        {
           if(!kiemtraMa() || !kiemtraTenNhanVien() || !kiemtraSoDienThoai() || !kiemtraCMND() || !kiemtraDiaChi()
                || !kiemtraEmail() || !kiemtraNgaySinh() || !kiemtraMatKhau() || !kiemtraNgayVL())
            {
                return;
            }
            else
            {
                if (qlns.kiemTraKhoaChinh(txtMa.Text) != 0)
                {
                    qlns.suaNhanVien(txtMa.Text, txtHoTen.Text, txtSoDienThoai.Text, txtCMND.Text, txtDiaChi.Text,
                       txtEmail.Text, dateTimePickerNgaySinh.Value, dateTimePickerNgayVL.Value, cboLoaiNhanVien.SelectedValue.ToString(),
                        checkHoatDong(), txtMatKhau.Text);
                    MessageBox.Show(checkHoatDong() + "");
                    MessageBox.Show("Sửa thành công");
                    loadDataGridViewNhanVien();
                    btnThem.Enabled = true;
                    btnLuu.Enabled = false;
                }
                else
                {
                   
                    qlns.themNhanVien(txtMa.Text, txtHoTen.Text, txtSoDienThoai.Text, txtCMND.Text, txtDiaChi.Text,
                        txtEmail.Text, dateTimePickerNgaySinh.Value, dateTimePickerNgayVL.Value, cboLoaiNhanVien.SelectedValue.ToString(),
                        true, txtMatKhau.Text);
                    MessageBox.Show("Thêm thành công");
                    loadDataGridViewNhanVien();
                    btnSua.Enabled = false;
                    btnLuu.Enabled = false;
                }
            }
           
            
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                qlns.xoaNhanVien(txtMa.Text);
                MessageBox.Show("Xóa thành công");
                loadDataGridViewNhanVien();
                btnXoa.Enabled = false;
            }
            catch
            {
                MessageBox.Show("Nhân viên" + txtMa.Text+ " không thể xóa");
            }
            
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if(txtSearch.Text.Length == 0)
            {
               loadDataGridViewNhanVien();
            }
            else
            {
                dataGridViewNhanVien.DataSource = qlns.loadGridViewTimKiemNhanVien(txtSearch.Text);
            }    
        }

       
    }
}
