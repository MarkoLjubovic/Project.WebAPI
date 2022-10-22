using Autofac;
using Project.Repository;
using Project.Repository.Common;
using Project.Service;
using Project.Service.Common;
using Project.WebAPI.MapperConfig;

namespace Project.WebAPI.AutoFacCommon
{
    public class AutoFacCommon:Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<VehicleMakeService>().As<IVehicleMakeService>().SingleInstance();
            builder.RegisterType<VehicleModelService>().As<IVehicleModelService>().SingleInstance();
            builder.RegisterType<VehicleMakeRepository>().As<IVehicleMakeRepository>().SingleInstance();
            builder.RegisterType<VehicleModelRepository>().As<IVehicleModelRepository>().SingleInstance();

            builder.RegisterInstance(AutoMapperConfig.Initialize()).SingleInstance();
        }
    }
}
