using System;
using System.Collections.Generic;

#nullable disable

namespace BusinessObject.Object
{
    public partial class TableFood
    {
        public TableFood()
        {
            Bills = new HashSet<Bill>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Status { get; set; }

        public virtual ICollection<Bill> Bills { get; set; }
    }
}
