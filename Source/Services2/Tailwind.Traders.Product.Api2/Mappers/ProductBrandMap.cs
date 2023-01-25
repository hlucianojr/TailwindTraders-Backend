using CsvHelper.Configuration;
using Tailwind.Traders.Product.Api2.Models;

namespace Tailwind.Traders.Product.Api2.Mappers
{
    public class ProductBrandMap : ClassMap<ProductBrand>
    {
        public ProductBrandMap()
        {
            Map();
        }
    }
}
