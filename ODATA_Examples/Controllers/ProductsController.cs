using ODATA_Examples.Data;
using ODATA_Examples.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.OData;

namespace ODATA_Examples.Controllers
{
    public class ProductsController : ODataController
    {
        ODATAContext context = new ODATAContext();

        [EnableQuery]
        public IQueryable<Product> Get()
        {
            return context.Products;
        }
    }
}
