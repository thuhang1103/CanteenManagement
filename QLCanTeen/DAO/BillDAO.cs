using QLCanTeen.DTO;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLCanTeen.DAO
{
    public class BillDAO
    {
        private static BillDAO instance;

        public static BillDAO Instance
        {
            get { if (instance == null) instance = new BillDAO(); return BillDAO.instance; }
            set { BillDAO.instance = value; }
        }
        private BillDAO() { }
        public int GetUnCheckBillIDByTableID(int id) {
            DataTable data = DataProvider.Instance.ExcuteQuery("select * from dbo.bill where idTable = "+ id +" and Status = 0");
            if (data.Rows.Count > 0) 
            {
                Bill bill =new Bill(data.Rows[0]);
                return bill.ID;
            }
            return -1;
        
        }
        public void CheckOut(int id,int discount,decimal totalPrice)
        {
            string query = "update dbo.bill set dateCheckOut= GETDATE(), status = 1 , " + "discount ="+discount + ",totalPrice = "+ totalPrice + " where id=" +id;
            DataProvider.Instance.ExcuteNonQuery(query);
        }
        public void InsertBill(int id)
        {
            DataProvider.Instance.ExcuteNonQuery("exec USP_InsertBill @idTable ", new object[] { id });
        }
        public DataTable GetBillListBydate(DateTime checkIn,DateTime checkOut)
        {
           return DataProvider.Instance.ExcuteQuery("exec USP_GetListBillByDate  @checkIn , @checkout ",new object[] {checkIn,checkOut});
        }
        public DataTable GetBillListBydateAndPage(DateTime checkIn, DateTime checkOut, int pageNum )
        {
            return DataProvider.Instance.ExcuteQuery("exec USP_GetListBillByDateAndPage  @checkIn , @checkout , @pageNum ", new object[] { checkIn, checkOut , pageNum });
        }

        public int GetNumBillBydate(DateTime checkIn, DateTime checkOut)
        {
            return (int)DataProvider.Instance.ExcuteScalar("exec USP_GetNumBillByDate  @checkIn , @checkout ", new object[] { checkIn, checkOut });
        }
        public int GetMaxIDBill()
        {
            try
            {
                return (int)DataProvider.Instance.ExcuteScalar("select MAX(id) from dbo.bill");
            }
            catch
            {
                return 1;
            }
        }
        public List<int> GetIDBillByIDTable(int idTable)
        {
            List<int> list = new List<int>();
            string query = "select id from bill where idTable =" + idTable;
            DataTable data = DataProvider.Instance.ExcuteQuery(query);
            foreach (DataRow item in data.Rows)
            {

                list.Add(Convert.ToInt32(item["id"]));

            }
            return list;
        }
        
        public void DeleteBillByTableID(int idTable)
        {

            List<int> lsidBill = GetIDBillByIDTable(idTable);
            if (lsidBill.Count > 0)
            { // laays id bill theo id banf
                BillInfoDAO.Instance.DeleteBillInfoByIDBill(lsidBill);
                string ids = string.Join(",", lsidBill);
                string query = string.Format("delete  dbo.bill where id in ({0})", ids);
                int result = DataProvider.Instance.ExcuteNonQuery(query);
            }
        }
        public void DeleteBillByID(int idBill)
        {
            string query = string.Format("delete  dbo.bill where id = {0}", idBill);
            int result = DataProvider.Instance.ExcuteNonQuery(query);
        }

        public decimal GetTotalRevenueByMonth(DateTime date)
        {
            string query = "SELECT SUM(totalPrice) FROM dbo.Bill WHERE MONTH(dateCheckOut) = @month AND YEAR(dateCheckOut) = @year AND status = 1";
            object result = DataProvider.Instance.ExcuteScalar(query, new object[] { date.Month, date.Year });
            return result == DBNull.Value ? 0 : Convert.ToDecimal(result);
        }
        public decimal GetTotalRevenueDay(DateTime date)
        {
            string query = "SELECT SUM(totalPrice) FROM dbo.Bill WHERE DAY(dateCheckOut) = @day AND MONTH(dateCheckOut) = @month AND YEAR(dateCheckOut) = @year AND status = 1";
            object result = DataProvider.Instance.ExcuteScalar(query, new object[] { date.Day,date.Month, date.Year });
            return result == DBNull.Value ? 0 : Convert.ToDecimal(result);
        }

        public List<int> GetBillUnCheck()
        {
            List<int> listBillID = new List<int>();
            string query = "SELECT id FROM Bill WHERE status = 0";
            DataTable data = DataProvider.Instance.ExcuteQuery(query);
            
            foreach (DataRow row in data.Rows)
            {
                int billID = Convert.ToInt32(row["id"]);
                listBillID.Add(billID);
            }
            
            return listBillID;
        }
    }
}
