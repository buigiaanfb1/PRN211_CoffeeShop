
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
            this.btnHistory = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnCheckout = new System.Windows.Forms.Button();
            this.btnOrder = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.StatusPanel = new System.Windows.Forms.Panel();
            this.btnSubmitName = new System.Windows.Forms.Button();
            this.txtChangeName = new System.Windows.Forms.TextBox();
            this.btnChangeName = new System.Windows.Forms.Button();
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
            this.panelSideMenu.BackColor = System.Drawing.Color.MintCream;
            this.panelSideMenu.Controls.Add(this.FoodPanelSub);
            this.panelSideMenu.Controls.Add(this.btnFoodManagement);
            this.panelSideMenu.Controls.Add(this.btnHistory);
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
            this.FoodPanelSub.BackColor = System.Drawing.Color.WhiteSmoke;
            this.FoodPanelSub.Controls.Add(this.btnUpdate);
            this.FoodPanelSub.Controls.Add(this.btnViewFood);
            this.FoodPanelSub.Controls.Add(this.btnCreate);
            this.FoodPanelSub.Dock = System.Windows.Forms.DockStyle.Top;
            this.FoodPanelSub.Font = new System.Drawing.Font("UD Digi Kyokasho NK-B", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.FoodPanelSub.Location = new System.Drawing.Point(0, 305);
            this.FoodPanelSub.Name = "FoodPanelSub";
            this.FoodPanelSub.Size = new System.Drawing.Size(262, 124);
            this.FoodPanelSub.TabIndex = 5;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnUpdate.FlatAppearance.BorderSize = 0;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Location = new System.Drawing.Point(0, 80);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(262, 40);
            this.btnUpdate.TabIndex = 2;
            this.btnUpdate.Text = "Update Current Menu";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnViewFood
            // 
            this.btnViewFood.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnViewFood.FlatAppearance.BorderSize = 0;
            this.btnViewFood.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewFood.Location = new System.Drawing.Point(0, 40);
            this.btnViewFood.Name = "btnViewFood";
            this.btnViewFood.Size = new System.Drawing.Size(262, 40);
            this.btnViewFood.TabIndex = 1;
            this.btnViewFood.Text = "Menu List";
            this.btnViewFood.UseVisualStyleBackColor = true;
            this.btnViewFood.Click += new System.EventHandler(this.btnViewFood_Click);
            // 
            // btnCreate
            // 
            this.btnCreate.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCreate.FlatAppearance.BorderSize = 0;
            this.btnCreate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreate.Location = new System.Drawing.Point(0, 0);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(262, 40);
            this.btnCreate.TabIndex = 0;
            this.btnCreate.Text = "Add New Drink/Food\r\n";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // btnFoodManagement
            // 
            this.btnFoodManagement.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnFoodManagement.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnFoodManagement.FlatAppearance.BorderSize = 0;
            this.btnFoodManagement.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFoodManagement.Font = new System.Drawing.Font("UD Digi Kyokasho NK-B", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnFoodManagement.Location = new System.Drawing.Point(0, 260);
            this.btnFoodManagement.Name = "btnFoodManagement";
            this.btnFoodManagement.Size = new System.Drawing.Size(262, 45);
            this.btnFoodManagement.TabIndex = 4;
            this.btnFoodManagement.Text = "Menu Management\r\n";
            this.btnFoodManagement.UseVisualStyleBackColor = false;
            this.btnFoodManagement.Click += new System.EventHandler(this.btnFoodManagement_Click);
            // 
            // btnHistory
            // 
            this.btnHistory.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnHistory.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnHistory.FlatAppearance.BorderSize = 0;
            this.btnHistory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHistory.Font = new System.Drawing.Font("UD Digi Kyokasho NK-B", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnHistory.Location = new System.Drawing.Point(0, 215);
            this.btnHistory.Name = "btnHistory";
            this.btnHistory.Size = new System.Drawing.Size(262, 45);
            this.btnHistory.TabIndex = 6;
            this.btnHistory.Text = "View Order History";
            this.btnHistory.UseVisualStyleBackColor = false;
            this.btnHistory.Click += new System.EventHandler(this.btnHistory_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("UD Digi Kyokasho NK-B", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnLogout.Location = new System.Drawing.Point(0, 545);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(262, 45);
            this.btnLogout.TabIndex = 3;
            this.btnLogout.Text = "Log out";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnCheckout
            // 
            this.btnCheckout.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnCheckout.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCheckout.FlatAppearance.BorderSize = 0;
            this.btnCheckout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCheckout.Font = new System.Drawing.Font("UD Digi Kyokasho NK-B", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCheckout.Location = new System.Drawing.Point(0, 170);
            this.btnCheckout.Name = "btnCheckout";
            this.btnCheckout.Size = new System.Drawing.Size(262, 45);
            this.btnCheckout.TabIndex = 2;
            this.btnCheckout.Text = "Check out";
            this.btnCheckout.UseVisualStyleBackColor = false;
            this.btnCheckout.Click += new System.EventHandler(this.btnCheckout_Click);
            // 
            // btnOrder
            // 
            this.btnOrder.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnOrder.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnOrder.FlatAppearance.BorderSize = 0;
            this.btnOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOrder.Font = new System.Drawing.Font("UD Digi Kyokasho NK-B", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnOrder.Location = new System.Drawing.Point(0, 125);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.Size = new System.Drawing.Size(262, 45);
            this.btnOrder.TabIndex = 1;
            this.btnOrder.Text = "Order Page";
            this.btnOrder.UseVisualStyleBackColor = false;
            this.btnOrder.Click += new System.EventHandler(this.btnOrder_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Font = new System.Drawing.Font("UD Digi Kyokasho NK-B", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
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
            this.StatusPanel.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.StatusPanel.Controls.Add(this.btnSubmitName);
            this.StatusPanel.Controls.Add(this.txtChangeName);
            this.StatusPanel.Controls.Add(this.btnChangeName);
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
            // btnSubmitName
            // 
            this.btnSubmitName.FlatAppearance.BorderSize = 2;
            this.btnSubmitName.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSubmitName.Font = new System.Drawing.Font("UD Digi Kyokasho NK-B", 7.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSubmitName.Location = new System.Drawing.Point(131, 29);
            this.btnSubmitName.Name = "btnSubmitName";
            this.btnSubmitName.Size = new System.Drawing.Size(79, 20);
            this.btnSubmitName.TabIndex = 10;
            this.btnSubmitName.Text = "Submit";
            this.btnSubmitName.UseVisualStyleBackColor = true;
            this.btnSubmitName.Click += new System.EventHandler(this.btnSubmitName_Click);
            // 
            // txtChangeName
            // 
            this.txtChangeName.Font = new System.Drawing.Font("UD Digi Kyokasho NK-B", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtChangeName.Location = new System.Drawing.Point(4, 29);
            this.txtChangeName.Multiline = true;
            this.txtChangeName.Name = "txtChangeName";
            this.txtChangeName.Size = new System.Drawing.Size(125, 20);
            this.txtChangeName.TabIndex = 9;
            // 
            // btnChangeName
            // 
            this.btnChangeName.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnChangeName.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnChangeName.FlatAppearance.BorderSize = 0;
            this.btnChangeName.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.btnChangeName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChangeName.Font = new System.Drawing.Font("UD Digi Kyokasho NK-B", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnChangeName.Location = new System.Drawing.Point(143, 3);
            this.btnChangeName.Name = "btnChangeName";
            this.btnChangeName.Size = new System.Drawing.Size(110, 19);
            this.btnChangeName.TabIndex = 8;
            this.btnChangeName.Text = "Change Name";
            this.btnChangeName.UseVisualStyleBackColor = false;
            this.btnChangeName.Click += new System.EventHandler(this.btnChangeName_Click);
            // 
            // lbTips
            // 
            this.lbTips.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbTips.AutoSize = true;
            this.lbTips.Font = new System.Drawing.Font("UD Digi Kyokasho NK-B", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbTips.Location = new System.Drawing.Point(6, 70);
            this.lbTips.Name = "lbTips";
            this.lbTips.Size = new System.Drawing.Size(613, 17);
            this.lbTips.TabIndex = 0;
            this.lbTips.Text = "Tips: You are viewing the old Receipt. Press New Receipts to start a new one";
            // 
            // btnNewOrder
            // 
            this.btnNewOrder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNewOrder.Font = new System.Drawing.Font("UD Digi Kyokasho NK-B", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
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
            this.lbTableIndex.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbTableIndex.AutoSize = true;
            this.lbTableIndex.Font = new System.Drawing.Font("UD Digi Kyokasho NK-B", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbTableIndex.Location = new System.Drawing.Point(367, 20);
            this.lbTableIndex.Name = "lbTableIndex";
            this.lbTableIndex.Size = new System.Drawing.Size(256, 17);
            this.lbTableIndex.TabIndex = 7;
            this.lbTableIndex.Text = "I Only Serve The Frozen Throne";
            // 
            // cbTableFood
            // 
            this.cbTableFood.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbTableFood.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTableFood.Font = new System.Drawing.Font("UD Digi Kyokasho NK-B", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cbTableFood.FormattingEnabled = true;
            this.cbTableFood.Location = new System.Drawing.Point(660, 9);
            this.cbTableFood.Name = "cbTableFood";
            this.cbTableFood.Size = new System.Drawing.Size(164, 25);
            this.cbTableFood.TabIndex = 0;
            this.cbTableFood.SelectedIndexChanged += new System.EventHandler(this.cbTableFood_SelectedIndexChanged);
            // 
            // lbDisplayStaffName
            // 
            this.lbDisplayStaffName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbDisplayStaffName.AutoSize = true;
            this.lbDisplayStaffName.Font = new System.Drawing.Font("UD Digi Kyokasho NK-B", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbDisplayStaffName.Location = new System.Drawing.Point(4, 5);
            this.lbDisplayStaffName.Name = "lbDisplayStaffName";
            this.lbDisplayStaffName.Size = new System.Drawing.Size(94, 17);
            this.lbDisplayStaffName.TabIndex = 6;
            this.lbDisplayStaffName.Text = "Hello, Nam";
            // 
            // ChildrenFormPanel
            // 
            this.ChildrenFormPanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ChildrenFormPanel.BackgroundImage")));
            this.ChildrenFormPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
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
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
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
        private System.Windows.Forms.Button btnHistory;
        private System.Windows.Forms.Button btnChangeName;
        private System.Windows.Forms.Button btnSubmitName;
        private System.Windows.Forms.TextBox txtChangeName;
    }
}