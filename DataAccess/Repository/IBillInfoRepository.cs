using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BusinessObject.Object;

namespace DataAccess.Repository
{
    public interface IBillInfoRepository
    {
        List<BillInfo> GetListBillInfo();
        List<ReceiptObject> GetReceiptForStaff(int idbill);
        bool IsReceiptEmpty(int idbill);
    }
}
