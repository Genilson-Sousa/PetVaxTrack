using System.Text.RegularExpressions;
using PetVaxTrack.Domain.Notifications;

namespace PetVaxTrack.Domain.Validations
{
    public partial class ContractValidations<T>
    {
        public ContractValidations<T> EmailIsValid(string email, string message, string propertyName)
        {
            if (string.IsNullOrEmpty(email) || !Regex.IsMatch(email, @"^\w+([.-]?\w+)*@\w+([.-]?\w+)*\.\w{2,}$"))
            {
                AddNotification(new Notification(message, propertyName));
            }

            return this;
        }
    }
}