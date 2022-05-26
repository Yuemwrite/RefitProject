using Refit;

namespace RefitProject;

public interface IPostAPI
{
    [Get("/posts")]
    Task<List<Post>> GetPost();

    [Get("/posts/{id}")]
    Task<Post> GetPostById(int id);
}