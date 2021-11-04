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
    public partial class frmOrderInput : Form
    {
        public frmOrderInput(int billindex, bool createorupdate)
        {
            InitializeComponent();
            idbill = billindex;
            action = createorupdate;
        }

        private int idbill;
        private bool action; //true mean create false mean update
        public Food chosenfood;
        private IFoodRepository foodRepo = new FoodRepository();
        private IReceiptRepository receiptRepo = new ReceiptRepository();
        private List<Food> foods;

        private void frmOrderInput_Load(object sender, EventArgs e)
        {
            foods = foodRepo.GetFoods();
            foreach(Food food in foods)
            {
                cbFoods.Items.Add(food.Name);
            }
            if(!action) //update
            {
                cbFoods.SelectedItem = chosenfood.Name;
                cbFoods.Enabled = false;
                txtVolume.Value = 1;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e) => Close();

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Number: " + idbill);
            if(cbFoods.Text == "")
            {
                MessageBox.Show("Please Select Food");
                this.DialogResult = DialogResult.None;
                return;
            }
            try
            {
                if(action) //create
                {
                    
                    Food food = foods.SingleOrDefault(f => f.Name == cbFoods.Text);
                    int quantity = Convert.ToInt32(Math.Round(txtVolume.Value, 0));
                    if (quantity <= 0)
                    {
                        MessageBox.Show("Please input above 0");
                        this.DialogResult = DialogResult.None;
                        return;
                    }
                    receiptRepo.AddNewOrderIntoReceipt(new ReceiptObject(food.Name, quantity,
                        food.Price, quantity * food.Price, food.Id), idbill);
                }
                else // update
                {
                    Food food = foods.SingleOrDefault(f => f.Name == cbFoods.Text);
                    int quantity = Convert.ToInt32(Math.Round(txtVolume.Value, 0));
                    if (quantity <= 0)
                    {
                        MessageBox.Show("Please input above 0");
                        this.DialogResult = DialogResult.None;
                        return;
                    }
                    receiptRepo.UpdateCurrentReceipt(new ReceiptObject(food.Name, quantity,
                        food.Price, quantity * food.Price, food.Id), idbill);
                }
                //MessageBox.Show("Number: " + cbFoods.SelectedIndex);
                
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error create Order");
                this.DialogResult = DialogResult.None;
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtVolume.Value = 1;
        }
    }
}
