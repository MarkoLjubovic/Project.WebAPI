using Project.Models;
using Project.Repository.Common;
using Project.Service.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Service
{
    public class VehicleModelService : IVehicleModelService
    {
        protected readonly IVehicleModelRepository _vehicleModelRepository;

        public VehicleModelService(IVehicleModelRepository vehicleModelRepository)
        {
            _vehicleModelRepository = vehicleModelRepository;
        }
        public async Task<VehicleModel> AddAsync(VehicleModel entity)
        {
            return await _vehicleModelRepository.AddAsync(entity);
        }

        public async Task DeleteAsync(int id)
        {
            await _vehicleModelRepository.DeleteAsync(id);
        }

        public async Task<List<VehicleModel>> GetAllAsync()
        {
            return await _vehicleModelRepository.GetAllAsync();
        }

        public async Task<VehicleModel> GetAsync(int? id)
        {
            return await _vehicleModelRepository.GetAsync(id);
        }

        public async Task<VehicleModel> UpdateAsync(VehicleModel entity)
        {
            return await _vehicleModelRepository.UpdateAsync(entity);
        }
    }
}
