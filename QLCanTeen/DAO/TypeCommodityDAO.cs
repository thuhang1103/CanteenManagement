using QLCanTeen.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLCanTeen.DAO
{
    public class TypeCommodityDAO
    {
        private static TypeCommodityDAO instance;
        public static TypeCommodityDAO Instance
        {
            get { if (instance == null) instance = new TypeCommodityDAO(); return TypeCommodityDAO.instance; }
            set { TypeCommodityDAO.instance = value; }
        }
        public List<TypeCcommodity> GetlistType()
        {
            List<TypeCcommodity> list = new List<TypeCcommodity>();
            string query = "select * from TypeCommodity";
            DataTable data = DataProvider.Instance.ExcuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                TypeCcommodity type = new TypeCcommodity(item);
                list.Add(type);

            }
            return list;
        }
    }
}
