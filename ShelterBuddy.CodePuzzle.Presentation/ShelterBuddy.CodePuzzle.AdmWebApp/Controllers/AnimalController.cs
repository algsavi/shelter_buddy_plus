using Microsoft.AspNetCore.Mvc;
using ShelterBuddy.CodePuzzle.AdmWebApp.GraphQL.Consumers;
using ShelterBuddy.CodePuzzle.AdmWebApp.Models;

namespace ShelterBuddy.CodePuzzle.AdmWebApp.Controllers
{
    public class AnimalController : Controller
    {
        private readonly AnimalConsumer _consumer;

        public AnimalController(AnimalConsumer consumer)
        {
            _consumer = consumer;
        }

        public async Task<IActionResult> Index()
        {
            var animals = await _consumer.GetAll();

            return View(animals);
        }
    }
}
