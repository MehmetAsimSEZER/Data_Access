using CodeFirstExample.Model.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstExample.Model.Entities.Concrete
{
    public class Supplier : BaseEntity<int>
    {
        public override int ID { get; set; }

        [Required]
        [MinLength(5)]
        [MaxLength(25)]
        public string CompanyName { get; set; }

        [Required]
        [MinLength(5)]
        [MaxLength(25)]
        public string ContactName { get; set; }

        [Required]
        [MinLength(5)]
        [MaxLength(25)]
        public string ContactTitle { get; set; }

        public string Country { get; set; }

        [MinLength(11),MaxLength(12)]
        public string Phone { get; set; }

        public virtual List<Product> Products { get; set; }
    }
}
