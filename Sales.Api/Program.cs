using Microsoft.EntityFrameworkCore;
using Sales.Api.DataBase;
using Sales.Api.Repository;
using Sales.Api.Services;
var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddDbContext<AppDbContext>(op => op.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

//Repo
builder.Services.AddScoped<CountryRepository>();
builder.Services.AddScoped<CustomerRepository>();

//Services
builder.Services.AddScoped<CountryService>();
builder.Services.AddScoped<CustomerService>();


builder.Services.AddMediatR(cfg => cfg.RegisterServicesFromAssembly(typeof(Program).Assembly));

builder.Services.AddControllers();
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
