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
    public class VehicleMakeRepository : IVehicleMakeRepository
    {
        private readonly ProjectDbContext _context;

        public VehicleMakeRepository(ProjectDbContext context)
        {
            _context = context;
        }
        public async Task<VehicleMake> AddAsync(VehicleMake entity)
        {
            await _context.AddAsync(entity);
            await _context.SaveChangesAsync();
            return entity;
        }

        public async Task DeleteAsync(int id)
        {
            var entity=await GetAsync(id);
            _context.Set<VehicleMake>().Remove(entity);
            await _context.SaveChangesAsync();
        }

        public async Task<List<VehicleMake>> GetAllAsync()
        {
            return await _context.Set<VehicleMake>().ToListAsync();
        }

        public async Task<VehicleMake> GetAsync(int? id)
        {
            return await _context.Set<VehicleMake>().FindAsync(id);
        }

        public async Task<VehicleMake> GetDetails(int id)
        {
            return await _context.VehicleMakes.Include(q => q.VehicleModels)
                .FirstOrDefaultAsync(q => q.Id == id);
        }

        public async Task<VehicleMake> UpdateAsync(VehicleMake entity)
        {
            _context.Update(entity);
            await _context.SaveChangesAsync();
            return entity;
        }
    }
}
