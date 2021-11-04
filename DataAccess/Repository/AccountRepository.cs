using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BusinessObject.Object;

namespace DataAccess.Repository
{
    public class AccountRepository : IAccountRepository
    {
        public bool Login(string userName, string passWord) => AccountDAO.Instance.Login(userName, passWord);
        public void UpdateAccount(Account olduser) => AccountDAO.Instance.UpdateAccount(olduser);
        public Account GetAccountByUserName(string userName) => AccountDAO.Instance.GetAccountByUserName(userName);
    }
}
