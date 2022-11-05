using AutoMapper;
using Project.Common.Interfaces;
using Project.Models;
using Project.Models.Interfaces;
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
        private readonly IMapper _mapper;

        public VehicleMakeService(IVehicleMakeRepository vehicleMakeRepository,IMapper mapper)
        {
            _vehicleMakeRepository = vehicleMakeRepository;
            _mapper = mapper;
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

        public async Task<IPage<VehicleMake>> GetPagingVehicleMake(IPageInfo pageInfo)
        {
            List<VehicleMake> vehicleMakes = await _vehicleMakeRepository.GetAllAsync();


            if (!String.IsNullOrEmpty(pageInfo.Filter))
            {
                vehicleMakes = vehicleMakes.Where(x => x.MakeName.Contains(pageInfo.Filter)).ToList();
            }

            switch (pageInfo.SortOrder)
            {
                case "name":
                    vehicleMakes = vehicleMakes.OrderBy(x => x.MakeName).ToList();
                    break;
                case "abrv":
                    vehicleMakes = vehicleMakes.OrderBy(x => x.MakeAbrv).ToList();
                    break;
                default:
                    vehicleMakes = vehicleMakes.OrderBy(x => x.MakeName).ToList();
                    break;
            }

            int counter = vehicleMakes.Count();

            int allofPages = (int)Math.Ceiling(counter / (double)5);
            if (allofPages > 0)
                allofPages--;

            vehicleMakes = vehicleMakes.Skip(pageInfo.PgSize * pageInfo.PgIndex).Take(pageInfo.PgSize).ToList();

            var vehicles = _mapper.Map<List<VehicleMake>>(vehicleMakes);

            var make = new Page<VehicleMake>()
            {
                Items = vehicles.Cast<VehicleMake>().ToList(),
                PgIndex = pageInfo.PgIndex,
                NumOfPages = allofPages,
                Filter = pageInfo.Filter,
                SortOrder = pageInfo.SortOrder
            };

            return make;
        }

        public async Task<VehicleMake> UpdateAsync(VehicleMake entity)
        {
           return await _vehicleMakeRepository.UpdateAsync(entity);
        }
    }
}
