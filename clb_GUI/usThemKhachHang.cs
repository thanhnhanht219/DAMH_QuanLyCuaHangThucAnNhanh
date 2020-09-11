using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL_DAL;

namespace clb_GUI
{
    public partial class usThemKhachHang : UserControl
    {
        qlKhachHang_BLL_DAL qlkh = new qlKhachHang_BLL_DAL();
        List<string> lstStringTextBox;
        public int tag = 0;
        public string ma;
        public usThemKhachHang()
        {
            InitializeComponent();

        }
        public List<string> addList()
        {
            lstStringTextBox = new List<string>();
            lstStringTextBox.Add(txtTenKhachHang.Text);
            lstStringTextBox.Add(txtSoDienThoai.Text);
            lstStringTextBox.Add(txtCMND.Text);
            return lstStringTextBox;
        }

        public bool isEmpty(List<string> lst)
        {
            int count = 0;
            foreach (string s in lst)
            {
                if (s.Length == 0)
                {
                    count++;
                }
            }
            return count != 0;
        }
        private void btnKhachHang_Click(object sender, EventArgs e)
        {

            if (isEmpty(addList()))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
            }
            else if (txtSoDienThoai.Text.Length != 10)
            {
                MessageBox.Show("Số điện thoại bạn nhập không hợp lệ");
                return;
            }
            else if (txtCMND.Text.Length != 10)
            {
                MessageBox.Show("CMND bạn nhập không hợp lệ");
                return;

            }
            else
            {
                if (qlkh.kiemtraSoDienThoaiTonTai(txtSoDienThoai.Text) == 1)
                {
                    try
                    {
                        DialogResult result;

                        result = MessageBox.Show("Bạn muốn lưu khách hàng " + txtTenKhachHang.Text + " ?",
                            "Thông báo", MessageBoxButtons.YesNo,
                            MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
                        if (result == DialogResult.Yes)
                        {
                            int soluongKH = qlkh.demSoLuongKhachHang() + 1;
                            qlkh.themKhachHang("KH00" + soluongKH, txtTenKhachHang.Text, txtSoDienThoai.Text, txtCMND.Text);
                            MessageBox.Show("Lưu thông tin khách hàng " + txtTenKhachHang.Text + "thành công");
                            tag = 1;
                            ma = soluongKH.ToString();
                            txtCMND.Clear();
                            txtTenKhachHang.Clear();
                            txtSoDienThoai.Clear();
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
                    MessageBox.Show("Số điện thoại này đã được đăng ký");
                }

            }
        }
    }
}
