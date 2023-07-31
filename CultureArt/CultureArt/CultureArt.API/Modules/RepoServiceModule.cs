using Autofac;
using CultureArt.Core.Repositories;
using CultureArt.Core.Services;
using CultureArt.Core.UnitOfWorks;
using CultureArt.Data;
using CultureArt.Data.Repositories;
using CultureArt.Data.UnitOfWork;
using CultureArt.Service.Mapping;
using CultureArt.Service.Services;
using System.Reflection;
using Module = Autofac.Module;

namespace CultureArt.API.Modules
{
	public class RepoServiceModule : Module
	{
		protected override void Load(ContainerBuilder builder)
		{
			builder.RegisterGeneric(typeof(GenericRepository<>))
				.As(typeof(IGenericRepository<>));
			builder.RegisterGeneric(typeof(Service<,>))
				.As(typeof(IService<,>));
			builder.RegisterType<UnitOfwork>()
				.As<IUnitOfWork>();

			// Bulunduğumuz Assembly
			var apiAssembly = Assembly.GetExecutingAssembly();
			// Data Katmanından bir üye 
			var repoAssembly = Assembly.GetAssembly(typeof(AppDbContext));
			// Service katmanı için
			var serviceAssembly = Assembly.GetAssembly(typeof(MapProfile));

			builder.RegisterAssemblyTypes(apiAssembly, repoAssembly, serviceAssembly)
				.Where(x => x.Name.EndsWith("Repository"))
				.AsImplementedInterfaces()
				.InstancePerLifetimeScope();
			builder.RegisterAssemblyTypes(apiAssembly, repoAssembly, serviceAssembly)
				.Where(x => x.Name.EndsWith("Service"))
				.AsImplementedInterfaces()
				.InstancePerLifetimeScope();
		}
	}
}
