using PetVaxTrack.Domain.ValueObjects;

namespace PetVaxTrack.Domain.Entities.PetContext
{
    public abstract class BaseEntity
    {
        protected BaseEntity(Name name)
        {
            Id = Guid.NewGuid();
            CreatedDate = DateTime.UtcNow;
            Name = name;
        }

        public Guid Id { get; private set; }
        public Name Name {get; private set; }
        public DateTime CreatedDate { get; private set; }
    }
}