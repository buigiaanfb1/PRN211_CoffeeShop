using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using BusinessObject.Object;

namespace DataAccess
{
    public class ReceiptDAO
    {
        private static ReceiptDAO instance;

        public static ReceiptDAO Instance
        {
            get { if (instance == null) instance = new ReceiptDAO(); return ReceiptDAO.instance; }
            private set { ReceiptDAO.instance = value; }
        }

        private ReceiptDAO() { }

        public List<ReceiptObject> GetReceipts(int idbill)
        {
            try
            {
                //int idBill, int idFood, int count
                using var context = new QuanLyQuanCafeContext();
                List<BillInfo> oldbill = context.BillInfos.Where(b => b.IdBill == idbill).ToList();
                List<Food> dbfood = context.Foods.ToList();
                List<ReceiptObject> receipts = new List<ReceiptObject>();
                foreach(BillInfo bill in oldbill)
                {
                    Food food = dbfood.SingleOrDefault(f => f.Id == bill.IdFood);
                    //string foodname, int quantity, decimal price, decimal totalMoney, int foodid
                    string name = food.Name;
                    int count = bill.Count;
                    decimal price = food.Price;
                    decimal total = price * count;
                    int foodid = food.Id;
                    receipts.Add(new ReceiptObject(name, count, price, total, foodid));
                }
                return receipts;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void AddNewOrderIntoReceipt(ReceiptObject receipt, int idbill)
        {
            try
            {
                //int idBill, int idFood, int count
                using var context = new QuanLyQuanCafeContext();
                var QueryCheck = from bill in context.BillInfos
                                 where bill.IdBill == idbill && bill.IdFood == receipt.foodid
                                 select bill;
                if(!QueryCheck.Any())
                {
                    BillInfo transfer = new BillInfo(idbill, receipt.foodid, receipt.quantity);
                    context.BillInfos.Add(transfer);
                    context.SaveChanges();
                }
                else
                {
                    throw new Exception("You already added this food please choose another");
                }
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public void UpdateCurrentReceipt(ReceiptObject receipt, int idbill)
        {
            try
            {
                //int idBill, int idFood, int count
                using var context = new QuanLyQuanCafeContext();
                var navigator = from bill in context.BillInfos
                                where bill.IdBill == idbill && bill.IdFood == receipt.foodid
                                select bill.Id;
                BillInfo transfer = new BillInfo(idbill, receipt.foodid, receipt.quantity);
                transfer.Id = navigator.FirstOrDefault();
                context.BillInfos.Update(transfer);
                context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void RemoveCurrentReceipt(ReceiptObject receipt, int idbill)
        {
            try
            {
                //int idBill, int idFood, int count
                using var context = new QuanLyQuanCafeContext();
                var navigator = from bill in context.BillInfos
                                where bill.IdBill == idbill && bill.IdFood == receipt.foodid
                                select bill.Id;
                BillInfo transfer = new BillInfo(idbill, receipt.foodid, receipt.quantity);
                transfer.Id = navigator.FirstOrDefault();
                context.BillInfos.Remove(transfer);
                context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
