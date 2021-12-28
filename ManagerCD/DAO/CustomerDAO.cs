using ManagerCD.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagerCD.DAO
{
    public class CustomerDAO
    {
        private static CustomerDAO intansce;

        public static CustomerDAO Intansce { 
            get
            {
                if (intansce == null) intansce = new CustomerDAO();
                return CustomerDAO.intansce;
            }
            private set => CustomerDAO.intansce = value; 
        }

        private CustomerDAO()
        {
        }

        public static int CDWidth = 100;
        public static int CDHeight = 100;

        public List<Customer> LoadListKH()
        {
            List<Customer> list = new List<Customer>();
            string query = "USP_LoadListKH";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                Customer customer = new Customer(item);
                list.Add(customer);
            }

            return list;
        }

        public DataTable GetListCustomer()
        {
            return DataProvider.Instance.ExecuteQuery("select * from KhachHang");
        }

        public DataTable SearchByNameorCMND(string key)
        {
            string query = string.Format("select * from KhachHang where dbo.ufn_removeMark(Name) LIKE N'%' + dbo.ufn_removeMark(N'{0}') + '%' or dbo.ufn_removeMark(CMND) LIKE '%' + dbo.ufn_removeMark('{0}') + '%'", key);
            return DataProvider.Instance.ExecuteQuery(query);
        }

        public bool InsertCustomer(string name, string cmnd, string sdt, string quequan) 
        {
            string query = string.Format("insert into KhachHang ([Name], CMND, Sdt, QueQuan, trangthai) values(N'{0}', '{1}' , '{2}' , N'{3}' , 2)", name, cmnd, sdt, quequan);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }

        public bool UpdateCustomer(int id, string name, string cmnd, string sdt, string quequan)
        {
            string query = string.Format("update KhachHang set [Name] = N'{0}' , CMND  = '{1}' , Sdt = '{2}' , QueQuan = N'{3}'  where id = {4}", name, cmnd, sdt, quequan, id);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }

        public bool DeleteCustomer(int id)
        {
            string query = string.Format("delete dbo.KhachHang where id = {0}", id);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }


    }
}
