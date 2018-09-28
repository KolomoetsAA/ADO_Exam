using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace MyBudget
{
    public class Spending
    {
        public Spending()
        {

        }

        [Key]
        public int Id { get; set; }

        [Required]
        public DateTime DateSpending { get; set; }

        [Required]
        public string SpendingsCategoryId { get; set; }

        [Required]
        public string ProductId { get; set; }

        [Required]
        public double Sum { get; set; }
        public string Description { get; set; }

        [Required]
        public virtual Product Product { get; set; }

        [Required]
        public virtual SpendingsCategory SpendingsCategory { get; set; }
    }
}
