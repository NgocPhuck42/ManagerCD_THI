using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagerCD.DTO
{
    public class Menuu
    {
        public Menuu(string cdName, int count, int price, int totalPrice = 0)
        {
            this.CdName = cdName;
            this.Count = count;
            this.Price = price;
            this.TotalPrice = totalPrice;
        }

        public Menuu(DataRow row)
        {
            this.CdName = row["namecd"].ToString();
            this.Count = (int)row["count"];
            this.Price = (int)row["price"];
            this.TotalPrice = (int)row["totalPrice"];
        }

        private int totalPrice;
        private int price;
        private int count;
        private string cdName;

        public string CdName { get => cdName; set => cdName = value; }
        public int Count { get => count; set => count = value; }
        public int Price { get => price; set => price = value; }
        public int TotalPrice { get => totalPrice; set => totalPrice = value; }
    }
}
