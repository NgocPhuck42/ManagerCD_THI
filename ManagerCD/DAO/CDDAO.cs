using ManagerCD.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagerCD.DAO
{
    public class CDDAO
    {
        private static CDDAO intansce;

        public static CDDAO Intansce { 
            
           get
            {
                if (intansce == null) intansce = new CDDAO();
                return CDDAO.intansce;
            }
            private set => CDDAO.intansce = value; }

        

        private CDDAO()
        {
        }

        public bool InsertCD(string NameCD, int idCategory, int Status)
        {
            string query = string.Format("INSERT dbo.CD (NameCD, idCategoryCD, Status) values (N'{0}' , {1}, {2})", NameCD, idCategory, Status);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }
        
        public List<CD> LoadList()
        {
            List<CD> list = new List<CD>();
            string query = string.Format("USP_LoadList");
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                CD cd = new CD(item);
                list.Add(cd);
            }

            return list;
        }

        public List<CDCategory> LoadListCD()
        {
            List<CDCategory> list = new List<CDCategory>();
            string query = string.Format("USP_LoadListCD");
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                CDCategory cd = new CDCategory(item);
                list.Add(cd);
            }

            return list;
        }

        public List<CD> GetCDByCategoryID(int id)
        {
            List<CD> list = new List<CD>();

            string query = "select * from CD where idCategoryCD = "+id;
            DataTable data = DataProvider.Instance.ExecuteQuery(query, new object[] { id });

            foreach (DataRow item in data.Rows)
            {
                CD cd = new CD(item);
                list.Add(cd);
            }

            return list;
        }

        public List<CD> GetCDById(int id)
        {
            List<CD> list = new List<CD>();

            string query = "USP_GetCDById @id";
            DataTable data = DataProvider.Instance.ExecuteQuery(query, new object[] { id});

            foreach(DataRow item in data.Rows)
            {
                CD cd = new CD(item);
                list.Add(cd);
            }

            return list;
        }

        public List<CDCategory> SearchCDByName(string name)
        {
            List<CDCategory> list = new List<CDCategory>();
            string query = "USP_SearchCD @namecd ";
            DataTable data = DataProvider.Instance.ExecuteQuery(query, new object[] { name});
            foreach (DataRow item in data.Rows)
            {
                CDCategory cd = new CDCategory(item);
                list.Add(cd);
            }
            return list;
        }

        public bool DeleteCD(int id)
        {
            string query = " USP_DeleteCD @id";
            int result = DataProvider.Instance.ExecuteNonQuery(query,new object[]{id});
            return result > 0;
        }
    }
}
