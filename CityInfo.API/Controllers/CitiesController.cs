using CityInfo.API.Models;
using Microsoft.AspNetCore.Mvc;

namespace CityInfo.API.Controllers
{
    [ApiController]
    [Route("api/cities")]
    public class CitiesController : ControllerBase
    {
        [HttpGet]
        public ActionResult<IEnumerable<CityDto>> GetCities()
        {
            return Ok(CitiesDataStore.Current.Cities);
        }

        [HttpGet("{id}")]
        public ActionResult<CityDto> GetCity(int id)
        {
            //find city
            var cityToReturn = CitiesDataStore.Current.Cities
                .FirstOrDefault(c => c.Id == id);

            if (cityToReturn == null)
            {
                return NotFound();
            }

            return Ok(cityToReturn);
        }
        [HttpPost]
        public IActionResult PostCity([FromBody] CityDto city) 
        {
            if (city == null) 
            {
                return BadRequest();
            }
            var dataBase = CitiesDataStore.Current.Cities;
            var maxId = dataBase.Max(c => c.Id);
            city.Id = maxId + 1; 
            dataBase.Add(city);
            
            return Ok(dataBase);
        }
    }
}
