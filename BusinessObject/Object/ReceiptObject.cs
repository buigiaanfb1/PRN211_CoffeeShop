using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessObject.Object
{
    public class ReceiptObject
    {
        public string foodname { get; set; }
        public int quantity { get; set; }
        public decimal Price { get; set; }
        public decimal totalMoney { get; set; }
        public int foodid { get; set; }

        public ReceiptObject(string foodname, int quantity, decimal price, decimal totalMoney, int foodid)
        {
            this.foodname = foodname;
            this.quantity = quantity;
            Price = price;
            this.totalMoney = totalMoney;
            this.foodid = foodid;
        }
    }
}
