using PetVaxTrack.Application.Input.Commands.Interfaces;
using PetVaxTrack.Domain.ValueObjects;
using System.ComponentModel.DataAnnotations;

namespace PetVaxTrack.Application.Input.Commands.PetsContext
{
    public class InsertOwnerCommand : ICommandBase
    {
        public Name Name { get; set; }
        public Document Document { get; set; }
        public string? Email { get; set; }
    }
}
