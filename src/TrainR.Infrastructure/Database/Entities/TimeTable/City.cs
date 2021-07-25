using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace TrainR.Infrastructure.Database.Entities.TimeTable
{
    public class City
    {
        public int? Id { get; set; }
        public string Name { get; set; }
        [InverseProperty("Start")]
        public ICollection<Connection> StartId { get; set; }
        [InverseProperty("Destination")]
        public ICollection<Connection> DestinationId { get; set; }
    }
}