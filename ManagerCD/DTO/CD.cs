using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagerCD.DTO
{
    public class CD
    {

        public CD(int id, String nameCD, int idCategory, int status)
        {
            this.Id = id;
            this.NameCD = nameCD;
            this.IdCategory = idCategory;
            this.Status = status;
        }

        public CD(DataRow row)
        {
            this.Id = (int)row["id"];
            this.NameCD = row["nameCD"].ToString();
            this.IdCategory = (int)row["idCategoryCD"];
            this.Status = (byte)row["status"];
        }

        private int status;
        private int idCategory;
        private String nameCD;
        private int id;

        public int Id { get => id; set => id = value; }
        public string NameCD { get => nameCD; set => nameCD = value; }
        public int IdCategory { get => idCategory; set => idCategory = value; }
        public int Status { get => status; set => status = value; }
    }
}
