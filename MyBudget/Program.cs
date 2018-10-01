using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace MyBudget
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Product product = new Product { Name = "Gas" };
            Product product0 = new Product { Name = "Bread" };
            Product product1 = new Product { Name = "Potato" };
            Product product2 = new Product { Name = "Jeans" };
            Product product3 = new Product { Name = "Fish" };
            Product product4 = new Product { Name = "Meat" };
            Product product5 = new Product { Name = "Game" };

            EarningsCategory ec1 = new EarningsCategory { Name = "Main" };
            EarningsCategory ec2 = new EarningsCategory { Name = "Etc." };

            SpendingsCategory sc1 = new SpendingsCategory { Name = "Fuel"};
            SpendingsCategory sc2 = new SpendingsCategory { Name = "Food" };
            SpendingsCategory sc3 = new SpendingsCategory { Name = "Clothes" };
            SpendingsCategory sc4 = new SpendingsCategory { Name = "Entertainment" };

            Earning e1 = new Earning { DateEarning = DateTime.Now, EarningsCategory = ec1, Sum = 3000 };
            Earning e2 = new Earning { DateEarning = DateTime.Now, EarningsCategory = ec2, Sum = 500, Description = "Freelance" };

            Spending s0 = new Spending { DateSpending = DateTime.Parse("2018-09-20"), SpendingsCategory = sc1, Product = product, Sum = 885.75, Description = "WOG" };
            Spending s1 = new Spending { DateSpending = DateTime.Now, SpendingsCategory = sc1, Product = product, Sum = 457.89, Description = "OKKO" };
            Spending s2 = new Spending { DateSpending = DateTime.Now, SpendingsCategory = sc2, Product = product4, Sum = 120, Description = "Steak" };
            Spending s3 = new Spending { DateSpending = DateTime.Now, SpendingsCategory = sc2, Product = product1, Sum = 30, Description = "" };
            Spending s4 = new Spending { DateSpending = DateTime.Now, SpendingsCategory = sc3, Product = product2, Sum = 555, Description = "LCW" };

            using (MyBudgetContext db = new MyBudgetContext())
            {
                db.Products.Add(product);
                db.Products.Add(product0);
                db.Products.Add(product1);
                db.Products.Add(product2);
                db.Products.Add(product3);
                db.Products.Add(product4);
                db.Products.Add(product5);

                db.EarningsCategories.Add(ec1);
                db.EarningsCategories.Add(ec2);

                db.SpendingsCategories.Add(sc1);
                db.SpendingsCategories.Add(sc2);
                db.SpendingsCategories.Add(sc3);
                db.SpendingsCategories.Add(sc4);

                db.Earnings.Add(e1);
                db.Earnings.Add(e2);

                db.Spendings.Add(s0);
                db.Spendings.Add(s1);
                db.Spendings.Add(s2);
                db.Spendings.Add(s3);
                db.Spendings.Add(s4);

                db.SaveChanges();
                //foreach (var a in db.Products)
                //{
                //    MessageBox.Show(a.Name);
                //}
            }

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
