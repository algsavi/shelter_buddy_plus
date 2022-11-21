using ShelterBuddy.CodePuzzle.AdmWebApp.Models;

namespace ShelterBuddy.CodePuzzle.AdmWebApp.GraphQL.ResponseTypes
{
    public class ResponseAnimalCollectionType
    {
        public List<AnimalModel> Animals { get; set; }
    }
}
