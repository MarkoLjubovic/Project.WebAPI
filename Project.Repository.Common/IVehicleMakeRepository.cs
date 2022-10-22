using Project.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Repository.Common
{
    public interface IVehicleMakeRepository
    {
        Task<VehicleMake> GetAsync(int? id);
        Task<List<VehicleMake>> GetAllAsync();
        Task<VehicleMake> AddAsync(VehicleMake entity);
        Task DeleteAsync(int id);
        Task <VehicleMake>UpdateAsync(VehicleMake entity);
        Task<VehicleMake> GetDetails(int id);
    }
}
