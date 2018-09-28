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

            lbl_Balance.Text = GetBalance().ToString(); // тут доделать!
        }

        private double GetBalance()
        {
            return 0;
        }

        private object FillSpendings(MyBudgetContext db)
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = db.Spendings.Select(s => new
            {
                Id = s.Id,
                Date = s.DateSpending,
                Category = s.SpendingsCategory,
                Product = s.Product,
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
                Category = e.EarningsCategory,
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

        }

        private void earningAddToolStripMenuItem_Click(object sender, EventArgs e)
        {

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
