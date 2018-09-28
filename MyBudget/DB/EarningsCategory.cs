using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace MyBudget
{
    public class EarningsCategory
    {
        public EarningsCategory()
        {

        }

        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        public virtual ICollection<Earning> Earnings { get; set; }
    }
}
