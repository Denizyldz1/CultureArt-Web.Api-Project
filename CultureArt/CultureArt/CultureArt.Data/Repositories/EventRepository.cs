using CultureArt.Core.Entities;
using CultureArt.Core.Entities.CultureArt.Core.Entities;
using CultureArt.Core.Enums;
using CultureArt.Core.Repositories;
using Microsoft.EntityFrameworkCore;

namespace CultureArt.Data.Repositories
{
	public class EventRepository : GenericRepository<Event>, IEventRepository
	{
		public EventRepository(AppDbContext context) : base(context)
		{
		}

		public async Task ChanceStatus(int eventId,EventStatus status)
		{
			var value = await _context.Events.FindAsync(eventId);
			value.EventStatus = status;
		}
        public override  IQueryable<Event> GetAll()
        {
            //return base.GetAll();
			var values =  _context.Events
				.Include(x=>x.AddressDetail)
				.ThenInclude(x=>x.City)
				.Include(x=>x.Category)
				.AsNoTracking().AsQueryable();
			return values;

        }

        public async Task<Event?> GetSingleEventByIdWithAllConnectionEntitiesAsync(int eventId)
		{
			var eventItem = await _context.Events
		.Include(x => x.EventFeature)
		.Include(x => x.AddressDetail)
		.Include(x => x.Category)
		.Include(x => x.City)
		.Include(x=>x.Publishers)
		.ThenInclude(x=>x.Publisher)
		.Where(x => x.Id == eventId)
		.SingleOrDefaultAsync();
			if(eventItem.Publishers != null)
			{
                // Map'leme hatası için eklendi AutoMapper
                foreach (var item in eventItem.Publishers)
                {
                    item.Event = null;
					if(item.Publisher != null)
					{
                        item.Publisher.Events = null;
                    }

                }
            }
			return eventItem;

		}
	}
}
