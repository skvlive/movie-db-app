using movie_db_app.Application.Common.Mappings;
using movie_db_app.Domain.Entities;
using System.Collections.Generic;

namespace movie_db_app.Application.TodoLists.Queries.GetTodos
{
    public class TodoListDto : IMapFrom<TodoList>
{
    public TodoListDto()
    {
        Items = new List<TodoItemDto>();
    }

    public int Id { get; set; }

    public string Title { get; set; }

    public IList<TodoItemDto> Items { get; set; }
}
}
