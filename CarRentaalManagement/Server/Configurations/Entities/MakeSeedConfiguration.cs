using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CarRentaalManagement.Server.Configurations.Entities;

public class MakeSeedConfiguration : IEntityTypeConfiguration<Make>
{
    public void Configure(EntityTypeBuilder<Make> builder)
    {
        builder.HasData(
            new Make
            {
                Id = 1,
                CreatedBy = "System",
                UpdatedBy = "System",
                DateCreated = DateTime.Now,
                DateUpdated = DateTime.Now,
                Name = "Opel",
            },

             new Make
             {
                 Id = 2,
                 CreatedBy = "System",
                 UpdatedBy = "System",
                 DateCreated = DateTime.Now,
                 DateUpdated = DateTime.Now,
                 Name = "Toyata",
             }

            );
    }
}
