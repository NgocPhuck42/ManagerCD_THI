using ManagerCD.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagerCD.DAO
{
    public class BillInfoDAO
    {
        private static BillInfoDAO intansce;

        public static BillInfoDAO Intansce
        {
            get
            {
                if (intansce == null) intansce = new BillInfoDAO();
                return BillInfoDAO.intansce;
            }
            private set => BillInfoDAO.intansce = value;
        }

        private BillInfoDAO()
        {
        }

        public List<BillInfo> GetListBillInfo(int id)
        {
            List<BillInfo> list = new List<BillInfo>();

            string query = "select * from BillInfo where idbill = "+id;

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach(DataRow item in data.Rows)
            {
                BillInfo info = new BillInfo(item);
                list.Add(info);
            }

            return list;
        }

        public void InsertBillInfo(int idbill, int idCD, int count)
        {
            DataProvider.Instance.ExecuteNonQuery("exec USP_InsertBillInfo @idbill , @idCD , @count", new object[] { idbill, idCD, count });
        }
    }
}
