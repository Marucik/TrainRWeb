using System;

namespace TrainR.Infrastructure.Dto
{
    public class DepartureEntryDto
    {
        public string From { get; set; }
        public string To { get; set; }
        public string Departure { get; set; }
        public int TravelTime { get; set; }
        public string Train { get; set; }
        public DepartureEntryDto(string from, string to, string departure, int travelTime, string train)
        {
            From = from;
            To = to;
            Departure = departure;
            TravelTime = travelTime;
            Train = train;
        }
    }
}