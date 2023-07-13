using System;
using GardenHQ.Data.Entities;
using GardenHQ.Data.EntityConfig;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using static System.Net.Mime.MediaTypeNames;

namespace GardenHQ.Data;


public class GardenDbContext : IdentityDbContext<User, UserTypes, Guid>
{
    public GardenDbContext(DbContextOptions<GardenDbContext> options) : base(options)
    {
    }

    public DbSet<GardenTask> GardenTasks { get; set; }
    public DbSet<Address> Address { get; set; }


    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.ApplyConfiguration(new AppIdentityUserTypeConfig());
        modelBuilder.ApplyConfiguration(new AppIdentityUserConfig());
    }
}