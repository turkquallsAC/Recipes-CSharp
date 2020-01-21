using System.Collections.Generic;

namespace Recipes
{
    public class Recipe
    {
        public string Name { get; }
        public List<Ingredient> Ingredients { get; }

        public Recipe(string name)
        {
            Name = name;
            Ingredients = new List<Ingredient>();
        }

        public void AddIngredient(Ingredient ingredient)
        {
            Ingredients.Add(ingredient);
        }
    }
}