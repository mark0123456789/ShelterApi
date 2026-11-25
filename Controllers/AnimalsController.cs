using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ShelterApi.Controllers
{
    [Route("/animals")]
    [ApiController]
    public class AnimalsController : ControllerBase
    {
        private readonly AnimalsController? _Context;
        [HttpPost("/animal/NewAnimal")]
        public async Task<IActionResult> NewAnimal() 
        {

            return null;

        }
        [HttpGet("/animals/allAnimal")]
        public async Task<IActionResult> AllAnimal() 
        {
            return null;
        }
        [HttpGet("/animals/byId")]
        public async Task<IActionResult> AnimalById() 
        {
            return null;
        }
        [HttpPut("/animals/update?id=")]
        public async Task<IActionResult> UpdateAnimalById() 
        {
            return null;
        }
        [HttpDelete("/animals/deleteAnimal?id=")]
        public async Task<IActionResult> DeleteAnimalById() 
        {
            return null;
        }

    }
}
