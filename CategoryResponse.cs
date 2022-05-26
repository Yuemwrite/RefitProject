namespace RefitProject;


public class CreateCategory
{
    public string categoryName { get; set; }
    public string description { get; set; } 
}
public class Category
{
    public int categoryId { get; set; }
    public string categoryName { get; set; }
    public string description { get; set; }
    public object products { get; set; }
}

public class CategoryResponse
{
    public int errorCode { get; set; }
    public bool succeeded { get; set; }
    public object message { get; set; }
    public object errors { get; set; }
    public CreateCategory data { get; set; }
}

public class CreateCategoryResponse
{
    public Category data { get; set; }
    public List<object> messages { get; set; }
    public bool succeeded { get; set; } 
}