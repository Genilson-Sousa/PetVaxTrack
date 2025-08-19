using PetVaxTrack.Domain.Validations;
using PetVaxTrack.Domain.Validations.Interfaces;

namespace PetVaxTrack.Domain.Entities.VaccineContext
{
    public class Category : BaseEntity, IContract
    {
        public Category(string description) : base(description)
        {
        }
        public override void SetDescription(string description)
        {
            base.SetDescription(description);
        }
        public override bool Validation()
        {
            var contracts = new ContractValidations<Category>()
                .DescriptionIsValid(this.Description, 64, 12, "A descrição deve ter entre 12 e 64 caracteres.", "Description");
            return contracts.IsValid(); 
        }
    }
}