using Autofac;
using Autofac.Extensions.DependencyInjection;
using CultureArt.API.Filters;
using CultureArt.API.Middlewares;
using CultureArt.API.Modules;
using CultureArt.Core.Repositories;
using CultureArt.Data;
using CultureArt.Service.Mapping;
using CultureArt.Service.Validations.AddressDetailValidator;
using FluentValidation.AspNetCore;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
#pragma warning disable CS0618 // Type or member is obsolete
builder.Services.AddControllers(opt =>
							   opt.Filters.Add(new ValidateFilterAttribute())).AddFluentValidation(x =>
							   x.RegisterValidatorsFromAssemblyContaining<CreateAddressDetailValidator>());

// Burada sistemin model d�n�� sistemini baskl�yoruz ��nk� kendi modelimizi olu�turduk.
// MVC taraf�nda bunu yazmam�za gerek yok sadece API taraf�nda default'da aktif geliyor. ��nk� MVC'de sayfa d�n�yoruz ve hangi sayfa d�nce�ini default'da veremez.
builder.Services.Configure<ApiBehaviorOptions>(x =>
{
	x.SuppressModelStateInvalidFilter = true;
});

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddScoped(typeof(NotFoundFilter<>));
builder.Services.AddAutoMapper(typeof(MapProfile));



builder.Services.AddDbContext<AppDbContext>(x =>
{
	x.UseSqlServer(builder.Configuration.GetConnectionString("SqlConnection"), opt =>
	{
		opt.MigrationsAssembly(Assembly.GetAssembly(typeof(AppDbContext)).GetName().Name);
	});
});

builder.Host.UseServiceProviderFactory(
	new AutofacServiceProviderFactory());
builder.Host.ConfigureContainer<ContainerBuilder>(containerBuilder =>
containerBuilder.RegisterModule(new RepoServiceModule()));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
	app.UseSwagger();
	app.UseSwaggerUI();
}

app.UseHttpsRedirection();
// Exception i�in ekledik
app.UseCustomException();
app.UseAuthorization();

app.MapControllers();

app.Run();
