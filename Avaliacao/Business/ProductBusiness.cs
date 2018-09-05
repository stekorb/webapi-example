using System.Collections.Generic;

using Newtonsoft.Json;
using Data;
using Entities;

namespace Business
{
    public class ProductBusiness
    {
        public List<Product> GetAll()
        {
            ProductData dataAccess = new ProductData();
            string products = dataAccess.GetAll();

            return JsonConvert.DeserializeObject<List<Product>>(products);
        }
    }
}
