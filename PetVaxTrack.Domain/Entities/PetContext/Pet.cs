using PetVaxTrack.Domain.Validations;
using PetVaxTrack.Domain.Validations.Interfaces;
using PetVaxTrack.Domain.ValueObjects;

namespace PetVaxTrack.Domain.Entities.PetContext
{
    public class Pet : BaseEntity, IContract
    {
        public Pet(Name name, string identifier) 
        : base(name)
        {
            Identifier = identifier;
        }
        public string Identifier { get; private set; }

        public override bool Validation()
        {
            var contracts = new ContractValidations<Pet>()
             .FirstNameIsOk(this.Name, 20, 5, "O primeiro nome deve ter entre 5 e 20 caracteres.", "firstName")
             .LastNameIsOk(this.Name, 20, 5, "O sobrenome deve ter entre 5 e 20 caracteres.", "lastName");

            return contracts.IsValid(); 
        }
        public void SetIdentifier(string identifier)
        {
            Identifier = identifier;
        }
    }
}