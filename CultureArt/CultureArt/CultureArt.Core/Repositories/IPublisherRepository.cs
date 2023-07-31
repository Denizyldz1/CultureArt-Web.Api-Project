using CultureArt.Core.Entities.CultureArt.Core.Entities;

namespace CultureArt.Core.Repositories
{
	public interface IPublisherRepository : IGenericRepository<Publisher>
	{
		Task<Publisher> GetSinglePublisherByIdWithEventAsync(int publisherId);

	}
}
