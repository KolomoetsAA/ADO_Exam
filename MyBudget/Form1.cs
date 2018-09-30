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
    public partial class Form1 : Form
    {
        MyBudgetContext db;
        public SpendingsCategory SpendingsCategoryFilter;
        public Form1()
        {
            InitializeComponent();
            db = new MyBudgetContext();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SpendingsCategoryFilter = null;
            dataGridView_Earnings.DataSource = FillEarnings(db);
            dataGridView_Spendings.DataSource = FillSpendings(db);

            Balance();
        }

        private void Balance()
        {
            lbl_Balance.Text = "0 $";
            try
            {
                lbl_Balance.Text = ((from ern in db.Earnings select ern.Sum).Sum() - (from spd in db.Spendings select spd.Sum).Sum()).ToString() + " $";
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private object FillSpendings(MyBudgetContext db)
        {
            dataGridView_Spendings.DataSource = null;
            BindingSource bs = new BindingSource();
            //bs.DataSource = db.Spendings.Select(s => new
            //{
            //    Id = s.Id,
            //    Date = s.DateSpending,
            //    Category = s.SpendingsCategory.Name,
            //    Product = s.Product.Name,
            //    Sum = s.Sum,
            //    Description = s.Description

            //}).ToList();
            if (SpendingsCategoryFilter == null)
            {
                bs.DataSource = (from s in db.Spendings
                                 where s.DateSpending.Month == DateTime.Now.Month
                                 orderby s.DateSpending ascending
                                 select new
                                 {
                                     Id = s.Id,
                                     Date = s.DateSpending,
                                     Category = s.SpendingsCategory.Name,
                                     Product = s.Product.Name,
                                     Sum = s.Sum,
                                     Description = s.Description
                                 }).ToList();
            }
            else
            {
                bs.DataSource = (from s in db.Spendings
                                 where s.DateSpending.Month == DateTime.Now.Month && s.SpendingsCategory.Id == SpendingsCategoryFilter.Id
                                 orderby s.DateSpending ascending
                                 select new
                                 {
                                     Id = s.Id,
                                     Date = s.DateSpending,
                                     Category = s.SpendingsCategory.Name,
                                     Product = s.Product.Name,
                                     Sum = s.Sum,
                                     Description = s.Description
                                 }).ToList();
            }
            return bs;
        }

        private object FillEarnings(MyBudgetContext db)
        {
            dataGridView_Earnings.DataSource = null;
            BindingSource bs = new BindingSource();
            bs.DataSource = db.Earnings.Select(e => new
            {
                Id = e.Id,
                Date = e.DateEarning,
                Category = e.EarningsCategory.Name,
                Sum = e.Sum,
                Description = e.Description

            }).ToList();
            return bs;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void spendingsAddToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EarningsSpendingsAddForm AddForm = new EarningsSpendingsAddForm(false);
            AddForm.ShowDialog();

            //dataGridView_Spendings.DataSource = null;
            dataGridView_Spendings.DataSource = FillSpendings(db);
            Balance();
        }

        private void earningAddToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EarningsSpendingsAddForm AddForm = new EarningsSpendingsAddForm(true);
            AddForm.ShowDialog();

            
            dataGridView_Earnings.DataSource = FillEarnings(db);
            Balance();
            
        }

        private void spendingsCategoryEditToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CategoryEditForm EditForm = new CategoryEditForm(false);
            EditForm.ShowDialog();
        }

        private void earningsCategoryEditToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CategoryEditForm EditForm = new CategoryEditForm(true);
            EditForm.ShowDialog();
        }

        private void taskToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TaskForm taskForm = new TaskForm();
            taskForm.ShowDialog();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutForm aboutForm = new AboutForm();
            aboutForm.ShowDialog();
        }

        private void filterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool chbx_checked = false;
            ComboBox cmbx;

            FilterForm filterForm = new FilterForm(SpendingsCategoryFilter);
            filterForm.ShowDialog();
            foreach (var item in filterForm.Controls)
            {
                if (item is CheckBox)
                {
                    CheckBox chbx = item as CheckBox;
                    chbx_checked = chbx.Checked;
                }
                if (item is ComboBox)
                {
                    cmbx = item as ComboBox;
                    SpendingsCategoryFilter = (from sc in db.SpendingsCategories where sc.Name == cmbx.Text select sc).FirstOrDefault();
                }
            }

            if (!chbx_checked)
            {
                SpendingsCategoryFilter = null;
            }

            dataGridView_Spendings.DataSource = FillSpendings(db);
        }

        private void statisticsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StatisticsForm statisticsForm = new StatisticsForm();
            statisticsForm.Show();
        }
    }
}
