using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using BusinessObject.Object;

namespace DataAccess
{
    public class AccountDAO
    {
        private static AccountDAO instance;

        public static AccountDAO Instance
        {
            get { if (instance == null) instance = new AccountDAO(); return instance; }
            private set { instance = value; }
        }

        private AccountDAO() { }

        public bool Login(string userName, string passWord)
        {
            try
            {
                using var context = new QuanLyQuanCafeContext();
                Account checker = context.Accounts.SingleOrDefault(acc => acc.UserName == userName && acc.PassWord == passWord);
                if (checker != null) return true;
                else return false;
}
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void UpdateAccount(Account olduser)
        {
            try
            {
                using var context = new QuanLyQuanCafeContext();
                context.Accounts.Update(olduser);
                context.SaveChanges();
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public Account GetAccountByUserName(string userName)
        {
            try
            {
                using var context = new QuanLyQuanCafeContext();
                Account acc = context.Accounts.SingleOrDefault(a => a.UserName == userName);
                return acc;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
