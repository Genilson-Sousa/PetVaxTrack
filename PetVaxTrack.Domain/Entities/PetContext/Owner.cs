using PetVaxTrack.Domain.Validations;
using PetVaxTrack.Domain.Validations.Interfaces;
using PetVaxTrack.Domain.ValueObjects;

namespace PetVaxTrack.Domain.Entities.PetContext
{
    public class Owner : BaseEntity, IContract
    {
        public Owner(Name name, string email, Document document)
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
                .FirstNameIsOk(this.Name, 20, 5, "O primeiro nome deve ter entre 5 e 20 caracteres.", "firstName")
                .LastNameIsOk(this.Name, 20, 5, "O sobrenome deve ter entre 5 e 20 caracteres.", "lastName")
                .EmailIsValid(Email, "Formato de e-mail inválido.", "email")
                .DocumentIsValid(Document, "Formato de documento inválido.", "document");

            return contracts.IsValid(); // Implementar lógica de validação aqui
        }
        public void SetEmail(string email)
        {
            Email = email;
        }
    }
}