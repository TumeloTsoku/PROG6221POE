using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecipeScaler
{
    using System;

    class Recipe1
    {
        private string[] ingredients;
        private float[] quantities;
        private string[] units;
        private string[] steps;

        public Recipe1(int numIngredients, int numSteps)
        {
            ingredients = new string[numIngredients];
            quantities = new float[numIngredients];
            units = new string[numIngredients];
            steps = new string[numSteps];
        }

        public void SetIngredient(int index, string name, float quantity, string unit)
        {
            ingredients[index] = name;
            quantities[index] = quantity;
            units[index] = unit;
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
            // TODO: Implement code to reset quantities to original values
        }

        public void ClearRecipe()
        {
            // TODO: Implement code to clear all recipe data
        }
    }
}

