using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace CultureArt.Core.Services
{
	public interface IBaseService<T>
	{
		Task<bool> AnyAsync(Expression<Func<T, bool>> expression);
	}
}
