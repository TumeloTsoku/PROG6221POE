using System.Collections.Generic;
using System.Linq;

namespace RecipeScaler
{
    // Class responsible for managing recipes
    class RecipeManager
    {
        private List<Recipe> recipes;  // List to store all the recipes

        // Constructor
        public RecipeManager()
        {
            recipes = new List<Recipe>();  // Initialize the list of recipes
        }

        // Method to add a recipe to the manager
        public void AddRecipe(Recipe recipe)
        {
            recipes.Add(recipe);  // Add the provided recipe to the list
        }

        // Method to get all the recipes in alphabetical order
        public List<Recipe> GetAllRecipes()
        {
            return recipes.OrderBy(recipe => recipe.Name).ToList();  // Order the recipes by name and return as a new list
        }
    }
}
