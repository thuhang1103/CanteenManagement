using QLCanTeen.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLCanTeen.DAO
{
    public class CategoryDAO
    {
        private static CategoryDAO instance;

        public static CategoryDAO Instance
        {
            get { if (instance == null) instance = new CategoryDAO(); return CategoryDAO.instance; }
            set { CategoryDAO.instance = value; }
        }
        private CategoryDAO() { }
        public List<Category> GetlistCategory() {
            List<Category> list = new List<Category>();
            string query = "select * from FoodCategory";
            DataTable data= DataProvider.Instance.ExcuteQuery(query);
            foreach (DataRow item in data.Rows) { 
                Category category =new Category(item);
                list.Add(category);
            
            }
            return list;
        }
        public Category GetCategoryByID(int id)
        {
            Category category= null;
            string query = "select * from FoodCategory where id ="+ id;
            DataTable data = DataProvider.Instance.ExcuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                 category = new Category(item);
                return category;

            }

            return category;
        }
        public string getNameCategoryByID(int id)
        {
            string query = "SELECT name FROM FoodCategory WHERE id = " + id;
            DataTable data = DataProvider.Instance.ExcuteQuery(query);
            if (data.Rows.Count > 0)
                return data.Rows[0]["name"].ToString();
            return null;
        }
        public List<string> getNameCategory()
        {
            List<string> listName = new List<string>();
            string query = "SELECT name FROM FoodCategory";
            DataTable data = DataProvider.Instance.ExcuteQuery(query);
            
            foreach (DataRow row in data.Rows)
            {
                string name = row["name"].ToString();
                listName.Add(name);
            }
            
            return listName;
        }
        public bool InsertCategory(string name)
        {
            //lấy danh sách tên categiry
            List<string> listNameCate = new List<string>();
            DataTable data = DataProvider.Instance.ExcuteQuery("SELECT name FROM dbo.FoodCategory");

            if (data != null)
            {
                foreach (DataRow row in data.Rows)
                {
                    string name1 = row["name"].ToString();
                    listNameCate.Add(name1);
                }
            }
            //kiểm tra tên bàn muốn thêm có tồn tại không
            int result = 0;
            if (!listNameCate.Contains(name))
            {
                string query = string.Format(" insert dbo.FoodCategory ( name) values ( N'{0}')", name);
                result = DataProvider.Instance.ExcuteNonQuery(query);
            }
            return result > 0;
            //
            }
        public bool UpdateCategory(int idCategory, string name)
        {
            string query = string.Format("update dbo.FoodCategory set name =N'{0}' where id = {1}", name, idCategory);
            int result = DataProvider.Instance.ExcuteNonQuery(query);
            return result > 0;
        }
        public bool DeleteCategory(int idCategpory)
        {
            BillInfoDAO.Instance.DeleteBillInfoAndFoodByCategoryID(idCategpory);
            string query = string.Format("delete dbo.FoodCategory where id = {0}", idCategpory);
            int result = DataProvider.Instance.ExcuteNonQuery(query);
            return result > 0;
        }

    }
}
