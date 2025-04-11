using System.Text;
namespace Practice;

public class Recipe(string title, string author, string cuisine, uint year) // primary constructor=> recipes.Add(new Recipe(title, author, cuisine, year));
{
    public string Title { get; set; } = title;
    public string Author { get; set; } = author;
    public string Cuisine {get; set;} = cuisine;
    public uint Year {get; set;} = year;

    // конструктор для пустых объектов

    public Recipe() : this("No Title", "No Author", "No Cuisine", 1900)
    {
        
    }
    

    // перегрузка ToStirng()
    public override string ToString()
    {
        var result = new StringBuilder();
        result.AppendLine($"Название: {Title}");
        result.AppendLine($"Автор: {Author}");
        result.AppendLine($"Кухня: {Cuisine}");
        result.AppendLine($"Год создания: {Year}");
        return result.ToString();
    }
    // перегрузка операторов сравнения
    public static bool operator ==(Recipe first, Recipe second)
    {
        return first.Title == second.Title && first.Year == second.Year;
    }

    public static bool operator !=(Recipe first, Recipe second)
    {
        return !(first == second);
    }
}