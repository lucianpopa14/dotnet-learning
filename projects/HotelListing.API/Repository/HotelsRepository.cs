using HotelListing.API.Contracts;
using HotelListing.API.Data;

namespace HotelListing.API.Repository
{
    public class HotelsRepository : GenericRepository<Hotel>, IHotelsRepository
    {
        public HotelsRepository(HotelListingDbContext context) : base(context)
        {

        }
        public Task<Hotel> AddAsync(Hotel entity)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(Hotel entity)
        {
            throw new NotImplementedException();
        }

        Task<List<Hotel>> IGenericRepository<Hotel>.GetAllAsync()
        {
            throw new NotImplementedException();
        }

        Task<Hotel> IGenericRepository<Hotel>.GetAsync(int? id)
        {
            throw new NotImplementedException();
        }
    }
}
