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
            this.tabPage_ComparisonOfPeriods = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.listView_CurrentPeriodStatistic = new System.Windows.Forms.ListView();
            this.Category = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Sum = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
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
            // tabPage_ComparisonOfPeriods
            // 
            this.tabPage_ComparisonOfPeriods.Controls.Add(this.label2);
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(327, 210);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "label2";
            // 
            // listView_CurrentPeriodStatistic
            // 
            this.listView_CurrentPeriodStatistic.Alignment = System.Windows.Forms.ListViewAlignment.Left;
            this.listView_CurrentPeriodStatistic.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Category,
            this.Sum});
            this.listView_CurrentPeriodStatistic.Enabled = false;
            this.listView_CurrentPeriodStatistic.Font = new System.Drawing.Font("Comic Sans MS", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listView_CurrentPeriodStatistic.FullRowSelect = true;
            this.listView_CurrentPeriodStatistic.GridLines = true;
            this.listView_CurrentPeriodStatistic.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.listView_CurrentPeriodStatistic.Location = new System.Drawing.Point(0, 0);
            this.listView_CurrentPeriodStatistic.Name = "listView_CurrentPeriodStatistic";
            this.listView_CurrentPeriodStatistic.Size = new System.Drawing.Size(584, 400);
            this.listView_CurrentPeriodStatistic.TabIndex = 0;
            this.listView_CurrentPeriodStatistic.UseCompatibleStateImageBehavior = false;
            // 
            // Category
            // 
            this.Category.Width = 150;
            // 
            // Sum
            // 
            this.Sum.Width = 100;
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
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListView listView_CurrentPeriodStatistic;
        private System.Windows.Forms.ColumnHeader Category;
        private System.Windows.Forms.ColumnHeader Sum;
    }
}