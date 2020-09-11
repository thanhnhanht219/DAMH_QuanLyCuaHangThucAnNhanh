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
    public partial class frmPhanQuyen : Form
    {
        QL_NhanSu_BLL_DAL qlns = new QL_NhanSu_BLL_DAL();
        List<QL_PhanQuyen> lstPQ;
        List<QL_ManHinh> lstMH;

        public frmPhanQuyen()
        {
            InitializeComponent();            
            trangthaiBD();
        }

        private void trangthaiBD()
        {
            groupten.Enabled = false;
            groupma.Enabled = false;
            stripLuu.Enabled = false;
            stripThemNhom.Enabled = true;
            stripXoaNhom.Enabled = true;
            stripSuaNhom.Enabled = true;
            grdNhom.Enabled = true;
            loadGrdViewNhom();

        }

        private void loadGrdViewNhom()
        {
            grdNhom.DataSource =  qlns.layNhomND();
        }

        private void loadGrdViewManHinhPhanQuyen()
        {
        
        }

        private void frmPhanQuyen_Load(object sender, EventArgs e)
        {
            loadGrdViewNhom();

        }

        private void frmPhanQuyen_FormClosing(object sender, FormClosingEventArgs e)
        {
         
        }

        private void stripDong_Click(object sender, EventArgs e)
        {
          
        }

        private void grdManHinh_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void stripLuu_Click(object sender, EventArgs e)
        {
            QL_NhomNguoiDung nnd = new QL_NhomNguoiDung()
            {
                MaNhom = txtMaNhom.Text,
                TenNhom = txtTenNhom.Text
            };
            lstPQ = layPQ();
            if(stripThemNhom.Enabled == true)
            {                
                if(qlns.themNhomND(nnd,lstPQ))
                {
                    MessageBox.Show("Thành công");
                }
                else
                {
                    MessageBox.Show("Thất bại");
                }
            }
            else
            {
                if(qlns.suaNhomND(nnd,lstPQ))
                {
                    MessageBox.Show("Thành công");
                }
                else
                {
                    MessageBox.Show("Thất bại");
                }
            }
            qlns.submitChange();
            trangthaiBD();
        }

        private void grdNhom_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = e.RowIndex;
            if (r < 0)
                return;
            txtMaNhom.Text = grdNhom.Rows[r].Cells[0].Value.ToString();
            txtTenNhom.Text = grdNhom.Rows[r].Cells[1].Value.ToString();
        }

        private void stripThemNhom_Click(object sender, EventArgs e)
        {
            grdNhom.Enabled = false;
            stripXoaNhom.Enabled = false;
            stripSuaNhom.Enabled = false;
            txtTenNhom.Text = "";
           
            txtMaNhom.Text = "Nhom" + grdNhom.Rows.Count;
            groupma.Enabled = false;
            groupten.Enabled = true;         
            stripLuu.Enabled = true;
            lstPQ = new List<QL_PhanQuyen>();

            foreach (QL_ManHinh item in qlns.layMH())
            {
               QL_PhanQuyen newqp = new QL_PhanQuyen()
               {
                   MaNhom = txtMaNhom.Text,
                   MaMH = item.MaMH,
                   CoQuyen = false,
                   TenManHinh = item.TenMH
               };
               lstPQ.Add(newqp);
            }

            gvManHinh.DataSource = lstPQ;
        }

        private void stripSuaNhom_Click(object sender, EventArgs e)
        {
            grdNhom.Enabled = false;
            stripXoaNhom.Enabled = false;
            stripThemNhom.Enabled = false;
            groupma.Enabled = false;
            groupten.Enabled = true;

            stripLuu.Enabled = true;
            lstPQ = layPQ();
            
        }

        private List<QL_PhanQuyen> layPQ()
        {
            List<QL_PhanQuyen> lst = new List<QL_PhanQuyen>();
            foreach (DataGridViewRow item in gvManHinh.Rows)
            {
                QL_PhanQuyen pq = new QL_PhanQuyen()
                {
                    MaMH = item.Cells[1].Value.ToString(),
                    MaNhom = txtMaNhom.Text,                    
                };
                if (item.Cells[2].Value.ToString() == "True")
                {
                    pq.CoQuyen = true;
                }
                else
                    pq.CoQuyen = false;
                
                lst.Add(pq);
            }
            return lst; 
                
            
        }

        private void stripXoaNhom_Click(object sender, EventArgs e)
        {
            if (grdNhom.SelectedRows.Count == 0)
            {
                MessageBox.Show("Bạn chưa chọn nhóm cần xóa");
            }
            else
            {
                DialogResult r = new DialogResult();
                r = MessageBox.Show("Bạn có muốn xóa nhóm này không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
                if (r == DialogResult.Yes)
                {

                    foreach (DataGridViewRow nhom in grdNhom.SelectedRows)
                    {                        
                        if (qlns.xoaNhomND(nhom.Cells[0].Value.ToString()))
                        {
                            MessageBox.Show("Xóa nhóm thành công");
                        }
                        else
                        {
                            MessageBox.Show("Xóa nhóm thất bại");
                        }
                    }
                }
                txtMaNhom.Text = txtTenNhom.Text = string.Empty;
                trangthaiBD();
            }
        }

        private void grdNhom_SelectionChanged(object sender, EventArgs e)
        {
            foreach  (DataGridViewRow item in grdNhom.SelectedRows)
            {
                gvManHinh.DataSource = qlns.layMH(item.Cells[0].Value.ToString().Trim());
                txtMaNhom.Text = item.Cells[0].Value.ToString();
                txtTenNhom.Text = item.Cells[1].Value.ToString();
            }
        }
    }
}
