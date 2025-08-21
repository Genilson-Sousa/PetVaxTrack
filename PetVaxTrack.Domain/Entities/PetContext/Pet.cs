using PetVaxTrack.Domain.Validations;
using PetVaxTrack.Domain.Validations.Interfaces;
using PetVaxTrack.Domain.ValueObjects;

namespace PetVaxTrack.Domain.Entities.PetContext
{
    public class Pet : BaseEntity, IContract
    {
        public Pet(Name name, int age,Guid ownerId,int identifier) 
        : base(name)
        {
            Age = age;
            OwnerId = ownerId;
            Identifier = identifier;
        }
        public int Age { get; private set; }
        public Guid OwnerId { get; private set; }
        public int Identifier { get; private set; }

        public override bool Validation()
        {
            var contracts = new ContractValidations<Pet>()
             .FirstNameIsOk(this.Name, 20, 5, "O primeiro nome deve ter entre 5 e 20 caracteres.", "firstName")
             .LastNameIsOk(this.Name, 20, 5, "O sobrenome deve ter entre 5 e 20 caracteres.", "lastName");

            return contracts.IsValid(); 
        }
        public void SetIdentifier(int identifier)
        {
            Identifier = identifier;
        }
    }
}