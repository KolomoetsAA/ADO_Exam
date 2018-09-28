namespace MyBudget
{
    partial class EarningsSpendingsAddForm
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
            this.dateTimePicker_Date = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox_Category = new System.Windows.Forms.ComboBox();
            this.label_Product = new System.Windows.Forms.Label();
            this.comboBox_Product = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_Sum = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox_Description = new System.Windows.Forms.TextBox();
            this.btn_Ok = new System.Windows.Forms.Button();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Broadway", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Date";
            // 
            // dateTimePicker_Date
            // 
            this.dateTimePicker_Date.Location = new System.Drawing.Point(143, 7);
            this.dateTimePicker_Date.Name = "dateTimePicker_Date";
            this.dateTimePicker_Date.Size = new System.Drawing.Size(176, 20);
            this.dateTimePicker_Date.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Broadway", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "Category";
            // 
            // comboBox_Category
            // 
            this.comboBox_Category.FormattingEnabled = true;
            this.comboBox_Category.Location = new System.Drawing.Point(143, 87);
            this.comboBox_Category.Name = "comboBox_Category";
            this.comboBox_Category.Size = new System.Drawing.Size(176, 21);
            this.comboBox_Category.TabIndex = 3;
            // 
            // label_Product
            // 
            this.label_Product.AutoSize = true;
            this.label_Product.Font = new System.Drawing.Font("Broadway", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Product.Location = new System.Drawing.Point(12, 117);
            this.label_Product.Name = "label_Product";
            this.label_Product.Size = new System.Drawing.Size(86, 19);
            this.label_Product.TabIndex = 4;
            this.label_Product.Text = "Product";
            // 
            // comboBox_Product
            // 
            this.comboBox_Product.FormattingEnabled = true;
            this.comboBox_Product.Location = new System.Drawing.Point(143, 115);
            this.comboBox_Product.Name = "comboBox_Product";
            this.comboBox_Product.Size = new System.Drawing.Size(176, 21);
            this.comboBox_Product.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Broadway", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(13, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 19);
            this.label4.TabIndex = 6;
            this.label4.Text = "Sum";
            // 
            // textBox_Sum
            // 
            this.textBox_Sum.Location = new System.Drawing.Point(143, 34);
            this.textBox_Sum.Name = "textBox_Sum";
            this.textBox_Sum.Size = new System.Drawing.Size(176, 20);
            this.textBox_Sum.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Broadway", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 61);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(120, 19);
            this.label5.TabIndex = 8;
            this.label5.Text = "Description";
            // 
            // textBox_Description
            // 
            this.textBox_Description.Location = new System.Drawing.Point(143, 60);
            this.textBox_Description.Name = "textBox_Description";
            this.textBox_Description.Size = new System.Drawing.Size(176, 20);
            this.textBox_Description.TabIndex = 9;
            // 
            // btn_Ok
            // 
            this.btn_Ok.Font = new System.Drawing.Font("Broadway", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Ok.Location = new System.Drawing.Point(143, 163);
            this.btn_Ok.Name = "btn_Ok";
            this.btn_Ok.Size = new System.Drawing.Size(85, 27);
            this.btn_Ok.TabIndex = 10;
            this.btn_Ok.Text = "Ok";
            this.btn_Ok.UseVisualStyleBackColor = true;
            this.btn_Ok.Click += new System.EventHandler(this.btn_Ok_Click);
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.Font = new System.Drawing.Font("Broadway", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Cancel.Location = new System.Drawing.Point(234, 163);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(85, 27);
            this.btn_Cancel.TabIndex = 12;
            this.btn_Cancel.Text = "Cancel";
            this.btn_Cancel.UseVisualStyleBackColor = true;
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // EarningsSpendingsAddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(328, 199);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.btn_Ok);
            this.Controls.Add(this.textBox_Description);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox_Sum);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboBox_Product);
            this.Controls.Add(this.label_Product);
            this.Controls.Add(this.comboBox_Category);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dateTimePicker_Date);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "EarningsSpendingsAddForm";
            this.Text = "EarningsSpendingsAddForm";
            this.Load += new System.EventHandler(this.EarningsSpendingsAddForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePicker_Date;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox_Category;
        private System.Windows.Forms.Label label_Product;
        private System.Windows.Forms.ComboBox comboBox_Product;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_Sum;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox_Description;
        private System.Windows.Forms.Button btn_Ok;
        private System.Windows.Forms.Button btn_Cancel;
    }
}