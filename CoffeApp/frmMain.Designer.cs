
namespace CoffeApp
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.panelSideMenu = new System.Windows.Forms.Panel();
            this.FoodPanelSub = new System.Windows.Forms.Panel();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnViewFood = new System.Windows.Forms.Button();
            this.btnCreate = new System.Windows.Forms.Button();
            this.btnFoodManagement = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnCheckout = new System.Windows.Forms.Button();
            this.btnOrder = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.StatusPanel = new System.Windows.Forms.Panel();
            this.lbTips = new System.Windows.Forms.Label();
            this.btnNewOrder = new System.Windows.Forms.Button();
            this.lbTableIndex = new System.Windows.Forms.Label();
            this.cbTableFood = new System.Windows.Forms.ComboBox();
            this.lbDisplayStaffName = new System.Windows.Forms.Label();
            this.ChildrenFormPanel = new System.Windows.Forms.Panel();
            this.panelSideMenu.SuspendLayout();
            this.FoodPanelSub.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.StatusPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelSideMenu
            // 
            this.panelSideMenu.Controls.Add(this.FoodPanelSub);
            this.panelSideMenu.Controls.Add(this.btnFoodManagement);
            this.panelSideMenu.Controls.Add(this.btnLogout);
            this.panelSideMenu.Controls.Add(this.btnCheckout);
            this.panelSideMenu.Controls.Add(this.btnOrder);
            this.panelSideMenu.Controls.Add(this.panel1);
            this.panelSideMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSideMenu.Location = new System.Drawing.Point(0, 0);
            this.panelSideMenu.Name = "panelSideMenu";
            this.panelSideMenu.Size = new System.Drawing.Size(262, 590);
            this.panelSideMenu.TabIndex = 0;
            // 
            // FoodPanelSub
            // 
            this.FoodPanelSub.Controls.Add(this.btnUpdate);
            this.FoodPanelSub.Controls.Add(this.btnViewFood);
            this.FoodPanelSub.Controls.Add(this.btnCreate);
            this.FoodPanelSub.Dock = System.Windows.Forms.DockStyle.Top;
            this.FoodPanelSub.Location = new System.Drawing.Point(0, 260);
            this.FoodPanelSub.Name = "FoodPanelSub";
            this.FoodPanelSub.Size = new System.Drawing.Size(262, 124);
            this.FoodPanelSub.TabIndex = 5;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnUpdate.Location = new System.Drawing.Point(0, 80);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(262, 40);
            this.btnUpdate.TabIndex = 2;
            this.btnUpdate.Text = "Update Current Food";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnViewFood
            // 
            this.btnViewFood.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnViewFood.Location = new System.Drawing.Point(0, 40);
            this.btnViewFood.Name = "btnViewFood";
            this.btnViewFood.Size = new System.Drawing.Size(262, 40);
            this.btnViewFood.TabIndex = 1;
            this.btnViewFood.Text = "Food List";
            this.btnViewFood.UseVisualStyleBackColor = true;
            this.btnViewFood.Click += new System.EventHandler(this.btnViewFood_Click);
            // 
            // btnCreate
            // 
            this.btnCreate.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCreate.Location = new System.Drawing.Point(0, 0);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(262, 40);
            this.btnCreate.TabIndex = 0;
            this.btnCreate.Text = "Add New Food";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // btnFoodManagement
            // 
            this.btnFoodManagement.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnFoodManagement.Location = new System.Drawing.Point(0, 215);
            this.btnFoodManagement.Name = "btnFoodManagement";
            this.btnFoodManagement.Size = new System.Drawing.Size(262, 45);
            this.btnFoodManagement.TabIndex = 4;
            this.btnFoodManagement.Text = "Food Management";
            this.btnFoodManagement.UseVisualStyleBackColor = true;
            this.btnFoodManagement.Click += new System.EventHandler(this.btnFoodManagement_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnLogout.Location = new System.Drawing.Point(0, 545);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(262, 45);
            this.btnLogout.TabIndex = 3;
            this.btnLogout.Text = "Log out";
            this.btnLogout.UseVisualStyleBackColor = true;
            // 
            // btnCheckout
            // 
            this.btnCheckout.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCheckout.Location = new System.Drawing.Point(0, 170);
            this.btnCheckout.Name = "btnCheckout";
            this.btnCheckout.Size = new System.Drawing.Size(262, 45);
            this.btnCheckout.TabIndex = 2;
            this.btnCheckout.Text = "Check out";
            this.btnCheckout.UseVisualStyleBackColor = true;
            // 
            // btnOrder
            // 
            this.btnOrder.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnOrder.Location = new System.Drawing.Point(0, 125);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.Size = new System.Drawing.Size(262, 45);
            this.btnOrder.TabIndex = 1;
            this.btnOrder.Text = "Order Page";
            this.btnOrder.UseVisualStyleBackColor = true;
            this.btnOrder.Click += new System.EventHandler(this.btnOrder_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(262, 125);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(262, 119);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // StatusPanel
            // 
            this.StatusPanel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.StatusPanel.Controls.Add(this.lbTips);
            this.StatusPanel.Controls.Add(this.btnNewOrder);
            this.StatusPanel.Controls.Add(this.lbTableIndex);
            this.StatusPanel.Controls.Add(this.cbTableFood);
            this.StatusPanel.Controls.Add(this.lbDisplayStaffName);
            this.StatusPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.StatusPanel.Location = new System.Drawing.Point(262, 500);
            this.StatusPanel.Name = "StatusPanel";
            this.StatusPanel.Size = new System.Drawing.Size(836, 90);
            this.StatusPanel.TabIndex = 6;
            // 
            // lbTips
            // 
            this.lbTips.AutoSize = true;
            this.lbTips.Location = new System.Drawing.Point(64, 57);
            this.lbTips.Name = "lbTips";
            this.lbTips.Size = new System.Drawing.Size(509, 20);
            this.lbTips.TabIndex = 0;
            this.lbTips.Text = "Tips: You are viewing the old Receipt. Press New Receipts to start a new one";
            // 
            // btnNewOrder
            // 
            this.btnNewOrder.Location = new System.Drawing.Point(660, 43);
            this.btnNewOrder.Name = "btnNewOrder";
            this.btnNewOrder.Size = new System.Drawing.Size(164, 44);
            this.btnNewOrder.TabIndex = 3;
            this.btnNewOrder.Text = "New Receipts";
            this.btnNewOrder.UseVisualStyleBackColor = true;
            this.btnNewOrder.Click += new System.EventHandler(this.btnNewOrder_Click);
            // 
            // lbTableIndex
            // 
            this.lbTableIndex.AutoSize = true;
            this.lbTableIndex.Location = new System.Drawing.Point(364, 12);
            this.lbTableIndex.Name = "lbTableIndex";
            this.lbTableIndex.Size = new System.Drawing.Size(50, 20);
            this.lbTableIndex.TabIndex = 7;
            this.lbTableIndex.Text = "label1";
            // 
            // cbTableFood
            // 
            this.cbTableFood.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTableFood.FormattingEnabled = true;
            this.cbTableFood.Location = new System.Drawing.Point(660, 9);
            this.cbTableFood.Name = "cbTableFood";
            this.cbTableFood.Size = new System.Drawing.Size(164, 28);
            this.cbTableFood.TabIndex = 0;
            this.cbTableFood.SelectedIndexChanged += new System.EventHandler(this.cbTableFood_SelectedIndexChanged);
            // 
            // lbDisplayStaffName
            // 
            this.lbDisplayStaffName.AutoSize = true;
            this.lbDisplayStaffName.Location = new System.Drawing.Point(24, 12);
            this.lbDisplayStaffName.Name = "lbDisplayStaffName";
            this.lbDisplayStaffName.Size = new System.Drawing.Size(84, 20);
            this.lbDisplayStaffName.TabIndex = 6;
            this.lbDisplayStaffName.Text = "Hello, Nam";
            // 
            // ChildrenFormPanel
            // 
            this.ChildrenFormPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ChildrenFormPanel.Location = new System.Drawing.Point(262, 0);
            this.ChildrenFormPanel.Name = "ChildrenFormPanel";
            this.ChildrenFormPanel.Size = new System.Drawing.Size(836, 500);
            this.ChildrenFormPanel.TabIndex = 7;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1098, 590);
            this.Controls.Add(this.ChildrenFormPanel);
            this.Controls.Add(this.StatusPanel);
            this.Controls.Add(this.panelSideMenu);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Coffe Shop";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.panelSideMenu.ResumeLayout(false);
            this.FoodPanelSub.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.StatusPanel.ResumeLayout(false);
            this.StatusPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelSideMenu;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnCheckout;
        private System.Windows.Forms.Button btnOrder;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel FoodPanelSub;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnViewFood;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Button btnFoodManagement;
        private System.Windows.Forms.Panel StatusPanel;
        private System.Windows.Forms.Panel ChildrenFormPanel;
        private System.Windows.Forms.Label lbDisplayStaffName;
        private System.Windows.Forms.ComboBox cbTableFood;
        private System.Windows.Forms.Label lbTips;
        private System.Windows.Forms.Button btnNewOrder;
        private System.Windows.Forms.Label lbTableIndex;
    }
}