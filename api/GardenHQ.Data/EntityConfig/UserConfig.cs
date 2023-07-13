using System;
using System.ComponentModel.DataAnnotations;
using GardenHQ.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GardenHQ.Data.EntityConfig;

public class AppIdentityUserConfig : IEntityTypeConfiguration<User>
{
    public void Configure(EntityTypeBuilder<User> builder)
    {
        builder.HasData
        (
            new User
            {
                Id = Guid.Parse("6a87f69b-5fcd-4863-a0da-57a2b01a5802"),
                AbbreviatedId = "6a87",
                UserName = "DemoUser",
                Email = "DemoUser.test@gardenHQ.org",
                NormalizedEmail = "DemoUser.test@gardenHQ.org".ToUpper(),
                NormalizedUserName = "DEMOUSER",
                TwoFactorEnabled = false,
                EmailConfirmed = true,
                DateOfBirth = "5/9/1998",
                Status = UserStatus.Inactive,
                AssignedTasks = null,
                CreatedBy = Guid.Empty,
                CreatedOn = DateTime.UnixEpoch,
                LastUpdatedBy = Guid.Empty,
                LastUpdated = DateTime.UnixEpoch,
                PhoneNumber = "987654321",
                PhoneNumberConfirmed = true,
                FirstName = "Demo",
                LastName = "User",
                ConcurrencyStamp = "a4bf66f9-ff47-47ac-ab36-378ccdf9171a",
                SecurityStamp = "0ccb92b4-a725-4140-8a57-7a55c25384aa"

            });

        builder.OwnsOne(e => e.Address).HasData(new Address
        {
            Id = Guid.Parse("e983bae4-d56c-4a46-88fa-9199c3c462ed"),
            StreetAddress = "123 four st",
            StreetAddressLine2 = null,
            City = "CityTowneShire",
            Country = "United States",
            ZipCode = "12345",
            State = "HI",
            CreatedBy = new Guid(),
            LastUpdatedBy = new Guid(),
            CreatedOn = DateTime.UnixEpoch,
            LastUpdated = DateTime.UnixEpoch,
            UserId = Guid.Parse("6a87f69b-5fcd-4863-a0da-57a2b01a5802")
        });

    }
}


