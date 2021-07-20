using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using TrainR.Core.Interfaces;

namespace TrainR.Infrastructure.Database.Entities.TimeTable
{
  public class Connection : IConnection
  {
    public int? Id { get; set; }
    public int StartId { get; set; }
    public int DestinationId { get; set; }
    public int TrainId { get; set; }

    public City Start { get; set; }
    public City Destination { get; set; }
    public Train Train { get; set; }

    [InverseProperty("Connection")]
    public ICollection<Departure> ConnectionID { get; set; }
  }
}