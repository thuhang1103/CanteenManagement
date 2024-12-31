using QLCanTeen.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLCanTeen.DAO
{
    public class BillInfoDAO
    {
        private BillInfoDAO() { }
        private static BillInfoDAO instance;

        public static BillInfoDAO Instance
        {
            get { if (instance == null) instance = new BillInfoDAO(); return BillInfoDAO.instance; }
            set { BillInfoDAO.instance = value; }
        }
        public List<BillInfo> GetListBillInfo(int id)
        {
            List<BillInfo> listBillInfo = new List<BillInfo>();
            DataTable data = DataProvider.Instance.ExcuteQuery("select * from dbo.billinfo where idBill = " + id);
            foreach (DataRow item in data.Rows) 
            {
                BillInfo info =new BillInfo(item);
                listBillInfo.Add(info);
            }
            return listBillInfo;
        }
        public List<int> GetIDBillinfoByIDBill(List<int> lsIDBill)
        {
            List<int> list = new List<int>();

            if (lsIDBill.Count > 0)
            {
                string ids = string.Join(",", lsIDBill);
                string query =string.Format( "select id from billinfo where idBill in ({0})" , ids);
                DataTable data = DataProvider.Instance.ExcuteQuery(query);
                foreach (DataRow item in data.Rows)
                {
                    list.Add(Convert.ToInt32(item["id"]));

                }
                
            }
            return list;

        }
        public void DeleteBillInfoByFoodID(int id)
        {
           DataProvider.Instance.ExcuteQuery("delete from dbo.billinfo where idFood = " + id);
        }
        //sửa xong rồi
        public void DeleteBillInfoAndFoodByCategoryID(int id)
        {
           
            List<int> foodIds = FoodDAO.Instance.GetIDFoodByCategoryId(id);
            if (foodIds.Count > 0)
            {   
                string ids = string.Join(",", foodIds);
                string query1 = string.Format("delete  dbo.billinfo where idFood IN ({0})", ids);
                int temp = DataProvider.Instance.ExcuteNonQuery(query1);
                string query = string.Format("delete dbo.Food where id in ({0})", ids);
                int result = DataProvider.Instance.ExcuteNonQuery(query);   
            }       
        }
        //hỗ trợ xóa bàn
        public void DeleteBillInfoByIDBill(List<int> idBill)
        {

            List<int> infoIds = GetIDBillinfoByIDBill( idBill);
            if (infoIds.Count > 0)
            {
                string ids = string.Join(",", infoIds);
                string query1 = string.Format("delete  dbo.billinfo where id IN ({0})", ids);
                int result = DataProvider.Instance.ExcuteNonQuery(query1);
            }
        }
        public void InsertBillInfo(int idBill,int idFood,int count)
        {
            DataProvider.Instance.ExcuteNonQuery("EXEC  USP_InsertBillInfo @idBill , @idFood , @count ", new object[] { idBill,idFood,count });
        }
        public bool SubBillInfo(int idBill, int idFood, int count)
        {
            int result = DataProvider.Instance.ExcuteNonQuery("EXEC  USP_SubBillInfo @idBill , @idFood , @count ", new object[] { idBill, idFood, count });
            return result > 0;
        }
    }
}
