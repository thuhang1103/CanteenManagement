using QLCanTeen.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.InteropServices.JavaScript;
using System.Text;
using System.Threading.Tasks;

namespace QLCanTeen.DAO
{
    public class CommodityDAO
    {
        private static CommodityDAO instance;
        public static CommodityDAO Instance
        {
            get { if (instance == null) instance = new CommodityDAO(); return CommodityDAO.instance; }
            set { CommodityDAO.instance = value; }
        }
        public List<commodity> GetlistCommodity()
        {
            List<commodity> list = new List<commodity>();
            string query = "select * from Commodity";
            DataTable data = DataProvider.Instance.ExcuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                commodity temp = new commodity(item);
                list.Add(temp);

            }
            return list;
        }
        public List<commodity> GetlistCommodityByType( int idType)
        {
            List<commodity> list = new List<commodity>();
            string query = "select * from Commodity where idType ="+ idType;
            DataTable data = DataProvider.Instance.ExcuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                commodity temp = new commodity(item);
                list.Add(temp);

            }
            return list;
        }
        public List<commodity> GetlistCommodityOut()
        {
            List<commodity> list = new List<commodity>();
            string query = "select * from Commodity where soluong <= 2 ";
            DataTable data = DataProvider.Instance.ExcuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                commodity temp = new commodity(item);
                list.Add(temp);

            }
            return list;
        }
        public List<commodity> GetlistInventory(DateTime date)
        {
            List<commodity> list = new List<commodity>();
            DateTime dateTime = date.AddDays(-60);
            string query = "select * from Commodity where dateImport <= @date ";
            DataTable data = DataProvider.Instance.ExcuteQuery(query,new object[] {dateTime});
            foreach (DataRow item in data.Rows)
            {
                commodity temp = new commodity(item);
                list.Add(temp);

            }
            return list;
        }
        public List<string> getNameCommodity()
        {
            List<string> listName = new List<string>();
            string query = "SELECT name FROM Commodity";
            DataTable data = DataProvider.Instance.ExcuteQuery(query);

            foreach (DataRow row in data.Rows)
            {
                string name = row["name"].ToString();
                listName.Add(name);
            }

            return listName;
        }
        public int getSoluongByName(string name)
        {
            int soluong;
            string query = "SELECT soluong FROM Commodity where name = @name ";
            soluong = (int)DataProvider.Instance.ExcuteScalar(query,new object[] { name });
            return soluong;
            
        }

        public bool InsertCommodity(string name, int idType, int soluong,DateTime date)
        {
            string query = "INSERT INTO dbo.commodity (name, idType, soluong, dateImport) VALUES ( @name , @idType , @soluong , @date )";
            
            int result = DataProvider.Instance.ExcuteNonQuery(query,new object[] {name,idType,soluong,date});
            return result > 0;
        }
        public bool UpdateCommodity(string name, int soluong, DateTime date)
        {
            string query = "UPDATE dbo.commodity SET soluong =soluong+ @soluong , dateImport = @date WHERE name = @name ";
            
            int result = DataProvider.Instance.ExcuteNonQuery(query, new object[] {  soluong, date, name });
            return result > 0;
        }
        public bool DeleteCommodity(string name)
        {
            string query = "delete from dbo.Commodity where name = @name ";

            int result = (int)DataProvider.Instance.ExcuteNonQuery(query, new object[] { name });
            return result > 0;
        }
        public bool ExportCommodity(string name, int soluong)
        {
            string query = "UPDATE dbo.commodity SET soluong =soluong -  @soluong where name = @name ";

            int result = DataProvider.Instance.ExcuteNonQuery(query, new object[] { soluong, name });
            return result > 0;
        }
    }
    
}
