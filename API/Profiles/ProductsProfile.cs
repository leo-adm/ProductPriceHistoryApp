using API.Models.PriceRegister;
using API.Models.Product;
using AutoMapper;
using Domain.AggregatesModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;

namespace API.Profiles
{
    public class ProductsProfile : Profile
    {
        public ProductsProfile()
        {
            CreateMap<ProductCreateModel, Product>();
            CreateMap<PriceRegisterCreateModel, PriceRegister>();

            CreateMap<Product, ProductReadModel>();
            CreateMap<PriceRegister, PriceRegisterReadModel>()
                .ForMember(dest => dest.Date, 
                           mapper => mapper.MapFrom(src => src.Date.ToLocalTime().ToString("dd/MM/yyyy")));
        }
    }
}
