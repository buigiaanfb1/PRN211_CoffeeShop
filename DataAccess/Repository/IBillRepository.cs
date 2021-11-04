using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BusinessObject.Object;

namespace DataAccess.Repository
{
    public interface IBillRepository
    {
        bool CreateNewReceipt(int idtable);
        bool CheckNoBill(int tableID);
        int GetLatestBill(int tableID);
        void SetSuspendedBill(int idbill);
        bool CheckBillStatus(int tableindex);
    }
}
