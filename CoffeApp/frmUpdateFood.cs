using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataAccess.Repository;
using BusinessObject.Object;

namespace CoffeApp
{
    public partial class frmUpdateFood : Form
    {
        public frmUpdateFood()
        {
            InitializeComponent();
            cateRepo = new CategoryRepository();
            foodRepo = new FoodRepository();
        }

        ICategoryRepository cateRepo;
        IFoodRepository foodRepo;
        List<FoodCategory> foodType;

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtPrice.Value <= 0)
                {
                    MessageBox.Show("Price must be higher than 0", "Update Information");
                    return;
                }
                if(string.IsNullOrWhiteSpace(txtFoodName.Text))
                {
                    MessageBox.Show("Food name must be something not some empty input\nFood is not the air", "Update Information");
                    return;
                }
                foodRepo.UpdateFood(new Food(txtFoodName.Text, cbFoodType.SelectedIndex, txtPrice.Value), oldfood);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Update failed");
            }
        }

        private void frmUpdateFood_Load(object sender, EventArgs e)
        {
            foodType = cateRepo.GetCategories();
            foreach (FoodCategory type in foodType)
            {
                cbFoodType.Items.Add(type.Name);
            }
            LoadFoodList();
        }

        private DataTable tableFormatter(List<Food> foodlist)
        {
            DataTable table = new DataTable();
            //MemberID, MemberName, Email, Password, City, Country
            table.Columns.Add("Food Count");
            table.Columns.Add("Food name");
            table.Columns.Add("Food Type");
            table.Columns.Add("Price");
            foreach (Food food in foodlist)
            {
                string categoryname = foodType.SingleOrDefault(f => f.Id == food.IdCategory).Name;
                table.Rows.Add(new object[] { food.Id, food.Name, categoryname, food.Price });
            }
            return table;
        }

        private void LoadFoodList()
        {
            List<Food> list = foodRepo.GetFoods();
            DataTable data = tableFormatter(list);
            updateFoodTable.DataSource = data;
        }

        private string oldfood;
        private void updateFoodTable_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                oldfood = updateFoodTable.Rows[e.RowIndex].Cells[1].Value.ToString();
                //MessageBox.Show("Number is " + FoodID);
                if (string.IsNullOrWhiteSpace(oldfood)) return; //bấm cc gì dậy
                Food selectedfood = foodRepo.GetFoodByName(oldfood);
                txtFoodName.Text = selectedfood.Name;
                txtPrice.Value = selectedfood.Price;
                cbFoodType.SelectedIndex = selectedfood.IdCategory;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Load click food");
            }
            //int FoodID = int.Parse(updateFoodTable.Rows[e.RowIndex].Cells[0].Value.ToString());
            //MessageBox.Show("Number is " + FoodID);
            //Food selectedfood = foodRepo.GetFoodByID(FoodID);
            //txtFoodName.Text = selectedfood.Name;
            //txtPrice.Value = selectedfood.Price;
        }

    }
}
