using CsvHelper.Configuration;
using Tailwind.Traders.Product.Api2.Models;

namespace Tailwind.Traders.Product.Api2.Mappers
{
    public sealed class ProductFeatureMap : ClassMap<ProductFeature>
    {
        public ProductFeatureMap()
        {
            Map();
        }
    }
}
