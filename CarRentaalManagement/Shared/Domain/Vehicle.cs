﻿namespace CarRentaalManagement.Shared.Domain;

public  class Vehicle: BaseDomainModel
{
    public int Year { get; set; }
    public int ModelId { get; set; }   
    public int MakeId { get; set; }
    public int ColourId { get; set; }
    public string Vin { get; set; }
    public string LicensePlateNumber { get; set; }
    public double RentalRate { get; set; }


    //navigation properties  // inner join vb.
    public virtual Model Model { get; set; }
    public virtual Make Make { get; set; }
    public virtual Colour Colour { get; set; }
    public virtual  List<Booking> Bookings { get; set; }

}
