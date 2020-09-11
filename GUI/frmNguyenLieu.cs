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
    public partial class frmNguyenLieu : Form
    {
        NguyenLieu_BLL_DAL nl = new NguyenLieu_BLL_DAL();

        public frmNguyenLieu()
        {
            InitializeComponent();
        }

        private void frmNguyenLieu_Load(object sender, EventArgs e)
        {
            cboLoc.SelectedIndex = 0;
            load_AllGrid();
            load_cbo_Loai();
        }

        // >>>>>>>>>> HÀM <<<<<<<<<<
        // Hàm kiểm tra text box
        Boolean kiemTraNull()
        {
            if (txt_MaNguyenLieu.Text != "")
            {
                if (txt_TenNguyenLieu.Text != "")
                {
                    if (txt_DonVi.Text != "")
                    {
                        if (txt_SoLuong.Text != "")
                        {
                            if (cbo_TenLoai.Text != "")
                            {
                                return true;
                            }
                            else
                            {
                                MessageBox.Show("Không được để trống Loại nguyên liệu");
                                return false;
                            }
                        }
                        else
                        {
                            MessageBox.Show("Không được để trống số lượng");
                            return false;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Không được để trống đơn vị");
                        return false;
                    }
                }
                else
                {
                    MessageBox.Show("Không được để trống tên nguyên liệu");
                    return false;
                }

            }
            else
            {
                MessageBox.Show("Không được để trống mã nguyên liệu");
                return false;
            }
        }
        // hàm load cbo MaLoai
        void load_cbo_Loai()
        {
            cbo_TenLoai.DataSource = nl.load_cboMaLoai();
            cbo_TenLoai.DisplayMember = "TenLoai";
            cbo_TenLoai.ValueMember = "MaLoaiNL";
        }
        // chọn đưa control textbox về null
        void textboxVeNull()
        {
            txt_TenNguyenLieu.Text = "";
            txt_DonVi.Text = "";
            txt_SoLuong.Text = "";
            cbo_TenLoai.SelectedIndex = -1;
        }
        // load grid
        void load_AllGrid()
        {
            // load nguyên liệu
            dgrv_HienThiNguyenLieu.DataSource = nl.loadNguyenLieuFormKho();

        }

        // >>>>>>>>>> KẾT THÚC HÀM <<<<<<<<<<
        private void btnThem_Click(object sender, EventArgs e)
        {
            load_AllGrid();
            btnXoa.Enabled = false;
            btnSua.Enabled = false;
            btnLuu.Enabled = true;
            textboxVeNull();
            txt_MaNguyenLieu.Text = nl.taoMaNguyenLieu();
            txt_TenNguyenLieu.Focus();
            cbo_TenLoai.SelectedIndex = 0;
        }

        private void frmKho_Load(object sender, EventArgs e)
        {
            //string[] arr = { "Hàng Còn Trong Kho", "Hàng Sắp Hết Hạn", "Hàng Mới Nhập", "Hàng Sắp Hết", "Hàng Đã Hết" };
            //if (cbo_TenLoai.Items.Count > 0)
            //{
            //    foreach (string item in arr)
            //    {
            //        btn = new btn_ChucNang(item);
            //        flowLayoutPanel_ChucNang.Controls.Add(btn);
            //    }
            //}   
        }

        private void dgrv_HienThiNguyenLieu_SelectionChanged(object sender, EventArgs e)
        {
            if (dgrv_HienThiNguyenLieu.SelectedCells.Count > 0)
            {
                btnSua.Enabled = true;
                btnXoa.Enabled = true;
                int vitri = dgrv_HienThiNguyenLieu.SelectedCells[0].RowIndex;

                string MaNL = dgrv_HienThiNguyenLieu.Rows[vitri].Cells[0].Value.ToString().Trim();
                string TenNL = dgrv_HienThiNguyenLieu.Rows[vitri].Cells[1].Value.ToString().Trim();
                string DonVi = dgrv_HienThiNguyenLieu.Rows[vitri].Cells[2].Value.ToString().Trim();
                string SoLuong = dgrv_HienThiNguyenLieu.Rows[vitri].Cells[3].Value.ToString().Trim();
                string HSD = dgrv_HienThiNguyenLieu.Rows[vitri].Cells[4].Value.ToString().Trim();
                string TenLoai = dgrv_HienThiNguyenLieu.Rows[vitri].Cells[5].Value.ToString().Trim();

                txt_MaNguyenLieu.Text = MaNL;
                txt_TenNguyenLieu.Text = TenNL;
                txt_DonVi.Text = DonVi;
                txt_SoLuong.Text = SoLuong;
                //txt_HSD.Text = HSD;
                txt_HSD.Value =  Convert.ToDateTime(HSD);
                cbo_TenLoai.Text = TenLoai;
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            txt_TenNguyenLieu.Focus();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (kiemTraNull() == true)
            {
                if (nl.kiemtrakhoachinh(txt_MaNguyenLieu.Text) == 1)
                {
                    nl.themNguyenLieu(txt_MaNguyenLieu.Text, txt_TenNguyenLieu.Text, txt_DonVi.Text, Convert.ToInt32(txt_SoLuong.Text), txt_HSD.Value, cbo_TenLoai.SelectedValue.ToString());
                    load_AllGrid();
                    textboxVeNull();
                    MessageBox.Show("Lưu thành công");
                }
                else
                {
                    nl.suaNguyenLieu(txt_MaNguyenLieu.Text.Trim(), txt_TenNguyenLieu.Text, txt_DonVi.Text, Convert.ToInt32(txt_SoLuong.Text), txt_HSD.Value, cbo_TenLoai.SelectedValue.ToString());
                    load_AllGrid();
                    textboxVeNull();
                    MessageBox.Show("Lưu thành công");
                }
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            nl.xoaNguyenLieu(txt_MaNguyenLieu.Text);
            load_AllGrid();
        }

        private void cboLoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cboLoc.SelectedIndex == 0 )
            {
                dgrv_HienThiNguyenLieu.DataSource = nl.loadNguyenLieuFormKho();

            }    
            else if(cboLoc.SelectedIndex == 1)
            {
                string now = DateTime.Now.ToShortDateString();
                dgrv_HienThiNguyenLieu.DataSource = nl.loadGridViewTheoHangHetDate(Convert.ToDateTime(now));
            }
            else
            {
                dgrv_HienThiNguyenLieu.DataSource = nl.loadGridViewTheoHangHetTrongKho();
            }
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {

            if (txtTimKiem.Text.Length > 0)
            {
                dgrv_HienThiNguyenLieu.DataSource = nl.loadGridViewNguyenLieuTimKiem(txtTimKiem.Text);
            }
            else
            {
                dgrv_HienThiNguyenLieu.DataSource = nl.loadNguyenLieuFormKho();
            }
        }

        private void txt_SoLuong_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txt_SoLuong_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
