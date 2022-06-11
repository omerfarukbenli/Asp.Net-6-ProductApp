using FluentValidation.AspNetCore;
using Microsoft.EntityFrameworkCore;
using ProductApp.Business.Abstract;
using ProductApp.Business.Concrete;
using ProductApp.Business.Validations;
using ProductApp.Data.Abstract;
using ProductApp.Data.Concrete;
using ProductApp.Data.Context;
using ProductApp.Entity.Mapping;
using System.Reflection;
using System.Text.Json.Serialization;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

// builder.Services.AddControllers();
builder.Services.AddControllers().AddJsonOptions(x =>
                x.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.IgnoreCycles);


builder.Services.AddControllers().AddFluentValidation(x => x.RegisterValidatorsFromAssemblyContaining<CreateProductValidator>());
builder.Services.AddControllers().AddFluentValidation(x => x.RegisterValidatorsFromAssemblyContaining<CreateSparepartValidator>());


// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();





builder.Services.AddDbContext<ProductAppContext>(x =>
{
    x.UseSqlServer(builder.Configuration.GetConnectionString("SqlServer"), option =>
    {
        option.MigrationsAssembly(Assembly.GetAssembly(typeof(ProductAppContext)).GetName().Name);
    });
});

builder.Services.AddAutoMapper(typeof(MapProfile)); //mapin yapýldýðý yer
builder.Services.AddScoped<IUnitOfWork, UnitOfWork>();
builder.Services.AddScoped(typeof(IGenericRepository<>), typeof(GenericRepository<>));
builder.Services.AddScoped(typeof(IService<>), typeof(Service<>));
builder.Services.AddScoped<ISparepartRepository, SparepartRepository>();
builder.Services.AddScoped<ISparepartService, SparepartService>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
