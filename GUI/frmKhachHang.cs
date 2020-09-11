using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL_DAL;
using Guna.UI.WinForms;
using Guna.UI2.WinForms;

namespace GUI
{
    public partial class frmKhachHang : Form
    {
        qlKhachHang_BLL_DAL qlkh = new qlKhachHang_BLL_DAL();
        List<string> lstStringTextBox;
        List<Guna2TextBox> lstTextBox;

        public List<Guna2TextBox> addListTextBox()
        {
            lstTextBox = new List<Guna2TextBox>();
            lstTextBox.Add(txtMaKhachHang);
            lstTextBox.Add(txtTenKhachHang);
            lstTextBox.Add(txtSoDienThoai);
            lstTextBox.Add(txtDiem);
            lstTextBox.Add(txtCMND);
            return lstTextBox;
        }

        public void setEnableTextBox(List<Guna2TextBox> lst, bool b)
        {
            foreach (Guna2TextBox s in lst)
            {
                s.Enabled = b;
            }
        }

        public frmKhachHang()
        {
            InitializeComponent();
        }

        private void frmKhachHang_Load(object sender, EventArgs e)
        {
            dataGridViewKhachHang.DataSource = qlkh.loadGridViewKhachHang();
            btnThem.Enabled = true;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnLuu.Enabled = false;
            lstTextBox = addListTextBox();
            setEnableTextBox(lstTextBox, false);
            txtSoDonHang.Enabled = false;
            txtTongTienDonHang.Enabled = false;
          
            string makh = dataGridViewKhachHang.Rows[0].Cells["MaKH"].FormattedValue.ToString();
            string hoten = dataGridViewKhachHang.Rows[0].Cells["HoTen"].FormattedValue.ToString();
            string sdt = dataGridViewKhachHang.Rows[0].Cells["SDT"].FormattedValue.ToString();
            string cmnd = dataGridViewKhachHang.Rows[0].Cells["CMND"].FormattedValue.ToString();
            string diemso = dataGridViewKhachHang.Rows[0].Cells["DiemSo"].FormattedValue.ToString();
            loadGridViewDonHang(makh);
            loadGridViewSanPham(makh);
            databinding(makh, hoten, sdt, cmnd, diemso);

        }

        public void setHeaderDonHang()
        {
            dataGridViewDonHang.Columns["MaHD"].HeaderText = "Mã hóa đơn";
            dataGridViewDonHang.Columns["NgayLap"].HeaderText = "Ngày lập";
            dataGridViewDonHang.Columns["PhuongThuc"].HeaderText = "Phương thức";
            dataGridViewDonHang.Columns["TongCong"].HeaderText = "Tổng cộng";
            dataGridViewDonHang.Columns["MaND"].Visible = false;
            dataGridViewDonHang.Columns["MaKH"].Visible = false;
            dataGridViewDonHang.Columns["TienDua"].Visible = false;
            dataGridViewDonHang.Columns["TienThua"].Visible = false;
            dataGridViewDonHang.Columns["QL_KHACHHANG"].Visible = false;
            dataGridViewDonHang.Columns["QL_NGUOIDUNG"].Visible = false;
        }

        private void dataGridViewKhachHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnXoa.Enabled = true;
            btnSua.Enabled = true;
            try
            {
                if(dataGridViewKhachHang.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                {
                    dataGridViewKhachHang.CurrentRow.Selected = true;

                    string makh = dataGridViewKhachHang.Rows[e.RowIndex].Cells["MaKH"].FormattedValue.ToString();
                    string hoten = dataGridViewKhachHang.Rows[e.RowIndex].Cells["HoTen"].FormattedValue.ToString();
                    string sdt = dataGridViewKhachHang.Rows[e.RowIndex].Cells["SDT"].FormattedValue.ToString();
                    string cmnd = dataGridViewKhachHang.Rows[e.RowIndex].Cells["CMND"].FormattedValue.ToString();
                    string diemso = dataGridViewKhachHang.Rows[e.RowIndex].Cells["DiemSo"].FormattedValue.ToString();
                    int diem = 0;
                    if (string.IsNullOrEmpty(diemso))
                    {
                        diem = 0;
                    }
                    else
                    {
                        diem = int.Parse(diemso);
                    }
                    
                    databinding(makh, hoten, sdt, cmnd, diemso);
                    loadGridViewDonHang(makh);
                    loadGridViewSanPham(makh);
                   
                }
            }
            catch
            {
                MessageBox.Show("Vui lòng chọn khách hàng!");
            }
        }


        public void databinding(string makh, string hoten, string sdt, string cmnd, string diemso)
        {
            txtMaKhachHang.Text = makh;
            txtTenKhachHang.Text = hoten;
            txtSoDienThoai.Text = sdt;
            txtCMND.Text = cmnd;
            txtDiem.Text = diemso;
        }
        public void loadGridViewDonHang(string makh)
        {
            dataGridViewDonHang.DataSource = qlkh.loadDonHangTheoKhachHang(makh);
            setHeaderDonHang();
            int count = 0;
            count = dataGridViewDonHang.Rows.Count;
            txtSoDonHang.Text = count.ToString();
            int sum = 0;
            for (int i = 0; i < count; i++)
            {
                sum += int.Parse(dataGridViewDonHang.Rows[i].Cells["TongCong"].Value.ToString());
            }
            txtTongTienDonHang.Text = sum + " ";
        }
        
        public void loadGridViewSanPham(string makh)
        {
            dataGridViewSanPhamKhachHang.DataSource = qlkh.loadSanPham(makh);

        }
        
        public List<string> addList()
        {
            lstStringTextBox = new List<string>();
            lstStringTextBox.Add(txtMaKhachHang.Text);
            lstStringTextBox.Add(txtTenKhachHang.Text);
            lstStringTextBox.Add(txtSoDienThoai.Text);
            lstStringTextBox.Add(txtCMND.Text);
            lstStringTextBox.Add(txtDiem.Text);
            return lstStringTextBox;
        }

        public bool isEmpty(List<string> lst)
        {
            int count = 0;
            foreach(string s in lst)
            {
                if(s.Length == 0)
                {
                    count++;
                }
            }
            return count != 0;
        }

        public void reset()
        {
            txtMaKhachHang.Clear();
            txtTenKhachHang.Clear();
            txtSoDienThoai.Clear();
            txtCMND.Clear();
            txtDiem.Clear();
        }
       
        private void btnThem_Click(object sender, EventArgs e)
        {
            reset();
            setEnableTextBox(lstTextBox,true);
            txtMaKhachHang.Enabled = false;
            int count = 0;
            count = dataGridViewKhachHang.Rows.Count + 1;
            txtMaKhachHang.Text = "KH00" + count;

            if(btnLuu.Enabled == true)
            {
                DialogResult result;

                result = MessageBox.Show("Bạn chưa lưu khách hàng " + txtMaKhachHang.Text + ". Bạn có muốn lưu lại ?",
                    "Thông báo", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question,MessageBoxDefaultButton.Button1);
                if(result == DialogResult.Yes)
                {
                    btnLuu_Click(sender, e);
                }
                else
                {
                    return;
                }

            }
            else
            {
                btnLuu.Enabled = true;
            }    
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            setEnableTextBox(lstTextBox, true);
            txtMaKhachHang.Enabled = false;
            if (btnLuu.Enabled == true)
            {
                DialogResult result;

                result = MessageBox.Show("Bạn chưa lưu khách hàng " + txtMaKhachHang.Text + ". Bạn có muốn lưu lại ?",
                    "Thông báo", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
                if (result == DialogResult.Yes)
                {
                    btnLuu_Click(sender, e);
                }
                else
                {
                    return;
                }
            }
            else
            {
                btnLuu.Enabled = true;
            }

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {

            try
            {
                DialogResult result;

                result = MessageBox.Show("Bạn chắc chắn xóa khách hàng " + txtMaKhachHang.Text + " ?",
                    "Thông báo", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
                if (result == DialogResult.Yes)
                {
                    qlkh.xoaKhachHang(txtMaKhachHang.Text);
                    frmKhachHang_Load(sender, e);
                }
                else
                {
                    return;
                }
            }
            catch
            {
                MessageBox.Show("Khách hàng "+ txtMaKhachHang.Text +" không đạt điều kiện để xóa");
            }
            
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            lstStringTextBox = addList();
            try
            {
                if (!isEmpty(lstStringTextBox))
                {
                    if(txtSoDienThoai.Text.Length != 10)
                    {
                        MessageBox.Show("Số điện thoại bạn nhập không hợp lệ");
                        return;
                    }
                    else if(txtCMND.Text.Length != 10)
                    {
                        MessageBox.Show("CMND bạn nhập không hợp lệ");
                        return;
                        
                    }    
                    else
                    {
                        if (qlkh.kiemtrakhoachinh(txtMaKhachHang.Text) == 1)
                        {
                            try
                            {
                                DialogResult result;

                                result = MessageBox.Show("Bạn muốn lưu khách hàng " + txtMaKhachHang.Text + " ?",
                                    "Thông báo", MessageBoxButtons.YesNo,
                                    MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
                                if (result == DialogResult.Yes)
                                {
                                    qlkh.themKhachHang(txtMaKhachHang.Text, txtTenKhachHang.Text, txtSoDienThoai.Text, txtCMND.Text);
                                    MessageBox.Show("Lưu thông tin khách hàng " + txtMaKhachHang.Text + "thành công");
                                }
                                else
                                {
                                    return;
                                }
                               
                            }
                            catch
                            {
                                MessageBox.Show("Lỗi hệ thống!");
                            }
                            
                        }
                        else
                        {
                            try
                            {
                                DialogResult result;

                                result = MessageBox.Show("Bạn muốn lưu thay đổi khách hàng " + txtMaKhachHang.Text + " ?",
                                    "Thông báo", MessageBoxButtons.YesNo,
                                    MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
                                if (result == DialogResult.Yes)
                                {
                                    qlkh.suaKhachHang(txtMaKhachHang.Text, txtTenKhachHang.Text, txtSoDienThoai.Text, txtCMND.Text, int.Parse(txtDiem.Text));
                                    MessageBox.Show("Cập nhật thông tin khách hàng " + txtMaKhachHang.Text + "thành công");
                                }
                                else
                                {
                                    return;
                                }
                                
                            }
                            catch
                            {
                                MessageBox.Show("Lỗi hệ thống!");
                            }
        }
                    }
                    
                }
                else
                {
                    MessageBox.Show("Vui lòng nhập đủ thông tin !");
                    return;
                }
              
            }
            catch
            {
                MessageBox.Show("Lỗi hệ thống!");
            }
            reset();
            frmKhachHang_Load(sender, e);
            
        }

        private void txtSoDienThoai_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            if(txtTimKiem.Text.Length > 0)
            {
                dataGridViewKhachHang.DataSource = qlkh.loadGridViewKhachHangTheoTen(txtTimKiem.Text);
               
            }
            else
            {
                dataGridViewKhachHang.DataSource = qlkh.loadGridViewKhachHang();
            }    
           
        }
    }
}
