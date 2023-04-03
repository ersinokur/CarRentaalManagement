using System.ComponentModel.DataAnnotations;

namespace CarRentaalManagement.Shared.Domain;

public abstract  class BaseDomainModel
{   
    public int Id { get; set; }
    public string? CreatedBy { get; set; }
    public string? UpdatedBy { get; set; }
    public DateTime DataCreated { get; set; }
    public DateTime DataUpdated { get; set; }

}
