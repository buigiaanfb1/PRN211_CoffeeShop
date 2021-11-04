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
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
            tableRepo = new TableRepository();
        }

        private ITableRepository tableRepo;
        private IBillRepository billRepo = new BillRepository();

        private void frmMain_Load(object sender, EventArgs e)
        {
            btnNewOrder.Enabled = false;
            FoodPanelSub.Visible = false;
            lbTableIndex.Hide();
            foreach(TableFood table in tableRepo.GetAvailableTables())
            {
                cbTableFood.Items.Add(table.Name);
            }
            btnOrder.Enabled = false;
            //btnCheckout.Enabled = false;
            lbTips.Text = "Tips: Select The table you want to serve ---->";
        }

        private void btnFoodManagement_Click(object sender, EventArgs e)
        {
            if (FoodPanelSub.Visible == false)
                FoodPanelSub.Visible = true;
            else FoodPanelSub.Visible = false;
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            frmCreateFood CFood = new frmCreateFood();
            ProcessChildForm(CFood);
        }



        Form openForm = null;
        private void ProcessChildForm(Form children)
        {
            if (openForm != null) openForm.Close();
            openForm = children;
            children.TopLevel = false;
            children.FormBorderStyle = FormBorderStyle.None;
            children.Dock = DockStyle.Fill;
            ChildrenFormPanel.Controls.Add(children);
            ChildrenFormPanel.Tag = children;
            ChildrenFormPanel.BringToFront();
            children.Show();
        }

        private void btnViewFood_Click(object sender, EventArgs e)
        {
            ProcessChildForm(new frmFoodList());
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            ProcessChildForm(new frmUpdateFood());
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            if(billRepo.CheckBillStatus(tableid))
            {
                ProcessChildForm(new frmOrder(cbTableFood.Text, false, true));
            }
            else
            {
                ProcessChildForm(new frmOrder(cbTableFood.Text, false, false));
            }
            
        }

        int tableid;
        private void cbTableFood_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnNewOrder.Enabled = true;
            lbTableIndex.Text = "You are serving: " + cbTableFood.Text;
            lbTableIndex.Show();
            tableid = int.Parse(cbTableFood.Text.Substring(cbTableFood.Text.Length - 1));
            //MessageBox.Show("Number: " + tableid);
            if(billRepo.CheckNoBill(tableid))
            {
                btnNewOrder.Enabled = true;
                btnOrder.Enabled = false;
                if (openForm != null) openForm.Close();
                lbTips.Text = "Tips: This table doesn't have a single order. Press New Receipt to create it";
            }
            else
            {
                btnOrder.Enabled = true;
                btnNewOrder.Enabled = true;
                if(!billRepo.CheckBillStatus(tableid))
                {
                    ProcessChildForm(new frmOrder(cbTableFood.Text, false, false));
                    lbTips.Text = "Tips: You are viewing the old receipt which have check out";
                }
                else
                {
                    ProcessChildForm(new frmOrder(cbTableFood.Text, false, true));
                    lbTips.Text = "Tips: You are viewing the receipt that still on working";
                }
            }
        }

        private void btnNewOrder_Click(object sender, EventArgs e)
        {
            int billindex = billRepo.GetLatestBill(cbTableFood.SelectedIndex);
            if (billRepo.CheckBillStatus(int.Parse(cbTableFood.Text.Substring(cbTableFood.Text.Length - 1))))
            {
                DialogResult dr;
                dr = MessageBox.Show("Are you sure want to Create a new receipt for" + cbTableFood.Text
                    + ".\nOld Receipt is not yet CheckOut And will be suspended.", "Coffe Management",
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
                if (dr == DialogResult.OK)
                {
                    billRepo.SetSuspendedBill(billindex);
                    ProcessChildForm(new frmOrder(cbTableFood.Text, true, true));
                    lbTips.Text = "Tips: You are creating new receipt for " + cbTableFood.Text;
                }
            }
            else
            {
                ProcessChildForm(new frmOrder(cbTableFood.Text, false, true));
                lbTips.Text = "Tips: You are creating new receipt for " + cbTableFood.Text;
            }
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dr;
            dr = MessageBox.Show("Are you sure want to quit\nEverything has been saved", "Coffe Management",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if (dr == DialogResult.Cancel) e.Cancel = true;
        }

        private void btnCheckout_Click(object sender, EventArgs e)
        {
            ProcessChildForm(new frmCheckout());
        }
    }
}
