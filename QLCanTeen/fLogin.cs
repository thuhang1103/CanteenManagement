using QLCanTeen.DAO;
using QLCanTeen.DTO;

namespace QLCanTeen
{
    public partial class fLogin : Form
    {
        public fLogin()
        {
            InitializeComponent();
        }

        private void fLogin_Load(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string useName = txbUserName.Text;
            string passWord = txbPassWord.Text;
            if (Login(useName, passWord))
            {
                Account loginAccount = AccountDAO.Instance.GetAccountByUserName(useName);
                fTableManager f = new fTableManager(loginAccount);
                this.Hide();
                f.ShowDialog();
                this.Show();
            }
            else
            {
                MessageBox.Show("sai tên đăng nhập hoặc mật khẩu!", "thông báo ", MessageBoxButtons.OK);
            }

        }
        bool Login(string userName, string passWord)
        {
            return AccountDAO.Instance.Login(userName, passWord);
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void fLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("bạn có thật sự muốn thoát chương trình không ?", "thông báo ", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
            }
        }

        private void ckbShowpass_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbShowpass.Checked)
            {
                txbPassWord.UseSystemPasswordChar = false;
            }
            else
            {
                txbPassWord.UseSystemPasswordChar = true;
            }
        }
    }
}
