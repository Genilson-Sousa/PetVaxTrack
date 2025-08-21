using PetVaxTrack.Application.Output.Requests.PetRequests;
using PetVaxTrack.Application.Output.Results.Interfaces;
using PetVaxTrack.Domain.Entities.VaccineContext;

namespace PetVaxTrack.Application.Repositories.VaccineContext
{
    internal interface ICategoryRepository
    {
        void IsertCategory(Category category);
        IResultBase DeleteCategory(Guid CategoryId);
        Task<CategoryRequest> GetAllCategoriesAsync();

    }
}
