using Project.Models;
using Project.Repository.Common;
using Project.Service.Common;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Service
{
    public class VehicleMakeService : IVehicleMakeService
    {
        protected readonly IVehicleMakeRepository _vehicleMakeRepository;

        public VehicleMakeService(IVehicleMakeRepository vehicleMakeRepository)
        {
            _vehicleMakeRepository = vehicleMakeRepository;
        }
        public async Task<VehicleMake> AddAsync(VehicleMake entity)
        {
            return await _vehicleMakeRepository.AddAsync(entity);
        }

        public async Task DeleteAsync(int id)
        {
            await _vehicleMakeRepository.DeleteAsync(id);
        }

        public async Task<List<VehicleMake>> GetAllAsync()
        {
            return await _vehicleMakeRepository.GetAllAsync();
        }

        public async Task<VehicleMake> GetAsync(int? id)
        {
            return await _vehicleMakeRepository.GetAsync(id);
        }

        public async Task<VehicleMake> GetDetails(int id)
        {
            return await _vehicleMakeRepository.GetDetails(id);
        }

        public async Task<VehicleMake> UpdateAsync(VehicleMake entity)
        {
           return await _vehicleMakeRepository.UpdateAsync(entity);
        }
    }
}
