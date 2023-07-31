using CultureArt.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CultureArt.Core.Repositories
{
	public interface ICityRepository : IGenericRepository<City>
	{
		Task<City> GetSingleCityByIdWithAddressDetailAsync(int cityId);
		Task<City> GetSingleCityByIdWithEventAsync(int cityId);
	}
}
