using CsvHelper.Configuration;
using Tailwind.Traders.Product.Api2.Models;

namespace Tailwind.Traders.Product.Api2.Mappers
{
    public class ProductItemMap : ClassMap<ProductItem>
    {
        public ProductItemMap()
        {
            Map(p => p.Id);
            Map(p => p.Name);
            Map(p => p.Price);
            Map(p => p.ImageName);
            Map(p => p.BrandId);
            Map(p => p.TypeId);
            Map(p => p.TagId);
        }
    }
}
