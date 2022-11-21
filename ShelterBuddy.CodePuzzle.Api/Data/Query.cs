using ShelterBuddy.CodePuzzle.Api.Models;

namespace ShelterBuddy.CodePuzzle.Api.Data
{
    public class Query
    {
        [UseProjection]
        [UseFiltering]
        [UseSorting]
        public IQueryable<AnimalModel> GetAnimals([Service] AppDbContext context) =>
            context.Animals;
    }
}
