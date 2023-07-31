using CultureArt.Core.Repositories;
using CultureArt.Core.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CultureArt.Service.Services
{
	public class BaseService<T> : IBaseService<T>  where T : class
	{
		private readonly IGenericRepository<T> _repository;

		public BaseService(IGenericRepository<T> repository)
		{
			_repository = repository;
		}

		public async Task<bool> AnyAsync(System.Linq.Expressions.Expression<Func<T, bool>> expression)
		{
			return await _repository.AnyAsync(expression);
		}
	}
}
