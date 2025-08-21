using Microsoft.EntityFrameworkCore;
using Products.Api.DataBase;
using Products.Api.Repository;
using Products.Api.Services;
var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddDbContext<AppDbContext>(op =>op.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

//Repo
builder.Services.AddScoped<ProductRepository>();
builder.Services.AddScoped<ProductGroupRepository>();
builder.Services.AddScoped<CurrencyRepository>();
builder.Services.AddScoped<BarcodeRepository>();
builder.Services.AddScoped<SecurityKeyRepository>();
builder.Services.AddScoped<ProductCommentRepository>();
builder.Services.AddScoped<TaxRepository>();

//service
builder.Services.AddScoped<CurrencyService>();
builder.Services.AddScoped<BarcodeService>();
builder.Services.AddScoped<ProductCommentsService>();
builder.Services.AddScoped<ProductService>();
builder.Services.AddScoped<ProductGroupService>();
builder.Services.AddScoped<SecurityKeyService>();

builder.Services.AddMediatR(cfg => cfg.RegisterServicesFromAssembly(typeof(Program).Assembly));
///////////////////////////////////////////////////////
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

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
