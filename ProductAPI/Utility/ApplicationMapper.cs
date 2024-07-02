using AutoMapper;
using ProductAPI.ApplicationCore.Entities;
using ProductAPI.ApplicationCore.Model.Request;
using ProductAPI.ApplicationCore.Model.Response;

namespace ProductAPI.Utility
{
    public class ApplicationMapper:Profile
    {
        public ApplicationMapper()
        {
            CreateMap<Category,CategoryRequestModel>().ReverseMap();
            CreateMap<Category,CategoryResponseModel>().ReverseMap();
            CreateMap<Product,ProductResponseModel>().ReverseMap().ForMember(x=>x.Category,opt=>opt.Ignore());
            CreateMap<Product,ProductRequestModel>().ReverseMap().ForMember(x => x.Category, opt => opt.Ignore());
            
        }
    }
}
