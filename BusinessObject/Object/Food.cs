using System;
using System.Collections.Generic;

#nullable disable

namespace BusinessObject.Object
{
    public partial class Food
    {
        public Food()
        {
            BillInfos = new HashSet<BillInfo>();
        }

        public Food(string name, int idCategory, decimal price)
        {
            Name = name;
            IdCategory = idCategory;
            Price = price;
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public int IdCategory { get; set; }
        public decimal Price { get; set; }

        public virtual FoodCategory IdCategoryNavigation { get; set; }
        public virtual ICollection<BillInfo> BillInfos { get; set; }
    }
}
