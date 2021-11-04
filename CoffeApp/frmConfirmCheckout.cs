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
    public partial class frmConfirmCheckout : Form
    {
        public frmConfirmCheckout(int tableid)
        {
            InitializeComponent();
            tableindex = tableid;
        }

        private int tableindex;
        private IReceiptRepository receipt = new ReceiptRepository();
        private IBillRepository billrepo = new BillRepository();
        private List<ReceiptObject> list;

        private void LoadReceipts()
        {
            list = receipt.GetReceiptsForTable(tableindex);
            DataTable data = tableFormatter(list);
            checkoutTable.DataSource = data;
            decimal totalCheckout = 0;
            foreach(ReceiptObject money in list)
            {
                totalCheckout += money.totalMoney;
            }
            txtMoney.Text = totalCheckout.ToString();
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

        private void frmConfirmCheckout_Load(object sender, EventArgs e)
        {
            txtMoney.Enabled = false;
            LoadReceipts();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            DialogResult dr;
            dr = MessageBox.Show("After Hit OK You must have received: " + txtMoney.Text, "Checkout This Receipt",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if (dr == DialogResult.OK)
            {
                billrepo.ConfirmCheckout(billrepo.GetCountingBill(tableindex),
                    txtDiscount.DecimalPlaces, decimal.Parse(txtMoney.Text));
            }
            else
            {
                this.DialogResult = DialogResult.None;
            }
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            decimal discount = txtDiscount.Value;
            decimal totalCheckout = 0;
            foreach (ReceiptObject money in list)
            {
                totalCheckout += money.totalMoney;
            }
            if(discount == 0)
            {
                txtMoney.Text = totalCheckout.ToString();
                return;
            }
            totalCheckout = totalCheckout * (100 - discount) / 100;
            txtMoney.Text = totalCheckout.ToString();
        }
    }
}
