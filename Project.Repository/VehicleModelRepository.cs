using Microsoft.EntityFrameworkCore;
using Project.DAL;
using Project.Models;
using Project.Repository.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Repository
{
    public class VehicleModelRepository : IVehicleModelRepository
    {
        private readonly ProjectDbContext _context;

        public VehicleModelRepository(ProjectDbContext context)
        {
            _context = context;
        }
        public async Task<VehicleModel> AddAsync(VehicleModel entity)
        {
            await _context.AddAsync(entity);
            await _context.SaveChangesAsync();
            return entity;
        }

        public async Task DeleteAsync(int id)
        {
            var entity = await GetAsync(id);
            _context.Set<VehicleModel>().Remove(entity);
            await _context.SaveChangesAsync();
        }
        public async Task<List<VehicleModel>> GetAllAsync()
        {
            return await _context.Set<VehicleModel>().ToListAsync();
        }

        public async Task<VehicleModel> GetAsync(int? id)
        {
            if (id is null)
            {
                return null;
            }

            return await _context.Set<VehicleModel>().FindAsync(id);
        }

        public async Task<VehicleModel> UpdateAsync(VehicleModel entity)
        {
            _context.Update(entity);
            await _context.SaveChangesAsync();
            return entity;
        }
    }
}
