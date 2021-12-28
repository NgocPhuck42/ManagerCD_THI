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
    public partial class frmXuLyCD : Form
    {
        
        private string add;
        BindingSource cd = new BindingSource();
        public frmXuLyCD(string add)
        {
            this.add = add;
            //    frmCD = cd;
            
            InitializeComponent();
            GetListCategoryInCB();
           
        }

        void LoadListCD()
        {
            cd.DataSource = CDDAO.Intansce.LoadListCD();

        }

        void GetListCategoryInCB()
        {
            List<Category> list = CategoryDAO.Instance.GetListCategoryInCB();
            cbxCategory.DataSource = list;
            cbxCategory.DisplayMember = "NameCCD";
        }

        void InsertCD(string NameCD, int idCategoryCD, int Status)
        {
            if (CDDAO.Intansce.InsertCD(NameCD, idCategoryCD, Status))
            {
                MessageBox.Show("Thêm đĩa thành công");
            }
            else
            {
                MessageBox.Show("Thêm đĩa thất bại");
            }
            
        }

        void GetCDById(int id)
        {
            List<CD> list = CDDAO.Intansce.GetCDById(id);
            cbxCategory.DataSource = list;
            cbxCategory.DisplayMember = "NameCD";
        }


        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            if(cbxCategory.SelectedIndex < 0)
            {
                MessageBox.Show("Vui lòng chọn loại đĩa", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int idCategory = (cbxCategory.SelectedItem as Category).ID;
            var tenCD = txbCD.Text.Trim();
            var status = cbStatus.Checked ? 1 : 0;
            if (string.IsNullOrEmpty(tenCD))
            {
                MessageBox.Show("Vui lòng nhập tên đĩa", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (string.IsNullOrEmpty(add))
            {
                InsertCD(tenCD, idCategory, status);
              //  LoadListCD();
            }
            else
            {

            }
        }

        private void cbxCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            //int id = 0;
            //ComboBox cb = sender as ComboBox;
            //if (cb.SelectedItem == null)
            //{
            //    return;
            //}
            //Category category = cb.SelectedItem as Category;
            //id = category.ID;
            //GetCDById(id);
        }

        private void frmXuLyCD_Load(object sender, EventArgs e)
        {
            //int id = (cbxCategory.SelectedItem as Category).ID;


            //GetCDById(id);
            
        }
    }
}
