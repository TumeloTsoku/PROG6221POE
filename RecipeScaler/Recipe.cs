using System;

class Recipe
{
    public string Name { get; private set; }
    private List<Ingredient> ingredients;
    private List<string> steps;

    public Recipe(string name)
    {
        Name = name;
        ingredients = new List<Ingredient>();
        steps = new List<string>();
    }

    public void AddIngredient(Ingredient ingredient)
    {
        ingredients.Add(ingredient);
    }

    public void AddStep(string description)
    {
        steps.Add(description);
    }

    public void PrintRecipe()
    {
        Console.WriteLine("Ingredients:");
        foreach (Ingredient ingredient in ingredients)
        {
            Console.WriteLine("- {0} {1} {2} ({3} calories) [{4}]", ingredient.Quantity, ingredient.Unit,
                ingredient.Name, ingredient.Calories, ingredient.FoodGroup);
        }

        Console.WriteLine("Steps:");
        for (int i = 0; i < steps.Count; i++)
        {
            Console.WriteLine("{0}. {1}", i + 1, steps[i]);
        }
    }

    public int GetTotalCalories()
    {
        return ingredients.Sum(ingredient => ingredient.Calories);
    }
}
