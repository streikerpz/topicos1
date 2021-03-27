
using AutoMapper;

namespace Products.API
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<Products.API.ViewModels.ProductQry, Topicos.NorthWnd.Model.Models.Product>()
                .ReverseMap();
            CreateMap<Products.API.ViewModels.ProductInsert, Topicos.NorthWnd.Model.Models.Product>()
                .ReverseMap();
        }
    }
}

