using AutoMapper;
using GardenHQ.Core.Services;
using GardenHQ.Data;
using GardenHQ.Data.Profiles;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

//for testing
ConfigureServices(builder.Services);

// Add services to the container.
builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddScoped<UsersService, UsersService>();
builder.Services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();

string postgresConnectionString = string.Empty;

postgresConnectionString = builder.Configuration.GetConnectionString("DefaultConnection");
builder.Services.AddDbContext<GardenDbContext>(options =>
{
    options.UseNpgsql(postgresConnectionString);
});
//string postgresConnectionString = builder.Configuration.GetConnectionString("DefaultConnection");
//builder.Services.AddDbContext<GardenDbContext>(options =>
//{
//    options.UseNpgsql(postgresConnectionString);
//});

var config = new MapperConfiguration(options =>
{
    options.AddProfile(new MappingProfiles());
});

builder.Services.AddSingleton(config.CreateMapper());

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

/// <summary>
/// For testing
/// https://www.youtube.com/watch?v=ULJ3UEezisw&list=TLPQMjgxMDIwMjLsXaHKig8_jw&index=1&ab_channel=WesDoyle
/// ~34:00mins
/// </summary>
void ConfigureServices(IServiceCollection services)
{
    services.AddTransient<IUsersService, UsersService>();
}
