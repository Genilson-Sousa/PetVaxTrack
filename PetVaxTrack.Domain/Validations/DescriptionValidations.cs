using PetVaxTrack.Domain.Notifications;

namespace PetVaxTrack.Domain.Validations
{
    public partial class ContractValidations<T>
    {
        public ContractValidations<T> DescriptionIsValid(string description, short maxLength, short minLength, string message, string propertyName)
        {
            if (string.IsNullOrEmpty(description) || description.Length < minLength || description.Length > maxLength)
            {
                AddNotification(new Notification(message, propertyName));
            }

            return this;
        }
    }
}