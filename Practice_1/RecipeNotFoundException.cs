namespace Practice;

public class RecipeNotFoundException : Exception
{
    public RecipeNotFoundException(string message) : base(message)
    {
    }
    public RecipeNotFoundException():base("Рецепт не найден")
    {
    }
}