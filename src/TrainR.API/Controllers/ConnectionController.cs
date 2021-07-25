using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TrainR.Infrastructure.Database;
using TrainR.Infrastructure.Database.Entities.TimeTable;
using TrainR.Infrastructure.Dto;

namespace TrainR.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ConnectionController : ControllerBase
    {
        private readonly TimeTableContext _context;
        public ConnectionController(TimeTableContext context)
        {
            _context = context;
        }

        [HttpGet]
        [Route("/connections")]
        public IEnumerable<ConnectionDto> GetConnections()
        {
            return _context.Connection
                    .Select(q => new ConnectionDto(q.Start.Name, q.Destination.Name, q.Train.Name))
                    .ToList();
        }

        [HttpPost]
        [Route("/connections")]
        public ActionResult AddConnection(InsertConnectionDto connection)
        {
            _context.Connection.Add(new Connection
            {
                Id = null,
                StartId = connection.StartId,
                DestinationId = connection.DestinationId,
                TrainId = connection.TrainId
            });

            _context.SaveChanges();
            return Ok();


        }
    }
}