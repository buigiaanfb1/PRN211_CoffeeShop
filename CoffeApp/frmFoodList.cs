using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessObject.Object;
using DataAccess.Repository;

namespace CoffeApp
{
    public partial class frmFoodList : Form
    {
        public frmFoodList()
        {
            InitializeComponent();
            dao = new FoodRepository();
        }

        private IFoodRepository dao;
        private ICategoryRepository catedao = new CategoryRepository();

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dr;
                dr = MessageBox.Show("Do you really want to delete seleted food?", "Coffe Management",
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
                if (dr == DialogResult.OK)
                {
                    foreach (DataGridViewRow row in FoodTable.SelectedRows)
                    {
                        string fname = row.Cells[0].Value.ToString();
                        if (string.IsNullOrWhiteSpace(fname)) continue;
                        dao.DeleteFood(fname);
                    }
                    LoadFoodList();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "FoodList Warning");
            }
        }

        private void frmFoodList_Load(object sender, EventArgs e)
        {
            LoadFoodList();
        }

        private DataTable tableFormatter(List<Food> foodlist)
        {
            DataTable table = new DataTable();
            //MemberID, MemberName, Email, Password, City, Country
            //table.Columns.Add("Food Count");
            List<FoodCategory> catelist = catedao.GetCategories();
            table.Columns.Add("Food name");
            table.Columns.Add("Food Type");
            table.Columns.Add("Price");
            foreach (Food food in foodlist)
            {
                string categoryname = catelist.SingleOrDefault(f => f.Id == food.IdCategory).Name;
                table.Rows.Add(new object[] {food.Name, categoryname, food.Price});
            }
            return table;
        }

        private void LoadFoodList()
        {
            List<Food> list = dao.GetFoods();
            DataTable data = tableFormatter(list);
            FoodTable.DataSource = data;
        }
    }
}
