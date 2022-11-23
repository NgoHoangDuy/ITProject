using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CoffeeManager.DTO;
using CoffeeManager.DAO;
using System.Globalization;

namespace CoffeeManager
{
    public partial class OrderForm : Form
    {
        private Account loginAccount;

        public Account LoginAccount
        {
            get { return loginAccount; }
            set { loginAccount = value; ChangeAccount(loginAccount.Type); }
        }
        public OrderForm(Account acc)
        {
            InitializeComponent();
            this.LoginAccount = acc;
            LoadTable();
            LoadCategory();
        }
        #region Method

        void ChangeAccount(int type)
        {
            toolStripMenuItemAccountInfor.Text += " (" + LoginAccount.DisplayName + ")";
        }
        void LoadCategory()
        {
            List<Category> listCategory = CategoryDAO.Instance.GetListCategory();
            cbCategory.DataSource = listCategory;
            cbCategory.DisplayMember = "Name";
        }

        void LoadFoodListByCategoryID(int id)
        {
            List<Food> listFood = FoodDAO.Instance.GetFoodByCategoryID(id);
            cbFood.DataSource = listFood;
            cbFood.DisplayMember = "Name";
        }
        void LoadTable()
        {
            flpTable.Controls.Clear();

            List<Table> tableList = TableDAO.Instance.LoadTableList();

            foreach (Table item in tableList)
            {
                Button btn = new Button() { Width = TableDAO.TableWidth, Height = TableDAO.TableHeight };
                btn.Text = item.Name + Environment.NewLine + item.Status;
                btn.Click += btn_Click;
                btn.Tag = item;

                switch (item.Status)
                {
                    case "Trống":
                        btn.BackColor = Color.DimGray;
                        break;
                    case "Đang chờ":
                        btn.BackColor = Color.Red;
                        break;
                    default:
                        btn.BackColor = Color.Sienna;
                        break;
                }

                flpTable.Controls.Add(btn);
            }
        }

        void ShowBill(int id)
        {
            lsvBill.Items.Clear();
            List<CoffeeManager.DTO.Menu> listBillInfo = MenuDAO.Instance.GetListMenuByTable(id);
            float totalPrice = 0;
            foreach (CoffeeManager.DTO.Menu item in listBillInfo)
            {
                ListViewItem lsvItem = new ListViewItem(item.FoodName.ToString());
                lsvItem.SubItems.Add(item.Count.ToString());
                lsvItem.SubItems.Add(item.Price.ToString());
                lsvItem.SubItems.Add(item.TotalPrice.ToString());
                totalPrice += item.TotalPrice;
                lsvBill.Items.Add(lsvItem);
            }
            CultureInfo culture = new CultureInfo("vi-VN");

            //Thread.CurrentThread.CurrentCulture = culture;

            txbTotalPrice.Text = totalPrice.ToString("c", culture);

        }


        void Payment()
        {
            Table table = lsvBill.Tag as Table;

            int idBill = BillDAO.Instance.GetUncheckBillIDByTableID(table.ID);
            int discount = Convert.ToInt32(cbDisCount.Text);

            double totalPrice = Convert.ToDouble(txbTotalPrice.Text.Split(',')[0]);
            double finalTotalPrice = totalPrice - (totalPrice / 100) * discount;

            if (idBill != -1)
            {

                CultureInfo culture = new CultureInfo("vi-VN");
                if (MessageBox.Show(string.Format("Bạn có chắc thanh toán hóa đơn cho bàn {0}\nTổng tiền - (Tổng tiền / 100) x Giảm giá\n=> {1} - ({1} / 100) x {2} = {3}", table.Name, totalPrice, discount, (finalTotalPrice * 1000).ToString("c", culture)), "Thông báo", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
                {
                    int id = (lsvBill.Tag as Table).ID;
                    UpDateStatusTable("Đang chờ", id);
                    LoadTable();

                }

            }
            else
            {
                MessageBox.Show("Chưa có hóa đơn!", "Thông báo", MessageBoxButtons.OK);
            }
        }

        void Served()
        {
            Table table = lsvBill.Tag as Table;

            int idBill = BillDAO.Instance.GetUncheckBillIDByTableID(table.ID);
            int discount = Convert.ToInt32(cbDisCount.Text);

            double totalPrice = Convert.ToDouble(txbTotalPrice.Text.Split(',')[0]);
            double finalTotalPrice = totalPrice - (totalPrice / 100) * discount;
            string status = table.Status;

            if (status == "Đang chờ")
            {

                if (MessageBox.Show(string.Format("Bạn có chắc đã phục vụ bàn này?"), "Thông báo", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
                {
                    int id = (lsvBill.Tag as Table).ID;
                    UpDateStatusTable("Có người", id);
                    BillDAO.Instance.CheckOut(idBill, discount, (float)finalTotalPrice);
                    ShowBill(table.ID);
                    LoadTable();

                }

            }
            else
            {
                MessageBox.Show("Chưa có hóa đơn đã thanh toán!", "Thông báo", MessageBoxButtons.OK);
            }
        }
        void Checkout()
        {
            Table table = lsvBill.Tag as Table;
            int idBill = BillDAO.Instance.GetUncheckBillIDByTableID(table.ID);
            int discount = Convert.ToInt32(cbDisCount.Text);

            double totalPrice = Convert.ToDouble(txbTotalPrice.Text.Split(',')[0]);
            double finalTotalPrice = totalPrice - (totalPrice / 100) * discount;
            string status = table.Status;
            if (status == "Có người")
            {

                if (MessageBox.Show(string.Format("Bạn xác nhận bàn này không còn khách nào?"), "Thông báo", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
                {
                    int id = (lsvBill.Tag as Table).ID;
                    UpDateStatusTable("Trống", id);
                    LoadTable();
                }

            }
            else
            {
                if (MessageBox.Show("Bàn này chưa được phục vụ. Bạn có muốn tiếp tục xác nhận bàn trống?", "Thông báo", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
                {
                    int id = (lsvBill.Tag as Table).ID;
                    UpDateStatusTable("Trống", id);
                    BillDAO.Instance.CheckOut(idBill, discount, (float)finalTotalPrice);
                    ShowBill(table.ID);
                    LoadTable();
                }
            }



        }
        void UpDateStatusTable(string status, int id)
        {
            TableDAO.Instance.UpdateStatusTable(status, id);
        }
        #endregion


        #region Events

        private void btnPayment_Click(object sender, EventArgs e)
        {
            Payment();

        }
        private void btnServed_Click(object sender, EventArgs e)
        {
            Served();
        }

        void btn_Click(object sender, EventArgs e)
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
            fAccountProfile f = new fAccountProfile(LoginAccount);
            f.UpdateAccount += f_UpdateAccount;
            f.ShowDialog();
        }

        void f_UpdateAccount(object sender, AccountEvent e)
        {
            toolStripMenuItemAccountInfor.Text = "Thông tin tài khoản (" + e.Acc.DisplayName + ")";
        }

        private void cbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            int id = 0;

            ComboBox cb = sender as ComboBox;

            if (cb.SelectedItem == null)
                return;

            Category selected = cb.SelectedItem as Category;
            id = selected.ID;

            LoadFoodListByCategoryID(id);
        }

        private void btnAddFood_Click(object sender, EventArgs e)
        {
            Table table = lsvBill.Tag as Table;

            if (table == null)
            {
                MessageBox.Show("Hãy chọn bàn");
                return;
            }

            int idBill = BillDAO.Instance.GetUncheckBillIDByTableID(table.ID);
            int foodID = (cbFood.SelectedItem as Food).ID;
            int count = Convert.ToInt32(Count.Text);

            if (idBill == -1)
            {
                BillDAO.Instance.InsertBill(table.ID);
                BillInfoDAO.Instance.InsertBillInfo(BillDAO.Instance.GetMaxIDBill(), foodID, count);
            }
            else
            {
                BillInfoDAO.Instance.InsertBillInfo(idBill, foodID, count);
            }

            ShowBill(table.ID);

            LoadTable();
        }
        private void btnDecFood_Click(object sender, EventArgs e)
        {
            Table table = lsvBill.Tag as Table;

            if (table == null)
            {
                MessageBox.Show("Hãy chọn bàn");
                return;
            }

            int idBill = BillDAO.Instance.GetUncheckBillIDByTableID(table.ID);
            int foodID = (cbFood.SelectedItem as Food).ID;
            int count = Convert.ToInt32(cbCount.Text);

            if (idBill == -1)
            {
                BillDAO.Instance.InsertBill(table.ID);
                BillInfoDAO.Instance.InsertBillInfo(BillDAO.Instance.GetMaxIDBill(), foodID, -count);
            }
            else
            {
                BillInfoDAO.Instance.InsertBillInfo(idBill, foodID, -count);
            }

            ShowBill(table.ID);

            LoadTable();
        }
        private void btnCheckOut_Click(object sender, EventArgs e)
        {
            Checkout();
        }

        

        #endregion


    }
}
