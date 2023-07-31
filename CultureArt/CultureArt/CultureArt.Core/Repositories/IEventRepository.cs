using CultureArt.Core.Entities;
using CultureArt.Core.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CultureArt.Core.Repositories
{
	public interface IEventRepository : IGenericRepository<Event>
	{
		//Task<List<Event>> GetEventWithEventFeatureAsync();
		Task<Event> GetSingleEventByIdWithAllConnectionEntitiesAsync(int eventId);
		Task ChanceStatus(int eventId, EventStatus status);
	}
}
