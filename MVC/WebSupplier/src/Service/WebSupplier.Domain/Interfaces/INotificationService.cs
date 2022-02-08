using WebSupplier.Domain.Models;
using WebSupplier.Domain.Notifier;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace WebSupplier.Domain.Interfaces
{
    public interface INotificationService
    {
        void AddErro(string erro);
        bool HasError();
        IEnumerable<Notification> AllError();        
    }
}
