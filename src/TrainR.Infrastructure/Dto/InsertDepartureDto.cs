using System;

namespace TrainR.Infrastructure.Dto
{
    public class InsertDepartureDto
    {
        public int ConnectionId { get; set; }
        public string Time { get; set; }
        public int TravelTime { get; set; }
        public InsertDepartureDto(int connectionId, string time, int travelTime)
        {
            ConnectionId = connectionId;
            Time = time;
            TravelTime = travelTime;
        }

    }
}