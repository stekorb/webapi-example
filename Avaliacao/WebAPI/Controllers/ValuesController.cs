using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

using Business;
using Entities;

namespace WebAPI.Controllers
{
    public class ValuesController : ApiController
    {
        // GET api/values
        public IList<Product> Get()
        {
            ProductBusiness productBusiness = new ProductBusiness();
            return productBusiness.GetAll();
        }

        // GET api/values/5
        public Product Get(Guid Id)
        {
            ProductBusiness productBusiness = new ProductBusiness();
            var list = productBusiness.GetAll();
            return list.FirstOrDefault(p => p.Id == Id);
        }

        // POST api/values
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}
