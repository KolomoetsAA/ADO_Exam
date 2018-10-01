using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace MyBudget
{
    public class MyBudgetContext : DbContext
    {
        public MyBudgetContext()
            : base("MyConnectionString")
        {
            ////инициализаторы для режима работы entity  
            ////создает новую базу всегда
            Database.SetInitializer<MyBudgetContext>(new DropCreateDatabaseAlways<MyBudgetContext>());
            ////создает биби если она изменилась
            //Database.SetInitializer<MyBudgetContext>(new DropCreateDatabaseIfModelChanges<MyBudgetContext>());
            ////создает биби если ее нет
            //Database.SetInitializer<MyBudgetContext>(new CreateDatabaseIfNotExists<MyBudgetContext>());
        }

        public DbSet<EarningsCategory> EarningsCategories { get; set; }
        public DbSet<SpendingsCategory> SpendingsCategories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Spending> Spendings { get; set; }
        public DbSet<Earning> Earnings { get; set; }
    }
}
