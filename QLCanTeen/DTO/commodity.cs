using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLCanTeen.DTO
{
    public class commodity
    {
        public commodity()
        {
            this.Id = id;
            this.Name = name;
            this.IdType = idType;
            this.SoLuong = soLuong;
            this.Date = date;
        }
        private int soLuong;
        public commodity(DataRow row)
        {
            this.Id = (int)row["id"];
            this.Name = row["name"].ToString();
            this.IdType = (int)row["idType"];
            this.SoLuong = (int)row["soLuong"];
            this.Date = (DateTime)row["dateImport"];
        }
        private int id;
       private string name;
        private int idType;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
       

        public int IdType
        {
            get { return idType; }
            set { idType = value; }
        }

        public int SoLuong
        {
            get { return soLuong; }
            set { soLuong = value; }
        }

        public DateTime Date
        {
            get { return date; }
            set { date = value; }
        }

        private DateTime date;

    }
}
