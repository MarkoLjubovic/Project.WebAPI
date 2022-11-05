using AutoMapper;
using Project.Models;
using Project.Models.Interfaces;
using Project.WebAPI.ProjectDtos.VehicleMake;
using Project.WebAPI.ProjectDtos.VehicleMake.Interfaces;
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
            //CreateMap<PageVehicleMake, IPage<VehicleMake>>().ReverseMap();
            //CreateMap<VehicleMake, IMakeRestDto>().ReverseMap();
            //CreateMap<VehicleMake, PageVehicleMake>().ReverseMap();
            CreateMap<PageVehicleMake, Page<VehicleMake>>();
            CreateMap<Page<VehicleMake>, PageVehicleMake>().ForMember(x => x.Items, y => y.MapFrom(z => z.Items.ConvertAll(k => new MakeDto()
            {
                Id = k.Id,
                MakeName = k.MakeName,
                MakeAbrv = k.MakeAbrv
            })));

            CreateMap<VehicleModel, ModelDto>().ReverseMap();
            CreateMap<VehicleModel, CreateModelDto>().ReverseMap();
        }
    }
}
