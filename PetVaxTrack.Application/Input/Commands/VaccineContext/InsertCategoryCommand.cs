using PetVaxTrack.Application.Input.Commands.Interfaces;

namespace PetVaxTrack.Application.Input.Commands.VaccineContext
{
    public class InsertCategoryCommand : ICommandBase
    {
        public string Discription {  get; set; }
    }
}
