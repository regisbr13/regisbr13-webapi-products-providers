﻿using System.Collections.Generic;

namespace WebApiProductsProviders.Business.Models
{
    public class Category : BaseEntity
    {
        public string Name { get; set; }
        public List<Product> Products { get; set; }
    }
}
