using System;
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

        [Fact]
        public void ShouldRemoveIngredient()
        {
            var ingredient1 = new Ingredient("ingredient 1", String.Empty);
            var ingredient2 = new Ingredient("ingredient 2", String.Empty);
            _recipe.AddIngredient(ingredient1);
            _recipe.AddIngredient(ingredient2);

            _recipe.RemoveIngredient(ingredient1);
            
            Assert.DoesNotContain(ingredient1, _recipe.Ingredients);
        }
    }
}