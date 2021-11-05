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
        public frmMain(Account login)
        {
            InitializeComponent();
            tableRepo = new TableRepository(); //stupid way (lack of memory)
            //this is not singleton this is NamTon
            staff = login;
        }

        private ITableRepository tableRepo;
        private IBillRepository billRepo = new BillRepository();
        private IBillInfoRepository billinfoRepo = new BillInfoRepository();
        private IAccountRepository dao = new AccountRepository();
        private Account staff;

        private void frmMain_Load(object sender, EventArgs e)
        {
            txtChangeName.Hide();
            btnSubmitName.Hide();
            lbDisplayStaffName.Text = "Hello, " + staff.DisplayName;
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
            int tableindex = cbTableFood.SelectedIndex + 1;
            if(billRepo.CheckNoBill(tableindex))
            {
                ProcessChildForm(new frmOrder(cbTableFood.Text, true, true));
                lbTips.Text = "Tips: You are creating new receipt for " + cbTableFood.Text;
            }
            else
            {
                if(!billRepo.CheckBillStatus(tableindex))
                {
                    ProcessChildForm(new frmOrder(cbTableFood.Text, true, true));
                    lbTips.Text = "Tips: You are creating new receipt for " + cbTableFood.Text;
                }
                else
                {
                    if(billinfoRepo.IsReceiptEmpty(billRepo.GetCountingBill(tableindex)))
                    {
                        MessageBox.Show("Current Receipt for table " + tableindex + " is empty\n" +
                            "Press Order Page and start it now");
                        return;
                    }
                    DialogResult dr;
                    dr = MessageBox.Show("Are you sure want to Create a new receipt for" + cbTableFood.Text
                        + ".\nOld Receipt is not yet CheckOut And will be suspended.", "Coffe Management",
                        MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
                    if (dr == DialogResult.OK)
                    {
                        billRepo.SetSuspendedBill(billRepo.GetCountingBill(tableindex));
                        ProcessChildForm(new frmOrder(cbTableFood.Text, true, true));
                        lbTips.Text = "Tips: You are creating new receipt for " + cbTableFood.Text;
                    }
                }
            }
            /*
            int billindex = billRepo.GetCountingBill(cbTableFood.SelectedIndex + 1);
            if (billRepo.CheckBillStatus(int.Parse(cbTableFood.Text.Substring(cbTableFood.Text.Length - 1))))
            {
                
            }
            else
            {
                ProcessChildForm(new frmOrder(cbTableFood.Text, false, true));
                lbTips.Text = "Tips: You are creating new receipt for " + cbTableFood.Text;
            }
            */
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(!IsItLogout)
            {
                DialogResult dr;
                dr = MessageBox.Show("Are you sure want to quit\nEverything has been saved", "Coffe Management",
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
                if (dr == DialogResult.Cancel) e.Cancel = true;
            }
        }

        private void btnCheckout_Click(object sender, EventArgs e)
        {
            ProcessChildForm(new frmCheckout());
        }

        private void btnHistory_Click(object sender, EventArgs e)
        {
            ProcessChildForm(new frmHistoryOrder());
        }

        private bool IsItLogout = false;
        private void btnLogout_Click(object sender, EventArgs e)
        {
            IsItLogout = true;
            frmLogin back = new frmLogin();
            Hide();
            back.ShowDialog();
            Close();
        }

        bool IsItPressed = false;
        private void btnChangeName_Click(object sender, EventArgs e)
        {
            if(!IsItPressed)
            {
                IsItPressed = true;
                txtChangeName.Show();
                btnSubmitName.Show();
            }
            else
            {
                IsItPressed = false;
                txtChangeName.Hide();
                btnSubmitName.Hide();
            }
            
        }

        private void btnSubmitName_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtChangeName.Text)) 
                    MessageBox.Show("Please Input something");
                else
                {
                    staff.DisplayName = txtChangeName.Text;
                    dao.UpdateAccount(staff);
                    lbDisplayStaffName.Text = "Hello, " + staff.DisplayName;
                }
            }
            catch
            {
                MessageBox.Show("Cannot change display name at the moment. Please Try again later", "Sad Coffe");
            }
            finally
            {
                txtChangeName.Hide();
                btnSubmitName.Hide();
            }
        }
    }
}
