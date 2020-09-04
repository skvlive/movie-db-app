using movie_db_app.Application.TodoLists.Queries.ExportTodos;
using System.Collections.Generic;

namespace movie_db_app.Application.Common.Interfaces
{
    public interface ICsvFileBuilder
    {
        byte[] BuildTodoItemsFile(IEnumerable<TodoItemRecord> records);
    }
}
