using PetVaxTrack.Domain.Notifications;
using PetVaxTrack.Domain.Validations.Interfaces;
using PetVaxTrack.Domain.ValueObjects;

namespace PetVaxTrack.Domain.Entities.PetContext
{
    public abstract class BaseEntity : IValidation
    {
        private List<Notification> _notifications = [];
        protected BaseEntity(Name name)
        {
            Id = Guid.NewGuid();
            CreatedDate = DateTime.UtcNow;
            Name = name;
        }

        public Guid Id { get; private set; }
        public Name Name {get; private set; }
        public DateTime CreatedDate { get; private set; }
        public IReadOnlyCollection<Notification> Notifications => _notifications;
        protected void SetNotificationList(List<Notification> notifications)
        {
            _notifications = notifications;
        }
        public abstract bool Validation();      
    }
}