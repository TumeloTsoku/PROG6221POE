using System;
using System.Collections.Generic;
using System.Linq;

namespace RecipeScaler
{
    class Program
    {
        static void Main(string[] args)
        {
            RecipeManager recipeManager = new RecipeManager();

            while (true)
            {
                Console.WriteLine("Select an option:");
                Console.WriteLine("1. Add a recipe");
                Console.WriteLine("2. Display all recipes");
                Console.WriteLine("3. Choose a recipe to display");
                Console.WriteLine("4. Exit");

                int option = int.Parse(Console.ReadLine());

                switch (option)
                {
                    case 1:
                        AddRecipe(recipeManager);
                        break;
                    case 2:
                        DisplayAllRecipes(recipeManager);
                        break;
                    case 3:
                        ChooseRecipeToDisplay(recipeManager);
                        break;
                    case 4:
                        Console.WriteLine("Exiting...");
                        return;
                    default:
                        Console.WriteLine("Invalid option. Please try again.");
                        break;
                }

                Console.WriteLine();
            }
        }

        static void AddRecipe(RecipeManager recipeManager)
        {
            Console.Write("Enter the name of the recipe: ");
            string name = Console.ReadLine();

            Recipe recipe = new Recipe(name);

            Console.Write("Enter the number of ingredients: ");
            int numIngredients = int.Parse(Console.ReadLine());

            for (int i = 0; i < numIngredients; i++)
            {
                Console.Write("Enter ingredient {0} name: ", i + 1);
                string ingredientName = Console.ReadLine();

                Console.Write("Enter ingredient {0} quantity: ", i + 1);
                float quantity = float.Parse(Console.ReadLine());

                Console.Write("Enter ingredient {0} unit: ", i + 1);
                string unit = Console.ReadLine();

                Console.Write("Enter ingredient {0} calories: ", i + 1);
                int calories = int.Parse(Console.ReadLine());

                Console.Write("Enter ingredient {0} food group: ", i + 1);
                string foodGroup = Console.ReadLine();

                Ingredient ingredient = new Ingredient(ingredientName, quantity, unit, calories, foodGroup);
                recipe.AddIngredient(ingredient);
            }

            Console.Write("Enter the number of steps: ");
            int numSteps = int.Parse(Console.ReadLine());

            for (int i = 0; i < numSteps; i++)
            {
                Console.Write("Enter step {0} description: ", i + 1);
                string description = Console.ReadLine();
                recipe.AddStep(description);
            }

            recipeManager.AddRecipe(recipe);

            Console.WriteLine("Recipe added successfully!");
        }

        static void DisplayAllRecipes(RecipeManager recipeManager)
        {
            Console.WriteLine("All Recipes:");
            foreach (Recipe recipe in recipeManager.GetAllRecipes())
            {
                Console.WriteLine(recipe.Name);
            }
        }

        static void ChooseRecipeToDisplay(RecipeManager recipeManager)
        {
            Console.WriteLine("Select a recipe to display:");

            List<Recipe> recipes = recipeManager.GetAllRecipes();
            for (int i = 0; i < recipes.Count; i++)
            {
                Console.WriteLine("{0}. {1}", i + 1, recipes[i].Name);
            }

            int choice = int.Parse(Console.ReadLine());

            if (choice >= 1 && choice <= recipes.Count)
            {
                Recipe selectedRecipe = recipes[choice - 1];
                selectedRecipe.PrintRecipe();

                Console.WriteLine("Total Calories: {0}", selectedRecipe.GetTotalCalories());

                if (selectedRecipe.GetTotalCalories() > 300)
                {
                    Console.WriteLine("Warning: This recipe exceeds 300 calories!");
                }
            }
            else
            {
                Console.WriteLine("Invalid choice. Please try again.");
            }
        }
    }