namespace Practice;
//TODO: Создайте extension method GroupByYear() для группировки рецептов по году создания. 

public static class RecipeExtension
{
    public static Dictionary<uint, List<Recipe>> GroupByYear(this RecipeCollection recipes, int year)
    {
        Dictionary<uint, List<Recipe>> result = new Dictionary<uint, List<Recipe>>();

        for (int i = 0; i < recipes.GetCount(); i++)
        {
            result.Add(recipes[i].Year,recipes[i]);
        }
        
        return result;
    }
    
}