using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Application.RepositoryInterfaces;
using Domain.Entities.Models;

namespace Infrastructure.Repositories
{
    public class FacilityRepository : IFacilityRepository
    {
        private readonly BookMyCampDbContext _dbContext;

        public FacilityRepository(BookMyCampDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task CreateFacilityAsync (Facility facility)
        {
            await _dbContext.Facilities.AddAsync (facility);
            await _dbContext.SaveChangesAsync();
        }

        public async Task<Facility?> GetFacilityByIdAsyc (int id)
        {
            return await _dbContext.Facilities.FindAsync (id);

        }

        public async Task<int> UpdateFacilityAsync (Facility facility)
        {
             _dbContext.Facilities.Update(facility);

            int result;

           return result =  await _dbContext.SaveChangesAsync();

        }
    }
}
