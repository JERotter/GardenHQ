using System;
using GardenHQ.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GardenHQ.Data.EntityConfig;

public class AppIdentityUserTypeConfig : IEntityTypeConfiguration<UserTypes>
{
    public void Configure(EntityTypeBuilder<UserTypes> builder)
    {
        builder.HasData
        (
            new UserTypes
            {
                Id = Guid.Parse("34051d90-abc8-43b2-a5c3-7f7985bf500f"),
                Name = "Admin",
                NormalizedName = "ADMIN",
                ConcurrencyStamp = "74938dcc-12a7-4a4f-a45b-6415472da842"
            },
            new UserTypes
            {
                Id = Guid.Parse("3825428b-c2fd-4aa9-aab5-135047c31578"),
                Name = "Manager",
                NormalizedName = "MANAGER",
                ConcurrencyStamp = "5f5d6120-6577-4330-a1af-7e2648d21442"
            },
            new UserTypes
            {
                Id = Guid.Parse("5da49aa7-2582-446e-87ad-dc630abd4a41"),
                Name = "Volunteer",
                NormalizedName = "VOLUNTEER",
                ConcurrencyStamp = "40315a27-1ad4-459c-8001-eb2f8814e6ac"
            },
            new UserTypes
            {
                Id = Guid.Parse("21180936-6923-479b-a46a-bbd4e548adc6"),
                Name = "Permanent",
                NormalizedName = "PERMANENT",
                ConcurrencyStamp = "d8e6b69d-11a9-4e23-96e6-ee6ed5529d41"
            },
            new UserTypes
            {
                Id = Guid.Parse("80273374-fb7b-49ea-a880-37e2635de69e"),
                Name = "Seasonal",
                NormalizedName = "SEASONAL",
                ConcurrencyStamp = "d45c9642-1156-407d-8204-a885e367397f"
            }
        );
    }
}
