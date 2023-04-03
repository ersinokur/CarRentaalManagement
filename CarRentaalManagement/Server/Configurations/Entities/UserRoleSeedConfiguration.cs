using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CarRentaalManagement.Server.Configurations.Entities;

public class UserRoleSeedConfiguration : IEntityTypeConfiguration<IdentityUserRole<string>>
{
    public void Configure(EntityTypeBuilder<IdentityUserRole<string>> builder)
    {
        builder.HasData(
            new IdentityUserRole<string>
            {
                //admin role
                RoleId = "7377a19a-1e1a-4911-9670-f98176f86c35",
                UserId = "6759a19a-1e1a-4911-9670-f98176f86cee",
            },
                 //user role
             new IdentityUserRole<string>
             {
                 RoleId = "e80c51ef-5797-47ee-813a-a8deca800085",
                 UserId = "e75c51ef-5797-47ee-813a-a8deca600c75",
             }
            );
    }
}
