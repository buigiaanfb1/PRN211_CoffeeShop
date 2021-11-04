using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BusinessObject.Object;

namespace DataAccess.Repository
{
    public interface IAccountRepository
    {
        bool Login(string userName, string passWord);
        void UpdateAccount(Account olduser);
        Account GetAccountByUserName(string userName);
    }
}
