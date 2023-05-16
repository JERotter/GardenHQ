using System;
using GardenHQ.Data.Entities;
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

