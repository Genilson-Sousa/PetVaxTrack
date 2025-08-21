using PetVaxTrack.Application.Output.DTOs;
using PetVaxTrack.Application.Output.Requests.Interfaces;
using PetVaxTrack.Application.Output.Results;

namespace PetVaxTrack.Application.Output.Requests.PetRequests
{
    public class CategoryRequest : IRequestBase
    {
        public Result Result { get; set; }
        public IEnumerable<CategoryDTO> Categories { get; set; }
    }
}