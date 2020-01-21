using System.Collections.Generic;
using Xunit;

namespace Recipes.Tests
{
    public class RecipeTest
    {
        private const string RecipeName = "name";
        private readonly Recipe _recipe;

        public RecipeTest()
        {
            _recipe = new Recipe(RecipeName);
        }

        [Fact]
        public void RecipeShouldHaveAName()
        {
            Assert.Equal(RecipeName, _recipe.Name);
        }

        [Fact]
        public void RecipeShouldHaveAListForIngredients()
        {
            Assert.IsType<List<Ingredient>>(_recipe.Ingredients);
        }
        
        [Fact]
        public void ShouldAddIngredients()
        {
            var ingredient = new Ingredient(string.Empty, string.Empty);
            _recipe.AddIngredient(ingredient);

            Assert.Contains(ingredient, _recipe.Ingredients);
        }
    }
}