using System;
using TrainR.Core.Interfaces;

namespace TrainR.Infrastructure.Database.Entities.TimeTable
{
  public class Departure : IDeparture
  {
    public int? Id { get; set; }
    public int ConnectionId { get; set; }
    public TimeSpan Time { get; set; }
    public int TravelTime { get; set; }
    public Connection Connection { get; set; }
  }
}