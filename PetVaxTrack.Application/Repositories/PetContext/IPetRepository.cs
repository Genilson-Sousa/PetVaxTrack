using PetVaxTrack.Application.Output.Requests.PetRequests;
using PetVaxTrack.Domain.Entities.PetContext;

namespace PetVaxTrack.Application.Repositories.PetContext
{
    public interface IPetRepository
    {
        void IsertPet(Pet pet);
        Task<PetRequest> GetPetsWonerByIdAsync(Guid id);
    }
}
