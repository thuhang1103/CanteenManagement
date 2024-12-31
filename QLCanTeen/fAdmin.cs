using QLCanTeen.DAO;
using QLCanTeen.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace QLCanTeen
{
    public partial class fAdmin : Form
    {
        BindingSource foodList = new BindingSource();
        BindingSource categoryList = new BindingSource();
        BindingSource tableList = new BindingSource();
        BindingSource accountList = new BindingSource();
        public Account loginAccount;

        public fAdmin()
        {
            InitializeComponent();
            Load();

        }
        #region methos

        List<Food> SearchFoodByName(string name)
        {
            List<Food> listFood = FoodDAO.Instance.SearchFoodByName(name);
            return listFood;
        }
        void Load()
        {
            dtgvFood.DataSource = foodList;
            dtgvCategory.DataSource = categoryList;
            dtgvTable.DataSource = tableList;
            dtgvAccount.DataSource = accountList;
            LoadDateTimePickerBill();
            LoadListBillByDateAndPage(dtpkFromDate.Value, dtpkToDate.Value, 1);
            LoadListFood();
            LoadListCategory();
            LoadListTable();
            LoadAccount();
            AddFoodBinding();
            AddTableBinding();
            AddCategoryBinding();
            AddAccountBinding();
            LoadCategoryIntoCombobox(cbFoodCategory);
            
        }

        void LoadDateTimePickerBill()
        {
            DateTime today = DateTime.Now;
            dtpkFromDate.Value = new DateTime(today.Year, today.Month, 1);
            dtpkToDate.Value = dtpkFromDate.Value.AddMonths(1).AddDays(-1);
        }
        void LoadListBillByDate(DateTime checkin, DateTime checkOut)
        {
            dtgvBill.DataSource = BillDAO.Instance.GetBillListBydate(checkin, checkOut);
        }
        void LoadListBillByDateAndPage(DateTime checkin, DateTime checkOut , int pageNum)
        {
            dtgvBill.DataSource = BillDAO.Instance.GetBillListBydateAndPage(checkin, checkOut ,pageNum);
        }
        void LoadListTable()
        {
            tableList.DataSource = TableDAO.Instance.LoadTableList();
        }
        void LoadListCategory()
        {
            categoryList.DataSource = CategoryDAO.Instance.GetlistCategory();
        }
        void LoadCategory()
        {
            List<Category> listcategory = CategoryDAO.Instance.GetlistCategory();
            cbFoodCategory.DataSource = listcategory;
            cbFoodCategory.DisplayMember = "Name";
        }
        void LoadListFood()
        {
            foodList.DataSource = FoodDAO.Instance.GetListFood();
        }
        void LoadAccount()
        {
            accountList.DataSource = AccountDAO.Instance.GetListAccount();
        }
        void AddAccountBinding()
        {
            txbUserName.DataBindings.Add(new Binding("Text", dtgvAccount.DataSource, "userName", true, DataSourceUpdateMode.Never));
            txbDisplayName.DataBindings.Add(new Binding("Text", dtgvAccount.DataSource, "displayName", true, DataSourceUpdateMode.Never));
            nmTypeAccount.DataBindings.Add(new Binding("value", dtgvAccount.DataSource, "type", true, DataSourceUpdateMode.Never));
        }

        void AddTableBinding()
        {
            txbTableID.DataBindings.Add(new Binding("Text", dtgvTable.DataSource, "ID", true, DataSourceUpdateMode.Never));
            txbTableName.DataBindings.Add(new Binding("Text", dtgvTable.DataSource, "name", true, DataSourceUpdateMode.Never));
            txbStatus.DataBindings.Add(new Binding("Text", dtgvTable.DataSource, "status", true, DataSourceUpdateMode.Never));

        }
        void AddCategoryBinding()
        {
            txbCategoryID.DataBindings.Add(new Binding("Text", dtgvCategory.DataSource, "ID", true, DataSourceUpdateMode.Never));
            txbNameCategory.DataBindings.Add(new Binding("Text", dtgvCategory.DataSource, "name", true, DataSourceUpdateMode.Never));
        }
        void AddFoodBinding()
        {
            txbFoodName.DataBindings.Add(new Binding("Text", dtgvFood.DataSource, "Name", true, DataSourceUpdateMode.Never));
            txbFoodId.DataBindings.Add(new Binding("Text", dtgvFood.DataSource, "ID", true, DataSourceUpdateMode.Never));
            nmFoodPrice.DataBindings.Add(new Binding("Value", dtgvFood.DataSource, "Price", true, DataSourceUpdateMode.Never));
            // cbFoodCategory.DataBindings.Add(new Binding());
        }
        void LoadCategoryIntoCombobox(ComboBox cb)
        {
            cb.DataSource = CategoryDAO.Instance.GetlistCategory();
            cb.DisplayMember = "Name";
        }
        //void LoadStatusIntoCombobox(ComboBox cb)
        //{
        //    cb.DataSource = TableDAO.Instance.LoadTableList();
        //    cb.DisplayMember = "status";
        //}
        void AddAccount(string userName, string displayName, int type)
        {

            if (AccountDAO.Instance.InsertAccount(userName, displayName, type))
            {
                MessageBox.Show("thêm tài khoản thành công ");
                LoadAccount();
                if (insertAccount != null)
                    insertAccount(this, new EventArgs());

            }
            else
            {
                MessageBox.Show(" tên tài khoản đã tồn tại");
            }

        }
        void EditAccount(string userName, string displayName, int type)
        {

            if (AccountDAO.Instance.UpdateAccount(userName, displayName, type))
            {
                MessageBox.Show("cập nhật tài khoản thành công ");
                LoadAccount();
                if (insertAccount != null)
                    insertAccount(this, new EventArgs());


            }
            else
            {
                MessageBox.Show(" sửa tài khoản thất bại ");
            }

        }
        void DeleteAccount(string userName)
        {
            //kiểm tra tài khoản đang đăng nhập 
            if (loginAccount.UserName.Equals(userName))
            {
                MessageBox.Show("không thể xóa tài khoản đang đăng nhập");
                return;
            }
            if (AccountDAO.Instance.DeleteAccount(userName))
            {
                MessageBox.Show("xóa tài khoản thành công ");
                LoadAccount();

            }
            else
            {
                MessageBox.Show(" xóa tài khoản thất bại ");
            }

        }
        void ResetPass(string userName)
        {
            if (AccountDAO.Instance.ResetPassword(userName))
            {
                MessageBox.Show("cập nhật mật khẩu thành công ");
            }
            else
            {
                MessageBox.Show("cập nhật mật khẩu thất bại ");
            }
        }

        #endregion

        #region events
        private void dtgvBill_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnViewBill_Click(object sender, EventArgs e)
        {
            LoadListBillByDateAndPage(dtpkFromDate.Value, dtpkToDate.Value, 1);
            txbPage.Text = "1";
        }

        private void btnShowFood_Click(object sender, EventArgs e)
        {
            LoadListFood();

            LoadCategoryIntoCombobox(cbFoodCategory);
        }
        //binding category theo idfood

        private void txbFoodId_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (dtgvFood.SelectedCells.Count > 0) // Kiểm tra xem có ô nào được chọn không
                {
                    var selectedCell = dtgvFood.SelectedCells[0];

                    // Kiểm tra xem cột "CategoryID" có giá trị hợp lệ hay không
                    if (selectedCell.OwningRow.Cells["CategoryID"].Value != null)
                    {
                        int id = (int)selectedCell.OwningRow.Cells["CategoryID"].Value;

                        // Lấy danh mục từ ID
                        Category category = CategoryDAO.Instance.GetCategoryByID(id);

                        if (category != null) // Kiểm tra danh mục có tồn tại
                        {
                            cbFoodCategory.SelectedItem = category;

                            int index = -1;
                            int i = 0;

                            // Tìm danh mục trong ComboBox
                            foreach (Category item in cbFoodCategory.Items)
                            {
                                if (item.ID == category.ID)
                                {
                                    index = i;
                                    break;
                                }
                                i++;
                            }

                            // Gán chỉ số được tìm thấy hoặc không tìm thấy
                            cbFoodCategory.SelectedIndex = index;
                        }
                        else
                        {
                            // Nếu không tìm thấy danh mục, đặt giá trị mặc định
                            cbFoodCategory.SelectedIndex = -1;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Đã xảy ra lỗi: {ex.Message}");
            }

        }

        private void btnAddFood_Click(object sender, EventArgs e)
        {
            string nameCategory = txbNameCategory.Text;
            List<string> categoryNames = CategoryDAO.Instance.getNameCategory();
            if (!categoryNames.Contains(nameCategory))
            {
                MessageBox.Show("Danh mục không tồn tại!");
                return;
            }
            string name = txbFoodName.Text;
            int categoryID = (cbFoodCategory.SelectedItem as Category).ID;
            float price = (float)nmFoodPrice.Value;
            if (FoodDAO.Instance.InsertFood(name, categoryID, price))
            {
                MessageBox.Show("thêm món thành công ");
                LoadListFood();
                if (insertFood != null)
                    insertFood(this, new EventArgs());

            }
            else
            {
                MessageBox.Show("món ăn đã tồn tại");
            }

        }

        private void btnEditFood_Click(object sender, EventArgs e)
        {
            string name = txbFoodName.Text;
            int categoryID = (cbFoodCategory.SelectedItem as Category).ID;
            float price = (float)nmFoodPrice.Value;
            int id = Convert.ToInt32(txbFoodId.Text);
            if (FoodDAO.Instance.UpdateFood(id, name, categoryID, price))
            {
                MessageBox.Show("sửa món thành công ");
                LoadListFood();
                if (updateFood != null)
                    updateFood(this, new EventArgs());
            }
            else
            {
                MessageBox.Show("có lỗi khi sửa món" + name);
            }
        }

        private void btnDeleteFood_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txbFoodId.Text);
            string name = FoodDAO.Instance.getFoodNameByID(id);
            if (MessageBox.Show(string.Format("bạn có thật sự muốn xóa món {0}", name), "thông báo xóa món", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
            {
                if (FoodDAO.Instance.DeleteFood(id))
                {
                    MessageBox.Show("xóa món thành công ");
                    LoadListFood();
                    TableDAO.Instance.SetTable();
                    if (deleteFood != null)
                        deleteFood(this, new EventArgs());

                }
                else
                {
                    MessageBox.Show("có lỗi khi xóa món" + name);
                }
            }
        }

        private void btnSearchFood_Click(object sender, EventArgs e)
        {
            foodList.DataSource = SearchFoodByName(txbSearchFoodName.Text);
        }

        private void btnShowCategory_Click(object sender, EventArgs e)
        {
            LoadListCategory();
        }

        private void btnShowTable_Click(object sender, EventArgs e)
        {
            LoadListTable();
        }

        private void btnAddCategory_Click(object sender, EventArgs e)
        {
            string name = txbNameCategory.Text;
            if (CategoryDAO.Instance.InsertCategory(name))
            {
                MessageBox.Show("thêm danh mục thành công ");
                LoadListCategory();
                LoadListFood();
                LoadCategory();
                if (insertCategory != null)
                    insertCategory(this, new EventArgs());

            }
            else
            {
                MessageBox.Show("danh mục đã tồn tại");
            }
        }

        private void btnEditCategory_Click(object sender, EventArgs e)
        {
            string name = txbNameCategory.Text;
            int id = Convert.ToInt32(txbCategoryID.Text);
            if (CategoryDAO.Instance.UpdateCategory(id, name))
            {
                MessageBox.Show("sửa danh mục thành công  ");
                LoadListCategory();
                LoadListFood();
                LoadCategory();
                if (updateCategory != null)
                    updateCategory(this, new EventArgs());
            }
            else
            {
                MessageBox.Show("có lỗi khi sửa danh mục" + name);
            }
        }

        private void btnDeleteCategory_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txbCategoryID.Text);
            string name = CategoryDAO.Instance.getNameCategoryByID(id);
            if (MessageBox.Show(string.Format("bạn có thật sự muốn danh mục {0}", name), "thông báo xóa danh mục", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
            {
                if (CategoryDAO.Instance.DeleteCategory(id))
                {
                    MessageBox.Show("xóa danh mục thành công ");
                    LoadListCategory();
                    LoadListFood();
                    LoadCategory();
                    TableDAO.Instance.SetTable();
                    if (deleteCategory != null)
                        deleteCategory(this, new EventArgs());

                }
                else
                {
                    MessageBox.Show("có lỗi khi xóa danh mục" + name);
                }
            }

        }

        private void btnAddTable_Click(object sender, EventArgs e)
        {
            string name = txbTableName.Text;
            if (TableDAO.Instance.InsertTable(name))
            {
                MessageBox.Show("thêm bàn thành công ");
                LoadListTable();
                if (insertTable != null)
                    insertTable(this, new EventArgs());

            }
            else
            {
                MessageBox.Show("bàn đã tồn tại");
            }

        }

        private void btnEditTable_Click(object sender, EventArgs e)
        {
            string name = txbTableName.Text;
            int id = Convert.ToInt32(txbTableID.Text);
            if (TableDAO.Instance.UpdateTable(id, name))
            {
                MessageBox.Show("sửa bàn thành công ");
                LoadListTable();
                //if (insertTable != null)
                //    insertTable(this, new EventArgs());
                if (updateTable != null)
                    updateTable(this, new EventArgs());

            }
            else
            {
                MessageBox.Show("có lỗi khi sửa bàn");
            }
        }

        private void btnDeleteTable_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txbTableID.Text);
            string name = TableDAO.Instance.GetNameTableByID(id);
            if (MessageBox.Show(string.Format("bạn có thật sự muốn xóa {0}", name), "thông báo xóa bàn", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
            {
                if (TableDAO.Instance.DeleteTable(id))
                {
                    MessageBox.Show("xóa bàn thành công ");
                    LoadListTable();
                    //if (insertTable != null)
                    //    insertTable(this, new EventArgs());
                    if (deleteTable != null) deleteTable(this, new EventArgs());
                }
                else
                {
                    MessageBox.Show("có lỗi khi xóa bàn");
                }
            }

        }

        private void btnTotalRevenueMonth_Click(object sender, EventArgs e)
        {
            DateTime selectedDate = dtpkFromDate.Value;
            decimal totalRevenue = BillDAO.Instance.GetTotalRevenueByMonth(selectedDate);
            txbTotalRevenueMonth.Text = $"{totalRevenue:N0} VNĐ";
        }

        private void btnTotalRevenua_Click(object sender, EventArgs e)
        {
            DateTime selectedDate = dtpkDate.Value;
            decimal totalRevenue = BillDAO.Instance.GetTotalRevenueDay(selectedDate);
            txbTotalRevenueDay.Text = $"{totalRevenue:N0} VNĐ";
        }

        private void btnShowAccount_Click(object sender, EventArgs e)
        {
            LoadAccount();
        }

        private void btnAddAccount_Click(object sender, EventArgs e)
        {
            string userName = txbUserName.Text;
            string displayName = txbDisplayName.Text;
            int type = (int)nmTypeAccount.Value;
            AddAccount(userName, displayName, type);

        }

        private void btnDeleteAccount_Click(object sender, EventArgs e)
        {
            string userName = txbUserName.Text;
            if (MessageBox.Show(string.Format("bạn có thật sự muốn xóa tài khoản {0}", userName), "thông báo xóa tài khoản", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
            {
                DeleteAccount(userName);
            }

        }

        private void btnEditAccount_Click(object sender, EventArgs e)
        {
            string userName = txbUserName.Text;
            string displayName = txbDisplayName.Text;
            int type = (int)nmTypeAccount.Value;
            EditAccount(userName, displayName, type);
        }

        private void btnResetPassword_Click(object sender, EventArgs e)
        {
            string userName = txbUserName.Text;
            ResetPass(userName);
        }

        private void btnFirst_Click(object sender, EventArgs e)
        {
            txbPage.Text = "1";
        }

        private void btnLast_Click(object sender, EventArgs e)
        {
            int sumRecord = BillDAO.Instance.GetNumBillBydate(dtpkFromDate.Value, dtpkToDate.Value);
            int lastPage = sumRecord / 10;
            if (sumRecord % 10 != 0)
            {
                lastPage++;
            }
            txbPage.Text = lastPage.ToString();
        }

        private void txbPage_TextChanged(object sender, EventArgs e)
        {
            dtgvBill.DataSource = BillDAO.Instance.GetBillListBydateAndPage(dtpkFromDate.Value, dtpkToDate.Value, Convert.ToInt32(txbPage.Text));
        }

        private void btnNextFirst_Click(object sender, EventArgs e)
        {
            int page = Convert.ToInt32(txbPage.Text);
            int sumRecord = BillDAO.Instance.GetNumBillBydate(dtpkFromDate.Value, dtpkToDate.Value) ;
            int lastPage = sumRecord / 10;
            if (sumRecord % 10 != 0)
            {
                lastPage++;
            }
            if (page < lastPage)
                page++;
            txbPage.Text = page.ToString();

        }

        private void btnNextLast_Click(object sender, EventArgs e)
        {

            int page = Convert.ToInt32(txbPage.Text);
            if (page > 1)
                page--;
            txbPage.Text = page.ToString();

        }

        private event EventHandler insertFood;
        public event EventHandler InsertFood
        {
            add { insertFood += value; }
            remove { insertFood -= value; }
        }
        private event EventHandler updateFood;
        public event EventHandler UpdateFood
        {
            add { updateFood += value; }
            remove { updateFood -= value; }
        }
        private event EventHandler deleteFood;
        public event EventHandler DeleteFood
        {
            add { deleteFood += value; }
            remove { deleteFood -= value; }
        }
        private event EventHandler insertCategory;
        public event EventHandler InsertCategory
        {
            add { insertCategory += value; }
            remove { insertCategory -= value; }
        }
        private event EventHandler updateCategory;
        public event EventHandler UpdateCategory
        {
            add { updateCategory += value; }
            remove { updateCategory -= value; }
        }
        private event EventHandler deleteCategory;
        public event EventHandler DeleteCategory
        {
            add { deleteCategory += value; }
            remove { deleteCategory -= value; }
        }
        private event EventHandler insertTable;
        public event EventHandler InsertTable
        {
            add { insertTable += value; }
            remove { insertTable -= value; }
        }
        private event EventHandler updateTable;
        public event EventHandler UpdateTable
        {
            add { updateTable += value; }
            remove { updateTable -= value; }
        }
        private event EventHandler deleteTable;
        public event EventHandler DeleteTable
        {
            add { deleteTable += value; }
            remove { deleteTable -= value; }
        }
        private event EventHandler insertAccount;
        public event EventHandler InsertAccount
        {
            add { insertAccount += value; }
            remove { insertAccount -= value; }
        }
        #endregion




    }
}
