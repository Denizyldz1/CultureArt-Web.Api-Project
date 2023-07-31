using CultureArt.Core.Entities;
using CultureArt.Core.Repositories;
using Microsoft.EntityFrameworkCore;

namespace CultureArt.Data.Repositories
{
	public class CityRepository : GenericRepository<City>, ICityRepository
	{
		public CityRepository(AppDbContext context) : base(context)
		{
		}

		public async Task<City?> GetSingleCityByIdWithAddressDetailAsync(int cityId)
		{
			return await _context.Cities
				.Include(x=>x.AddressDetails)
				.Where(x=>x.Id == cityId)
				.SingleOrDefaultAsync();
		}

		public async Task<City?> GetSingleCityByIdWithEventAsync(int cityId)
		{
			return await _context.Cities
				.Include(x => x.Events)
				.Where(x => x.Id == cityId)
				.SingleOrDefaultAsync();
		}
	}
}
