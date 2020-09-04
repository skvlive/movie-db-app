using movie_db_app.Domain.Common;
using System.Threading.Tasks;

namespace movie_db_app.Application.Common.Interfaces
{
    public interface IDomainEventService
    {
        Task Publish(DomainEvent domainEvent);
    }
}
