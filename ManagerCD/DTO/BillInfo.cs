using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagerCD.DTO
{
    public class BillInfo
    {

        public BillInfo(int id, int idbill, int idcd, int count)
        {
            this.ID = id;
            this.IdBill = idbill;
            this.IdCD = idcd;
            this.Count = count;
        }

        public BillInfo(DataRow row)
        {
            this.ID = (int)row["id"];
            this.IdBill = (int)row["idbill"]; 
            this.IdCD = (int)row["idcd"]; 
            this.Count = (int)row["count"]; 
        }

        private int count;
        private int idCD;
        private int idBill;
        private int iD;

        public int ID { get => iD; set => iD = value; }
        public int IdBill { get => idBill; set => idBill = value; }
        public int IdCD { get => idCD; set => idCD = value; }
        public int Count { get => count; set => count = value; }
    }
}
