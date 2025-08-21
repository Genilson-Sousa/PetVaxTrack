using PetVaxTrack.Domain.Notifications;

namespace PetVaxTrack.Domain.Validations
{
    public partial class ContractValidations<T>
    {
        public ContractValidations<T> GuidIsValid(object guidObj, string message, string propertyName)
        {
            if ((guidObj is not Guid guid) || guid == Guid.Empty)
            {
                AddNotification(new Notification(message, propertyName));
            }
           
            return this;
        }
    }
}