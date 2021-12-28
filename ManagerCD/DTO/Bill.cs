using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagerCD.DTO
{
    public class Bill
    {

        public Bill(int id, DateTime? ngaytra, DateTime? ngaythue, int dathanhtoan)
        {
            this.ID = id;
            this.NgayTra = ngaytra;
            this.NgayThue = ngaythue;
            this.DaThanhToan = dathanhtoan;
        }

        public Bill(DataRow row)
        {
            this.ID = (int)row["id"];
           
            this.NgayThue = (DateTime?)row["ngaythue"];
            var dateCheckOutTemp = row["ngaytra"];
            if (dateCheckOutTemp.ToString() != "")
                this.NgayTra = (DateTime?)dateCheckOutTemp;
         
            this.DaThanhToan = (byte)row["dathanhtoan"];
        }

        private int daThanhToan;

        private DateTime? ngayThue;
        private DateTime? ngayTra;
        private int iD;

        public int ID { get => iD; set => iD = value; }
        public DateTime? NgayTra { get => ngayTra; set => ngayTra = value; }
        public DateTime? NgayThue { get => ngayThue; set => ngayThue = value; }
        public int DaThanhToan { get => daThanhToan; set => daThanhToan = value; }
    }
}
