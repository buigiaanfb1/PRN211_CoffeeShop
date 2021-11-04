using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessObject.Object;

namespace DataAccess
{
    //STATUS ID 1 mean Counting
    //STATUS ID 2 SUSPEND
    //STATUS ID 3 COMPLETED
    public class BillDAO
    {
        private static BillDAO instance;

        public static BillDAO Instance
        {
            get { if (instance == null) instance = new BillDAO(); return BillDAO.instance; }
            private set { BillDAO.instance = value; }
        }

        private BillDAO() { }

        //secure no data
        public bool CheckNoBill(int tableID)
        {
            try
            {
                using var context = new QuanLyQuanCafeContext();
                //datecheckin, int idtable, int status, int discount, decimal totalprice
                Bill bill = context.Bills.OrderByDescending(b => b.Id)
                    .FirstOrDefault(b => b.IdTable == tableID);
                if (bill == null) return true;
                else return false;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public bool CheckBillStatus(int tableindex)
        {
            try
            {
                using var context = new QuanLyQuanCafeContext();
                //datecheckin, int idtable, int status, int discount, decimal totalprice
                var QueryCheck = from bill in context.Bills
                                 where bill.IdTable == tableindex && bill.Status == 1
                                 select bill;
                if (QueryCheck.Any()) return true;
                else return false;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public int GetLatestBill(int tableID)
        {
            try
            {
                using var context = new QuanLyQuanCafeContext();
                //datecheckin, int idtable, int status, int discount, decimal totalprice
                Bill bill = context.Bills.Where(b => b.IdTable == tableID).OrderByDescending(a => a.Id)
                    .FirstOrDefault();
                if (bill != null) return bill.Id;
                else return -1;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public bool CreateNewReceipt(int idtable) //checkin
        {
            try
            {
                using var context = new QuanLyQuanCafeContext();
                //datecheckin, int idtable, int status, int discount, decimal totalprice
                Bill receipt = new Bill(DateTime.Now, idtable, 1, 0, 0);
                context.Bills.Add(receipt);
                context.SaveChanges();
                return true;
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void SetSuspendedBill(int idbill)
        {
            try
            {
                using var context = new QuanLyQuanCafeContext();
                //datecheckin, int idtable, int status, int discount, decimal totalprice
                Bill receipt = context.Bills.SingleOrDefault(b => b.Id == idbill);
                receipt.Status = 2;
                context.Bills.Update(receipt);
                context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

    }
}
