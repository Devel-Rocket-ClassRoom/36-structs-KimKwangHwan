using System;
using System.Collections.Generic;
using System.Text;

struct RecipeCard
{
    public string Name;
    public int Servings;
    public Ingredient[] Ingredients;

    public RecipeCard(string name, int servings, Ingredient[] ingredients)
    {
        Name = name;
        Servings = servings;
        Ingredients = ingredients;
    }

    public void PrintRecipe()
    {
        Console.WriteLine($"[{Name}] ({Servings}인분)");
        foreach (Ingredient ingredient in Ingredients)
        {
            Console.WriteLine($"- {ingredient.Name}: {ingredient.Amount}{ingredient.Unit}");
        }
    }

    public RecipeCard ScaleRecipe(int newServings)
    {
        RecipeCard new_recipeCard = new RecipeCard(Name, newServings, Ingredients);

        for (int i = 0; i < Ingredients.Length; i++)
        {
            new_recipeCard.Ingredients[i].Amount = (int)(Ingredients[i].Amount * ((double)newServings / Servings));
        }

        return new_recipeCard;
    }
}