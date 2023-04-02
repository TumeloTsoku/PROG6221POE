using System;

class Ingredient
{
    public string Name { get; private set; }
    public float Quantity { get; private set; }
    public string Unit { get; private set; }
    public int Calories { get; private set; }
    public string FoodGroup { get; private set; }

    public Ingredient(string name, float quantity, string unit, int calories, string foodGroup)
    {
        Name = name;
        Quantity = quantity;
        Unit = unit;
        Calories = calories;
        FoodGroup = foodGroup;
    }
}

