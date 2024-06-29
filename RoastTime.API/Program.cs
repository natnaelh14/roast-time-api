using RoastTime.API.Data;
using Microsoft.EntityFrameworkCore;
using RoastTime.API.Mappings;
using RoastTime.API.Repositories;

var builder = WebApplication.CreateBuilder(args);

// var logger = new LoggerConfiguration()
//     .WriteTo.Console()
//     .WriteTo.File("Logs/RoastTime_Log.txt", rollingInterval: RollingInterval.Minute)
//     .MinimumLevel.Warning()
//     .CreateLogger();

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//We are injecting the connection string from the appsettings.json file to the DbContext
builder.Services.AddDbContext<RoastTimeDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("RoastTimeConnectionString")));

builder.Services.AddScoped<IRestaurantRepository, SQLRestaurantRepository>();

builder.Services.AddAutoMapper(typeof(AutoMapperProfiles));

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

