using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CarRentaalManagement.Server.Configurations.Entities;

public class RoleSeedConfiguration : IEntityTypeConfiguration<IdentityRole>
{
    public void Configure(EntityTypeBuilder<IdentityRole> builder)
    {
        builder.HasData(

                new IdentityRole
                {
                    Id = "7377a19a-1e1a-4911-9670-f98176f86c35",//Guid.NewGuid().ToString(),
                    Name = "User",
                    NormalizedName = "USER"
                },
                 new IdentityRole
                 {
                     Id = "e80c51ef-5797-47ee-813a-a8deca800085",
                     Name = "Administrator",
                     NormalizedName = "ADMINISTRATOR"
                 }


            ); ; ;
    }
}
