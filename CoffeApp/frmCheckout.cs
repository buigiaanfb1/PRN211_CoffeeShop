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
    public partial class frmCheckout : Form
    {
        public frmCheckout()
        {
            InitializeComponent();
        }

        private IBillInfoRepository billinfo = new BillInfoRepository();
        private IBillRepository bill = new BillRepository();

        private void ProcessingCheckout(int tableindex)
        {
            try
            {
                if (billinfo.IsReceiptEmpty(bill.GetCountingBill(tableindex)))
                {
                    MessageBox.Show("This Table Doesn't order anything.");
                    return;
                }
                else
                {
                    frmConfirmCheckout confirm = new frmConfirmCheckout(tableindex);
                    if (confirm.ShowDialog() == DialogResult.OK)
                    {
                        MessageBox.Show("Table " + tableindex + "has completed order. You will no longer access to that receipt");
                    }
                }
            }
            catch(Exception ex)
            {
                if (ex.Message == "Sequence contains no elements") MessageBox.Show("This Table Doesn't have order");
                else MessageBox.Show(ex.Message);
            }
        }

        private void BtnT1_Click(object sender, EventArgs e)
        {
            ProcessingCheckout(1);
        }

        private void btnT2_Click(object sender, EventArgs e)
        {
            ProcessingCheckout(2);
        }

        private void btnT3_Click(object sender, EventArgs e)
        {
            ProcessingCheckout(3);
        }

        private void btnT4_Click(object sender, EventArgs e)
        {
            ProcessingCheckout(4);
        }

        private void btnT5_Click(object sender, EventArgs e)
        {
            ProcessingCheckout(5);
        }
    }
}
