using Practice;

var recipeBook = new RecipeCollection();
recipeBook.AddRecipe(new Recipe("Лютая дичь","Юлия Высоцкая","Марсианская",2000));
recipeBook.AddRecipe(new Recipe("Батин Суп","Батя","Авторская",1980));
recipeBook.AddRecipe(new Recipe("Голубцы с Говном", "Иван Семеныч","газета Мегаполис-Экспресс",2005));
recipeBook.AddRecipe(new Recipe("Хрючево","ХЗ кто","Кухня времен царя Гороха",1200));
var recipe6 = new Recipe("test","test","test",1212);
recipeBook.AddRecipe(recipe6);
for(int i = 0; i < recipeBook.GetCapacity(); i++)
{
    Console.WriteLine(recipeBook[i]);
}

