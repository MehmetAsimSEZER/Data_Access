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
    public class Order_Detail : BaseEntity<int>
    {
        public override int ID { get; set; }
        [Required]
        public decimal UnitPrice { get; set; }
        [Required]
        public short Quantity { get; set; }
        [Required]
        public decimal Discount { get; set; }

        [ForeignKey("Product")]
        public int ProductID { get; set; }
        public virtual Product Product { get; set; }


        [ForeignKey("Order")]
        public int OrderID { get; set; }
        public virtual Order Order { get; set; }
    }
}
