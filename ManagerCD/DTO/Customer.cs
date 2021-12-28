using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagerCD.DTO
{
    public class Customer
    {

        public Customer(int id, string name, string cmnd, string sdt, string quequan, int trangthai)
        {
            this.ID = id;
            this.Name = name;
            this.Cmnd = cmnd;
            this.Sdt = sdt;
            this.Quequan = quequan;
            this.TrangThai = trangthai;
        }

        public Customer(DataRow row)
        {
            this.ID = (int)row["id"];
            this.Name = row["name"].ToString();
            this.Cmnd = row["cmnd"].ToString();
            this.Sdt = row["sdt"].ToString();
            this.Quequan = row["quequan"].ToString();
            this.TrangThai = (byte)row["trangthai"];
        }

        private int trangThai;
        private string quequan;
        private string sdt;
        private string cmnd;
        private string name;
        private int iD;

        public int ID { get => iD; set => iD = value; }
        public string Name { get => name; set => name = value; }
        public string Cmnd { get => cmnd; set => cmnd = value; }
        public string Sdt { get => sdt; set => sdt = value; }
        public string Quequan { get => quequan; set => quequan = value; }
        public int TrangThai { get => trangThai; set => trangThai = value; }
    }
}
