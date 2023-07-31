using CultureArt.Core.Entities;

namespace CultureArt.Core.Repositories
{
    public interface IPublisherEventRepository<T> where T : class
    {
        void RemoveRange(IEnumerable<T> entities);
    }
}
