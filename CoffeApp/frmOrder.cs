using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessObject.Object;
using DataAccess.Repository;

namespace CoffeApp
{
    public partial class frmOrder : Form
    {
        public frmOrder(string tableindex, bool WhichButton, bool editable)
        {
            InitializeComponent();
            servingtable = tableindex;
            NewOrOld = WhichButton;
            editing = editable;
        }

        private string servingtable;
        private bool NewOrOld; //true = new, false = old
        private bool editing;
        private IBillInfoRepository billinfo = new BillInfoRepository();
        private IBillRepository bill = new BillRepository();
        private IReceiptRepository receipt = new ReceiptRepository();
        private IFoodRepository foodRepo = new FoodRepository();
        private int currentbill;

        private void frmOrder_Load(object sender, EventArgs e)
        {
            if(!NewOrOld)
            {
                currentbill = bill.GetLatestBill(int.Parse(servingtable.Substring(servingtable.Length - 1)));
                LoadReceipts();
                if(!editing)
                {
                    btnCreate.Enabled = false;
                    btnDelete.Enabled = false;
                    btnUpdate.Enabled = false;
                }
            }
            else
            {
                try
                {
                    bill.CreateNewReceipt(int.Parse(servingtable.Substring(servingtable.Length - 1)));
                    currentbill = bill.GetLatestBill(int.Parse(servingtable.Substring(servingtable.Length - 1)));
                    MessageBox.Show("You are serving " + servingtable + " With new Receipt");
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message, "Create new Receipt failed");
                }
            }
        }
        private DataTable tableFormatter(List<ReceiptObject> foodlist)
        {
            DataTable table = new DataTable();
            //MemberID, MemberName, Email, Password, City, Country
            table.Columns.Add("Food Name");
            table.Columns.Add("Quantity");
            table.Columns.Add("Unit Price");
            table.Columns.Add("Total Price");
            foreach (ReceiptObject food in foodlist)
            {
                table.Rows.Add(new object[] { food.foodname, food.quantity, food.Price, food.totalMoney });
            }
            return table;
        }

        private void LoadReceipts()
        {
            List<ReceiptObject> list = receipt.GetReceipts(currentbill);
            DataTable data = tableFormatter(list);
            ReceiptsTable.DataSource = data;
        }

        private void frmOrder_FormClosed(object sender, FormClosedEventArgs e)
        {
            //i dunno
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            frmOrderInput input = new frmOrderInput(currentbill, true);
            if(input.ShowDialog() == DialogResult.OK)
            {
                LoadReceipts();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in ReceiptsTable.SelectedRows)
            {
                string foodname = row.Cells[0].Value.ToString();
                Food goodbye = foodRepo.GetFoodByName(foodname);
                frmOrderInput input = new frmOrderInput(currentbill, false)
                {
                    chosenfood = goodbye
                };
                input.ShowDialog();
            }
            LoadReceipts();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult dr;
            dr = MessageBox.Show("Are you sure want to delete selected row", "Receipt Management",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if (dr == DialogResult.OK)
            {
                foreach (DataGridViewRow row in ReceiptsTable.SelectedRows)
                {
                    string foodname = row.Cells[0].Value.ToString();
                    int quantity = int.Parse(row.Cells[1].Value.ToString());
                    Food goodbye = foodRepo.GetFoodByName(foodname);
                    receipt.RemoveCurrentReceipt(new ReceiptObject(goodbye.Name, quantity,
                        goodbye.Price, goodbye.Price * quantity, goodbye.Id), currentbill);
                }
                LoadReceipts();
            }
        }
    }
}
