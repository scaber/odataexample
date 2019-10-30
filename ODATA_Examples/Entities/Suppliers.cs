using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ODATA_Examples.Entities
{
    public class Suppliers
    {
        public Suppliers()
        {
            this.Products = new HashSet<Product>();
        }
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
       public virtual ICollection<Product> Products { get; set; }


    }
}