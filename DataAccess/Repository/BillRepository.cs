using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BusinessObject.Object;

namespace DataAccess.Repository
{
    public class BillRepository : IBillRepository
    {
        public List<Bill> GetBills() => BillDAO.Instance.GetBills();
        public bool CreateNewReceipt(int idtable) => BillDAO.Instance.CreateNewReceipt(idtable);
        public bool CheckNoBill(int tableID) => BillDAO.Instance.CheckNoBill(tableID);
        public int GetLatestBill(int tableID) => BillDAO.Instance.GetLatestBill(tableID);
        public void SetSuspendedBill(int idbill) => BillDAO.Instance.SetSuspendedBill(idbill);
        public bool CheckBillStatus(int tableindex) => BillDAO.Instance.CheckBillStatus(tableindex);
        public int GetCountingBill(int tableID) => BillDAO.Instance.GetCountingBill(tableID);
        public void ConfirmCheckout(int idbill, int discount, decimal total) =>
            BillDAO.Instance.ConfirmCheckout(idbill, discount, total);
    }
}
