using PetVaxTrack.Application.Output.Results.Interfaces;
using PetVaxTrack.Domain.Notifications;

namespace PetVaxTrack.Application.Output.Results
{
    public class Result : IResultBase
    {
        private List<Notification> _notifications;

        public Result(int resultCod, string message, bool isOk)
        {
            ResultCod = resultCod;
            Message = message;
            IsOk = isOk;
            _notifications = new List<Notification>();
        }
        public int ResultCod { get; private set; }
        public string Message { get; private set; }
        public bool IsOk { get; private set; }
        public object Data { get; private set; } = new object();
        public IReadOnlyCollection<Notification> Notifications => _notifications;
        public void SetNotifications(List<Notification> notifications)
        {
            _notifications = notifications;
        }
        public void SetData(object data)
        {
            Data = data;
        }
    }
}