using CodeFirstExample.Model.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstExample.Model.Entities.Concrete
{
    public class Customer : BaseEntity<int>
    {
        public override int ID { get; set; }

        [Required]
        [MinLength(5)]
        [MaxLength(25)]
        public string CustomerName { get; set; }

        [Required]
        [MinLength(5)]
        [MaxLength(25)]
        public string CustomerLastName { get; set; }
        
        [Required]
        public string Address { get; set; }

        [MinLength(11), MaxLength(12)]
        public string Phone { get; set; }

        public virtual List<Order> Orders { get; set; }
    }
}
