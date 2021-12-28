using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagerCD.DTO
{
    public class CDCategory
    {
        public CDCategory(int id, String namecd, String nameccd, int price, String status)
        {
            this.Id = id;
            this.Namecd = namecd;
            this.Nameccd = nameccd;
            this.Price = price;
            this.Status = status;
       //     this.IdCategoryCD = idCategoryCD;
        }

        public CDCategory(DataRow row)
        {
            this.Id = (int)row["id"];
            this.Namecd = row["namecd"].ToString();
            this.Nameccd = row["nameccd"].ToString();
            this.Price = (int)row["price"];
            this.Status = row["status"].ToString();
        //    this.IdCategoryCD = (int)row["idCategoryCD"];
        }

      //  private int idCategoryCD;
        private String status;
        private int price; 
        private String nameccd;
        private String namecd;
        private int id;

        public int Id { get => id; set => id = value; }
        public String Namecd { get => namecd; set => namecd = value; }
        public String Nameccd { get => nameccd; set => nameccd = value; }
        public int Price { get => price; set => price = value; }
        public String Status { get => status; set => status = value; }
     //   public int IdCategoryCD { get => idCategoryCD; set => idCategoryCD = value; }
    }
}
