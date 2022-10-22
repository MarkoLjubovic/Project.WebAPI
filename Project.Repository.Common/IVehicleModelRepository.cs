using Project.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Repository.Common
{
    public interface IVehicleModelRepository
    {
        Task<VehicleModel> GetAsync(int? id);
        Task<List<VehicleModel>> GetAllAsync();
        Task<VehicleModel> AddAsync(VehicleModel entity);
        Task DeleteAsync(int id);
        Task <VehicleModel> UpdateAsync(VehicleModel entity);
    }
}
