using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BusinessObject.Object;

namespace DataAccess.Repository
{
    public class TableRepository : ITableRepository
    {
        public List<TableFood> GetTables() => TableDAO.Instance.GetTables();
        public List<TableFood> GetAvailableTables() => TableDAO.Instance.GetAvailableTables();
    }
}
