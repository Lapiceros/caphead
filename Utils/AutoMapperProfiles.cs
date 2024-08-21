using AutoMapper;
using CapHead.DTOs;
using CapHead.Models;

namespace CapHead.Utils;

public class AutoMapperProfiles : Profile
{
    public AutoMapperProfiles()
    {
        CreateMap<Product, ProducDTO>().ReverseMap();
       
    }
}