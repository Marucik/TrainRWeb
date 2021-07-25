using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TrainR.Infrastructure.Database;
using TrainR.Infrastructure.Database.Entities.TimeTable;
using TrainR.Infrastructure.Dto;

namespace TrainR.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class DepartureController : ControllerBase
    {
        private readonly TimeTableContext _context;
        public DepartureController(TimeTableContext context)
        {
            _context = context;
        }

        [HttpGet]
        [Route("/departures/{startId}")]
        public IEnumerable<DepartureEntryDto> GetCities(int startId)
        {
            return _context.Departure.Include(b => b.Connection)
                                        .Include(c => c.Connection)
                                        .Where(q => q.Connection.StartId == startId)
                                        .Select(q => new DepartureEntryDto(q.Connection.Start.Name, q.Connection.Destination.Name, q.Time.ToString(), q.TravelTime, q.Connection.Train.Name))
                                        .ToList();
        }

        [HttpPost]
        [Route("/departures")]
        public ActionResult AddDeparture(InsertDepartureDto departure)
        {
            _context.Departure.Add(new Departure
            {
                Id = null,
                ConnectionId = departure.ConnectionId,
                Time = TimeSpan.Parse(departure.Time),
                TravelTime = departure.TravelTime
            });

            _context.SaveChanges();

            return Ok();
        }
    }
}