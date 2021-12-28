using ManagerCD.DAO;
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
    public partial class frmCustomer : Form
    {
        BindingSource customer = new BindingSource();

        public frmCustomer()
        {
            InitializeComponent();
            dtgvCustomer.DataSource = customer;
            AddCustomerBinding();
            LoadCustomer();
        }

        void AddCustomerBinding()
        {
            txbCusID.DataBindings.Add(new Binding("Text", dtgvCustomer.DataSource, "id", true, DataSourceUpdateMode.Never));
            txbNameCus.DataBindings.Add(new Binding("Text", dtgvCustomer.DataSource, "Name", true, DataSourceUpdateMode.Never));
            txbCMNDCus.DataBindings.Add(new Binding("Text", dtgvCustomer.DataSource, "CMND", true, DataSourceUpdateMode.Never));
            txbSDTCus.DataBindings.Add(new Binding("Text", dtgvCustomer.DataSource, "Sdt", true, DataSourceUpdateMode.Never));
            txbQQCus.DataBindings.Add(new Binding("Text", dtgvCustomer.DataSource, "QueQuan", true, DataSourceUpdateMode.Never));
            nmTypeCus.DataBindings.Add(new Binding("Value", dtgvCustomer.DataSource, "Trangthai", true, DataSourceUpdateMode.Never));
        }

        void LoadCustomer()
        {
            customer.DataSource = CustomerDAO.Intansce.GetListCustomer();
        }

        void SearchCustomer(string key)
        {
            customer.DataSource = CustomerDAO.Intansce.SearchByNameorCMND(key);
        }

        void AddCustomer(string name, string cmnd, string sdt, string quequan)
        {

            if(CustomerDAO.Intansce.InsertCustomer(name, cmnd, sdt, quequan))
            {
                MessageBox.Show("Thêm khách hàng thành công");
            }
            else
            {
                MessageBox.Show("Thêm khách hàng không thành công");
            }
            LoadCustomer();
        }

        void EditCustomer(int id, string name, string cmnd, string sdt, string quequan)
        {

            if (CustomerDAO.Intansce.UpdateCustomer(id, name, cmnd, sdt, quequan))
            {
                MessageBox.Show("Cập nhật khách hàng thành công");
            }
            else
            {
                MessageBox.Show("Cập nhật khách hàng không thành công");
            }
            LoadCustomer();
        }

        void DeleteCustomer(int id)
        {

            if (CustomerDAO.Intansce.DeleteCustomer(id))
            {
                MessageBox.Show("Xóa khách hàng thành công");
            }
            else
            {
                MessageBox.Show("Xóa khách hàng không thành công");
            }
            LoadCustomer();
        }

        private void btnViewCus_Click(object sender, EventArgs e)
        {
            LoadCustomer();
        }

        private void btnAddCus_Click(object sender, EventArgs e)
        {
            var name = txbNameCus.Text.Trim();
            var cmnd = txbCMNDCus.Text.Trim();
            var sdt = txbSDTCus.Text.Trim();
            var quequan = txbQQCus.Text.Trim();

            if (string.IsNullOrEmpty(name))
            {
                MessageBox.Show("Vui lòng nhập tên khách hàng cần thêm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;

            }
            if (string.IsNullOrEmpty(cmnd))
            {
                MessageBox.Show("Vui lòng nhập cmnd cần thêm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;

            }
            if (string.IsNullOrEmpty(sdt))
            {
                MessageBox.Show("Vui lòng nhập sdt cần thêm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;

            }
            if (string.IsNullOrEmpty(quequan))
            {
                MessageBox.Show("Vui lòng nhập quê quán cần thêm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;

            }
            AddCustomer(name, cmnd, sdt, quequan);
        }

        private void btnEditCus_Click(object sender, EventArgs e)
        {
            var id = Convert.ToInt32 (txbCusID.Text.Trim());
            var name = txbNameCus.Text.Trim();
            var cmnd = txbCMNDCus.Text.Trim();
            var sdt = txbSDTCus.Text.Trim();
            var quequan = txbQQCus.Text.Trim();

            if (string.IsNullOrEmpty(name))
            {
                MessageBox.Show("Vui lòng nhập tên khách hàng cần thêm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;

            }
            if (string.IsNullOrEmpty(cmnd))
            {
                MessageBox.Show("Vui lòng nhập cmnd cần thêm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;

            }
            if (string.IsNullOrEmpty(sdt))
            {
                MessageBox.Show("Vui lòng nhập sdt cần thêm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;

            }
            if (string.IsNullOrEmpty(quequan))
            {
                MessageBox.Show("Vui lòng nhập quê quán cần thêm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;

            }
            EditCustomer(id, name, cmnd, sdt, quequan);
        }

        private void btnDeleteCus_Click(object sender, EventArgs e)
        {
            var id = Convert.ToInt32(txbCusID.Text);

            if (MessageBox.Show("Bạn có muốn xóa loại phòng này hay không ?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                DeleteCustomer(id);
        }

        private void btnSearchCus_Click(object sender, EventArgs e)
        {
            var key = txbSearchCus.Text.Trim();

            if (string.IsNullOrEmpty(key))
            {
                LoadCustomer();
            }
            else {
                SearchCustomer(key);
            }
        }
    }
}
