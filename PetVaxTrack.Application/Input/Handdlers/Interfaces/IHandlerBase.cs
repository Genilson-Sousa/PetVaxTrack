using PetVaxTrack.Application.Input.Commands.Interfaces;
using PetVaxTrack.Application.Output.Results.Interfaces;

namespace PetVaxTrack.Application.Input.Handdlers.Interfaces
{
    public interface IHandlerBase<in T> where T : ICommandBase
    {
        IResultBase Handler(T command);
    }
}
