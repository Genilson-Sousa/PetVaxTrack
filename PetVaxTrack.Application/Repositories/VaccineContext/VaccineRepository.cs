using PetVaxTrack.Domain.Entities.VaccineContext;

namespace PetVaxTrack.Application.Repositories.VaccineContext
{
    public interface VaccineRepository
    {
        void IsertVaccine(Vaccine vaccine);
    }
}
