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
    public partial class FilterForm : Form
    {
        public FilterForm()
        {
            InitializeComponent();

            MyBudgetContext db = new MyBudgetContext();
            var sCategory = (from spd in db.SpendingsCategories select spd).ToList();
            comboBox_Category.DataSource = sCategory;
            comboBox_Category.DisplayMember = "Name";
            comboBox_Category.ValueMember = "Id";
        }

        public FilterForm(SpendingsCategory sc)
        {
            InitializeComponent();
            checkBox_SpendingsCategory.Checked = (sc == null ? false : true);

            MyBudgetContext db = new MyBudgetContext();
            var sCategory = (from spd in db.SpendingsCategories select spd).ToList();
            comboBox_Category.DataSource = sCategory;
            comboBox_Category.DisplayMember = "Name";
            comboBox_Category.ValueMember = "Id";

            if (sc != null)
                comboBox_Category.SelectedValue = sc.Id;
        }
    }
}
