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
    public partial class frmHistoryOrder : Form
    {
        public frmHistoryOrder()
        {
            InitializeComponent();
        }

        private IBillRepository dao = new BillRepository();

        private void frmHistoryOrder_Load(object sender, EventArgs e)
        {
            List<Bill> everythingyouhavebuildwillfall = dao.GetBills();
            DataTable data = tableFormatter(everythingyouhavebuildwillfall);
            BillTable.DataSource = data;
        }

        private DataTable tableFormatter(List<Bill> fullbill)
        {
            DataTable table = new DataTable();
            //MemberID, MemberName, Email, Password, City, Country
            table.Columns.Add("ID");
            table.Columns.Add("Date CheckIn");
            table.Columns.Add("Date Checkout");
            table.Columns.Add("Table Serve");
            table.Columns.Add("Status");
            table.Columns.Add("Discount");
            table.Columns.Add("Income");
            string status;
            foreach (Bill bill in fullbill)
            {
                if (bill.Status == 1) status = "Counting";
                else if (bill.Status == 2) status = "Suspended";
                else status = "Completed";
                table.Rows.Add(new object[] {bill.Id, bill.DateCheckIn, bill.DateCheckOut,
                bill.IdTable, status, bill.Discount , bill.TotalPrice });
            }
            return table;
        }

        private void BillTable_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string selectedbill = BillTable.Rows[e.RowIndex].Cells[0].Value.ToString();
            int converter = int.Parse(selectedbill);
            frmDetailOrder alo = new frmDetailOrder(converter);
            alo.ShowDialog();
        }
    }
}
