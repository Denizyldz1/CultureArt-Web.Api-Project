using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CultureArt.Core.UnitOfWorks
{
	public interface IUnitOfWork
	{
		// Bu katmanda SaveChanges() ve SaveChangesAsync() methotlarını kontrol ediyoruz.

		Task CommitAsync();
		void Commit();
	}
}
