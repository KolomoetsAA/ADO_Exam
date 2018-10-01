namespace MyBudget
{
    partial class StatisticsForm
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
            this.radioButton_CurrentPeriod = new System.Windows.Forms.RadioButton();
            this.radioButton_ComparisonOfPeriods = new System.Windows.Forms.RadioButton();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage_CurrentPeriod = new System.Windows.Forms.TabPage();
            this.listView_CurrentPeriodStatistic = new System.Windows.Forms.ListView();
            this.Category = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Sum = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabPage_ComparisonOfPeriods = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.Percent = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.dateTimePicker_FirstPeriod = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePicker_SecondPeriod = new System.Windows.Forms.DateTimePicker();
            this.listView_FirstPeriod = new System.Windows.Forms.ListView();
            this.listView_SecondPeriod = new System.Windows.Forms.ListView();
            this.fp_Category = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.fp_Sum = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.fp_Percent = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.sp_Category = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.sp_Sum = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.sp_Percent = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabControl1.SuspendLayout();
            this.tabPage_CurrentPeriod.SuspendLayout();
            this.tabPage_ComparisonOfPeriods.SuspendLayout();
            this.SuspendLayout();
            // 
            // radioButton_CurrentPeriod
            // 
            this.radioButton_CurrentPeriod.AutoSize = true;
            this.radioButton_CurrentPeriod.Checked = true;
            this.radioButton_CurrentPeriod.Font = new System.Drawing.Font("Broadway", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton_CurrentPeriod.Location = new System.Drawing.Point(12, 12);
            this.radioButton_CurrentPeriod.Name = "radioButton_CurrentPeriod";
            this.radioButton_CurrentPeriod.Size = new System.Drawing.Size(171, 23);
            this.radioButton_CurrentPeriod.TabIndex = 0;
            this.radioButton_CurrentPeriod.TabStop = true;
            this.radioButton_CurrentPeriod.Text = "Current period";
            this.radioButton_CurrentPeriod.UseVisualStyleBackColor = true;
            this.radioButton_CurrentPeriod.CheckedChanged += new System.EventHandler(this.radioButton_CurrentPeriod_CheckedChanged);
            // 
            // radioButton_ComparisonOfPeriods
            // 
            this.radioButton_ComparisonOfPeriods.AutoSize = true;
            this.radioButton_ComparisonOfPeriods.Font = new System.Drawing.Font("Broadway", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton_ComparisonOfPeriods.Location = new System.Drawing.Point(189, 12);
            this.radioButton_ComparisonOfPeriods.Name = "radioButton_ComparisonOfPeriods";
            this.radioButton_ComparisonOfPeriods.Size = new System.Drawing.Size(244, 23);
            this.radioButton_ComparisonOfPeriods.TabIndex = 1;
            this.radioButton_ComparisonOfPeriods.Text = "Comparison of periods";
            this.radioButton_ComparisonOfPeriods.UseVisualStyleBackColor = true;
            // 
            // tabControl1
            // 
            this.tabControl1.Alignment = System.Windows.Forms.TabAlignment.Bottom;
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage_CurrentPeriod);
            this.tabControl1.Controls.Add(this.tabPage_ComparisonOfPeriods);
            this.tabControl1.ItemSize = new System.Drawing.Size(19, 1);
            this.tabControl1.Location = new System.Drawing.Point(1, 41);
            this.tabControl1.Multiline = true;
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(592, 409);
            this.tabControl1.TabIndex = 2;
            // 
            // tabPage_CurrentPeriod
            // 
            this.tabPage_CurrentPeriod.Controls.Add(this.listView_CurrentPeriodStatistic);
            this.tabPage_CurrentPeriod.Location = new System.Drawing.Point(4, 4);
            this.tabPage_CurrentPeriod.Name = "tabPage_CurrentPeriod";
            this.tabPage_CurrentPeriod.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_CurrentPeriod.Size = new System.Drawing.Size(584, 400);
            this.tabPage_CurrentPeriod.TabIndex = 0;
            // 
            // listView_CurrentPeriodStatistic
            // 
            this.listView_CurrentPeriodStatistic.Alignment = System.Windows.Forms.ListViewAlignment.Left;
            this.listView_CurrentPeriodStatistic.AllowColumnReorder = true;
            this.listView_CurrentPeriodStatistic.AutoArrange = false;
            this.listView_CurrentPeriodStatistic.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Category,
            this.Sum,
            this.Percent});
            this.listView_CurrentPeriodStatistic.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView_CurrentPeriodStatistic.Font = new System.Drawing.Font("Comic Sans MS", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listView_CurrentPeriodStatistic.FullRowSelect = true;
            this.listView_CurrentPeriodStatistic.GridLines = true;
            this.listView_CurrentPeriodStatistic.Location = new System.Drawing.Point(3, 3);
            this.listView_CurrentPeriodStatistic.Name = "listView_CurrentPeriodStatistic";
            this.listView_CurrentPeriodStatistic.Size = new System.Drawing.Size(578, 394);
            this.listView_CurrentPeriodStatistic.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.listView_CurrentPeriodStatistic.TabIndex = 0;
            this.listView_CurrentPeriodStatistic.UseCompatibleStateImageBehavior = false;
            this.listView_CurrentPeriodStatistic.View = System.Windows.Forms.View.Details;
            // 
            // Category
            // 
            this.Category.Text = "Category";
            this.Category.Width = 200;
            // 
            // Sum
            // 
            this.Sum.Text = "Sum";
            this.Sum.Width = 150;
            // 
            // tabPage_ComparisonOfPeriods
            // 
            this.tabPage_ComparisonOfPeriods.Controls.Add(this.listView_SecondPeriod);
            this.tabPage_ComparisonOfPeriods.Controls.Add(this.listView_FirstPeriod);
            this.tabPage_ComparisonOfPeriods.Controls.Add(this.label2);
            this.tabPage_ComparisonOfPeriods.Controls.Add(this.dateTimePicker_SecondPeriod);
            this.tabPage_ComparisonOfPeriods.Controls.Add(this.label1);
            this.tabPage_ComparisonOfPeriods.Controls.Add(this.dateTimePicker_FirstPeriod);
            this.tabPage_ComparisonOfPeriods.Location = new System.Drawing.Point(4, 4);
            this.tabPage_ComparisonOfPeriods.Name = "tabPage_ComparisonOfPeriods";
            this.tabPage_ComparisonOfPeriods.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_ComparisonOfPeriods.Size = new System.Drawing.Size(584, 400);
            this.tabPage_ComparisonOfPeriods.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Broadway", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(439, 10);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(154, 27);
            this.button1.TabIndex = 3;
            this.button1.Text = "Show statistic";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Percent
            // 
            this.Percent.Text = "%";
            this.Percent.Width = 150;
            // 
            // dateTimePicker_FirstPeriod
            // 
            this.dateTimePicker_FirstPeriod.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateTimePicker_FirstPeriod.Location = new System.Drawing.Point(94, 6);
            this.dateTimePicker_FirstPeriod.Name = "dateTimePicker_FirstPeriod";
            this.dateTimePicker_FirstPeriod.Size = new System.Drawing.Size(177, 26);
            this.dateTimePicker_FirstPeriod.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Broadway", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "First period";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Broadway", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(293, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Second period";
            // 
            // dateTimePicker_SecondPeriod
            // 
            this.dateTimePicker_SecondPeriod.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateTimePicker_SecondPeriod.Location = new System.Drawing.Point(403, 6);
            this.dateTimePicker_SecondPeriod.Name = "dateTimePicker_SecondPeriod";
            this.dateTimePicker_SecondPeriod.Size = new System.Drawing.Size(176, 26);
            this.dateTimePicker_SecondPeriod.TabIndex = 2;
            // 
            // listView_FirstPeriod
            // 
            this.listView_FirstPeriod.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.fp_Category,
            this.fp_Sum,
            this.fp_Percent});
            this.listView_FirstPeriod.Font = new System.Drawing.Font("Comic Sans MS", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listView_FirstPeriod.FullRowSelect = true;
            this.listView_FirstPeriod.GridLines = true;
            this.listView_FirstPeriod.Location = new System.Drawing.Point(0, 38);
            this.listView_FirstPeriod.Name = "listView_FirstPeriod";
            this.listView_FirstPeriod.Size = new System.Drawing.Size(290, 362);
            this.listView_FirstPeriod.TabIndex = 4;
            this.listView_FirstPeriod.UseCompatibleStateImageBehavior = false;
            this.listView_FirstPeriod.View = System.Windows.Forms.View.Details;
            // 
            // listView_SecondPeriod
            // 
            this.listView_SecondPeriod.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.sp_Category,
            this.sp_Sum,
            this.sp_Percent});
            this.listView_SecondPeriod.Font = new System.Drawing.Font("Comic Sans MS", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listView_SecondPeriod.FullRowSelect = true;
            this.listView_SecondPeriod.GridLines = true;
            this.listView_SecondPeriod.Location = new System.Drawing.Point(296, 38);
            this.listView_SecondPeriod.Name = "listView_SecondPeriod";
            this.listView_SecondPeriod.Size = new System.Drawing.Size(288, 362);
            this.listView_SecondPeriod.TabIndex = 5;
            this.listView_SecondPeriod.UseCompatibleStateImageBehavior = false;
            this.listView_SecondPeriod.View = System.Windows.Forms.View.Details;
            // 
            // fp_Category
            // 
            this.fp_Category.Text = "Category";
            this.fp_Category.Width = 120;
            // 
            // fp_Sum
            // 
            this.fp_Sum.Text = "Sum";
            this.fp_Sum.Width = 75;
            // 
            // fp_Percent
            // 
            this.fp_Percent.Text = "%";
            this.fp_Percent.Width = 75;
            // 
            // sp_Category
            // 
            this.sp_Category.Text = "Category";
            this.sp_Category.Width = 120;
            // 
            // sp_Sum
            // 
            this.sp_Sum.Text = "Sum";
            this.sp_Sum.Width = 75;
            // 
            // sp_Percent
            // 
            this.sp_Percent.Text = "%";
            this.sp_Percent.Width = 75;
            // 
            // StatisticsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(596, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.radioButton_ComparisonOfPeriods);
            this.Controls.Add(this.radioButton_CurrentPeriod);
            this.Name = "StatisticsForm";
            this.Text = "Statistics";
            this.tabControl1.ResumeLayout(false);
            this.tabPage_CurrentPeriod.ResumeLayout(false);
            this.tabPage_ComparisonOfPeriods.ResumeLayout(false);
            this.tabPage_ComparisonOfPeriods.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton radioButton_CurrentPeriod;
        private System.Windows.Forms.RadioButton radioButton_ComparisonOfPeriods;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage_CurrentPeriod;
        private System.Windows.Forms.TabPage tabPage_ComparisonOfPeriods;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListView listView_CurrentPeriodStatistic;
        private System.Windows.Forms.ColumnHeader Category;
        private System.Windows.Forms.ColumnHeader Sum;
        private System.Windows.Forms.ColumnHeader Percent;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePicker_FirstPeriod;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePicker_SecondPeriod;
        private System.Windows.Forms.ListView listView_SecondPeriod;
        private System.Windows.Forms.ColumnHeader sp_Category;
        private System.Windows.Forms.ColumnHeader sp_Sum;
        private System.Windows.Forms.ColumnHeader sp_Percent;
        private System.Windows.Forms.ListView listView_FirstPeriod;
        private System.Windows.Forms.ColumnHeader fp_Category;
        private System.Windows.Forms.ColumnHeader fp_Sum;
        private System.Windows.Forms.ColumnHeader fp_Percent;
    }
}