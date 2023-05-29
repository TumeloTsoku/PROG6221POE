using System;

class RecipeManager
{
    private List<Recipe> recipes;

    public RecipeManager()
    {
        recipes = new List<Recipe>();
    }

    public void AddRecipe(Recipe recipe)
    {
        recipes.Add(recipe);
    }

    public List<Recipe> GetAllRecipes()
    {
        return recipes.OrderBy(recipe => recipe.Name).ToList();
    }
}
}
