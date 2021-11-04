using System;
using System.Collections.Generic;

#nullable disable

namespace BusinessObject.Object
{
    public partial class Bill
    {
        public Bill()
        {
            BillInfos = new HashSet<BillInfo>();
        }

        public Bill(DateTime dateCheckIn, int idTable, int status, int? discount, decimal? totalPrice)
        {
            DateCheckIn = dateCheckIn;
            IdTable = idTable;
            Status = status;
            Discount = discount;
            TotalPrice = totalPrice;
        }
        //datecheckin, int idtable, int status, int discount, decimal totalprice

        public int Id { get; set; }
        public DateTime DateCheckIn { get; set; }
        public DateTime? DateCheckOut { get; set; }
        public int IdTable { get; set; }
        public int Status { get; set; }
        public int? Discount { get; set; }
        public decimal? TotalPrice { get; set; }

        public virtual TableFood IdTableNavigation { get; set; }
        public virtual ICollection<BillInfo> BillInfos { get; set; }
    }
}
