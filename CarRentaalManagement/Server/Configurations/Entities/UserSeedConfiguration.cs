using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CarRentaalManagement.Server.Configurations.Entities;

public class UserSeedConfiguration : IEntityTypeConfiguration<ApplicationUser>
{
    public void Configure(EntityTypeBuilder<ApplicationUser> builder)
    {
        var hasher = new PasswordHasher<ApplicationUser>();

        builder.HasData(
            new ApplicationUser
            {
                Id = "6759a19a-1e1a-4911-9670-f98176f86cee",
                Email = "ersin.okur@gmail.com",
                NormalizedEmail = "ERSIN.OKUR@GMAIL.COM",
                FirstName = "Ersin",
                LastName = "Okur",
                UserName = "ersin.okur@gmail.com",
                NormalizedUserName = "ERSIN.OKUR@GMAIL.COM",
                PasswordHash = hasher.HashPassword(null, "Deneme123*.")
            },
            new ApplicationUser
            {
                Id = "e75c51ef-5797-47ee-813a-a8deca600c75",
                Email = "sefiluser@gmail.com",
                NormalizedEmail = "SEFILUSER@GMAIL.COM",
                FirstName = "System",
                LastName = "User",
                UserName = "sefiluser@gmail.com",
                NormalizedUserName = "SEFILUSER@GMAIL.COM",
                PasswordHash = hasher.HashPassword(null, "Merhaba123.")
            }

            );
    }
}
