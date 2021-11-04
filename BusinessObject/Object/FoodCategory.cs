using System;
using System.Collections.Generic;

#nullable disable

namespace BusinessObject.Object
{
    public partial class FoodCategory
    {
        public FoodCategory()
        {
            Foods = new HashSet<Food>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Food> Foods { get; set; }
    }
}
