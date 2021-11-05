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
    public partial class frmDetailOrder : Form
    {
        public frmDetailOrder(int billindex)
        {
            InitializeComponent();
            billid = billindex;
        }
        private int billid;
        private IReceiptRepository dao = new ReceiptRepository();

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmDetailOrder_Load(object sender, EventArgs e)
        {
            LoadReceipts();
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
            List<ReceiptObject> list = dao.GetReceipts(billid);
            DataTable data = tableFormatter(list);
            ReceiptTable.DataSource = data;
        }
    }
}
