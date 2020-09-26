using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AmniyatAirlines.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AmniyatAirlines.Api
{
    [Route("api/[controller]")]
    [ApiController]
    public class AirplaneController : ControllerBase
    {
        public AirplaneController(DBContext dBContext)
        {
            DbContext = dBContext;
        }
        private DBContext DbContext;
        [HttpGet]
        public IActionResult GetAirplanes()
        {
            List<Airplane> airplanes = DbContext.Airplanes.ToList();
            return Ok(airplanes);
        }
        [HttpGet("{id}")]
        public IActionResult GetAirplane(int id)
        {
            Airplane airplane = DbContext.Airplanes.Where(x => x.Id == id).FirstOrDefault();
            return Ok(airplane);
        }
        [HttpPost]
        public IActionResult AddAirplane([FromBody] Airplane airplane)
        {
            DbContext.Airplanes.Add(airplane);
            DbContext.SaveChanges();

            return Ok("Success");
        }
    }
}