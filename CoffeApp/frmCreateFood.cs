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
    public partial class frmCreateFood : Form
    {
        public frmCreateFood()
        {
            InitializeComponent();
        }

        private ICategoryRepository cateRepo = new CategoryRepository();
        private IFoodRepository foodRepo = new FoodRepository();
        private List<FoodCategory> foodType;

        private void btnCreate_Click(object sender, EventArgs e)
        {
            int checker = Validation();
            if(checker != -1)
            {
                MessageBox.Show("Input is empty or containing white space", "Create Food Information");
                if (checker == 0) txtFoodName.Select();
                else cbCategory.Select();
                return;
            }
            try
            {
                Food newfood = new Food(txtFoodName.Text, cbCategory.SelectedIndex + 1, txtPrice.Value);
                foodRepo.AddFood(newfood);
                MessageBox.Show("Add food Successfully, Press View food list to view that new food", "Happy adding");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Create Food Error");
            }
        }

        private int Validation()
        {
            string[] everyinput = { txtFoodName.Text, cbCategory.Text };
            int index = 0;
            foreach(string input in everyinput)
            {
                if (string.IsNullOrWhiteSpace(input)) return index;
                index++;
            }
            return -1;
        }

        private void frmCreateFood_Load(object sender, EventArgs e)
        {
            foodType = cateRepo.GetCategories();
            foreach(FoodCategory type in foodType)
            {
                cbCategory.Items.Add(type.Name);
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
