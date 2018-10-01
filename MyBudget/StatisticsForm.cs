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

            listView_CurrentPeriodStatistic.View = View.Details;
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
                             where st.DateSpending.Month == DateTime.Now.Month
                             group st by st.SpendingsCategory.Name into stcs
                             select new { Category = stcs.Key, Sum = stcs.Sum(st => st.Sum), Per = db.Spendings.Where(ps => ps.DateSpending.Month == DateTime.Now.Month).Sum(ps => ps.Sum) }).ToList();


                listView_CurrentPeriodStatistic.Items.Clear();
                foreach (var st in stats)
                {
                    ListViewItem lv_Item = new ListViewItem(st.Category);
                    lv_Item.SubItems.Add(String.Format("{0:f2}", st.Sum));
                    lv_Item.SubItems.Add(String.Format("{0:p1}", (st.Sum/st.Per)));
                    listView_CurrentPeriodStatistic.Items.Add(lv_Item);
                }
            }
            else
            {
                var stats_fp = (from st in db.Spendings
                             join stc in db.SpendingsCategories on st.SpendingsCategory equals stc
                             where st.DateSpending.Month == dateTimePicker_FirstPeriod.Value.Month
                             group st by st.SpendingsCategory.Name into stcs
                             select new { Category = stcs.Key, Sum = stcs.Sum(st => st.Sum), Per = db.Spendings.Where(ps => ps.DateSpending.Month == dateTimePicker_FirstPeriod.Value.Month).Sum(ps => ps.Sum) }).ToList();

                var stats_sp = (from st in db.Spendings
                                join stc in db.SpendingsCategories on st.SpendingsCategory equals stc
                                where st.DateSpending.Month == dateTimePicker_SecondPeriod.Value.Month
                                group st by st.SpendingsCategory.Name into stcs
                                select new { Category = stcs.Key, Sum = stcs.Sum(st => st.Sum), Per = db.Spendings.Where(ps => ps.DateSpending.Month == dateTimePicker_SecondPeriod.Value.Month).Sum(ps => ps.Sum) }).ToList();


                listView_FirstPeriod.Items.Clear();
                listView_SecondPeriod.Items.Clear();
                foreach (var st in stats_fp)
                {
                    ListViewItem lv_Item = new ListViewItem(st.Category);
                    lv_Item.SubItems.Add(String.Format("{0:f2}", st.Sum));
                    lv_Item.SubItems.Add(String.Format("{0:p1}", (st.Sum / st.Per)));
                    listView_FirstPeriod.Items.Add(lv_Item);
                }

                foreach (var st in stats_sp)
                {
                    ListViewItem lv_Item = new ListViewItem(st.Category);
                    lv_Item.SubItems.Add(String.Format("{0:f2}", st.Sum));
                    lv_Item.SubItems.Add(String.Format("{0:p1}", (st.Sum / st.Per)));
                    listView_SecondPeriod.Items.Add(lv_Item);
                }
            }
        }
    }
}
