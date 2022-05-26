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
         ITodoAPI todoAPI = RestService.For<ITodoAPI>("http://jsonplaceholder.typicode.com");
         List<Todo> todos = await todoAPI.GetTodos();
         foreach (var todo in todos)
         {
             Console.WriteLine(todo.title); 
         }

         // Todo todo2 = await todoAPI.GetTodo(3);
         // Console.WriteLine("Todo TITLE : " + todo2.title);

        // ICategory category = RestService.For<ICategory>("https://localhost:7099/api");
        //
        //
        // #region GET DATA
        //
        // var categories = await category.GetCategories();
        //
        //  foreach (var item in categories.data)
        //  {
        //      Console.WriteLine(item.categoryName);
        //  }
        

        // #endregion
        //
        // CategoryResponse newCategory = new CategoryResponse()
        // {
        //     data = new CreateCategory()
        //     {
        //         categoryName = "SonData",
        //         description = "SonDesc"
        //     }
        // };
        //
        // var createCategory = await category.CreateCategory(new CreateCategory
        // {
        //     categoryName = "ilk",
        //     description = "ilk"
        // });
        //
        // Console.WriteLine($" İşlem Sonucu :  {createCategory.categoryName} {createCategory.description}");
        //
        // int a = 5;





        // var categoryData = await category.GetCategory(3);
        // foreach (var item in categoryData.data)
        // {
        //     Console.WriteLine(item.description);
        // }


        //
        // foreach (var item in categoryData.data)
        // {
        //     Console.WriteLine(item.description);
        // }



        // var currentCategory = await category.GetCategory(5);
        //
        // Console.WriteLine(currentCategory);



    }
}

