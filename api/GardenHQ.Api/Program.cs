using System.Text;
using AutoMapper;
using GardenHQ.Common.Authentication;
using GardenHQ.Core.Services;
using GardenHQ.Data;
using GardenHQ.Data.Profiles;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;

var builder = WebApplication.CreateBuilder(args);

//for testing
ConfigureServices(builder.Services);

// Add services to the container.
builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddHealthChecks();

builder.Services.AddScoped<UsersService, UsersService>();
builder.Services.AddScoped<GardenTaskService, GardenTaskService>();
builder.Services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();

builder.Services.AddCors();

string postgresConnectionString = string.Empty;

postgresConnectionString = builder.Configuration.GetConnectionString("DefaultConnection");
builder.Services.AddDbContext<GardenDbContext>(options =>
{
    options.UseNpgsql(postgresConnectionString);
});

//https://www.youtube.com/watch?v=Y-MjCw6thao&list=TLPQMTEwNzIwMjNiW3NlgnSO1Q&index=2&ab_channel=MohamadLawand
builder.Services.Configure<JwtConfig>(builder.Configuration.GetSection(key: "JwtConfig"));

builder.Services.AddAuthentication(configureOptions: options =>
{
    options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
    options.DefaultScheme = JwtBearerDefaults.AuthenticationScheme;
    options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;

}).AddJwtBearer(jwt =>
{
    var key = Encoding.ASCII.GetBytes(builder.Configuration.GetSection(key: "jwtConfig:Secret").Value);

    jwt.SaveToken = true;
    jwt.TokenValidationParameters = new TokenValidationParameters()
    {
        ValidateIssuerSigningKey = true,
        IssuerSigningKey = new SymmetricSecurityKey(key),
        ValidateIssuer = false, //for dev
        ValidateAudience = false, // for dev
        RequireExpirationTime = false, //for dev
        ValidateLifetime = true
    };
});

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

app.UseCors(options =>
{
    options.WithOrigins("http://127.0.0.1:3000");

});

app.UseHttpsRedirection();
app.UseAuthentication();
app.UseAuthorization();
app.MapControllers();
app.MapHealthChecks("/api/healthcheck");
app.Run();

/// <summary>
/// For testing
/// https://www.youtube.com/watch?v=ULJ3UEezisw&list=TLPQMjgxMDIwMjLsXaHKig8_jw&index=1&ab_channel=WesDoyle
/// ~34:00mins
/// </summary>
void ConfigureServices(IServiceCollection services)
{
    services.AddTransient<IUsersService, UsersService>();
    services.AddTransient<IGardenTaskService, GardenTaskService>();
}
