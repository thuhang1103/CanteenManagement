using QLCanTeen.DAO;
using QLCanTeen.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices.JavaScript;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLCanTeen
{
    public partial class fWarehouseManagement : Form
    {
        BindingSource CommodityList = new BindingSource();
        public fWarehouseManagement()
        {
            InitializeComponent();
            Load();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
        #region methos
        void Load()
        {
            dtgvCommodity.DataSource = CommodityList;
            LoadListCommodity();
            LoadDateTimePickerBill();
            AddCommodityBinding();
            LoadTypeIntoCombobox(cbType);
            LoadListCommodityOut();
        }
        void LoadListCommodity()
        {
            CommodityList.DataSource = CommodityDAO.Instance.GetlistCommodity();
        }
        void LoadListCommodityByType(int idType)
        {
            CommodityList.DataSource = CommodityDAO.Instance.GetlistCommodityByType(idType);
        }
        void LoadListCommodityOut()
        {
            dtgvCommodity2.DataSource = CommodityDAO.Instance.GetlistCommodityOut();
        }
        void LoadListInventory(DateTime date)
        {
            dtgvCommodity2.DataSource = CommodityDAO.Instance.GetlistInventory(date);
        }
        void LoadDateTimePickerBill()
        {
            dtpkCommodity.Value = DateTime.Now;

        }
        void AddCommodityBinding()
        {
            txbNameCommodity.DataBindings.Add(new Binding("Text", dtgvCommodity.DataSource, "name", true, DataSourceUpdateMode.Never));
            nmCommodity.DataBindings.Add(new Binding("Value", dtgvCommodity.DataSource, "soluong", true, DataSourceUpdateMode.Never));
            cbType.DataBindings.Add(new Binding("SelectedValue", dtgvCommodity.DataSource, "idType", true, DataSourceUpdateMode.Never));
        }
        void LoadTypeIntoCombobox(ComboBox cb)
        {
            cb.DataSource = TypeCommodityDAO.Instance.GetlistType();
            cb.DisplayMember = "Name";
            cb.ValueMember = "ID";
        }
        void ImportCommodity()
        {
            string name = txbNameCommodity.Text;
            int type = Convert.ToInt32(cbType.SelectedValue);
            int soluong = (int)nmCommodity.Value;
            DateTime date = dtpkCommodity.Value;
            List<string> names = CommodityDAO.Instance.getNameCommodity();
            if (names.Contains(name))
            {
                if (CommodityDAO.Instance.UpdateCommodity(name, soluong, date))
                {
                    LoadListCommodity();
                }
                return;
            }
            else
            {
                if (CommodityDAO.Instance.InsertCommodity(name, type, soluong, date))
                {
                    LoadListCommodity();
                }
                return;
            }

        }
        void ExportCommodity()
        {
            string name = txbNameCommodity.Text;
            int type = Convert.ToInt32(cbType.SelectedValue);
            int soluong = CommodityDAO.Instance.getSoluongByName(name);
            int soluongxuat = (int)nmCommodity.Value;

            List<string> names = CommodityDAO.Instance.getNameCommodity();
            if (names.Contains(name))
            {
                if (soluongxuat == soluong)
                {
                    CommodityDAO.Instance.DeleteCommodity(name);
                    return;
                }
                else
                {
                    if (soluongxuat > soluong)
                    {
                        if (MessageBox.Show(string.Format("mặt hàng này trong kho chỉ còn lại số lượng là {0},\n bạn có muốn xuất kho toàn bộ không", soluong), "thông báo", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
                        {
                            CommodityDAO.Instance.DeleteCommodity(name);
                            return;
                        }
                        return;
                    }
                    else
                    {
                        CommodityDAO.Instance.ExportCommodity(name, soluongxuat);
                        return;
                    }
                }
            }
            else
            {
                MessageBox.Show("Mặt hàng này không tồn tại trong kho");
            }
        }
        #endregion

        #region events
        private void btnShowGoods_Click(object sender, EventArgs e)
        {
            LoadListCommodity();
        }

        private void btnShow1_Click(object sender, EventArgs e)
        {
            int idType = 1;
            LoadListCommodityByType(idType);
        }

        private void btnShow2_Click(object sender, EventArgs e)
        {
            int idType = 2;
            LoadListCommodityByType(idType);
        }

        private void btnShow3_Click(object sender, EventArgs e)
        {
            int idType = 3;
            LoadListCommodityByType(idType);
        }

        private void btnImport_Click(object sender, EventArgs e)
        {
            ImportCommodity();
            LoadListCommodityOut();
        }
        private void btnExport_Click(object sender, EventArgs e)
        {
            ExportCommodity();
            LoadListCommodity();
            LoadListCommodityOut();
            

        }
        //hàng sắp hết
        private void button1_Click(object sender, EventArgs e)
        {
            LoadListCommodityOut();
        }
        //hàng tồn kho
        private void button3_Click(object sender, EventArgs e)
        {
            DateTime date = DateTime.Now;
            LoadListInventory(date);
        }
        #endregion





    }
}
