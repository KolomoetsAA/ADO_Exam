namespace MyBudget
{
    partial class FilterForm
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
            this.checkBox_SpendingsCategory = new System.Windows.Forms.CheckBox();
            this.comboBox_Category = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // checkBox_SpendingsCategory
            // 
            this.checkBox_SpendingsCategory.AutoSize = true;
            this.checkBox_SpendingsCategory.Font = new System.Drawing.Font("Broadway", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox_SpendingsCategory.Location = new System.Drawing.Point(12, 12);
            this.checkBox_SpendingsCategory.Name = "checkBox_SpendingsCategory";
            this.checkBox_SpendingsCategory.Size = new System.Drawing.Size(215, 23);
            this.checkBox_SpendingsCategory.TabIndex = 0;
            this.checkBox_SpendingsCategory.Text = "Spendings category";
            this.checkBox_SpendingsCategory.UseVisualStyleBackColor = true;
            // 
            // comboBox_Category
            // 
            this.comboBox_Category.FormattingEnabled = true;
            this.comboBox_Category.Location = new System.Drawing.Point(233, 12);
            this.comboBox_Category.Name = "comboBox_Category";
            this.comboBox_Category.Size = new System.Drawing.Size(176, 21);
            this.comboBox_Category.TabIndex = 4;
            // 
            // FilterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(426, 48);
            this.Controls.Add(this.comboBox_Category);
            this.Controls.Add(this.checkBox_SpendingsCategory);
            this.Name = "FilterForm";
            this.Text = "FilterForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox checkBox_SpendingsCategory;
        private System.Windows.Forms.ComboBox comboBox_Category;
    }
}