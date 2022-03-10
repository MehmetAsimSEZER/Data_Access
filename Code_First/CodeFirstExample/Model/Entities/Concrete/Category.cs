using CodeFirstExample.Model.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstExample.Model.Entities.Concrete
{
    public class Category : BaseEntity<int>
    {
        public override int ID { get; set; }

        [Required]
        [MinLength(3)]
        [MaxLength(25)]
        public string CategoryName { get; set; }

        [Required]
        [MinLength(3)]
        [MaxLength(25)]
        public string Description { get; set; }

        public virtual List<Product> Products { get; set; }

    }
}
