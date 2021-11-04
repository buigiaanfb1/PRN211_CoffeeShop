using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using BusinessObject.Object;

namespace DataAccess
{
    public class TableDAO
    {
        private static TableDAO instance;

        public static TableDAO Instance
        {
            get { if (instance == null) instance = new TableDAO(); return TableDAO.instance; }
            private set { TableDAO.instance = value; }
        }

        public static int TableWidth = 90;
        public static int TableHeight = 90;

        private TableDAO() { }

        public void SwitchTable(int id1, int id2)
        {
            
        }

        public List<TableFood> GetTables()
        {
            try
            {
                using var context = new QuanLyQuanCafeContext();
                List<TableFood> tables = context.TableFoods.ToList();
                return tables;
            }
            catch (Exception eX)
            {
                throw new Exception(eX.Message);
            }
        }

        public List<TableFood> GetAvailableTables()
        {
            try
            {
                using var context = new QuanLyQuanCafeContext();
                var QueryList = from table in context.TableFoods
                                where table.Status == "Available"
                                select table;
                List<TableFood> tables = QueryList.ToList();
                return tables;
            }
            catch (Exception eX)
            {
                throw new Exception(eX.Message);
            }
        }
    }
}
