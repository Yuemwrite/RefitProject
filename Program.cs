// See https://aka.ms/new-console-template for more information

using System.Net.Http.Json;
using System.Text.Json.Serialization;
using Newtonsoft.Json;
using Refit;
using RefitProject;

public class Program
{
    static async Task Main(string[] args)
    {
        
         IPostAPI postApi = RestService.For<IPostAPI>("https://jsonplaceholder.typicode.com/");
         List<Post> posts = await postApi.GetPost();

         foreach (var post in posts)
         {
             Console.WriteLine(post.id + $". Post bilgileri: ");
             Console.WriteLine($"userId : {post.userId}" + Environment.NewLine +
             $"id: {post.id}" + Environment.NewLine + $"title : {post.title}" + Environment.NewLine + $"body: {post.body}");
             Console.WriteLine("-----");
         }


         var currentPost = await postApi.GetPostById(2);
         Console.WriteLine($"userId : {currentPost.userId}" + Environment.NewLine +
                           $"id: {currentPost.id}" + Environment.NewLine + $"title : {currentPost.title}" + Environment.NewLine + $"body: {currentPost.body}");
    }
}

