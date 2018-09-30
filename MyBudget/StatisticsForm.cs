using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyBudget
{
    public partial class StatisticsForm : Form
    {
        public StatisticsForm()
        {
            InitializeComponent();
        }

        private void radioButton_CurrentPeriod_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton_CurrentPeriod.Checked)
            {
                //tabPage_CurrentPeriod.Show();
                tabControl1.SelectedIndex = 0;
            }
            else
            {
                //tabPage_ComparisonOfPeriods.Show();
                tabControl1.SelectedIndex = 1;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MyBudgetContext db = new MyBudgetContext();

            if (radioButton_CurrentPeriod.Checked)
            {
                /*  Select SpendingsCategories.Name as Category, SUM([sum]) as [Sum]  from Spendings
                    join SpendingsCategories ON SpendingsCategories.Id = Spendings.SpendingsCategory_Id
                    where month(Spendings.DateSpending) = MONTH(GETDATE())
                    Group BY SpendingsCategories.Name*/
                var stats = (from st in db.Spendings
                             join stc in db.SpendingsCategories on st.SpendingsCategory equals stc
                             //where st.DateSpending.Month == DateTime.Now.Month
                             group st by st.SpendingsCategory.Name into stcs
                             select new { Category = stcs.Key, Sum = stcs.Sum(st => st.Sum)}).ToList();

                

                foreach (var item in stats)
                {
                    listView_CurrentPeriodStatistic.Items.Add(item.Category +" " +item.Sum);
                }
            }
        }
    }
}
