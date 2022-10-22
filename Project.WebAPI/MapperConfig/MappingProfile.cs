using AutoMapper;
using Project.Models;
using Project.WebAPI.ProjectDtos.VehicleMake;
using Project.WebAPI.ProjectDtos.VehicleModel;

namespace Project.WebAPI.MapperConfig
{
    public class MappingProfile:Profile
    {
        public MappingProfile()
        {
            CreateMap<VehicleMake, CreateMakeDto>().ReverseMap();
            CreateMap<VehicleMake, GetMakeDto>().ReverseMap();
            CreateMap<VehicleMake, MakeDto>().ReverseMap();
            CreateMap<VehicleMake, UpdateMakeDto>().ReverseMap();

            CreateMap<VehicleModel, ModelDto>().ReverseMap();
            CreateMap<VehicleModel, CreateModelDto>().ReverseMap();
        }
    }
}
