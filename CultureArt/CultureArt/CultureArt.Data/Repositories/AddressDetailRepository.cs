using CultureArt.Core.Entities;
using CultureArt.Core.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CultureArt.Data.Repositories
{
	public class AddressDetailRepository : GenericRepository<AddressDetail>, IAddressDetailRepository
	{
		public AddressDetailRepository(AppDbContext context) : base(context)
		{
		}

		public async Task<List<AddressDetail>> GetAddressDetailWithCityAsync()
		{
			return await _context.AddressDetails.Include(a => a.City).ToListAsync();
 		}

		public async Task<AddressDetail?> GetSingleAddressDetailByIdWithCityAsync(int addressDetailId)
		{
			return await _context.AddressDetails
				.Include(x => x.City)
				.Where(x => x.Id == addressDetailId)
				.SingleOrDefaultAsync();
		}
	}
}
