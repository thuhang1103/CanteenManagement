using QLCanTeen.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace QLCanTeen.DAO
{
    public class TableDAO
    {
        private static TableDAO instance;
       
        public static TableDAO Instance {
            get { if (instance == null) instance = new TableDAO(); return TableDAO.instance; }
            private set {  TableDAO.instance = value; } 
        }
        public static int TableWidth = 120;
        public static int TableHeight =120;
        private TableDAO() { }
        public void SwitchTable(int id1,int id2)
        {
            DataProvider.Instance.ExcuteQuery(" USP_SwitchTable @idTable1 , @idTable2",new object[] {id1,id2});
        }
        public void MegerTable(int id1, int id2)
        {
            DataProvider.Instance.ExcuteQuery(" USP_MegerTable @idTable1 , @idTable2", new object[] { id1, id2 });
        }
        public string GetNameTableByID(int id)
        {
            string query = "SELECT name FROM TableFood WHERE id = " + id;
            DataTable data = DataProvider.Instance.ExcuteQuery(query);
            if (data.Rows.Count > 0)
                return data.Rows[0]["name"].ToString();
            return null;
        }
        public List<Table> LoadTableList()
        {
            List<Table> tableList = new List<Table>();
            
            DataTable data = DataProvider.Instance.ExcuteQuery  (" exec dbo.USP_GetTableList");
            foreach (DataRow item in data.Rows) { 
                Table table= new Table(item);
                tableList.Add(table);
            }
            return tableList;
        }
        public bool InsertTable(string name)
        {
            //lấy danh sách tên bàn
            List<string> listName = new List<string>();
            DataTable data = DataProvider.Instance.ExcuteQuery("SELECT name FROM dbo.TableFood");

            if (data != null)
            {
                foreach (DataRow row in data.Rows)
                {
                    string name1 = row["name"].ToString();
                    listName.Add(name1);
                }
            }
            //kiểm tra tên bàn muốn thêm có tồn tại không
            int result= 0;
            if (!listName.Contains(name))
            {
                string query = string.Format(" insert dbo.TableFood ( name ) values ( N'{0}')", name);
                result = DataProvider.Instance.ExcuteNonQuery(query);

            }
            return result > 0;
        }
        public bool UpdateTable(int id,string name)
        {
            string query = string.Format("update dbo.tableFood set name =N'{0}' where id ={1}", name, id);
            int result = DataProvider.Instance.ExcuteNonQuery(query);
            return result > 0;
        }
        public bool DeleteTable(int id)
        {
            BillDAO.Instance.DeleteBillByTableID(id);
            string query = string.Format("delete dbo.TableFood where id = {0}", id);
            int result = DataProvider.Instance.ExcuteNonQuery(query);
            return result > 0;
        }
        public void SetTable()
        {
            // Lấy danh sách bill chưa thanh toán
            List<int> unCheckedBills = BillDAO.Instance.GetBillUnCheck();
            
            if (unCheckedBills.Count > 0)
            {
                foreach (int billID in unCheckedBills)
                {
                    // Kiểm tra billinfo của từng bill
                    List<int> billInfoIDs = BillInfoDAO.Instance.GetIDBillinfoByIDBill(new List<int> { billID });
                    
                    // Nếu bill này không có billinfo
                    if (billInfoIDs.Count == 0)
                    {
                        // Lấy ID bàn từ bill
                        string query = "SELECT idTable FROM Bill WHERE id = " + billID;
                        DataTable data = DataProvider.Instance.ExcuteQuery(query);
                        string query2 = "delete FROM Bill WHERE id = " + billID;
                         DataProvider.Instance.ExcuteQuery(query2);
                        if (data.Rows.Count > 0)
                        {
                            int tableID = Convert.ToInt32(data.Rows[0]["idTable"]);
                            // Cập nhật trạng thái bàn thành "trống"
                            DataProvider.Instance.ExcuteNonQuery("UPDATE TableFood SET status = N'trống' WHERE id = " + tableID);
                        }
                    }
                }
            }
        }
    }
}
