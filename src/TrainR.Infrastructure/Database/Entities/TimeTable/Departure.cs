using System;
using System.ComponentModel.DataAnnotations.Schema;
using TrainR.Infrastructure.Dto;

namespace TrainR.Infrastructure.Database.Entities.TimeTable
{
    public class Departure
    {
        public int? Id { get; set; }
        public int ConnectionId { get; set; }
        public TimeSpan Time { get; set; }
        public int TravelTime { get; set; }

        [ForeignKey("ConnectionId")]
        public Connection Connection { get; set; }
    }
}