using movie_db_app.Application.Common.Mappings;
using movie_db_app.Domain.Entities;

namespace movie_db_app.Application.TodoLists.Queries.ExportTodos
{
    public class TodoItemRecord : IMapFrom<TodoItem>
    {
        public string Title { get; set; }

        public bool Done { get; set; }
    }
}
