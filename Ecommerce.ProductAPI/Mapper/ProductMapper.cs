using AutoMapper;
using Ecommerce.ProductAPI.Data.ValueObject;
using Ecommerce.ProductAPI.Model.Base;

namespace Ecommerce.ProductAPI.Mapper
{
    public class ProductMapper
    {
        public static MapperConfiguration RegisterMaps()
        {
            var mappingConfig = new MapperConfiguration(config => {
                config.CreateMap<ProductVO, Product>();
                config.CreateMap<Product, ProductVO>();
            });
            return mappingConfig;
        }
    }
}
