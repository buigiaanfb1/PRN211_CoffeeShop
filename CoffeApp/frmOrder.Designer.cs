
namespace CoffeApp
{
    partial class frmOrder
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
            this.ReceiptsTable = new System.Windows.Forms.DataGridView();
            this.btnCreate = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ReceiptsTable)).BeginInit();
            this.SuspendLayout();
            // 
            // ReceiptsTable
            // 
            this.ReceiptsTable.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ReceiptsTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ReceiptsTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ReceiptsTable.Location = new System.Drawing.Point(112, 12);
            this.ReceiptsTable.Name = "ReceiptsTable";
            this.ReceiptsTable.ReadOnly = true;
            this.ReceiptsTable.RowHeadersWidth = 51;
            this.ReceiptsTable.RowTemplate.Height = 29;
            this.ReceiptsTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ReceiptsTable.Size = new System.Drawing.Size(694, 429);
            this.ReceiptsTable.TabIndex = 0;
            // 
            // btnCreate
            // 
            this.btnCreate.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnCreate.Location = new System.Drawing.Point(12, 12);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(94, 70);
            this.btnCreate.TabIndex = 1;
            this.btnCreate.Text = "Create An Order";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnUpdate.Location = new System.Drawing.Point(12, 179);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(94, 70);
            this.btnUpdate.TabIndex = 2;
            this.btnUpdate.Text = "Update Selected Order";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnDelete.Location = new System.Drawing.Point(12, 371);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(94, 70);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.Text = "Remove Order";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // frmOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(818, 453);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.ReceiptsTable);
            this.Name = "frmOrder";
            this.Text = "frmOrder";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmOrder_FormClosed);
            this.Load += new System.EventHandler(this.frmOrder_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ReceiptsTable)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView ReceiptsTable;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
    }
}