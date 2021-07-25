using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using TrainR.Infrastructure.Database;
using TrainR.Infrastructure.Dto;

namespace TrainR.API.Controllers
{
    [ApiController]
    public class TrainController : ControllerBase
    {
        private readonly TimeTableContext _context;
        public TrainController(TimeTableContext context)
        {
            _context = context;
        }

        [HttpGet]
        [Route("/trains")]
        public IEnumerable<TrainDto> GetTrains()
        {
            return _context.Train
                    .Select(q => new TrainDto(q.Name))
                    .ToList();
        }
    }
}