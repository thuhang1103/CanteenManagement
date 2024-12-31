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
using System.Windows.Forms;
using System.Globalization;
using System.Net.NetworkInformation;

namespace QLCanTeen
{
    public partial class fTableManager : Form
    {
        private Account loginAccount;

        public Account LoginAccount
        {
            get { return loginAccount; }
            set { loginAccount = value; ChangeAccount(loginAccount.Type); }
        }
        public fTableManager(Account acc)
        {
            InitializeComponent();
            this.loginAccount = acc;
            ChangeAccount(this.loginAccount.Type);
            LoadTable();
            LoadCategory();
            LoadComboboxTable(cbSwitchTable);

        }

        private void fTableManager_Load(object sender, EventArgs e)
        {

        }

        #region Methor
        void ChangeAccount(int type)
        {

            adminToolStripMenuItem.Enabled = type == 1;
            thôngTinTàiKhoảnToolStripMenuItem.Text += " (" + loginAccount.DisplayName + ")";
        }
        void LoadCategory()
        {
            List<Category> listcategory = CategoryDAO.Instance.GetlistCategory();
            cbCategory.DataSource = listcategory;
            cbCategory.DisplayMember = "Name";
        }
        void LoadFoodListByCategoryID(int id)
        {

            List<Food> listFood = FoodDAO.Instance.GetFoodByCategoryId(id);
            if (!listFood.Any())
            {
                cbFood.Text = string.Empty;
            }
            else
            {
                cbFood.DataSource = listFood;
                cbFood.DisplayMember = "Name";
            }


        }
        void LoadTable()
        {
            flpTable.Controls.Clear();
            List<Table> tableLisst = TableDAO.Instance.LoadTableList();
            foreach (Table item in tableLisst)
            {
                Button btn = new Button() { Width = TableDAO.TableWidth, Height = TableDAO.TableHeight };
                btn.Text = item.Name + Environment.NewLine + item.Status;
                btn.Click += btn_Click;
                btn.Tag = item;
                switch (item.Status)
                {
                    case "trống":
                        btn.BackColor = Color.Aqua;
                        break;
                    default:
                        btn.BackColor = Color.LightSkyBlue;
                        break;

                }
                flpTable.Controls.Add(btn);

            }
        }

        void ShowBill(int id)
        {
            lsvBill.Items.Clear();
            List<Menu> lissBillInfo = MenuDAO.Instance.GetListMenuByTable(id);
            float totalPrice = 0;
            foreach (Menu item in lissBillInfo)
            {

                ListViewItem lsvItem = new ListViewItem(item.FoodName.ToString());
                lsvItem.SubItems.Add(item.Count.ToString());
                lsvItem.SubItems.Add(item.Price.ToString());
                lsvItem.SubItems.Add(item.TotalPrice.ToString());
                totalPrice += item.TotalPrice;
                lsvBill.Items.Add(lsvItem);
            }
            CultureInfo culture = new CultureInfo("vi-VN");
            // Thread.CurrentThread.CurrentCulture = culture;
            txbTotalPrice.Text = totalPrice.ToString("c", culture);

        }
        void LoadComboboxTable(ComboBox cb)
        {
            cb.DataSource = TableDAO.Instance.LoadTableList();
            cb.DisplayMember = "Name";
        }

        #endregion

        #region Event
        private void btn_Click(object? sender, EventArgs e)
        {
            int tableID = ((sender as Button).Tag as Table).ID;
            lsvBill.Tag = (sender as Button).Tag;
            ShowBill(tableID);
        }
        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void thôngTinCáNhânToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fAccountProfile f = new fAccountProfile(loginAccount);
            //DialogResult dialogResult=
            f.UpdateAccount1 += f_UpdateAccount;
            f.ShowDialog();
        }

        void f_UpdateAccount(object? sender, AccountEvent e)
        {
            thôngTinTàiKhoảnToolStripMenuItem.Text = "thông tin tài khoản (" + e.Acc.DisplayName + ")";
        }
        //cbCategory_selected...
        private void cbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            int id = 0;
            ComboBox cb = sender as ComboBox;
            if (cb.SelectedItem == null) return;
            Category selected = cb.SelectedItem as Category;
            id = selected.ID;
            LoadFoodListByCategoryID(id);
        }
        private void btnAddFood_Click(object sender, EventArgs e)
        {
            Table table = lsvBill.Tag as Table;
            if (table == null)
            {
                MessageBox.Show("hãy chọn bàn trước khi thêm món ");
                return;
            }

            int categoryID = (cbCategory.SelectedItem as Category).ID;
            if (FoodDAO.Instance.GetFoodByCategoryId(categoryID).Count > 0)
            {
                int idBill = BillDAO.Instance.GetUnCheckBillIDByTableID(table.ID);
                int foodID = (cbFood.SelectedItem as Food).ID;
                int count = (int)nmFoodCount.Value;

                if (idBill == -1)
                {
                    BillDAO.Instance.InsertBill(table.ID);
                    BillInfoDAO.Instance.InsertBillInfo(BillDAO.Instance.GetMaxIDBill(), foodID, count);
                    LoadTable();
                }
                else
                {
                    BillInfoDAO.Instance.InsertBillInfo(idBill, foodID, count);
                }
            }
            else
            {
                MessageBox.Show("danh mục hiện tại đang không có món ");
                return;
            }
            ShowBill(table.ID);

        }
        private void btnSubFood_Click(object sender, EventArgs e)
        {
            Table table = lsvBill.Tag as Table;
            if (table == null)
            {
                MessageBox.Show("hãy chọn bàn ");
                return;
            }

            int categoryID = (cbCategory.SelectedItem as Category).ID;
            if (FoodDAO.Instance.GetFoodByCategoryId(categoryID).Count > 0)
            {
                int idBill = BillDAO.Instance.GetUnCheckBillIDByTableID(table.ID);
                int foodID = (cbFood.SelectedItem as Food).ID;
                int count = (int)nmSubFood.Value;

                if (idBill == -1)
                {
                    MessageBox.Show("bàn hiện tại đang trống ");
                    return;

                }
                else
                {
                    if (BillInfoDAO.Instance.SubBillInfo(idBill, foodID, count))
                    {

                        if (!BillInfoDAO.Instance.GetListBillInfo(idBill).Any())
                        {
                            BillDAO.Instance.DeleteBillByID(idBill);
                            LoadTable();
                        }

                    }

                }
            }
            else
            {
                MessageBox.Show("danh mục hiện tại đang không có món ");
                return;
            }
            ShowBill(table.ID);
        }


        private void btnCheckOut_Click(object sender, EventArgs e)
        {
            Table table = lsvBill.Tag as Table;
            if (table == null)
            {
                MessageBox.Show(string.Format("hãy chọn bàn trước khi nhấn thanh toán"), "lỗi thanh toán", MessageBoxButtons.OKCancel);
                return;
            }
            int idBill = BillDAO.Instance.GetUnCheckBillIDByTableID(table.ID);
            int discount = (int)nmDisCount.Value;
            string input = txbTotalPrice.Text;
            string temp = input.Replace("₫", "").Replace(".", ""); //loại  bỏ ký hiệu tiền tệ 
            decimal totalPrice = decimal.Parse(temp);
            decimal tempdiscount = (totalPrice / 100) * (decimal)discount;
            decimal finalTotalPrice = totalPrice - (totalPrice / 100) * (decimal)discount;
            if (idBill != -1)
            {
                if (MessageBox.Show(string.Format("bạn có chắc thanh toán hóa dơn cho {0}\n Tổng tiền - Giảm giá là {1} - {2} ={3} ", table.Name, totalPrice, tempdiscount, finalTotalPrice), "thông báo", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
                {
                    BillDAO.Instance.CheckOut(idBill, discount, finalTotalPrice);
                    ShowBill(table.ID);
                    LoadTable();
                    nmDisCount.Value = 0;
                }
            }
            else
            {
                MessageBox.Show(string.Format("bàn hiện tại không có hóa đơn"), "thông báo", MessageBoxButtons.OKCancel);
                return;
            }
        }

        private void btnSwitchTable_Click(object sender, EventArgs e)
        {
            Table table = lsvBill.Tag as Table;
            if (table == null)
            {
                MessageBox.Show(string.Format("hãy chọn bàn"), "lỗi chuyển bàn", MessageBoxButtons.OKCancel);
                return;
            }
            int id1 = table.ID;

            string name1 = table.Name;
            /*chuyển item được chọn trong combobox 
             * có kiểu object sang kiểu table */
            int id2 = (cbSwitchTable.SelectedItem as Table).ID;
            string name2 = (cbSwitchTable.SelectedItem as Table).Name;
            if (MessageBox.Show(string.Format("bạn có thật sự muốn chuyển bàn {0} qua bàn {1} hay không ", name1, name2), "thông báo chuyển bàn", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
            {
                TableDAO.Instance.SwitchTable(id1, id2);
                if (lsvBill.Tag != null)
                    ShowBill((lsvBill.Tag as Table).ID);
            }


            LoadTable();
        }
        private void btnMergeTable_Click(object sender, EventArgs e)
        {
            Table table = lsvBill.Tag as Table;
            if (table == null)
            {
                MessageBox.Show(string.Format("hãy chọn bàn"), "lỗi gộp bàn", MessageBoxButtons.OKCancel);
                return;
            }
            int id1 = table.ID;
            string name1 = table.Name;
            /*chuyển item được chọn trong combobox 
             * có kiểu object sang kiểu table */
            int id2 = (cbSwitchTable.SelectedItem as Table).ID;
            string name2 = (cbSwitchTable.SelectedItem as Table).Name;
            if (MessageBox.Show(string.Format("bạn có thật sự muốn gộp {0} qua {1} hay không ", name1, name2), "thông báo gộp bàn", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
            {
                TableDAO.Instance.MegerTable(id1, id2);
                lsvBill.Items.Clear();
            }

            LoadTable();
        }

        private void adminToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fAdmin f = new fAdmin();
            f.InsertFood += F_InsertFood;
            f.DeleteFood += F_DeleteFood;
            f.UpdateFood += F_UpdateFood;
            f.InsertCategory += F_InsertCategory;
            f.UpdateCategory += F_UpdateCategory;
            f.DeleteCategory += F_DeleteCategory;
            f.InsertTable += F_InsertTable;
            f.UpdateTable += F_UpdateTable;
            f.DeleteTable += F_DeleteTable;
            f.InsertAccount += F_InsertAccount;
            f.loginAccount = loginAccount;
            f.ShowDialog();
        }


        private void quảnLýKhoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fWarehouseManagement f = new fWarehouseManagement();
            f.ShowDialog();
        }

        private void F_InsertAccount(object? sender, EventArgs e)
        {
            Account updatedAccount = AccountDAO.Instance.GetAccountByUserName(loginAccount.UserName);
            if (updatedAccount != null)
            {
                loginAccount = updatedAccount;
                thôngTinTàiKhoảnToolStripMenuItem.Text = "thông tin tài khoản (" + loginAccount.DisplayName + ")";
            }
        }

        private void F_DeleteTable(object? sender, EventArgs e)
        {
            LoadTable();
            LoadComboboxTable(cbSwitchTable);
        }

        private void F_UpdateTable(object? sender, EventArgs e)
        {
            LoadTable();
            LoadComboboxTable(cbSwitchTable);
        }

        private void F_InsertTable(object? sender, EventArgs e)
        {
            LoadTable();
            LoadComboboxTable(cbSwitchTable);
        }

        //thêm xóa sửa category
        private void F_DeleteCategory(object? sender, EventArgs e)
        {
            LoadCategory();
            if (lsvBill.Tag != null)
                ShowBill((lsvBill.Tag as Table).ID);

            LoadTable();
        }

        private void F_UpdateCategory(object? sender, EventArgs e)
        {
            LoadCategory();
            if (lsvBill.Tag != null)
                ShowBill((lsvBill.Tag as Table).ID);
        }

        private void F_InsertCategory(object? sender, EventArgs e)
        {
            LoadCategory();
        }

        //thêm xóa sửa food
        private void F_UpdateFood(object? sender, EventArgs e)
        {
            LoadFoodListByCategoryID((cbCategory.SelectedItem as Category).ID);
            if (lsvBill.Tag != null)
                ShowBill((lsvBill.Tag as Table).ID);
        }

        private void F_DeleteFood(object? sender, EventArgs e)
        {
            LoadFoodListByCategoryID((cbCategory.SelectedItem as Category).ID);
            if (lsvBill.Tag != null)
                ShowBill((lsvBill.Tag as Table).ID);

            LoadTable();
        }

        private void F_InsertFood(object? sender, EventArgs e)
        {
            LoadFoodListByCategoryID((cbCategory.SelectedItem as Category).ID);
            if (lsvBill.Tag != null)
                ShowBill((lsvBill.Tag as Table).ID);
        }
        #endregion



    }
}
