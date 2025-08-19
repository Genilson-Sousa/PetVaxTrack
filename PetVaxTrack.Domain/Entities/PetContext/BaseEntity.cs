namespace PetVaxTrack.Domain.Entities.PetContext
{
    public abstract class BaseEntity
    {
        protected BaseEntity(string firstName, string lastName)
        {
            Id = Guid.NewGuid();
            FirstName = firstName;
            LastName = lastName;
            CreatedDate = DateTime.UtcNow;
        }

        public Guid Id { get; private set; }
        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public DateTime CreatedDate { get; private set; }
    }
}