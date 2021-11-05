
namespace CoffeApp
{
    partial class frmHistoryOrder
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
            this.BillTable = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.BillTable)).BeginInit();
            this.SuspendLayout();
            // 
            // BillTable
            // 
            this.BillTable.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BillTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.BillTable.BackgroundColor = System.Drawing.Color.SpringGreen;
            this.BillTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.BillTable.Location = new System.Drawing.Point(12, 12);
            this.BillTable.Name = "BillTable";
            this.BillTable.ReadOnly = true;
            this.BillTable.RowHeadersWidth = 51;
            this.BillTable.RowTemplate.Height = 29;
            this.BillTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.BillTable.Size = new System.Drawing.Size(794, 387);
            this.BillTable.TabIndex = 0;
            this.BillTable.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.BillTable_CellDoubleClick);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("UD Digi Kyokasho NK-B", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.DarkGreen;
            this.label1.Location = new System.Drawing.Point(154, 414);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(505, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tips: Double click on the bill for viewing the Receipt";
            // 
            // frmHistoryOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleGreen;
            this.ClientSize = new System.Drawing.Size(818, 453);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BillTable);
            this.Name = "frmHistoryOrder";
            this.Text = "frmHistoryOrder";
            this.Load += new System.EventHandler(this.frmHistoryOrder_Load);
            ((System.ComponentModel.ISupportInitialize)(this.BillTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView BillTable;
        private System.Windows.Forms.Label label1;
    }
}