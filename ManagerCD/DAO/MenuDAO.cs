using ManagerCD.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManagerCD.DAO
{
    public class MenuDAO
    {
        private static MenuDAO intansce;

        public static MenuDAO Intansce
        {
            get
            {
                if (intansce == null) intansce = new MenuDAO();
                return MenuDAO.intansce;
            }
            private set => MenuDAO.intansce = value;
        }
        private MenuDAO()
        {
        }

        public List<Menuu> GetListMenuByKH(int id)
        {
            List<Menuu> list = new List<Menuu>();
            string query = " select c.NameCD, bi.count, ct.Price, ct.Price*bi.count as TotalPrice from BillInfo as bi, Bill as b, CD as c inner join Category as ct on c.idCategoryCD = ct.id where bi.idBill = b.id and bi.idCD = c.id and b.DaThanhToan=0 and b.idKH = "+id;
            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach(DataRow item in data.Rows)
            {
                Menuu menu = new Menuu(item);
                list.Add(menu);
            }

            return list;
        }
    }
}
