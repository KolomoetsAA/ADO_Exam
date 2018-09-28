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
        public Form1()
        {
            InitializeComponent();
            db = new MyBudgetContext();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView_Earnings.DataSource = FillEarnings(db);
            dataGridView_Spendings.DataSource = FillSpendings(db);

            Balance();
        }

        private void Balance()
        {
            lbl_Balance.Text = ((from ern in db.Earnings select ern.Sum).Sum() - (from spd in db.Spendings select spd.Sum).Sum()).ToString() + " $";
            
        }

        private object FillSpendings(MyBudgetContext db)
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = db.Spendings.Select(s => new
            {
                Id = s.Id,
                Date = s.DateSpending,
                Category = s.SpendingsCategory.Name,
                Product = s.Product.Name,
                Sum = s.Sum,
                Description = s.Description

            }).ToList();
            return bs;
        }

        private object FillEarnings(MyBudgetContext db)
        {
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

            dataGridView_Spendings.DataSource = null;
            dataGridView_Spendings.DataSource = FillSpendings(db);
            Balance();
        }

        private void earningAddToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EarningsSpendingsAddForm AddForm = new EarningsSpendingsAddForm(true);
            AddForm.ShowDialog();

            dataGridView_Earnings.DataSource = null;
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
    }
}
