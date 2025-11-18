using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Application.RepositoryInterfaces;
using Domain.Entities.Models;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Repositories
{
    public class FacilityRepository : IFacilityRepository
    {
        private readonly BookMyCampDbContext _dbContext;

        public FacilityRepository(BookMyCampDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<int> CreateFacilityAsync (Facility facility)
        {

            int result;
            await _dbContext.Facilities.AddAsync (facility);
            
            return result = await _dbContext.SaveChangesAsync();
        }

        public async Task<Facility?> GetFacilityByIdAsyc (int id)
        {
            return await _dbContext.Facilities.FindAsync (id);

        }

        public async Task<List<Facility>> GetAllFacilitiesAsync()
        {
            return await _dbContext.Facilities.ToListAsync();
        }


        public async Task<int> UpdateFacilityAsync (Facility facility)
        {
            int result;

            _dbContext.Facilities.Update(facility);

           return result =  await _dbContext.SaveChangesAsync();

        }

        public async Task<int> DeleteFacilityAsync (Facility facility)
        {
            int result;

            _dbContext.Facilities.Remove(facility);

            return result = await _dbContext.SaveChangesAsync();
        }
    }
}
