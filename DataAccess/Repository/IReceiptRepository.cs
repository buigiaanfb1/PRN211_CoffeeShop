using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BusinessObject.Object;

namespace DataAccess.Repository
{
    public interface IReceiptRepository
    {
        void AddNewOrderIntoReceipt(ReceiptObject receipt, int idbill);
        List<ReceiptObject> GetReceipts(int idbill);
        void UpdateCurrentReceipt(ReceiptObject receipt, int idbill);
        void RemoveCurrentReceipt(ReceiptObject receipt, int idbill);
    }
}
