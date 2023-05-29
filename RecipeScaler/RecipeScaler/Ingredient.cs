namespace RecipeScaler
{
    // Class representing an ingredient
    class Ingredient
    {
        // Properties
        public string Name { get; private set; }  // The name of the ingredient
        public float Quantity { get; private set; }  // The quantity of the ingredient
        public string Unit { get; private set; }  // The unit of measurement for the ingredient
        public int Calories { get; private set; }  // The number of calories in the ingredient
        public string FoodGroup { get; private set; }  // The food group that the ingredient belongs to

        // Constructor
        public Ingredient(string name, float quantity, string unit, int calories, string foodGroup)
        {
            Name = name;
            Quantity = quantity;
            Unit = unit;
            Calories = calories;
            FoodGroup = foodGroup;
        }
    }
}
