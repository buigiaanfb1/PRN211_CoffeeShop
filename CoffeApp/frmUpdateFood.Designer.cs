
namespace CoffeApp
{
    partial class frmUpdateFood
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.NumericUpDown();
            this.txtFoodName = new System.Windows.Forms.TextBox();
            this.cbFoodType = new System.Windows.Forms.ComboBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.updateFoodTable = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.txtPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.updateFoodTable)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(221, 259);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Food";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(221, 305);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Food Type";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(221, 348);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Price";
            // 
            // txtPrice
            // 
            this.txtPrice.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.txtPrice.Location = new System.Drawing.Point(321, 346);
            this.txtPrice.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(217, 27);
            this.txtPrice.TabIndex = 3;
            // 
            // txtFoodName
            // 
            this.txtFoodName.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.txtFoodName.Location = new System.Drawing.Point(321, 256);
            this.txtFoodName.Name = "txtFoodName";
            this.txtFoodName.Size = new System.Drawing.Size(217, 27);
            this.txtFoodName.TabIndex = 4;
            // 
            // cbFoodType
            // 
            this.cbFoodType.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.cbFoodType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFoodType.FormattingEnabled = true;
            this.cbFoodType.Location = new System.Drawing.Point(321, 302);
            this.cbFoodType.Name = "cbFoodType";
            this.cbFoodType.Size = new System.Drawing.Size(217, 28);
            this.cbFoodType.TabIndex = 5;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnUpdate.Location = new System.Drawing.Point(336, 394);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(153, 47);
            this.btnUpdate.TabIndex = 6;
            this.btnUpdate.Text = "Update This Food";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // updateFoodTable
            // 
            this.updateFoodTable.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.updateFoodTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.updateFoodTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.updateFoodTable.Location = new System.Drawing.Point(12, 12);
            this.updateFoodTable.Name = "updateFoodTable";
            this.updateFoodTable.ReadOnly = true;
            this.updateFoodTable.RowHeadersWidth = 51;
            this.updateFoodTable.RowTemplate.Height = 29;
            this.updateFoodTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.updateFoodTable.Size = new System.Drawing.Size(794, 238);
            this.updateFoodTable.TabIndex = 7;
            this.updateFoodTable.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.updateFoodTable_CellClick);
            // 
            // frmUpdateFood
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(818, 453);
            this.Controls.Add(this.updateFoodTable);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.cbFoodType);
            this.Controls.Add(this.txtFoodName);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmUpdateFood";
            this.Text = "frmUpdateFood";
            this.Load += new System.EventHandler(this.frmUpdateFood_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.updateFoodTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown txtPrice;
        private System.Windows.Forms.TextBox txtFoodName;
        private System.Windows.Forms.ComboBox cbFoodType;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.DataGridView updateFoodTable;
    }
}