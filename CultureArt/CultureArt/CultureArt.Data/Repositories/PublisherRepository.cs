using CultureArt.Core.Entities;
using CultureArt.Core.Entities.CultureArt.Core.Entities;
using CultureArt.Core.Repositories;
using Microsoft.EntityFrameworkCore;

namespace CultureArt.Data.Repositories
{
    public class PublisherRepository : GenericRepository<Publisher>, IPublisherRepository
	{
		public PublisherRepository(AppDbContext context) : base(context)
		{
		}


		public async Task<Publisher?> GetSinglePublisherByIdWithEventAsync(int publisherId)
		{
			var values = await _context.Publishers
                .Include(x => x.Events)
                    .ThenInclude(x => x.Event)
                    .ThenInclude(x => x.Category)
               .Include(x => x.Events)
                    .ThenInclude(x => x.Event)
                    .ThenInclude(x => x.AddressDetail)
                    .ThenInclude(x=>x.City)
                .Where(x => x.Id == publisherId)
                .SingleOrDefaultAsync();
			return values;

        }
	}
}
