using Microsoft.AspNetCore.Identity;

namespace CarRentaalManagement.Server.Models;

public class ApplicationUser : IdentityUser
{
    //buraya tarih vb gibi AspNetUser tablosunda bulunmasini istedigin herseyi ekleyebilirsin.
    public string? FirstName { get; set; }
    public string? LastName { get; set; }
}