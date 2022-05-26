using Refit;

namespace RefitProject;

public interface ITodoAPI
{
    [Get("/todos")]
    Task<List<Todo>> GetTodos();

    [Get("/todos/{id}")]
    Task<Todo> GetTodo(int id);
}