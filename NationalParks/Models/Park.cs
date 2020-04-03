using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace NationalParks.Models
{
  public class Park
  {
    public int ParkId { get; set; }
    public string Name { get; set; }
    public string City { get; set; }
    public string State { get; set; }
    public string Description { get; set; }
    public int ClimbingRoutes { get; set; }
    public int Campgrounds { get; set; }
    public int GeneralStores { get; set; }
  }
}