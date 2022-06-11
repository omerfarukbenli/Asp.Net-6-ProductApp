using AutoMapper;
using ProductApp.Entity.Dto;
using ProductApp.Entity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductApp.Entity.Mapping
{
    public class MapProfile : Profile
    {
        public MapProfile()
        {
            CreateMap<Product, ProductDto>().ReverseMap();
            CreateMap<Product, ProductCreateDto>().ReverseMap();
            CreateMap<Sparepart, SparepartDto>().ReverseMap();
            CreateMap<Sparepart, CreateSparepartDto>()
                .ForMember(des => des.Products, opt =>
                opt.MapFrom(src => src.ProductSpareparts.Select(x => new CreateProductSparepartDto { SparepartID = x.SparepartID, ProductID = x.ProductID }
                ))).ReverseMap();
        }
    }
}
