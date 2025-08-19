using PetVaxTrack.Domain.Notifications;
using PetVaxTrack.Domain.Validations.Interfaces;

namespace PetVaxTrack.Domain.Entities.VaccineContext
{
    public abstract class BaseEntity : IValidations
    {
        private List<Notification> _notifications = [];
        protected BaseEntity(string description)
        {
            Id = Guid.NewGuid();
            CreatedDate = DateTime.UtcNow;
            Description = description;
        }
        public Guid Id { get; private set; }
        public DateTime CreatedDate { get; private set; }
        public string Description { get; private set; }
        public IReadOnlyCollection<Notification> Notifications => _notifications;
        public void SetNotificationList(List<Notification> notifications)
        {
            _notifications = notifications;
        }
        public virtual void SetDescription(string description)
        {
            Description = description;
        }
        public abstract bool Validation();
    }
}