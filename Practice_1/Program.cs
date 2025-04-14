using Practice;

var recipeBook = new RecipeCollection();
try
{
    recipeBook.AddRecipe(new Recipe("Лютая дичь", "Юлия Высоцкая", "Марсианская", 2000));
    recipeBook.AddRecipe(new Recipe("Лютая дичь v 2", "Юлия Высоцкая", "Марсианская", 2000));
    recipeBook.AddRecipe(new Recipe("Батин Суп", "Батя", "Авторская", 1980));
    recipeBook.AddRecipe(new Recipe("Голубцы с Говном", "Иван Семеныч", "газета Мегаполис-Экспресс", 2005));
    recipeBook.AddRecipe(new Recipe("Хрючево", "ХЗ кто", "Кухня времен царя Гороха", 1200));
    var recipe6 = new Recipe("test", "test", "test", 1212);
    recipeBook.AddRecipe(recipe6);
    var testRecipe = new Recipe("test", "test", "test", 2323);
    recipeBook.AddRecipe(testRecipe);

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
        default:
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


Console.WriteLine("Пример работы метода расширения GroupByYear()");
var yearDict = recipeBook.GroupByYear(2000);
foreach (var year in yearDict)
{
    Console.WriteLine(year);
}
