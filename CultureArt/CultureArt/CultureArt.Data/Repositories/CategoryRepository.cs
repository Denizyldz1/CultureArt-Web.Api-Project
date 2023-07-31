using CultureArt.Core.Entities;
using CultureArt.Core.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace CultureArt.Data.Repositories
{
	public class CategoryRepository : GenericRepository<Category>, ICategoryRepository
	{
		public CategoryRepository(AppDbContext context) : base(context)
		{
		}

		public async Task<Category?> GetSingleCategoryByIdWithEventAsync(int categoryId)
		{
			return await _context.Categories
				.Include(x => x.Events)
				.Where(x => x.Id == categoryId)
				.SingleOrDefaultAsync();
		}
	}
}
