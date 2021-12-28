using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagerCD.DTO
{
    public class Category
    {

        public Category(int id, String nameccd, int price)
        {
            this.ID = id;
            this.NameCCD = nameccd;
            this.Price = price;
        }

        public Category(DataRow row)
        {
            this.ID = (int)row["id"];
            this.NameCCD = row["NameCCD"].ToString();
            this.Price = (int)row["Price"];
        }

        private int price;
        private String nameCCD;
        private int iD;

        public int ID { get => iD; set => iD = value; }
        public string NameCCD { get => nameCCD; set => nameCCD = value; }
        public int Price { get => price; set => price = value; }
    }
}
