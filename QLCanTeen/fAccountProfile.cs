using QLCanTeen.DAO;
using QLCanTeen.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;

namespace QLCanTeen
{
    public partial class fAccountProfile : Form
    {
        private Account loginAccount1;

        public Account LoginAccount1
        {
            get { return loginAccount1; }
            set { loginAccount1 = value; ChangeAccount(loginAccount1); }
        }
        public fAccountProfile(Account acc)
        {
            InitializeComponent();
            loginAccount1 = acc;
            ChangeAccount(loginAccount1);
        }
        public void ChangeAccount(Account acc)
        {
            txbUserName2.Text = loginAccount1.UserName;
            txbDisplayName2.Text = loginAccount1.DisplayName;

        }
        // thay đổi thông tin tài khoản 
        void UpdateAccount()
        {
            string displayName=txbDisplayName2.Text;
            string password=txbPassWord.Text;
            string userName=txbUserName2.Text;
            string newpass = txbNewPass.Text;
            string reenterpass =txbReEnterPass.Text;
            if (!newpass.Equals(reenterpass))
            {
                MessageBox.Show("vui lòng nhập lại mật khẩu đúng với mật khẩu mới");
            }
            else
            {
                if (AccountDAO.Instance.UpdateAccount(userName, displayName, password, newpass))
                {
                    MessageBox.Show("cập nhật thành công");
                    //chỉnh sửa phần update thông tin cá nhân                    
                    if (updateAccount1 != null)
                         updateAccount1(this, new AccountEvent(AccountDAO.Instance.GetAccountByUserName(userName)));
                }
                else
                {
                    MessageBox.Show("vui lòng điền đúng mật khẩu");
                }
            }
        }
        private event EventHandler<AccountEvent> updateAccount1;
        public event EventHandler<AccountEvent> UpdateAccount1
        {
            add { updateAccount1 += value; }
            remove { updateAccount1 -= value; }
        }

        private void btnExti_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        // thay đổi thông tin tài khoản
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            UpdateAccount();
        }
    }
    public class AccountEvent : EventArgs
    {
        private Account acc;

        public Account Acc
        {
            get { return acc; }
            set { acc = value; }
        }
        public AccountEvent(Account acc)
        {
            Acc = acc;
        }
    }
}
