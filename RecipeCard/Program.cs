using System;

Ingredient[] ingredients =
{
    new Ingredient("스파게티면", 200, "g"),
    new Ingredient("토마토소스", 150, "ml"),
    new Ingredient("양파", 1, "개"),
    new Ingredient("마늘", 3, "쪽"),
};

RecipeCard tomato_pasta = new RecipeCard("토마토 파스타", 2, ingredients);
Console.WriteLine("=== 원본 레시피 ===");
tomato_pasta.PrintRecipe();

RecipeCard new_pasta = tomato_pasta.ScaleRecipe(4);
Console.WriteLine("\n=== 4인분으로 변환 ===");
new_pasta.PrintRecipe();