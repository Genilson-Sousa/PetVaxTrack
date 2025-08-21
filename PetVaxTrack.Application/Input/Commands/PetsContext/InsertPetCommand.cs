using PetVaxTrack.Application.Input.Commands.Interfaces;
using PetVaxTrack.Domain.ValueObjects;

namespace PetVaxTrack.Application.Input.Commands.PetsContext
{
    public class InsertPetCommand : ICommandBase
    {
        public Name Name { get; set; }
        public int Age { get; set; }
        public int Identifier { get; set; }
        public Guid OwnerId { get; set; }
    }
}
