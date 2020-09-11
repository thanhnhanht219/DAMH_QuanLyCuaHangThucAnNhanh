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
    public partial class frmPhieuDatHang : Form
    {
        NguyenLieu_BLL_DAL nl = new NguyenLieu_BLL_DAL();
        BLL_DAL_NhaCungCap ncc = new BLL_DAL_NhaCungCap();
        BLL_DAL_PhieuDatHang dh = new BLL_DAL_PhieuDatHang();
        BLL_DAL_ChiTietPhieuDatHang ct = new BLL_DAL_ChiTietPhieuDatHang();

        string maNLDangChon;
        string tenNLDangChon;
        string maPhieuDangChon;
        string maND = "ND01";
        double tong = 0;

        public frmPhieuDatHang()
        {
            InitializeComponent();
        }

        //>>>>>>>>>> HÀM <<<<<<<<<<


        // Kiểm tra các text box null
        Boolean kiemTra()
        {
            if (txt_maPhieu.Text != "")
            {
                if(txt_NgayNhap.Text != "")
                {
                    if (txt_TongTien.Text !="")
                    {
                        if(cbo_PhuongThuc.Text != "")
                        {
                            if(txt_NhanVienDat.Text != "")
                            {
                                if(cbo_TinhTrang.Text != "")
                                {
                                    return true;
                                }
                                else
                                {
                                    MessageBox.Show("Không được để trống Tình Trạng");
                                    return false;
                                }
                            }
                            else
                            {
                                MessageBox.Show("Không được để trống Nhân viên đặt");
                                return false;
                            }
                        }
                        else
                        {
                            MessageBox.Show("Không được để trống Phương Thức");
                            return false;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Không được để trống Tổng tiền");
                        return false;
                    }
                }
                else
                {
                    MessageBox.Show("Không được để trống Ngày Nhập");
                    return false;
                }
            }
            else
            {
                MessageBox.Show("Không được để trống Mã Phiếu");
                return false;
            }
        }
        // Hàm tính tổng 
        void tinhTong()
        {
            tong = 0;
            for (int i = 0; i <= dataGridViewChiTiet.Rows.Count - 1; i++)
            {
                tong = Convert.ToDouble(dataGridViewChiTiet.Rows[i].Cells[3].Value.ToString().Trim()) * Convert.ToDouble(dataGridViewChiTiet.Rows[i].Cells[4].Value.ToString().Trim()) + tong;
            }
            txt_TongTien.Text = tong.ToString();
        }

        // Kiểm tra các textbox vs combobox
        private bool kiemTraNhapChiTiet()
        {
            if (txt_SoLuong.Text != "")
            {
                if (txt_DonGia.Text != "")
                {
                    return true;
                }
                else
                {
                    MessageBox.Show("Không được để trống đơn giá");
                    return false;
                }
            }
            else
            {
                MessageBox.Show("Không được để trống số lượng");
                return false;
            }
        }

        // Bỏ chọn tất cả các grid
        void boChonGrid()
        {
            dataGridViewNguyenLieu.ClearSelection();
            dataGridViewPhieuDatHang.ClearSelection();
            dataGridViewChiTiet.ClearSelection();
        }

        // load cbo Nhà cung cấp
        void load_cbo()
        {
            // cbo Nhà cung cấp
            cbo_NhaCungCap.DataSource = ncc.loadNhaCungCap();
            cbo_NhaCungCap.DisplayMember = "TenNCC";
            cbo_NhaCungCap.ValueMember = "MaNCC";
            cbo_NhaCungCap.SelectedIndex = 0;

            // cbo Tình trạng
            cbo_TinhTrang.Items.Add("Chưa thanh toán");
            cbo_TinhTrang.Items.Add("Đã thanh toán");
            cbo_TinhTrang.SelectedIndex = 0;

            // cbo Phương thức
            cbo_PhuongThuc.Items.Add("Online");
            cbo_PhuongThuc.Items.Add("Thủ công");
            cbo_PhuongThuc.SelectedIndex = 0;
        }


        // Load grid 
        void load_DataGridView()
        {
            // dgv Nguyen Lieu
            dataGridViewNguyenLieu.DataSource = nl.loadNguyenLieu();

            // dgv Phieu Dat Hang
            dataGridViewPhieuDatHang.DataSource = dh.loadPhieuDatHang();

            //// dgv Chi Tiet Phieu Dat Hang
            //dataGridViewChiTiet.DataSource = ct.load_ChiTietPhieuDatHang();
        }

        //>>>>>>>>>> KẾT THÚC HÀM <<<<<<<<<<

        private void btnThemNguyenLieuVaoChiTiet_Click(object sender, EventArgs e)
        {
            if (ct.ktTrung(maPhieuDangChon,maNLDangChon) == true)
            {
                if (kiemTraNhapChiTiet() == true)
                {
                    ct.themChiTietPhieuNhap(maPhieuDangChon, maNLDangChon, txt_DonViTinh.Text, Convert.ToInt32(txt_SoLuong.Text), Convert.ToInt32(txt_DonGia.Text));
                    dataGridViewChiTiet.DataSource = ct.load_chiTietPhieuDatHangTheoMa(maPhieuDangChon);
                    tinhTong();
                    dh.capNhatTongTien(maPhieuDangChon, (int)tong);
                    load_DataGridView();
                    MessageBox.Show("Thêm thành công");
                }
            }
            else
                MessageBox.Show("Nguyên liệu này đã đặt, bạn cần chọn nguyên liệu khác");
        }

        private void btnThemPhieuDatHang_Click(object sender, EventArgs e)
        {
            if (kiemTra() == true)
            {
                if (dh.kT(txt_maPhieu.Text) == true)
                {
                    btnLuuPhieuDatHang.Enabled = true;
                    dh.themPhieuDatHang(txt_maPhieu.Text, cbo_NhaCungCap.SelectedValue.ToString(), txt_NgayNhap.Value, Convert.ToInt32(txt_TongTien.Text), txt_NhanVienDat.Text, cbo_PhuongThuc.Text, cbo_TinhTrang.Text);
                    MessageBox.Show("Thêm thành công");
                    load_DataGridView();
                    btnThemPhieuDatHang.Enabled = false;
                }
                else
                {
                    MessageBox.Show("Mã phiếu đặt hàng bị trùng");
                    txt_maPhieu.Focus();
                }
            }  
        }

        private void btnXoaDongChiTietPDH_Click(object sender, EventArgs e)
        {
            if (dataGridViewChiTiet.SelectedCells.Count > 0)
            {
                int vt = dataGridViewChiTiet.SelectedCells[0].RowIndex;
                ct.xoaChiTietPhieuDatHang(dataGridViewChiTiet.Rows[vt].Cells[0].Value.ToString(), dataGridViewChiTiet.Rows[vt].Cells[1].Value.ToString());
                dataGridViewChiTiet.DataSource = ct.load_chiTietPhieuDatHangTheoMa(maPhieuDangChon);
                tinhTong();
                dh.capNhatTongTien(maPhieuDangChon, (int)tong);
                MessageBox.Show("Xóa thành công");
                load_DataGridView();
            }

        }

        private void guna2ControlBox1_Click(object sender, EventArgs e)
        {

        }

        private void frmPhieuDatHang_Load(object sender, EventArgs e)
        {
            load_cbo();
            load_DataGridView();
        }

        private void dataGridViewNguyenLieu_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridViewNguyenLieu.SelectedCells.Count > 0)
            {
                int vitri = dataGridViewNguyenLieu.SelectedCells[0].RowIndex;
                maNLDangChon = dataGridViewNguyenLieu.Rows[vitri].Cells[0].Value.ToString().Trim();
                tenNLDangChon = dataGridViewNguyenLieu.Rows[vitri].Cells[1].Value.ToString().Trim();
                txt_DonViTinh.Text = dataGridViewNguyenLieu.Rows[vitri].Cells[2].Value.ToString().Trim();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLamMoiPhieuDat_Click(object sender, EventArgs e)
        {
            btnSuaPhieuDatHang.Enabled = false;
            btnThemPhieuDatHang.Enabled = true;
            txt_TongTien.Text = "0";
            txt_NgayNhap.Value = DateTime.Now;
            txt_NhanVienDat.Text = maND;
            txt_maPhieu.Text = dh.taoMaPhieuDatHang();
            //txt_NgayNhap.Text = DateTime.Now.Day + "/ " + DateTime.Now.Month + "/ " + DateTime.Now.Year + "";
        }

        private void dataGridViewPhieuDatHang_SelectionChanged(object sender, EventArgs e)
        {
            btnSuaPhieuDatHang.Enabled = true;
            if (dataGridViewPhieuDatHang.SelectedCells.Count > 0)
            {
                int vt = dataGridViewPhieuDatHang.SelectedCells[0].RowIndex;
                maPhieuDangChon = dataGridViewPhieuDatHang.Rows[vt].Cells[0].Value.ToString().Trim();
                txt_maPhieu.Text = maPhieuDangChon;
                cbo_NhaCungCap.Text = dataGridViewPhieuDatHang.Rows[vt].Cells[1].Value.ToString().Trim();
                txt_NgayNhap.Value = Convert.ToDateTime(dataGridViewPhieuDatHang.Rows[vt].Cells[2].Value.ToString().Trim());
                txt_TongTien.Text = dataGridViewPhieuDatHang.Rows[vt].Cells[3].Value.ToString().Trim();
                txt_NhanVienDat.Text = dataGridViewPhieuDatHang.Rows[vt].Cells[4].Value.ToString().Trim();
                cbo_PhuongThuc.Text = dataGridViewPhieuDatHang.Rows[vt].Cells[5].Value.ToString().Trim();
                cbo_TinhTrang.Text = dataGridViewPhieuDatHang.Rows[vt].Cells[6].Value.ToString().Trim();
                dataGridViewChiTiet.DataSource = ct.load_chiTietPhieuDatHangTheoMa(maPhieuDangChon);
            }
        }

        private void toolStripSua_Click(object sender, EventArgs e)
        {
            ct.suaChiTiet(maPhieuDangChon, maNLDangChon, txt_DonViTinh.Text, Convert.ToInt32(txt_SoLuong.Text), Convert.ToInt32(txt_DonGia.Text));
            dataGridViewChiTiet.DataSource = ct.load_chiTietPhieuDatHangTheoMa(maPhieuDangChon);
            tinhTong();
            dh.capNhatTongTien(maPhieuDangChon, (int)tong);
            load_DataGridView();
            MessageBox.Show("Sửa thành công");
        }

        private void toolStripXoa_Click(object sender, EventArgs e)
        {
            if (dataGridViewChiTiet.SelectedCells.Count > 0)
            {
                int vt = dataGridViewChiTiet.SelectedCells[0].RowIndex;
                ct.xoaChiTietPhieuDatHang(dataGridViewChiTiet.Rows[vt].Cells[0].Value.ToString(), dataGridViewChiTiet.Rows[vt].Cells[1].Value.ToString());
                dataGridViewChiTiet.DataSource = ct.load_chiTietPhieuDatHangTheoMa(maPhieuDangChon);
                tinhTong();
                dh.capNhatTongTien(maPhieuDangChon, (int)tong);
                MessageBox.Show("Xóa thành công");
                load_DataGridView();
            }
        }

        private void dataGridViewChiTiet_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Tab && dataGridViewChiTiet.CurrentCell.ColumnIndex == 1)
            {
                e.Handled = true;
                DataGridViewCell cell = dataGridViewChiTiet.Rows[0].Cells[0];
                dataGridViewChiTiet.CurrentCell = cell;
                dataGridViewChiTiet.BeginEdit(true);
            }
        }

        private void dataGridViewChiTiet_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridViewChiTiet.SelectedCells.Count > 0)
            {
                int vt = dataGridViewChiTiet.SelectedCells[0].RowIndex;
                maPhieuDangChon = dataGridViewChiTiet.Rows[vt].Cells[0].Value.ToString().Trim();
                maNLDangChon = dataGridViewChiTiet.Rows[vt].Cells[1].Value.ToString().Trim();
                txt_SoLuong.Text = dataGridViewChiTiet.Rows[vt].Cells[3].Value.ToString().Trim();
                txt_DonGia.Text = dataGridViewChiTiet.Rows[vt].Cells[4].Value.ToString().Trim();
                txt_DonViTinh.Text = dataGridViewChiTiet.Rows[vt].Cells[2].Value.ToString().Trim();
            }

        }

        private void btnSuaPhieuDatHang_Click(object sender, EventArgs e)
        {
            dh.suaPhieuDatHang(txt_maPhieu.Text, cbo_NhaCungCap.SelectedValue.ToString(), txt_NgayNhap.Value, Convert.ToInt32(txt_TongTien.Text.Replace(".0000", "").ToString().Trim()), txt_NhanVienDat.Text, cbo_PhuongThuc.Text, cbo_TinhTrang.Text);
            MessageBox.Show("Sửa thành công");
            load_DataGridView();
        }

        private void xoaPDHToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                dh.xoaPhieuDathang(txt_maPhieu.Text);
                MessageBox.Show("Xóa thành công");
                load_DataGridView();
            }
            catch
            {
                MessageBox.Show("Không thể xóa hóa đơn đã được nhập hàng");
            }
            
        }

        private void txt_DonGia_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txt_SoLuong_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnNhapChiTietPhieu_Click(object sender, EventArgs e)
        {
            ct.suaChiTiet(maPhieuDangChon, maNLDangChon, txt_DonViTinh.Text, Convert.ToInt32(txt_SoLuong.Text), Convert.ToInt32(txt_DonGia.Text));
            dataGridViewChiTiet.DataSource = ct.load_chiTietPhieuDatHangTheoMa(maPhieuDangChon);
            tinhTong();
            dh.capNhatTongTien(maPhieuDangChon, (int)tong);
            load_DataGridView();
            MessageBox.Show("Sửa thành công");
        }

        private void txt_TongTien_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
