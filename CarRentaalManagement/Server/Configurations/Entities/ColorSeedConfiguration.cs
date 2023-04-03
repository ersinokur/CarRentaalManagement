using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CarRentaalManagement.Server.Configurations.Entities;

public class ColorSeedConfiguration : IEntityTypeConfiguration<Colour>
{
    public void Configure(EntityTypeBuilder<Colour> builder)
    {
        builder.HasData(
             new Colour
             {
                 Id = 1,
                 CreatedBy = "System",
                 DataCreated = DateTime.Now,
                 DataUpdated = DateTime.Now,
                 Name = "Black",
                 UpdatedBy = "System"
             },
              new Colour
              {
                  Id = 2,
                  CreatedBy = "System",
                  DataCreated = DateTime.Now,
                  DataUpdated = DateTime.Now,
                  Name = "Blue",
                  UpdatedBy = "System"
              }

             );
    }
}
