using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BusinessObject.Object;

namespace DataAccess.Repository
{
    public class BillInfoRepository : IBillInfoRepository
    {
        public List<BillInfo> GetListBillInfo() => BillInfoDAO.Instance.GetListBillInfo();
        public List<ReceiptObject> GetReceiptForStaff(int idbill) => BillInfoDAO.Instance.GetReceiptForStaff(idbill);
        public bool IsReceiptEmpty(int idbill) => BillInfoDAO.Instance.IsReceiptEmpty(idbill);
    }
}
