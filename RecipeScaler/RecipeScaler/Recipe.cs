using System;
using System.Collections.Generic;
using System.Linq;

namespace RecipeScaler
{
    // Class representing a recipe
    class Recipe
    {
        // Properties
        public string Name { get; private set; }
        private List<Ingredient> ingredients;
        private List<string> steps;

        // Constructor
        public Recipe(string name)
        {
            Name = name;
            ingredients = new List<Ingredient>();
            steps = new List<string>();
        }

        // Method to add an ingredient to the recipe
        public void AddIngredient(Ingredient ingredient)
        {
            ingredients.Add(ingredient);
        }

        // Method to add a step to the recipe
        public void AddStep(string description)
        {
            steps.Add(description);
        }

        // Method to print the recipe
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

        // Method to calculate the total calories of the recipe
        public int GetTotalCalories()
        {
            return ingredients.Sum(ingredient => ingredient.Calories);
        }
    }
}
