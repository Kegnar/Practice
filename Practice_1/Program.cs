using Practice;

var recipeBook = new RecipeCollection();
try
{
    recipeBook.AddRecipe(new Recipe("Лютая дичь", "Юлия Высоцкая", "Марсианская", 2000));
    recipeBook.AddRecipe(new Recipe("Лютая дичь v 2", "Юлия Высоцкая", "Марсианская", 2000));
    recipeBook.AddRecipe(new Recipe("Батин Суп", "Батя", "Авторская", 1980));
    recipeBook.AddRecipe(new Recipe("Голубцы с Говном", "Иван Семеныч", "газета Мегаполис-Экспресс", 2005));
    recipeBook.AddRecipe(new Recipe("Хрючево", "ХЗ кто", "Кухня времен царя Гороха", 1200));
    var recipe6 = new Recipe("Пирожок", "Мамин", "Народная", 1212);
    recipeBook.AddRecipe(recipe6);
    var testRecipe = new Recipe("test", "test", "test", 2323);
    recipeBook.AddRecipe(testRecipe);
    recipeBook.AddRecipe(new Recipe("test", "test", "test", 2323));

    for (int i = 0; i < recipeBook.GetCount(); i++)
    {
        Console.WriteLine(recipeBook[i]);
    }
    
    // Обработка исключений
    Console.WriteLine("Пример обработки исключений:");
    Console.WriteLine("1 - ArgumentOutOfRangeException");
    Console.WriteLine("2 - RecipeNotFoundException");
    Console.WriteLine("3 - NullReferenceException");
    int key = Int32.Parse(Console.ReadLine());
    switch (key)
    {
        case 1:
            // Выход за границу коллекции
            Console.WriteLine(recipeBook[9]);
            break;
        case 2:
            // RecipeNotFoundException сработает при установке неверного года или имени в параметре
            if (recipeBook.RemoveRecipe("Лютая дичь v 2", 2001) == 0)
            {
                throw new RecipeNotFoundException();
            }
            break;
        // В конструкторе сработает NullReferenceException.
        case 3:
            var nullExceptionRecipe = new Recipe("","","", 2000);
            break;
    }
}

// Ловим разные исключения. Останова программы не произойдет, т.к. нет проброса исключения наверх.
// Чтобы программа остановилась надо раскомментировать throw.

catch (Exception e)
{
    switch (e)
    {
        case RecipeNotFoundException:
            Console.WriteLine(e.Message);
            break;
        case ArgumentOutOfRangeException:
            Console.WriteLine(e.Message);
            break;
        case NullReferenceException:
            Console.WriteLine(e.Message);
            break;
    }
   // throw;
}

// extension method 
Console.WriteLine("\nПример работы метода расширения GroupByYear()");
var yearDict = recipeBook.GroupByYear(2000);

foreach (var year in yearDict)
{
    Console.WriteLine(year);
}

// работа словаря
Dictionary<string,List<Recipe>> recipesDict = new Dictionary<string, List<Recipe>>();

    for (int i = 0; i < recipeBook.GetCount(); i++)
    {
        var resultList = new List<Recipe>();
        // проверка на уже собранного автора
        if (recipesDict.ContainsKey(recipeBook[i].Author))
        {
            continue;
        }
        // пробегаемся по коллекции и собираем список рецептов одного автора
        for (int j = 0; j < recipeBook.GetCount(); j++)
        {
            if (recipeBook[i].Author == recipeBook[j].Author)
            {
                resultList.Add(recipeBook[j]);
            }
        }
        // собираем результат
        recipesDict.Add(recipeBook[i].Author, resultList);
    }

Console.WriteLine("Словарь");
Console.WriteLine($"Проверка наличия рецептов автора \"test\" :{recipesDict.ContainsKey("test")}");

// работа hashset
HashSet<string> recipeSet = new HashSet<string>();
for (int i = 0; i < recipeBook.GetCount(); i++)
{
    recipeSet.Add(recipeBook[i].Author);
    
}
Console.WriteLine("\nРабота HashSet:");
foreach (var recipe in recipeSet)
{
    Console.WriteLine(recipe);
}