using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using DataAccess.Repository;
using BusinessObject.Object;
using System.Windows.Forms;

namespace CoffeApp
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
            dao = new AccountRepository();
        }

        private IAccountRepository dao;

        private void lbClear_Click(object sender, EventArgs e)
        {
            txtUsername.Clear();
            txtPassword.Clear();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrWhiteSpace(txtUsername.Text) && string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                MessageBox.Show("Please Fill username and password.", "Login Information");
                return;
            }
            if(dao.Login(txtUsername.Text, txtPassword.Text))
            {
                Account guest = dao.GetAccountByUserName(txtUsername.Text);
                frmMain newpage = new frmMain(guest);
                this.Hide();
                newpage.ShowDialog();
                this.Close();
            }
            else MessageBox.Show("Incorrect username or password.", "Login Information");
        }

        private void btnExit_Click(object sender, EventArgs e) => Close();
    }
}
