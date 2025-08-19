using PetVaxTrack.Domain.Validations;
using PetVaxTrack.Domain.Validations.Interfaces;

namespace PetVaxTrack.Domain.Entities.VaccineContext
{
    public class Vaccine : BaseEntity, IContract
    {
        public Vaccine(string description, Guid categoryId, Guid petId) : base(description)
        {
            CategoryId = categoryId;
            PetId = petId;
        }
        public Guid CategoryId { get; private set; }
        public Guid PetId { get; private set; }
        public override void SetDescription(string description)
        {
            base.SetDescription(description);
        }

        public override bool Validation()
        {
            var contracts = new ContractValidations<Vaccine>()
                .DescriptionIsValid(this.Description, 30, 12, "A descrição deve ter entre 12 e 30 caracteres.", "Description")
                .GuidIsValid(this.CategoryId, "O campo 'Categoria' deve conter um GUID válido.", nameof(CategoryId))
                .GuidIsValid(this.PetId, "O campo 'Pet' deve conter um GUID válido.", nameof(PetId));

            return contracts.IsValid();
        }
    }
}