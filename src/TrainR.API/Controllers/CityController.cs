using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using TrainR.Infrastructure.Database;
using TrainR.Infrastructure.Database.Entities.TimeTable;
using TrainR.Infrastructure.Dto;

namespace TrainR.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CityController : ControllerBase
    {
        private readonly TimeTableContext _context;
        public CityController(TimeTableContext context)
        {
            _context = context;
        }

        [HttpGet]
        [Route("/cities")]
        public IEnumerable<CityDto> GetCities()
        {
            return _context.City.Select(q => new CityDto(q.Id, q.Name)).ToList();
        }

        [HttpPost]
        [Route("/cities")]
        public ActionResult AddCity(InsertCityDto city)
        {
            _context.City.Add(new City
            {
                Id = null,
                Name = city.Name
            });

            _context.SaveChanges();
            return Ok();


        }
    }
}