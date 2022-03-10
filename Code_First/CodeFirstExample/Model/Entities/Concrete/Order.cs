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
    public class Order : BaseEntity<int>
    {
        public override int ID { get; set; }

        [Required]
        public DateTime OrderDate { get; set; }

        [ForeignKey("Customer")]
        public int CustomerID { get; set; }
        public virtual Customer Customer { get; set; }

        [ForeignKey("Employee")]
        public int EmployeeID { get; set; }
        public virtual Employee Employee { get; set; }

        public virtual List<Order> Orders { get; set; }
    }
}
