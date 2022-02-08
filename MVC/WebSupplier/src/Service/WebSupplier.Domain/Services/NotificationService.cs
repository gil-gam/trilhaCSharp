using WebSupplier.Domain.Interfaces;
using WebSupplier.Domain.Notifier;
using System.Collections.Generic;
using System.Linq;

namespace WebSupplier.Domain.Services
{
    public class NotificationService : INotificationService
    {
        private List<Notification> _error = new List<Notification>();

        public NotificationService()
        {

        }

        public void AddErro(string erro)
        {
            _error.Add(new Notification(erro));
        }

        public IEnumerable<Notification> AllError()
        {
            return _error;
        }

        public bool HasError()
        {
            return _error.Any();
        }
    }
}
