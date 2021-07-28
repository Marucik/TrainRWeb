namespace TrainR.Infrastructure.Dto
{
    public class ConnectionDto
    {
        public int ConnectionId { get; set; }
        public string Start { get; set; }
        public string Destination { get; set; }
        public string TrainType { get; set; }
        public ConnectionDto(string start, string destination, string trainType, int connectionId)
        {
            Start = start;
            Destination = destination;
            TrainType = trainType;
            ConnectionId = connectionId;
        }

    }
}