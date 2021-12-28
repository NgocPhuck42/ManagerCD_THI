using ManagerCD.DAO;
using ManagerCD.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManagerCD.FORM
{
    public partial class frmCD : Form
    {
        private int idCD;
        BindingSource cd = new BindingSource();
        public frmCD()
        {
            InitializeComponent();
            dtgvCD.DataSource = cd;
        }

        void LoadListCD()
        {
            dtgvCD.DataSource = CDDAO.Intansce.LoadListCD();
            
        }
        List<CDCategory> SearchCDbyName(string name)
        {
            List<CDCategory> list = CDDAO.Intansce.SearchCDByName(name);

            return list;
        }

        void DeleteCD(int id)
        {
            if (CDDAO.Intansce.DeleteCD(id))
            {
                MessageBox.Show("Xóa loại thành công");
            }
            else
            {
                MessageBox.Show("Xóa loại thất bại");
            }
            LoadListCD();
        }
        private void btnAddCD_Click(object sender, EventArgs e)
        {
            new frmXuLyCD(null).ShowDialog();
            LoadListCD();
        }

        
        private void frmCD_Load(object sender, EventArgs e)
        {
            LoadListCD();
            dtgvCD.Columns["id"].Width = 100;
            dtgvCD.Columns["id"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft; 
            dtgvCD.Columns["id"].HeaderText = "Mã loại";
            dtgvCD.Columns[3].Width = 200;
            dtgvCD.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dtgvCD.Columns[3].DefaultCellStyle.Format = "N0";
            dtgvCD.Columns[3].HeaderText = "Giá";
            dtgvCD.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dtgvCD.Columns[1].HeaderText = "Tên đĩa";
            dtgvCD.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dtgvCD.Columns[2].HeaderText = "Tên loại";
            dtgvCD.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dtgvCD.Columns[4].HeaderText = "Trạng thái";
        }

        private void dtgvCD_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var id = dtgvCD.Rows[e.RowIndex].Cells["id"].Value.ToString();
            new frmXuLyCD(id).ShowDialog();
            LoadListCD();
        }

        private void btnSearchCD_Click(object sender, EventArgs e)
        {
            var namecd = txbSearchCD.Text.Trim();

            if (string.IsNullOrEmpty(namecd))
            {
                MessageBox.Show("Vui lòng nhập tên loại CD cần tìm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                LoadListCD();
                return;

            }
           
            dtgvCD.DataSource = SearchCDbyName(namecd);
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            LoadListCD();
        }

        private void btnDeleteCD_Click(object sender, EventArgs e)
        {
          //  idCD = int.Parse(int.Parse(dtgvCD.Rows[e.RowIndex].Cells[0].Value.ToString());)
            int id = idCD;
            if (id == 0)
            {
                MessageBox.Show("Vui lòng chọn tên loại cần xóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;

            }
            if (MessageBox.Show("Bạn có muốn xóa loại phòng này hay không ?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                DeleteCD(id);
        }

        private void dtgvCD_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                idCD = int.Parse(dtgvCD.Rows[e.RowIndex].Cells[0].Value.ToString());
                txbSearchCD.Text = dtgvCD.Rows[e.RowIndex].Cells["NameCD"].Value.ToString();
                
            }
        }
    }
}
