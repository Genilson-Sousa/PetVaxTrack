using PetVaxTrack.Domain.ValueObjects;

namespace PetVaxTrack.Domain.Entities.PetContext
{
    public class Pet : BaseEntity
    {
        public Pet(Name name, string lastName, string identifier) 
        : base(name)
        {
            Identifier = identifier;
        }
        public string Identifier { get; private set; }

        public override bool Validation()
        {
            throw new NotImplementedException();
        }

        public void SetIdentifier(string identifier)
        {
            Identifier = identifier;
        }
    }
}