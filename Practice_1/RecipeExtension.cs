namespace Practice;

public static class RecipeExtension
{
    public static List<Recipe> GroupByYear(this RecipeCollection recipes,int year)
    {
        Dictionary<int, List<Recipe>> result = new Dictionary<int,List <Recipe>>();

        for (int i = 0; i < recipes.GetCount(); i++)
        {
            var resultList = new List<Recipe>();
            // проверка на уже собранный год
            if (result.ContainsKey(recipes[i].Year))
            {
                continue;
            }
            // пробегаемся по коллекции и собираем список рецептов-одногодок
            for (int j = 0; j < recipes.GetCount(); j++)
            {
                if (recipes[i].Year == recipes[j].Year)
                {
                    resultList.Add(recipes[j]);
                }
            }
            // собираем результат
            result.Add(recipes[i].Year, resultList);
        }
        return result[year];
    }

}