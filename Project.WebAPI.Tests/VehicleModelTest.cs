using Moq;
using Project.Models;
using Project.Service.Common;
using Project.WebAPI.Tests.MockData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Project.WebAPI.Tests
{
    public class VehicleModelTest
    {
        private readonly Mock<IVehicleModelService> vehicleModelService;

        public VehicleModelTest()
        {
            vehicleModelService=new Mock<IVehicleModelService>();
        }

        [Fact]
        public async Task GetAllVehicleModel_Test()
        {
            vehicleModelService.Setup(vms => vms.GetAllAsync()).ReturnsAsync(VehicleModelData.GetVehicleModel());

            var result = await vehicleModelService.Object.GetAllAsync();
            Assert.True(result.Count == 1);
        }

        [Fact]
        public async Task AddVehicleModel_Test()
        {
            VehicleModel vehicleModel = null;
            vehicleModelService.Setup(vms=>vms.AddAsync(It.IsAny<VehicleModel>())).Callback<VehicleModel>(x=>vehicleModel = x);

            var modelData = VehicleModelData.AddVehicleModel();

            await vehicleModelService.Object.AddAsync(modelData);

            vehicleModelService.Verify(x=>x.AddAsync(It.IsAny<VehicleModel>()), Times.Once);
            Assert.Equal(vehicleModel.ModelName,modelData.ModelName);
            Assert.Equal(vehicleModel.ModelAbrv,modelData.ModelAbrv);
            Assert.Equal(vehicleModel.MakeId,modelData.MakeId);
        }

        [Fact]
        public async Task UpdateVehicleModel_Test()
        {
            VehicleModel vehicleModel = null;
            vehicleModelService.Setup(vms => vms.UpdateAsync(It.IsAny<VehicleModel>())).Callback<VehicleModel>(x => vehicleModel = x);

            var modelData = VehicleModelData.UpdateVehicleModel();

            await vehicleModelService.Object.UpdateAsync(modelData);

            vehicleModelService.Verify(x => x.UpdateAsync(It.IsAny<VehicleModel>()), Times.Once);

            Assert.Equal(vehicleModel.ModelName, modelData.ModelName);
            Assert.Equal(vehicleModel.ModelAbrv, modelData.ModelAbrv);
            Assert.Equal(vehicleModel.MakeId, modelData.MakeId);
        }

        [Fact]
        public async Task DeleteVehicleModel_Test()
        {
            var Id = 10;
            vehicleModelService.Setup(vms => vms.DeleteAsync(Id));

            await vehicleModelService.Object.DeleteAsync(Id);

            vehicleModelService.Verify(rem=>rem.DeleteAsync(Id), Times.Once);
        }
    }
}
