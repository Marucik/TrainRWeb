using System;

namespace TrainR.Core.Interfaces
{
  public interface IDeparture
  {
    public int? Id { get; set; }
    public int ConnectionId { get; set; }
    public TimeSpan Time { get; set; }
    public int TravelTime { get; set; }
  }
}