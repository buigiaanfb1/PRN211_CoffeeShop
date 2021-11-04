using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using BusinessObject.Object;

namespace DataAccess
{
    public class BillInfoDAO
    {
        private static BillInfoDAO instance;

        public static BillInfoDAO Instance
        {
            get { if (instance == null) instance = new BillInfoDAO(); return BillInfoDAO.instance; }
            private set { BillInfoDAO.instance = value; }
        }

        private BillInfoDAO() { }

        public List<BillInfo> GetListBillInfo()
        {
            try
            {
                using var context = new QuanLyQuanCafeContext();
                List<BillInfo> bill = context.BillInfos.ToList();
                return bill;
            }
            catch (Exception eX)
            {
                throw new Exception(eX.Message);
            }
        }
        public List<ReceiptObject> GetReceiptForStaff(int idbill)
        {
            try
            {
                using var context = new QuanLyQuanCafeContext();
                var QueryList = from billy in context.BillInfos
                                where billy.IdBill == idbill
                                select billy;
                List<BillInfo> dbbill = context.BillInfos.Where(b => b.IdBill == idbill).ToList();
                List<Food> dbfood = context.Foods.ToList();
                List<ReceiptObject> receipts = new List<ReceiptObject>();
                foreach(BillInfo bill in dbbill)
                {
                    Food AmSoNoob = dbfood.SingleOrDefault(f => f.Id == bill.IdFood);
                    string name = AmSoNoob.Name;
                    int quantity = bill.Count;
                    decimal price = AmSoNoob.Price;
                    decimal totalPrice = price * quantity;
                    receipts.Add(new ReceiptObject(name, quantity, price, totalPrice, bill.IdFood));
                }
                return receipts;
            }
            catch (Exception eX)
            {
                throw new Exception(eX.Message);
            }
        }
    }
}
