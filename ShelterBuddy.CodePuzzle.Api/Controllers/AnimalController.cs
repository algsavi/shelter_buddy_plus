using Microsoft.AspNetCore.Mvc;
using ShelterBuddy.CodePuzzle.Api.Models;

namespace ShelterBuddy.CodePuzzle.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AnimalController : ControllerBase
    {
        private readonly AppDbContext _context;

        public AnimalController(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var animals = await _context.Animals.ToListAsync();

            return Ok(animals);
        }

        [HttpPost]
        public async Task<ActionResult<AnimalModel>> AddAnimal(AnimalModel animal)
        {
            _context.Animals.Add(animal);

            await _context.SaveChangesAsync();

            return Ok();
        }
    }
}
