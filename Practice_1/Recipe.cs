using System.Text;
namespace Practice;

public class Recipe
{
    public string Title { get; set; } 
    public string Author { get; set; }
    public string Cuisine {get; set;}
    public int Year{get; set;}
    public Recipe(string title, string author, string cuisine, uint year){}

    public Recipe()
    {
        Title = "No Title";
        Author = "No Author";
        Cuisine = "No Cuisine";
        Year = 1900;
    }

    public override string ToString()
    {
        var result = new StringBuilder();
        result.AppendLine($"Название: {Title}");
        result.AppendLine($"Автор: {Author}");
        result.AppendLine($"Кухня: {Cuisine}");
        result.AppendLine($"Год создания: {Year}");
        return result.ToString();
    }

    public static bool operator ==(Recipe first, Recipe second)
    {
        return first.Title == second.Title && first.Year == second.Year;
    }

    public static bool operator !=(Recipe first, Recipe second)
    {
        return !(first == second);
    }
}