using System;
using System.Collections.Generic;
using Xunit;

namespace Recipes.Tests
{
    public class RecipeTest
    {
        [Fact]
        public void RecipeShouldHaveAName()
        {
            var name = "name";
            var recipe = new Recipe(name);
            
            Assert.Equal(name, recipe.Name);
        }

        [Fact]
        public void RecipeShouldHaveAListForIngredients()
        {
            var recipe = new Recipe(String.Empty);

            Assert.IsType<List<Ingredient>>(recipe.Ingredients);
        }
    }
}