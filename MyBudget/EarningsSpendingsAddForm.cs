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
    public partial class EarningsSpendingsAddForm : Form
    {
        bool AddEarnings = true;
        MyBudgetContext db;
        public EarningsSpendingsAddForm()
        {
            InitializeComponent();
        }

        public EarningsSpendingsAddForm(bool flag)
        {
            InitializeComponent();
            AddEarnings = flag;
        }
        private void EarningsSpendingsAddForm_Load(object sender, EventArgs e)
        {
            db = new MyBudgetContext();
            if (AddEarnings)
            {
                label_Product.Visible = false;
                comboBox_Product.Visible = false;
                var eCategory = (from ern in db.EarningsCategories select ern).ToList();
                comboBox_Category.DataSource = eCategory;
                comboBox_Category.DisplayMember = "Name";
                comboBox_Category.ValueMember = "Id";
            }
            else
            {
                label_Product.Visible = true;
                comboBox_Product.Visible = true;
                var sCategory = (from spd in db.SpendingsCategories select spd).ToList();
                comboBox_Category.DataSource = sCategory;
                comboBox_Category.DisplayMember = "Name";
                comboBox_Category.ValueMember = "Id";

                var prodCategory = (from p in db.Products select p).ToList();
                comboBox_Product.DataSource = prodCategory;
                comboBox_Product.DisplayMember = "Name";
                comboBox_Product.ValueMember = "Id";
            }
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Ok_Click(object sender, EventArgs e)
        {
            if (AddEarnings)
            {
                Earning ern = new Earning();
                ern.DateEarning = dateTimePicker_Date.Value;
                ern.Description = textBox_Description.Text;
                ern.Sum = Convert.ToDouble(textBox_Sum.Text);
                var idCategory = (from er in db.EarningsCategories where er.Name == comboBox_Category.Text select er).FirstOrDefault();
                ern.EarningsCategory = idCategory;
                db.Earnings.Add(ern);
                db.SaveChanges();
            }
            else
            {
                Spending spd = new Spending();
                spd.DateSpending = dateTimePicker_Date.Value;
                spd.Description = textBox_Description.Text;
                spd.Sum = Convert.ToDouble(textBox_Sum.Text);
                var idCategory = (from sc in db.SpendingsCategories where sc.Name == comboBox_Category.Text select sc).FirstOrDefault();
                spd.SpendingsCategory = idCategory;
                var prod = (from p in db.Products where p.Name == comboBox_Product.Text select p).FirstOrDefault();
                spd.Product = prod;
                db.Spendings.Add(spd);
                db.SaveChanges();
            }

            this.DialogResult = DialogResult.OK;
        }
    }
}
