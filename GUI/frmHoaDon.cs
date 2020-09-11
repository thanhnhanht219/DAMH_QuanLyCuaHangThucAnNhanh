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
    public partial class frmHoaDon : Form
    {
        HoaDon_BLL_DLL hd = new HoaDon_BLL_DLL();
        bool checkXuat = true;
        public frmHoaDon()
        {
            InitializeComponent();
        }
        
        public void openfromPOS()
        {
            btnXuatKho.Visible = false;
        }

        private void frmHoaDon_Load(object sender, EventArgs e)
        {
            dateTimePickerFrom.Value = DateTime.Now;
            dateTimePickerTo.Value = DateTime.Now;

            //dataGridViewHoaDon.DataSource = hd.layHoaDon();
            //if (dataGridViewHoaDon.Rows.Count == 0)
            //{
            //    MessageBox.Show("Chưa có hóa đơn nào");

            //}
            //else
            //{
            //    string mahd = dataGridViewHoaDon.Rows[0].Cells["MaHD"].FormattedValue.ToString();
            //    dataGridViewChiTietHD.DataSource = hd.layChiTietHoaDon(mahd);
            //}

        }

        private void dataGridViewHoaDon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try {

                if (dataGridViewHoaDon.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                {
                    dataGridViewHoaDon.CurrentRow.Selected = true;
                    string mahd = dataGridViewHoaDon.Rows[e.RowIndex].Cells["MaHD"].FormattedValue.ToString();
                    dataGridViewChiTietHD.DataSource = hd.layChiTietHoaDon(mahd);
                }

            }
            catch
            {
                MessageBox.Show("Vui lòng chọn hóa đơn !");
            }
            
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            if(txtTimKiem.Text.Length == 0)
            {
                dataGridViewHoaDon.DataSource = hd.layHoaDon();
            }
            else
            {
                dataGridViewHoaDon.DataSource = hd.loadGridViewTimKiemHoaDon(txtTimKiem.Text);
            }    
        }

        private void dateTimePickerFrom_ValueChanged(object sender, EventArgs e)
        {
            dataGridViewHoaDon.DataSource = hd.loadHoaDonTheoNgay(dateTimePickerFrom.Value, dateTimePickerTo.Value);

            if (dataGridViewHoaDon.Rows.Count == 0)
            {
                
                dataGridViewChiTietHD.DataSource = null;
            }
            else
            {
                string mahd = dataGridViewHoaDon.Rows[0].Cells["MaHD"].FormattedValue.ToString();
                dataGridViewChiTietHD.DataSource = hd.layChiTietHoaDon(mahd);
            }
        }

        private void btnXuatKho_Click(object sender, EventArgs e)
        {
            hd.xuatKho(dateTimePickerFrom.Value, dateTimePickerTo.Value);

        }
    }
}
