
namespace Practice;

public class RecipeCollection
{
    private List<Recipe> recipes;

    public void AddRecipe(Recipe recipe)
    {
        recipes.Add(recipe);
    }

    public void RemoveRecipe(string recipeTitle)
    {
        recipes.RemoveAll(r => r.Title == recipeTitle);
    }

    public void RemoveRecipe(int recipeYear)
    {
        recipes.RemoveAll(r => r.Year == recipeYear);
    }

    public List<Recipe> FindRecipesByAuthor(string recipeAuthor)
    {
        return recipes.Where(r => r.Author == recipeAuthor).ToList();
    }

    public List<Recipe> GetRecipesByCuisine(string recipeCuisine)
    {
        return recipes.Where(r => r.Cuisine == recipeCuisine).ToList();
    }
}