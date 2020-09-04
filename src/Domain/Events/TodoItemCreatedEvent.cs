using movie_db_app.Domain.Common;
using movie_db_app.Domain.Entities;

namespace movie_db_app.Domain.Events
{
    public class TodoItemCreatedEvent : DomainEvent
    {
        public TodoItemCreatedEvent(TodoItem item)
        {
            Item = item;
        }

        public TodoItem Item { get; }
    }
}
