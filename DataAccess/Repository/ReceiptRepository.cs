using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BusinessObject.Object;

namespace DataAccess.Repository
{
    public class ReceiptRepository : IReceiptRepository
    {
        public void AddNewOrderIntoReceipt(ReceiptObject receipt, int idbill) => ReceiptDAO.Instance.AddNewOrderIntoReceipt(receipt, idbill);
        public List<ReceiptObject> GetReceipts(int idbill) => ReceiptDAO.Instance.GetReceipts(idbill);
        public void UpdateCurrentReceipt(ReceiptObject receipt, int idbill) => ReceiptDAO.Instance.UpdateCurrentReceipt(receipt, idbill);
        public void RemoveCurrentReceipt(ReceiptObject receipt, int idbill) => ReceiptDAO.Instance.RemoveCurrentReceipt(receipt, idbill);
    }
}
