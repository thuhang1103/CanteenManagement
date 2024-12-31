using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLCanTeen.DTO
{
    public class TypeCcommodity
    {
        public TypeCcommodity(int iD, string name)
        {
            this.ID = iD;
            this.Name = name;
        }
        public TypeCcommodity(DataRow row)
        {
            this.ID = (int)row["id"];
            this.Name = row["name"].ToString();
        }
        private string name;
        private int iD;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public int ID
        {
            get { return iD; }
            set { iD = value; }
        }
    }
}
