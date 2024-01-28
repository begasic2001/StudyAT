using AutoMapper;
using Catalog.API.Entities;

namespace Catalog.API.Extensions
{
    public class MappingProfiles : Profile
    {
        public MappingProfiles() {
            CreateMap<Product, Product>();
        }
    }
}
