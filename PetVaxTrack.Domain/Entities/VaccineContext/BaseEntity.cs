namespace PetVaxTrack.Domain.Entities.VaccineContext
{
    public abstract class BaseEntity
    {
        protected BaseEntity(string description)
        {
            Id = Guid.NewGuid();
            CreatedDate = DateTime.UtcNow;
            Description = description;
        }
        public Guid Id { get; private set; }
        public DateTime CreatedDate { get; private set; }
        public string Description { get; private set; }
        public virtual void SetDescription(string description)
        {
            Description = description;
        }
    }
}