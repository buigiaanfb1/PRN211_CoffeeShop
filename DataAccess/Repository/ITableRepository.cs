using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BusinessObject.Object;

namespace DataAccess.Repository
{
    public interface ITableRepository
    {
        List<TableFood> GetTables();
        List<TableFood> GetAvailableTables();
    }
}
