using System;

namespace TrainR.Infrastructure.Dto
{
    public class DepartureDto
    {
        public int? Id { get; set; }
        public int ConnectionId { get; set; }
        public TimeSpan Time { get; set; }
        public int TravelTime { get; set; }
    }
}