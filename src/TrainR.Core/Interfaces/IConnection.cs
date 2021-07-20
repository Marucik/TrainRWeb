namespace TrainR.Core.Interfaces
{
  public interface IConnection
  {
    public int? Id { get; set; }
    public int StartId { get; set; }
    public int DestinationId { get; set; }
    public int TrainId { get; set; }

  }
}