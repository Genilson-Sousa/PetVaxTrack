using PetVaxTrack.Application.Output.Requests.PetRequests;
using PetVaxTrack.Application.Output.Results.Interfaces;
using PetVaxTrack.Domain.Entities.PetContext;

namespace PetVaxTrack.Application.Repositories.PetContext
{
    public interface IOwnerRepository
    {
        void IsertOwner (Owner owner);
        Task<OwnerRequest> GetOwnerDocumentAsync (Owner owner);
        Task<OwnerRequest> GetOwnerEmailAsync (Owner owner);
        IResultBase DeleteOwnerById(Guid id);
    }
}
