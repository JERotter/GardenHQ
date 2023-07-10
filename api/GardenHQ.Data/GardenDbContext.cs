using System;
using GardenHQ.Data.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace GardenHQ.Data;

public class GardenDbContext : DbContext
{
    public GardenDbContext(DbContextOptions options) : base(options)
    {
    }

    public DbSet<User> Users { get; set; }
    public DbSet<GardenTask> GardenTasks { get; set; }
    public DbSet<Address> Address { get; set; }
}

//public class GardenDbContext : IdentityDbContext<User, UserRoles, Guid>
//{
//	public GardenDbContext(DbContextOptions<GardenDbContext> options) : base(options)
//	{
//	}

//	public DbSet<User> Users { get; set; }
//	public DbSet<GardenTask> GardenTasks { get; set; }
//	public DbSet<Address> Address { get; set; }
//}

