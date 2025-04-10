
using System.Collections;

namespace Practice;

public class RecipeCollection: IEnumerable
{
    private List<Recipe> recipes = new List<Recipe>();

  
    public Recipe this[int index]
    {
        get => recipes[index];
        set => recipes[index] = value;
    }
    public int GetCapacity()
    {
        return recipes.Capacity;
    }
    public void AddRecipe(Recipe recipe)
    {
        recipes.Add(recipe);
    }
    /* Удаление рецептов по названию и году создания. Возвращает количество удаленных рецептов.
    // Методы ниже используют т.н "Делегаты" - указатели на методы. Здесь r - делегат, позволяющий 
    // получить значение поля объекта через неявный вызов метода get.
    */
    
    public int RemoveRecipe(string recipeTitle, int recipeYear)
    {
      return recipes.RemoveAll(r => r.Title == recipeTitle && r.Year == recipeYear);
    }
    //Возвращает список рецептов определенного автора. Так же использует делегат для поиска
    public List<Recipe> FindRecipesByAuthor(string recipeAuthor)
    {
        return recipes.Where(r => r.Author == recipeAuthor).ToList();
    }
    // Возвращает список рецептов по кухне. Все так же при помощи делегата.
    public List<Recipe> GetRecipesByCuisine(string recipeCuisine)
    {
        return recipes.Where(r => r.Cuisine == recipeCuisine).ToList();
    }
// Для работы foreach наш класс должен реализовывать интерфейс IEnumerable 
// тут будет реализация


public IEnumerator GetEnumerator()
{
    throw new NotImplementedException();
}
}
