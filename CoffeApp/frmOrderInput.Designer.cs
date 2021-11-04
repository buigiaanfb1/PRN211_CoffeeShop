
namespace CoffeApp
{
    partial class frmOrderInput
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
            this.txtVolume = new System.Windows.Forms.NumericUpDown();
            this.cbFoods = new System.Windows.Forms.ComboBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.txtVolume)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(132, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Food";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(132, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Quantity";
            // 
            // txtVolume
            // 
            this.txtVolume.Location = new System.Drawing.Point(203, 99);
            this.txtVolume.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.txtVolume.Name = "txtVolume";
            this.txtVolume.Size = new System.Drawing.Size(199, 27);
            this.txtVolume.TabIndex = 2;
            // 
            // cbFoods
            // 
            this.cbFoods.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFoods.FormattingEnabled = true;
            this.cbFoods.Location = new System.Drawing.Point(203, 46);
            this.cbFoods.Name = "cbFoods";
            this.cbFoods.Size = new System.Drawing.Size(199, 28);
            this.cbFoods.TabIndex = 3;
            this.cbFoods.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // btnSubmit
            // 
            this.btnSubmit.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnSubmit.Location = new System.Drawing.Point(161, 210);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(94, 29);
            this.btnSubmit.TabIndex = 4;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(339, 210);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(94, 29);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // frmOrderInput
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(588, 295);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.cbFoods);
            this.Controls.Add(this.txtVolume);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmOrderInput";
            this.Text = "Receipt Input";
            this.Load += new System.EventHandler(this.frmOrderInput_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtVolume)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown txtVolume;
        private System.Windows.Forms.ComboBox cbFoods;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btnCancel;
    }
}