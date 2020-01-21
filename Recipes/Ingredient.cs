using System;

namespace Recipes
{
    public class Ingredient
    {
        public string Name { get; }
        public string Amount { get; }

        public Ingredient(string name, string amount)
        {
            Name = name;
            Amount = amount;
        }
    }
}
