using System.Collections.Generic;

namespace Recipes
{
    public class Recipe
    {
        public string Name { get; private set; }
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

        public void RemoveIngredient(Ingredient ingredient)
        {
            Ingredients.Remove(ingredient);
        }

        public void UpdateName(string name)
        {
            Name = name;
        }
    }
}