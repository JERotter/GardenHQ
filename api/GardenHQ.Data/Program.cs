using GardenHQ.Data;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

//builder.Services.AddControllers();
//// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
//builder.Services.AddEndpointsApiExplorer();
//builder.Services.AddSwaggerGen();

string postgresConnectionString = string.Empty;
postgresConnectionString = builder.Configuration.GetConnectionString("DefaultConnection");

builder.Services.AddDbContext<GardenDbContext>(options => {
    options.UseNpgsql(postgresConnectionString);
});

var app = builder.Build();

app.Run();

