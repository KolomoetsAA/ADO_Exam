using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace MyBudget
{
    public class Earning
    {
        public Earning()
        {

        }

        [Key]
        public int Id { get; set; }

        [Required]
        public DateTime DateEarning { get; set; }

        [Required]
        public string EarningsCategoryId { get; set; }

        [Required]
        public double Sum { get; set; }
        public string Description { get; set; }

        [Required]
        public virtual EarningsCategory EarningsCategory { get; set; }
    }
}
