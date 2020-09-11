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
    public partial class frmPhieuNhanHang : Form
    {

        NguyenLieu_BLL_DAL nl = new NguyenLieu_BLL_DAL();
        BLL_DAL_PhieuDatHang pd = new BLL_DAL_PhieuDatHang();
        BLL_DAL_PhieuNhanHang pn = new BLL_DAL_PhieuNhanHang();
        BLL_DAL_ChiTietPhieuNhanHang ct = new BLL_DAL_ChiTietPhieuNhanHang();

        string maNLDangChon;
        string tenNLDangChon;
        string maPhieuTuSinh;
        string maPhieuDangChon;
        double tong;

        public frmPhieuNhanHang()
        {
            InitializeComponent();
        }

        //>>>>>>>>>> HÀM <<<<<<<<<<

        // Kiểm tra null
        Boolean kiemTraNull()
        {
            if (txt_maPhieuNhan.Text != "")
            {
                if (cbo_PhieuDat.Text != "")
                {
                    if (txt_NgayNhan.Text !="")
                    {
                        if(txt_TongTien.Text != "")
                        {
                            return true;
                        }
                        else
                        {
                            MessageBox.Show("Không được để trống Tổng Tiền");
                            return false;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Không được để trống Ngày Nhận");
                        return false;
                    }
                }
                else
                {
                    MessageBox.Show("Không được để trống Mã Phiếu đặt");
                    return false;
                }
            }
            else
            {
                MessageBox.Show("Không được để trống Mã Phiếu Nhận");
                return false;
            }
        }

        // load cbo
        void load_cbo()
        {
            // load cbo các phiếu đặt hàng
            cbo_PhieuDat.DataSource = pd.loadPhieuDatHang();
            cbo_PhieuDat.DisplayMember = "MaHDNH";
            cbo_PhieuDat.ValueMember = "MaHDNH";
        }

        // load grid 
        void load_DataGridView()
        {
            // dgv Nguyen Lieu
            dataGridViewNguyenLieu.DataSource = nl.loadNguyenLieu();

            // load dgv phiếu nhận
            dataGridViewPhieuNhanHang.DataSource = pn.load_PhieuNhan();

            // load dgv chi tiết
            dataGridViewChiTiet.DataSource = ct.chiTietPhieuNhan(maPhieuDangChon);

        }

        // tính tổng 
        void tinhTong()
        {
            tong = 0;
            for (int i = 0; i <= dataGridViewChiTiet.Rows.Count - 1; i++)
            {
                tong = Convert.ToDouble(dataGridViewChiTiet.Rows[i].Cells[2].Value.ToString().Trim()) * Convert.ToDouble(dataGridViewChiTiet.Rows[i].Cells[3].Value.ToString().Trim()) + tong;
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
        //>>>>>>>>>> KẾT THÚC HÀM <<<<<<<<<<


        private void frmPhieuNhanHang_Load(object sender, EventArgs e)
        {
            load_DataGridView();
            load_cbo();
        }

        private void dataGridViewNguyenLieu_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridViewNguyenLieu.SelectedCells.Count > 0)
            {
                txt_SoLuong.Text = "";
                txt_DonGia.Text = "";
                int vitri = dataGridViewNguyenLieu.SelectedCells[0].RowIndex;
                maNLDangChon = dataGridViewNguyenLieu.Rows[vitri].Cells[0].Value.ToString().Trim();
                tenNLDangChon = dataGridViewNguyenLieu.Rows[vitri].Cells[1].Value.ToString().Trim();
                txt_DonViTinh.Text = dataGridViewNguyenLieu.Rows[vitri].Cells[2].Value.ToString().Trim();
            }
        }

        private void btnLamMoiPhieuNhan_Click(object sender, EventArgs e)
        {
            btnSuaPhieuNhanHang.Enabled = false;
            btnLuuPhieuNhanHang.Enabled = true;
            maPhieuTuSinh = pn.taoMaPhieuNhanHang();
            txt_maPhieuNhan.Text = maPhieuTuSinh;
            txt_NgayNhan.Value = DateTime.Now;
            txt_TongTien.Text = "0";
            btnThemPhieuNhanHang.Enabled = true;
        }

        private void btnThemPhieuNhanHang_Click(object sender, EventArgs e)
        {
            if (kiemTraNull() == true)
            {
                if (pn.kT(txt_maPhieuNhan.Text) == true)
                {
                    pn.themPhieuNhan(txt_maPhieuNhan.Text, cbo_PhieuDat.Text, txt_NgayNhan.Value, Convert.ToInt32(txt_TongTien.Text));
                    load_DataGridView();
                    MessageBox.Show("Thêm thành công");
                }
                else
                {
                    MessageBox.Show("Mã phiếu nhận hàng bị trùng");
                    txt_maPhieuNhan.Focus();
                }
            }
        }

        private void dataGridViewPhieuNhanHang_SelectionChanged(object sender, EventArgs e)
        {
            btnSuaPhieuNhanHang.Enabled = true;
            if (dataGridViewPhieuNhanHang.SelectedCells.Count > 0)
            {
                int vt = dataGridViewPhieuNhanHang.SelectedCells[0].RowIndex;
                maPhieuDangChon = dataGridViewPhieuNhanHang.Rows[vt].Cells[0].Value.ToString().Trim();
                txt_maPhieuNhan.Text = maPhieuDangChon;
                cbo_PhieuDat.Text = dataGridViewPhieuNhanHang.Rows[vt].Cells[1].Value.ToString().Trim();
                txt_NgayNhan.Value = Convert.ToDateTime(dataGridViewPhieuNhanHang.Rows[vt].Cells[2].Value.ToString().Trim());
                txt_TongTien.Text = dataGridViewPhieuNhanHang.Rows[vt].Cells[3].Value.ToString().Trim();
                dataGridViewChiTiet.DataSource = ct.chiTietPhieuNhan(txt_maPhieuNhan.Text);
            }
        }

        private void btnThemNguyenLieuVaoChiTiet_Click(object sender, EventArgs e)
        {
            if (ct.ktTrung(maNLDangChon, maPhieuDangChon) == true)
            {
                if (kiemTraNhapChiTiet() == true)
                {
                    ct.themCTPhieuNhan(maPhieuDangChon, maNLDangChon, Convert.ToInt32(txt_SoLuong.Text), Convert.ToInt32(txt_DonGia.Text), txt_DonViTinh.Text);
                    dataGridViewChiTiet.DataSource = ct.chiTietPhieuNhan(maPhieuDangChon);
                    tinhTong();
                    pn.capNhatTong(maPhieuDangChon, (int)tong);
                    MessageBox.Show("Thêm thành công");
                    load_DataGridView();
                }
            }
            else
                MessageBox.Show("Nguyên liệu này đã đặt, bạn cần chọn nguyên liệu khác");
        }

        private void toolStripXoa_Click(object sender, EventArgs e)
        {
            ct.xoaCTPhieuNhan(maPhieuDangChon, maNLDangChon);
            dataGridViewChiTiet.DataSource = ct.chiTietPhieuNhan(maPhieuDangChon);
            tinhTong();
            pn.capNhatTong(maPhieuDangChon, (int)tong);
            MessageBox.Show("Xóa thành công");
            load_DataGridView();
        }

        private void dataGridViewChiTiet_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridViewChiTiet.SelectedCells.Count > 0)
            {
                int vt = dataGridViewChiTiet.SelectedCells[0].RowIndex;
                maPhieuDangChon = dataGridViewChiTiet.Rows[vt].Cells[0].Value.ToString().Trim();
                maNLDangChon = dataGridViewChiTiet.Rows[vt].Cells[1].Value.ToString().Trim();
                txt_SoLuong.Text = dataGridViewChiTiet.Rows[vt].Cells[2].Value.ToString().Trim();
                txt_DonGia.Text = dataGridViewChiTiet.Rows[vt].Cells[3].Value.ToString().Trim();
                txt_DonViTinh.Text = dataGridViewChiTiet.Rows[vt].Cells[4].Value.ToString().Trim();
            }
        }

        private void toolStripSua_Click(object sender, EventArgs e)
        {
            if (dataGridViewChiTiet.SelectedCells.Count > 0)
            {
                int vt = dataGridViewChiTiet.SelectedCells[0].RowIndex;
                string maDH = dataGridViewChiTiet.Rows[vt].Cells[0].Value.ToString().Trim();
                string maNL = dataGridViewChiTiet.Rows[vt].Cells[1].Value.ToString().Trim();
                string DVT = txt_DonViTinh.Text;
                int SL = Convert.ToInt32(txt_SoLuong.Text);
                int donGia = Convert.ToInt32(txt_DonGia.Text);
                ct.suaCTPhieuNhan(maDH, maNL, SL, donGia, DVT);
                dataGridViewChiTiet.DataSource = ct.chiTietPhieuNhan(maPhieuDangChon);
                tinhTong();
                pn.capNhatTong(maPhieuDangChon, (int)tong);
                MessageBox.Show("Sửa thành công");
                load_DataGridView();
            }
        }

        private void btnNhapChiTietPhieu_Click(object sender, EventArgs e)
        {
            if (dataGridViewChiTiet.SelectedCells.Count > 0)
            {
                int vt = dataGridViewChiTiet.SelectedCells[0].RowIndex;
                string maDH = dataGridViewChiTiet.Rows[vt].Cells[0].Value.ToString().Trim();
                string maNL = dataGridViewChiTiet.Rows[vt].Cells[1].Value.ToString().Trim();
                string DVT = txt_DonViTinh.Text;
                int SL = Convert.ToInt32(txt_SoLuong.Text);
                int donGia = Convert.ToInt32(txt_DonGia.Text);
                ct.suaCTPhieuNhan(maDH, maNL, SL, donGia, DVT);
                dataGridViewChiTiet.DataSource = ct.chiTietPhieuNhan(maPhieuDangChon);
                tinhTong();
                pn.capNhatTong(maPhieuDangChon, (int)tong);
                MessageBox.Show("Sửa thành công");
                load_DataGridView();
            }
        }

        private void btnSuaPhieuNhanHang_Click(object sender, EventArgs e)
        {
            pn.suaPhieuNhan(txt_maPhieuNhan.Text, cbo_PhieuDat.Text, DateTime.Now, Convert.ToInt32(txt_TongTien.Text.Replace(".0000", "").ToString().Trim()));
            MessageBox.Show("Sửa thành công");
            load_DataGridView();
        }

        private void btnXoaDongChiTietPDH_Click(object sender, EventArgs e)
        {
            ct.xoaCTPhieuNhan(maPhieuDangChon, maNLDangChon);
            dataGridViewChiTiet.DataSource = ct.chiTietPhieuNhan(maPhieuDangChon);
            tinhTong();
            pn.capNhatTong(maPhieuDangChon, (int)tong);
            MessageBox.Show("Xóa thành công");
            load_DataGridView();
        }

        private void xóaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridViewChiTiet.Rows.Count == 0)
            {
                pn.xoaPhieuNhan(maPhieuDangChon);
                MessageBox.Show("Xóa thành công");
                load_DataGridView();
            }
            else
                MessageBox.Show("Phải xóa chi tiết trước");
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
