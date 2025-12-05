using HotelListing.API.Contracts;
using HotelListing.API.Data;
using Microsoft.EntityFrameworkCore;

namespace HotelListing.API.Repository
{
    public class CountriesRepository : ICountriesRepository, IGenericRepository<Country>
    {
        private readonly HotelListingDbContext _context;

        public CountriesRepository(HotelListingDbContext context)
        {
            this._context = context;
        }
        public Task<Country> AddAsync(Country entity)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Exists(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<Country>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Country> GetAsync(int? id)
        {
            throw new NotImplementedException();
        }

        public async Task<Country> GetDetails(int id)
        {
            return await _context.Countries.Include(q => q.Hotels)
                .FirstOrDefaultAsync(q => q.Id == id);
        }

        public Task UpdateAsync(Country entity)
        {
            throw new NotImplementedException();
        }
    }
}
