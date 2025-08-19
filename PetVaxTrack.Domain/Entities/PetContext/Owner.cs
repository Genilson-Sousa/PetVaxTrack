using PetVaxTrack.Domain.Validations;
using PetVaxTrack.Domain.Validations.Interfaces;
using PetVaxTrack.Domain.ValueObjects;

namespace PetVaxTrack.Domain.Entities.PetContext
{
    public class Owner : BaseEntity, IContract
    {
        public Owner(Name name, string lastName, string email, Document document)
        : base(name)
        {
            Email = email;
            Document = document;
        }
        public string Email { get; private set; }
        public Document Document { get; private set; }

        public override bool Validation()
        {
            var contracts = new ContractValidations<Owner>()
            .FirstNameIsOk(this.Name, 20, 5, "First name must be between 5 and 20 characters.", "firstName")
            .LastNameIsOk(this.Name, 20, 5, "Last name must be between 5 and 20 characters.", "lastName");
            return true; // Implement validation logic here
        }

        public void SetEmail(string email)
        {
            Email = email;
        }
    }
}