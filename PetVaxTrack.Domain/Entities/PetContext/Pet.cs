namespace PetVaxTrack.Domain.Entities.PetContext
{
    public class Pet : BaseEntity
    {
        public Pet(string firstName, string lastName, string identifier) 
        : base(firstName, lastName)
        {
            Identifier = identifier;
        }
        public string Identifier { get; private set; }
        public void SetIdentifier(string identifier)
        {
            Identifier = identifier;
        }
    }
}