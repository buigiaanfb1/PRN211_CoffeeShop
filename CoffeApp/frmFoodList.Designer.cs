
namespace CoffeApp
{
    partial class frmFoodList
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
            this.FoodTable = new System.Windows.Forms.DataGridView();
            this.btnDelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.FoodTable)).BeginInit();
            this.SuspendLayout();
            // 
            // FoodTable
            // 
            this.FoodTable.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FoodTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.FoodTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.FoodTable.Location = new System.Drawing.Point(12, 12);
            this.FoodTable.Name = "FoodTable";
            this.FoodTable.ReadOnly = true;
            this.FoodTable.RowHeadersWidth = 51;
            this.FoodTable.RowTemplate.Height = 29;
            this.FoodTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.FoodTable.Size = new System.Drawing.Size(794, 395);
            this.FoodTable.TabIndex = 0;
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Location = new System.Drawing.Point(12, 413);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(794, 29);
            this.btnDelete.TabIndex = 1;
            this.btnDelete.Text = "Remove Selected Food";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // frmFoodList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(818, 453);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.FoodTable);
            this.Name = "frmFoodList";
            this.Text = "frmFoodList";
            this.Load += new System.EventHandler(this.frmFoodList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.FoodTable)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView FoodTable;
        private System.Windows.Forms.Button btnDelete;
    }
}