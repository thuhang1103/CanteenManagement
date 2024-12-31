using QLCanTeen.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace QLCanTeen.DAO
{
    public class AccountDAO
    {
        private static AccountDAO instance;
        public static AccountDAO Instance {
            get {
                if (instance == null) instance = new AccountDAO();
                return instance; }
            private set { instance = value; }
        }
        private AccountDAO() { }
        public bool Login(string userName, string passWord)
        {
            string query = "SELECT passWord FROM Account WHERE userName = @userName ";
            DataTable result = DataProvider.Instance.ExcuteQuery(query, new object[] { userName });
            
            if (result.Rows.Count > 0)
            {
                string storedPassword = result.Rows[0]["passWord"].ToString();
                
                // Kiểm tra xem mật khẩu có phải dạng hash không
                try
                {
                    // Thử verify với hash
                    return PasswordHasher.VerifyPassword(passWord, storedPassword);
                }
                catch (FormatException)
                {
                    // Nếu không phải hash, so sánh trực tiếp và update hash mới
                    if (passWord == storedPassword)
                    {
                        // Auto update hash cho mật khẩu
                        string hashedPassword = PasswordHasher.HashPassword(passWord);
                        string updateQuery = "UPDATE Account SET passWord = @hashedPassword WHERE userName = @userName";
                        DataProvider.Instance.ExcuteNonQuery(updateQuery, new object[] { hashedPassword, userName });
                        return true;
                    }
                }
            }
            return false;
        }
        public bool UpdateAccount(string userName, string displayName, string pass, string newpass)
        {
            string query = "SELECT passWord FROM Account WHERE userName = @userName ";
            DataTable result = DataProvider.Instance.ExcuteQuery(query, new object[] { userName });
            
            if (result.Rows.Count > 0)
            {
                string storedPassword = result.Rows[0]["passWord"].ToString();
                bool passwordValid = false;

                try
                {
                    // Thử verify với hash
                    passwordValid = PasswordHasher.VerifyPassword(pass, storedPassword);
                }
                catch (FormatException)
                {
                    // Nếu không phải hash, so sánh trực tiếp
                    passwordValid = (pass == storedPassword);
                }

                if (passwordValid)
                {
                    // Hash mật khẩu mới
                    string hashedNewPassword = PasswordHasher.HashPassword(newpass);
                    string updateQuery = "UPDATE Account SET displayName = @displayName , passWord = @hashedNewPassword WHERE userName = @userName ";
                    int updateResult = DataProvider.Instance.ExcuteNonQuery(updateQuery, new object[] { displayName, hashedNewPassword, userName });
                    return updateResult > 0;
                }
            }
            return false;
        }
        public DataTable GetListAccount()
        {
            return DataProvider.Instance.ExcuteQuery("select userName,displayName,type from dbo.Account");
        }
        public Account GetAccountByUserName(string userName)
        {
            string query = "SELECT * FROM Account WHERE username = @userName";
            DataTable data = DataProvider.Instance.ExcuteQuery(query, new object[] { userName });
            foreach (DataRow item in data.Rows)
            {
                return new Account(item);
            }
            return null;
        }
        public bool InsertAccount(string username, string displayName, int type)
        {
            try
            {
                // Lấy danh sách tên tài khoản
                List<string> listName = new List<string>();
                DataTable data = DataProvider.Instance.ExcuteQuery("SELECT username FROM dbo.account");

                if (data != null)
                {
                    foreach (DataRow row in data.Rows)
                    {
                        string name1 = row["username"].ToString();
                        listName.Add(name1);
                    }
                }

                // Kiểm tra tên tài khoản có tồn tại không
                if (!listName.Contains(username))
                {
                    // Tạo mật khẩu mặc định đã hash
                    string defaultHashedPassword = PasswordHasher.HashPassword("0");

                    // Sử dụng tham số để tránh SQL injection
                    string query = "INSERT INTO dbo.Account (username, displayName, passWord, type) VALUES ( @username , @displayName , @password , @type )";
                    int result = DataProvider.Instance.ExcuteNonQuery(query,  new object[] { username, displayName, defaultHashedPassword, type });

                    return result > 0;
                }
                return false;
            }
            catch (Exception ex)
            {
                // Log lỗi nếu cần
                Console.WriteLine("Error in InsertAccount: " + ex.Message);
                return false;
            }
        }
        public bool UpdateAccount(string username, string displayName, int type)
        {
            string query = "UPDATE dbo.Account SET displayName = @displayName , type = @type WHERE userName = @userName";
            int result = DataProvider.Instance.ExcuteNonQuery(query, new object[] { displayName, type, username });
            return result > 0;
        }
        public bool DeleteAccount(string userName)
        {
            string query = "DELETE FROM dbo.Account WHERE userName = @userName ";
            int result = DataProvider.Instance.ExcuteNonQuery(query, new object[] { userName });
            return result > 0;
        }
        public bool ResetPassword(string name)
        {
            string defaultHashedPassword = PasswordHasher.HashPassword("0");
            string query = "UPDATE Account SET passWord = @defaultHashedPassword WHERE userName = @userName ";
            int result = DataProvider.Instance.ExcuteNonQuery(query, new object[] { defaultHashedPassword, name });
            return result > 0;
        }
    }
}
