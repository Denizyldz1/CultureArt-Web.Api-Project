using CultureArt.Core.UnitOfWorks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CultureArt.Data.UnitOfWork
{
	public class UnitOfwork : IUnitOfWork
	{
		private readonly AppDbContext _context;

		public UnitOfwork(AppDbContext context)
		{
			_context = context;
		}

		public void Commit()
		{
			_context.SaveChanges();
		}

		public async Task CommitAsync()
		{
			await _context.SaveChangesAsync();
		}
	}
}
