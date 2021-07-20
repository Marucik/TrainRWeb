using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using TrainR.Core.Interfaces;

namespace TrainR.Infrastructure.Database.Entities.TimeTable
{
  public class Train : ITrain
  {
    public int? Id { get; set; }
    public string Name { get; set; }

    [InverseProperty("Train")]
    public ICollection<Connection> TrainId { get; set; }
  }
}