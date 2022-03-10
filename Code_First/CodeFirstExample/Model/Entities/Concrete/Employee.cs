using CodeFirstExample.Model.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstExample.Model.Entities.Concrete
{
    public class Employee : BaseEntity<int>
    {
        public override int ID { get; set; }

        [Required]
        [MinLength(5)]
        [MaxLength(25)]
        public string FirstName { get; set; }

        [Required]
        [MinLength(5)]
        [MaxLength(25)]
        public string LastName { get; set; }

        [Required]
        [MinLength(5)]
        [MaxLength(25)]
        public string Title { get; set; }

        public virtual List<Order> Orders { get; set; }

    }
}
