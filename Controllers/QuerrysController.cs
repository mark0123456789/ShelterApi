using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ShelterApi.Controllers
{
    [Route("/queries")]
    [ApiController]
    public class QuerrysController : ControllerBase
    {
        [HttpGet("/queries/allSheltersWithAnimals")]
        public async Task<IActionResult> AllSheltersWithAnimals() 
        {
            return null;
        }
        [HttpGet("/queries/allAnimalsWithShelter")]
        public async Task<IActionResult> AllAnimalsWithShelter() 
        {
            return null;
        }
        [HttpGet("/queries/animalsOfShelter")]
        public async Task<IActionResult> SheltersAllAnimalData() 
        {
            return null;
        }
        [HttpGet("/queries/animalCountByShelter")]
        public async Task<IActionResult> OrderSheltersByAnimalCount() 
        {
            return null;
        }
    }
}
