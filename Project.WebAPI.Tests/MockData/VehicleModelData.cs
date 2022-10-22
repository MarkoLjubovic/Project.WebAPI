using Project.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.WebAPI.Tests.MockData
{
    public class VehicleModelData
    {
        public static List<VehicleModel> GetVehicleModel()
        {
            return new List<VehicleModel>(){
                new VehicleModel()
                {
                    Id = 10,
                    ModelName = "Golf",
                    ModelAbrv = "GTI 5",
                    MakeId = 1
                }
            };
        }

        public static VehicleModel AddVehicleModel()
        {
            return new VehicleModel{
                    ModelName = "Golf",
                    ModelAbrv = "GTI 5",
                    MakeId = 1
            };
        }

        public static VehicleModel UpdateVehicleModel()
        {
            return new VehicleModel
            {
                Id = 10,
                ModelName = "Model Name Updated",
                ModelAbrv = "Model Abrv Updated",
                MakeId = 4
            };
        }
    }
}
