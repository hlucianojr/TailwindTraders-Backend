using CsvHelper.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tailwind.Traders.Product.Api2.Models;

namespace Tailwind.Traders.Product.Api2.Mappers
{
    public class ProductTagMap : ClassMap<ProductTag>
    {
        public ProductTagMap()
        {
            Map();
        }
    }
}
