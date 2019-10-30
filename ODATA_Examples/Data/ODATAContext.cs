using ODATA_Examples.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ODATA_Examples.Data
{
    public class ODATAContext:DbContext
    {

        public ODATAContext():base("name=ODATAContext")
        {
             
        }

        public virtual DbSet<Category>Categories { get; set; }
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<Suppliers> Suppliers { get; set; }

    }
}