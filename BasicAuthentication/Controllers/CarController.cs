using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

using BasicAuthentication.Services;
using BasicAuthentication.Models;
using Microsoft.AspNetCore.Authorization;

namespace BasicAuthentication.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class CarController : ControllerBase
    {
        private readonly ICarService _carService;

        public CarController(ICarService carService) {
            _carService = carService;
        }

        [HttpGet]
        public async Task<IEnumerable<Car>> Get () => await _carService.Get();
    }
}