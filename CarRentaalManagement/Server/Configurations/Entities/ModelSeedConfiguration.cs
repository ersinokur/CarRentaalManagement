using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CarRentaalManagement.Server.Configurations.Entities;
public class ModelSeedConfiguration : IEntityTypeConfiguration<Model>
{
    public void Configure(EntityTypeBuilder<Model> builder)
    {
        builder.HasData(
            new Model
            {
                Id = 1,
                CreatedBy = "System",
                UpdatedBy = "System",
                DataCreated = DateTime.Now,
                DataUpdated = DateTime.Now,
                Name = "Astra",
            },
              new Model
              {
                  Id=2,
                  CreatedBy = "System",
                  UpdatedBy = "System",
                  DataCreated = DateTime.Now,
                  DataUpdated = DateTime.Now,
                  Name = "Mokka",
              },
                new Model
                {
                    Id =3,
                    CreatedBy = "System",
                    UpdatedBy = "System",
                    DataCreated = DateTime.Now,
                    DataUpdated = DateTime.Now,
                    Name = "Coralla",
                },
                  new Model
                  {
                      Id =4,
                      CreatedBy = "System",
                      UpdatedBy = "System",
                      DataCreated = DateTime.Now,
                      DataUpdated = DateTime.Now,
                      Name = "Prius",
                  }
            );
    }
}

