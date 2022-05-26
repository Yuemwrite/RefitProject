using Refit;

namespace RefitProject;

public interface ICategory
{
    [Get("/Category")]
    Task<CategoryResponse> GetCategories();
    
    [Get("/Category/{id}")]
    Task<CategoryResponse> GetCategory(int id);

    [Post("/Category")]
    Task<CreateCategory> CreateCategory([Body] CreateCategory category);
}