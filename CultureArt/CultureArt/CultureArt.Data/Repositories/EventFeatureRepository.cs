using CultureArt.Core.Entities;
using CultureArt.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CultureArt.Data.Repositories
{
	public class EventFeatureRepository : GenericRepository<EventFeature>, IEventFeatureRepository
	{
		public EventFeatureRepository(AppDbContext context) : base(context)
		{
		}
	}
}
