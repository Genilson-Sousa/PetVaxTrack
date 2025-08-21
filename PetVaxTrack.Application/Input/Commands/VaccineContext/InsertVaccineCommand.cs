using PetVaxTrack.Application.Input.Commands.Interfaces;

namespace PetVaxTrack.Application.Input.Commands.VaccineContext
{
    public class InsertVaccineCommand : ICommandBase
    {      
        public Guid CategoryId { get; set; }
        public Guid PetId { get; set; }
        public string Description { get; set; }
    }
}
