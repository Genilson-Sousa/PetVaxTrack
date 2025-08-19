using PetVaxTrack.Domain.Notifications;
using PetVaxTrack.Domain.Validations.Interfaces;
using PetVaxTrack.Domain.ValueObjects;

namespace PetVaxTrack.Domain.Validations
{
    public partial class ContractValidations<T> where T : IContract
    {
        private List<Notification> _notifications;
        public ContractValidations()
        {
            _notifications = new List<Notification>();
        }
        public IReadOnlyCollection<Notification> Notifications => _notifications;
        public void AddNotification(Notification notification)
        {
            _notifications.Add(notification);
        }
        public bool IsValid()
        {
            return _notifications.Count == 0;
        }

        internal object FirstNameIsOk(Name name, int v1, int v2, string v3)
        {
            throw new NotImplementedException();
        }
    }
}