using Practice;

var recipeBook = new RecipeCollection();
recipeBook.AddRecipe(new Recipe("Лютая дичь","Юлия Высоцкая","Марсианская",2000));
recipeBook.AddRecipe(new Recipe("Батин Суп","Батя","Авторская",1980));
recipeBook.AddRecipe(new Recipe("Голубцы с Говном", "Иван Семеныч","газета Мегаполис-Экспресс",2005));
recipeBook.AddRecipe(new Recipe("Хрючево","ХЗ кто","Кухня времен царя Гороха",1200));
var recipe6 = new Recipe("test","test","test",1212);
recipeBook.AddRecipe(recipe6);

//TODO: починить итератор в RecipeCollection
// смотреть тут - https://learn.microsoft.com/ru-ru/dotnet/api/system.collections.ienumerable?view=net-9.0
foreach (var recipe in recipeBook)
{
    Console.WriteLine(recipe);
}



