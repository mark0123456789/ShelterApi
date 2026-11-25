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
          
            

        }
        [HttpGet("/animals/allAnimal")]
        public async Task<IActionResult> AllAnimal() 
        {
        
        }
        [HttpGet("/animals/byId")]
        public async Task<IActionResult> AnimalById() 
        {
        
        }

    }
}
