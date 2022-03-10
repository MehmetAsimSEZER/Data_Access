using CodeFirstExample.Model.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstExample.Model.Entities.Concrete
{
    public class Product : BaseEntity<int>
    {
        public override int ID { get; set; }

        [Required]
        [MinLength(3)]
        [MaxLength(25)]
        public string ProductName { get; set; }
        [Required]
        public decimal UnitPrice { get; set; }
        [Required]
        public short UnitsInStock { get; set; }

        [ForeignKey("Category")]
        public int CategoryID { get; set; }
        public virtual Category Category { get; set; }

        [ForeignKey("Supplier")]
        public int SupplierID { get; set; }
        public virtual  Supplier Supplier { get; set; }

        public virtual List<Order_Detail> Order_Details { get; set; }
    }
}
