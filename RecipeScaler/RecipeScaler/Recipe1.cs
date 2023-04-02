using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecipeScaler
{
    class Recipe1
    {
        private string[] ingredients;
        private float[] quantities;
        private string[] units;
        private string[] steps;

        private float[] originalQuantities; // Added to store original quantities

        public Recipe1(int numIngredients, int numSteps)
        {
            ingredients = new string[numIngredients];
            quantities = new float[numIngredients];
            units = new string[numIngredients];
            steps = new string[numSteps];

            originalQuantities = new float[numIngredients]; // Initialize originalQuantities array
        }

        public void SetIngredient(int index, string name, float quantity, string unit)
        {
            ingredients[index] = name;
            quantities[index] = quantity;
            units[index] = unit;

            originalQuantities[index] = quantity; // Store original quantity
        }

        public void SetStep(int index, string description)
        {
            steps[index] = description;
        }

        public void PrintRecipe()
        {
            Console.WriteLine("Ingredients:");
            for (int i = 0; i < ingredients.Length; i++)
            {
                Console.WriteLine("- {0} {1} {2}", quantities[i], units[i], ingredients[i]);
            }
            Console.WriteLine("Steps:");
            for (int i = 0; i < steps.Length; i++)
            {
                Console.WriteLine("{0}. {1}", i + 1, steps[i]);
            }
        }

        public void ScaleRecipe(float factor)
        {
            for (int i = 0; i < quantities.Length; i++)
            {
                quantities[i] *= factor;
            }
        }

        public void ResetQuantities()
        {
            for (int i = 0; i < quantities.Length; i++)
            {
                quantities[i] = originalQuantities[i]; // Reset quantities to original values
            }
        }

        public void ClearRecipe()
        {
            Array.Clear(ingredients, 0, ingredients.Length); // Clear ingredient array
            Array.Clear(quantities, 0, quantities.Length); // Clear quantities array
            Array.Clear(units, 0, units.Length); // Clear units array
            Array.Clear(steps, 0, steps.Length); // Clear steps array
            Array.Clear(originalQuantities, 0, originalQuantities.Length); // Clear originalQuantities array
        }
    }
}