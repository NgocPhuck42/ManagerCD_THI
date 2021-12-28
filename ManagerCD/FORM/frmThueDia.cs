using ManagerCD.DAO;
using ManagerCD.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManagerCD.FORM
{
    public partial class frmThueDia : Form
    {
        public frmThueDia()
        {
            InitializeComponent();
            LoadKH();
            LoadCategory();
        }

        void LoadKH()
        {
            flpCD.Controls.Clear();
            List<Customer> customerList = CustomerDAO.Intansce.LoadListKH();
            foreach (Customer item in customerList)
            {
                Button btn = new Button() { Width = CustomerDAO.CDWidth, Height = CustomerDAO.CDHeight };

                btn.Text = item.Name + Environment.NewLine + Environment.NewLine + (item.TrangThai == 1 ? "Đang thuê" : "Đã trả");
                btn.Click += btn_Click;
                btn.Tag = item;
                switch (item.TrangThai)
                {
                    case 1:
                        btn.BackColor = Color.Red;
                        break;
                    default:
                        btn.BackColor = Color.White;
                        break;
                }

                flpCD.Controls.Add(btn);
            }

        }

        void ShowBill(int id)
        {
            lsvBill.Items.Clear();
            List<Menuu> listBillInfo = MenuDAO.Intansce.GetListMenuByKH(id);
            float totalPrice = 0;
            foreach (Menuu item in listBillInfo)
            {
                ListViewItem listView = new ListViewItem(item.CdName.ToString());
                listView.SubItems.Add(item.Count.ToString());
                listView.SubItems.Add(item.Price.ToString());
                listView.SubItems.Add(item.TotalPrice.ToString());
                totalPrice += item.TotalPrice;
                lsvBill.Items.Add(listView);
            }
            CultureInfo culture = new CultureInfo("vi-VN");

            Thread.CurrentThread.CurrentCulture = culture;
            txbSum.Text = totalPrice.ToString("c");

            LoadKH();
        }

        void LoadCategory()
        {
            List<Category> listCategory = CategoryDAO.Instance.GetListCategoryInCB();
            cbxCategory.DataSource = listCategory;
            cbxCategory.DisplayMember = "NameCCD";
        }

        void LoadFoodListByCategoryID(int id)
        {
            List<CD> listCD = CDDAO.Intansce.GetCDByCategoryID(id);
            cbxCD.DataSource = listCD;
            cbxCD.DisplayMember = "NameCD";
        }

        private void btn_Click(object sender, EventArgs e)
        {
            int CustomerID = ((sender as Button).Tag as Customer).ID;
            lsvBill.Tag = (sender as Button).Tag;
            ShowBill(CustomerID);
        }


       

        private void cbxCategory_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            int id = 0;

            ComboBox cb = sender as ComboBox;

            if (cb.SelectedItem == null)
                return;

            Category selected = cb.SelectedItem as Category;
            id = selected.ID;
            LoadFoodListByCategoryID(id);
        }

        private void btnAddCD_Click_1(object sender, EventArgs e)
        {
            Customer cus = lsvBill.Tag as Customer;
            int idBill = BillDAO.Intansce.GetUncheckBillByCusID(cus.ID);
            int CDID = (cbxCD.SelectedItem as CD).Id;
            int count = (int)nmCDCount.Value;
            
            if (idBill == -1)
            {
                BillDAO.Intansce.InsertBill(cus.ID);
                BillInfoDAO.Intansce.InsertBillInfo(BillDAO.Intansce.GetMaxIdBill(), CDID, count);
            }
            else
            {
                BillInfoDAO.Intansce.InsertBillInfo(idBill, CDID, count);
            }
            ShowBill(cus.ID);
           LoadKH();
        }

        private void btnCheckOut_Click(object sender, EventArgs e)
        {
            Customer cus = lsvBill.Tag as Customer;

            int idBill = BillDAO.Intansce.GetUncheckBillByCusID(cus.ID);
            double totalprice = Convert.ToDouble(txbSum.Text.Split(',')[0]);
            

            if (idBill != -1)
            {
                if (MessageBox.Show("Bạn muốn thanh toán cho khách hàng " + cus.Name, "Thông báo", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
                {
                    BillDAO.Intansce.CheckOut(idBill , totalprice);
                    ShowBill(cus.ID);
                    LoadKH();
                }
            }
        }

        private void btnAddKH_Click(object sender, EventArgs e)
        {
            frmCustomer f = new frmCustomer();
            
            f.ShowDialog();
            this.Show();
            LoadKH();
        }
    }
}
