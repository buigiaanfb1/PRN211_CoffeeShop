using System;
using System.Collections.Generic;

#nullable disable

namespace BusinessObject.Object
{
    public partial class BillInfo
    {
        public BillInfo(int idBill, int idFood, int count)
        {
            IdBill = idBill;
            IdFood = idFood;
            Count = count;
        }

        public int Id { get; set; }
        public int IdBill { get; set; }
        public int IdFood { get; set; }
        public int Count { get; set; }

        public virtual Bill IdBillNavigation { get; set; }
        public virtual Food IdFoodNavigation { get; set; }
    }
}
