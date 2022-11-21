using System.ComponentModel.DataAnnotations;

namespace ShelterBuddy.CodePuzzle.AdmWebApp.Models
{
    public class AnimalModel
    {
        public Guid? Id { get; init; }
        [Required(ErrorMessage = "Name is required.")]
        public string? Name { get; init; }
        public string? Colour { get; init; }
        public string? MicrochipNumber { get; init; }
        [Required(ErrorMessage = "Date of Birth is required.")]
        public DateTime? DateOfBirth { get; init; }
        public string? Specie { get; init; }
    }
}
