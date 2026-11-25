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
        
        }
        [HttpGet("/queries/allAnimalsWithShelter")]
        public async Task<IActionResult> AllAnimalsWithShelter() 
        {
        
        }
        [HttpGet("/queries/animalsOfShelter")]
        public async Task<IActionResult> SheltersAllAnimalData() 
        {
        
        }
        [HttpGet("/queries/animalCountByShelter")]
        public async Task<IActionResult> OrderSheltersByAnimalCount() 
        {
        
        }
    }
}
