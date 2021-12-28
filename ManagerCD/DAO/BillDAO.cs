using ManagerCD.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagerCD.DAO
{
    public class BillDAO
    {
        private static BillDAO intansce;

        public static BillDAO Intansce
        {
            get
            {
                if (intansce == null) intansce = new BillDAO();
                return BillDAO.intansce;
            }
            private set => BillDAO.intansce = value;
        }

        private BillDAO()
        {
        }

        public int GetUncheckBillByCusID(int id)
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("select * from Bill where idKH = "+ id +" and DaThanhToan = 0");

            if (data.Rows.Count > 0)
            {
                Bill bill = new Bill(data.Rows[0]);
                return bill.ID;

            }
            return -1;
        }

        public void InsertBill(int id)
        {
            DataProvider.Instance.ExecuteNonQuery("exec USP_InsertBill @idKH", new object[] { id});
        }

        public int GetMaxIdBill()
        {
            try
            {
                return (int)DataProvider.Instance.ExecuteScalar("select max(id) from Bill");
            }
            catch
            {
                return 1;
            }
        }

        public void CheckOut(int id, double totalprice)
        {
            string query = "update	bill set NgayTra = GETDATE() , DaThanhToan = 1 ,"+" totalPrice = " + totalprice + "where id = "+id;
            DataProvider.Instance.ExecuteNonQuery(query);
        }

        public DataTable GetBillListByDate(DateTime ngaythue, DateTime ngaytra)
        {
            return DataProvider.Instance.ExecuteQuery("exec USP_GetListBillByDate @ngaythue , @ngaytra ", new object[] { ngaythue, ngaytra});
        }
    }
}
