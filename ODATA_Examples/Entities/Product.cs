using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ODATA_Examples.Entities
{
    public class Product
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Category> Category_Id { get; set; }
        public List<Suppliers> Suppliers_Id { get; set; }
    }
}