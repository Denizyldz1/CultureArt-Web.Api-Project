using CultureArt.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CultureArt.Core.Repositories
{
	public interface IAddressDetailRepository : IGenericRepository<AddressDetail>
	{
		Task<List<AddressDetail>> GetAddressDetailWithCityAsync();
		Task<AddressDetail> GetSingleAddressDetailByIdWithCityAsync(int addressDetailId);
	}
}
