using PetVaxTrack.Domain.ValueObjects;

namespace PetVaxTrack.Domain.Entities.PetContext
{
    public class Owner : BaseEntity
    {
        public Owner(Name name, string lastName, string email, Document document)
        : base(name)
        {
            Email = email;
            Document = document;
        }
        public string Email { get; private set; }
        public Document Document { get; private set; }
        public void SetEmail(string email)
        {
            Email = email;
        }
    }
}