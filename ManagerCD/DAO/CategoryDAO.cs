using ManagerCD.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagerCD.DAO
{
    public class CategoryDAO
    {
        private static CategoryDAO instance;

        public static CategoryDAO Instance
        {
            get
            {
                if (instance == null) instance = new CategoryDAO();
                return CategoryDAO.instance;
            }    
            
           private set => CategoryDAO.instance = value; 
        }

        private CategoryDAO(){}

        public List<Category> SearchCategoryByName(string nameccd)
        {
            List<Category> categories = new List<Category>();
            string query = string.Format("select * from Category where dbo.ufn_removeMark(NameCCD) LIKE N'%' + dbo.ufn_removeMark(N'{0}') + '%' ", nameccd);
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                Category category = new Category(item);
                categories.Add(category);
            }
            return categories;
        }

        public List<Category> GetListCategoryInCB()
        {
            List<Category> list = new List<Category>();

            string query = "select * from Category";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach(DataRow item in data.Rows)
            {
                Category category = new Category(item);
                list.Add(category);
            }

            return list;
        }

        public DataTable GetListCategory()
        {
            return DataProvider.Instance.ExecuteQuery("USP_ListCategory");
        }
        public bool InsertCategory(string nameccd, int price)
        {
            string query =string.Format("insert dbo.Category (NameCCD, Price) values (N'{0}' , {1})", nameccd, price);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }

        public bool UpdateCategory(int id, string nameccd, int price)
        { 
            string query = string.Format("update dbo.Category set price = {2} , NameCCD = N'{1}'  where id = {0}", id, nameccd, price);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }

        public bool DeleteCategory(int id)
        {
            string query = string.Format("delete dbo.Category where id = {0}", id);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }

       
    }
}
