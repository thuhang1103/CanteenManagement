using QLCanTeen.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLCanTeen.DAO
{
    public class FoodDAO
    {
        private static FoodDAO instance;

        public static FoodDAO Instance
        {
            get { if (instance == null) instance = new FoodDAO(); return FoodDAO.instance; }
            set { instance = value; }
        }
        private FoodDAO() { }
        public List<Food> GetFoodByCategoryId(int id)
        {
            List<Food> list=new List<Food>();
            string query = "select * from Food where idCategory ="+id;
            DataTable data= DataProvider.Instance.ExcuteQuery(query);
            foreach (DataRow item in data.Rows) 
            {
                Food food =new Food(item);
                list.Add(food);

            }
            return list;
        }
        public List<int> GetIDFoodByCategoryId(int id)
        {
            List<int> list = new List<int>();
            string query = "select id from Food where idCategory =" + id;
            DataTable data = DataProvider.Instance.ExcuteQuery(query);
            foreach (DataRow item in data.Rows)
            {

                list.Add(Convert.ToInt32(item["id"]));

            }
            return list;
        }
        
        public List<Food> GetListFood()
        {
            List<Food> list = new List<Food>();
            string query = "select * from food ";
            DataTable data = DataProvider.Instance.ExcuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                Food food = new Food(item);
                list.Add(food);
            }


            return list;
        }

        public List<Food> SearchFoodByName(string name)
        {
            List<Food> list = new List<Food>();
            string query = string.Format("select * from Food where dbo.fuConvertToUnsignl(name) like N'%' + dbo.fuConvertToUnsignl(N'{0}') + '%' ", name);
            DataTable data = DataProvider.Instance.ExcuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                Food food = new Food(item);
                list.Add(food);

            }
            return list;

        }
        public bool InsertFood(string name ,int idCategory,float price)
        {
            //lấy danh sách tên bàn
            List<string> listName = new List<string>();
            DataTable data = DataProvider.Instance.ExcuteQuery("SELECT name FROM dbo.Food");

            if (data != null)
            {
                foreach (DataRow row in data.Rows)
                {
                    string name1 = row["name"].ToString();
                    listName.Add(name1);
                }
            }
            //kiểm tra tên bàn muốn thêm món có tồn tại không
            int result = 0;
            if (!listName.Contains(name))
            {

                string query = string.Format(" insert dbo.food ( name , idCategory , price ) values ( N'{0}' ,{1} , {2})", name, idCategory, price);
                 result = DataProvider.Instance.ExcuteNonQuery(query);

            }
            return result > 0;
        }
        public bool UpdateFood(int idFood, string name, int idCategory, float price)
        {
            string query = string.Format("update dbo.Food set name =N'{0}',idCategory = {1} , price = {2} where id ={3}",name,idCategory,price,idFood);
            int result = DataProvider.Instance.ExcuteNonQuery(query);
            return result > 0;
        }
        public bool DeleteFood(int idFood)
        {
            BillInfoDAO.Instance.DeleteBillInfoByFoodID(idFood);
            string query = string.Format("delete dbo.Food where id = {0}",idFood);
            int result = DataProvider.Instance.ExcuteNonQuery(query);
            return result > 0;
        }

        public string getFoodNameByID(int id)
        {
            string query = "SELECT name FROM Food WHERE id = " + id;
            DataTable data = DataProvider.Instance.ExcuteQuery(query);
            if (data.Rows.Count > 0)
                return data.Rows[0]["name"].ToString();
            return null;
        }
    }
}
