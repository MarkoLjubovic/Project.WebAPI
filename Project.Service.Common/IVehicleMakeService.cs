using Project.Common.Interfaces;
using Project.Models;
using Project.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Service.Common
{
    public interface IVehicleMakeService
    {
        Task<VehicleMake> GetAsync(int? id);
        Task<List<VehicleMake>> GetAllAsync();
        Task<VehicleMake> AddAsync(VehicleMake entity);
        Task DeleteAsync(int id);
        Task<VehicleMake> UpdateAsync(VehicleMake entity);
        Task<VehicleMake> GetDetails(int id);
        Task<IPage<VehicleMake>> GetPagingVehicleMake(IPageInfo pageInfo);
    }
}
