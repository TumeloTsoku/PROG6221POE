/*using RecipeScaler;

class Program
{
    static void Main(string[] args)
    {
        
           Console.Write("Enter the number of ingredients: ");
            int numIngredients = int.Parse(Console.ReadLine());
            Console.Write("Enter the number of steps: ");
            int numSteps = int.Parse(Console.ReadLine());
            Recipe1 recipe = new Recipe1(numIngredients, numSteps);

            for (int i = 0; i < numIngredients; i++)
            {
                Console.Write("Enter ingredient {0} name: ", i + 1);
                string name = Console.ReadLine();
                Console.Write("Enter ingredient {0} quantity: ", i + 1);
                float quantity = float.Parse(Console.ReadLine());
                Console.Write("Enter ingredient {0} unit: ", i + 1);
                string unit = Console.ReadLine();
                recipe.SetIngredient(i, name, quantity, unit);
            }

            for (int i = 0; i < numSteps; i++)
            {
                Console.Write("Enter step {0} description: ", i + 1);
                string description = Console.ReadLine();
                recipe.SetStep(i, description);
            }

            recipe.PrintRecipe();

            Console.Write("Enter scaling factor (0.5, 2, or 3): ");
            float factor = float.Parse(Console.ReadLine());
            recipe.ScaleRecipe(factor);

            recipe.PrintRecipe();
        }
    }



*/