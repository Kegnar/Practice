
using System.Text;
namespace Practice;

public class Recipe 
{
    public string Title { get; set; }
    public string Author { get; set; } 
    public string Cuisine { get; set; } 
    public int Year { get; set; }
    public Recipe(string title, string author, string cuisine, int year)
    {
        // Для проверки ArgumentNullException. nullOrEmpty() возвращает true если по ссылке null или пустая строка
        if (string.IsNullOrEmpty(title)|| string.IsNullOrEmpty(author) || string.IsNullOrEmpty(cuisine))
        {
            throw new ArgumentNullException("Поля рецепра не могут быть пустыми");
        }
        Title = title;
        Author = author;
        Cuisine = cuisine;
        Year = year;
    }

// конструктор для пустых объектов
    public Recipe() : this("No Title", "No Author", "No Cuisine", 1900)
    {
        
    }
    /* перегрузка ToStirng()
     Используется класс StringBuilder. По факту он тут ни к чему и можно легко обойтись обычным string, 
     т.к тут результирующая строка маленькая. Просто захотелось попробовать его использовать.
    */
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