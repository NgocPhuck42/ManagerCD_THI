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
    public partial class frmDoanhThu : Form
    {
        public frmDoanhThu()
        {
            InitializeComponent();
            LoadListBillByDate(dtpkFromdate.Value, dtpkTodate.Value);
            LoadDateTime();
        }

        void LoadListBillByDate(DateTime ngaythue, DateTime ngaytra)
        {
            dtgvBill.DataSource=BillDAO.Intansce.GetBillListByDate(ngaythue, ngaytra);
        }

        void LoadDateTime()
        {
            DateTime today = DateTime.Now;
            dtpkFromdate.Value = new DateTime(today.Year, today.Month, 1);
            dtpkTodate.Value = dtpkFromdate.Value.AddMonths(1).AddDays(-1);
        }

        private void btnViewBill_Click(object sender, EventArgs e)
        {

        }

        private void btnViewBill_Click_1(object sender, EventArgs e)
        {
            LoadListBillByDate(dtpkFromdate.Value, dtpkTodate.Value);
        }
    }
}
