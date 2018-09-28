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
    public partial class CategoryEditForm : Form
    {
        bool EarningsCategoryEdit = true;
        MyBudgetContext db;
        public CategoryEditForm()
        {
            InitializeComponent();
        }

        public CategoryEditForm(bool flag)
        {
            InitializeComponent();
            EarningsCategoryEdit = flag;
        }

        private void CategoryEditForm_Load(object sender, EventArgs e)
        {
            db = new MyBudgetContext();

            if (EarningsCategoryEdit)
                dataGridView1.DataSource = FillEarnings(db);
            else
                dataGridView1.DataSource = FillSpendings(db);
        }

        private object FillSpendings(MyBudgetContext db)
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = db.SpendingsCategories.Select(s => new
            {
                Id = s.Id,
                Name = s.Name,

            }).ToList();
            return bs;
        }

        private object FillEarnings(MyBudgetContext db)
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = db.EarningsCategories.Select(e => new
            {
                Id = e.Id,
                Name = e.Name,

            }).ToList();
            return bs;
        }

        private void button_Add_Click(object sender, EventArgs e)
        {
            if (EarningsCategoryEdit)
            {
                EarningsCategory ec = new EarningsCategory { Name = textBox1.Text };
                db.EarningsCategories.Add(ec);
                db.SaveChanges();
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = FillEarnings(db);
            }
            else
            {
                SpendingsCategory sc = new SpendingsCategory { Name = textBox1.Text };
                db.SpendingsCategories.Add(sc);
                db.SaveChanges();
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = FillSpendings(db);
            }
            textBox1.Text = "";
        }

        private void button_Edit_Click(object sender, EventArgs e)
        {
            if (EarningsCategoryEdit)
            {
                EarningsCategory ec = db.EarningsCategories.Find(dataGridView1.SelectedRows[0].Cells[0].Value);
                ec.Name = textBox1.Text;
                
                db.SaveChanges();
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = FillEarnings(db);
            }
            else
            {
                SpendingsCategory sc = db.SpendingsCategories.Find(dataGridView1.SelectedRows[0].Cells[0].Value);
                sc.Name = textBox1.Text;
                
                db.SaveChanges();
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = FillSpendings(db);
            }
            textBox1.Text = "";
        }
    }
}
