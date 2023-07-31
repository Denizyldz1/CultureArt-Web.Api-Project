using CultureArt.Core.Entities;
using CultureArt.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CultureArt.Data.Repositories
{
    public class PublisherEventRepository : IPublisherEventRepository<PublisherEvent>
    {
        private readonly AppDbContext _appDbContext;

        public PublisherEventRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public void RemoveRange(IEnumerable<PublisherEvent> entities)
        {
            _appDbContext.Set<PublisherEvent>().RemoveRange(entities);
            _appDbContext.SaveChanges();
        }
    }
}
