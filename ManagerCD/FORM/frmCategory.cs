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
    public partial class frmCategory : Form
    {
        BindingSource category = new BindingSource();
        public frmCategory()
        {
            InitializeComponent();
         //   AddCategoryBinding();
        //    LoadListCategory();
        }
        private int idCategory;
        void LoadListCategory()
        {
            dtgvCategoryCD.DataSource = CategoryDAO.Instance.GetListCategory();
        }

        private void frmCategory_Load(object sender, EventArgs e)
        {
            LoadListCategory();
            dtgvCategoryCD.Columns[0].Width = 100;
            dtgvCategoryCD.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dtgvCategoryCD.Columns[0].HeaderText = "Mã loại";
            dtgvCategoryCD.Columns[2].Width = 200;
            dtgvCategoryCD.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dtgvCategoryCD.Columns[2].DefaultCellStyle.Format = "N0";
            dtgvCategoryCD.Columns[2].HeaderText = "Giá";
            dtgvCategoryCD.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dtgvCategoryCD.Columns[1].HeaderText = "Tên loại";
        }

        private void txbPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        void AddCategory(string nameccd, int price)
        {
            if(CategoryDAO.Instance.InsertCategory(nameccd, price))
            {
                MessageBox.Show("Thêm loại thành công");
            }
            else {
                MessageBox.Show("Thêm loại thất bại");
            }
            LoadListCategory();
        }

        void UpdateCategory(int id, string nameccd, int price)
        {
            if (CategoryDAO.Instance.UpdateCategory(id, nameccd, price))
            {
                MessageBox.Show("Cập nhật loại thành công");
            }
            else
            {
                MessageBox.Show("Cập nhật loại thất bại");
            }
            LoadListCategory();
        }

        void DeleteCategory(int id)
        {
            if (CategoryDAO.Instance.DeleteCategory(id))
            {
                MessageBox.Show("Xóa loại thành công");
            }
            else
            {
                MessageBox.Show("Xóa loại thất bại");
            }
            LoadListCategory();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var tenloai = txbNameCD.Text.Trim();
            var gia = int.Parse(txbPrice.Text);

            if (string.IsNullOrEmpty(tenloai))
            {
                MessageBox.Show("Vui lòng nhập tên loại CD cần cập nhật", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;

            }
            if (gia < 5000)
            {
                MessageBox.Show("Vui lòng nhập giá tối thiểu là 5000", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            AddCategory(tenloai, gia);


        }

        List<Category> SearchCategoryByName(string namecc)
        {
            List<Category> list = CategoryDAO.Instance.SearchCategoryByName(namecc);

            return list;
        }

        void AddCategoryBinding()
        {
            txbNameCD.DataBindings.Add(new Binding("Text", dtgvCategoryCD.DataSource, "NameCCD", true, DataSourceUpdateMode.Never));
            txbPrice.DataBindings.Add(new Binding("Text", dtgvCategoryCD.DataSource, "Price", true, DataSourceUpdateMode.Never));
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            int id = idCategory;
            var tenloai = txbNameCD.Text.Trim();
            var gia = int.Parse(txbPrice.Text);

            if (id==0)
            {
                MessageBox.Show("Vui lòng chọn tên loại cần cập nhật", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;

            }
            if (string.IsNullOrEmpty(tenloai))
            {
                MessageBox.Show("Vui lòng nhập tên loại CD cần cập nhật", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;

            }
            if (gia < 5000)
            {
                MessageBox.Show("Vui lòng nhập giá tối thiểu là 5000", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            UpdateCategory(id, tenloai, gia);
        }
       
        private void dtgvCategoryCD_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex>=0)
            {
                idCategory = int.Parse(dtgvCategoryCD.Rows[e.RowIndex].Cells[0].Value.ToString());
                txbNameCD.Text = dtgvCategoryCD.Rows[e.RowIndex].Cells[1].Value.ToString();
                txbPrice.Text = dtgvCategoryCD.Rows[e.RowIndex].Cells[2].Value.ToString();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int id = idCategory;
            if (id == 0)
            {
                MessageBox.Show("Vui lòng chọn tên loại cần xóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
                
            }
            if(MessageBox.Show("Bạn có muốn xóa loại phòng này hay không ?", "Xác nhận xóa", MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes)
                DeleteCategory(id);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            var tenloai = txbNameCD.Text.Trim();


            if (string.IsNullOrEmpty(tenloai))
            {
                MessageBox.Show("Vui lòng nhập tên loại CD cần tìm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                LoadListCategory();
                return;

            }
            dtgvCategoryCD.DataSource = SearchCategoryByName(tenloai);
        }

    }
}
