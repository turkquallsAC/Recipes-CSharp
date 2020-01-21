using System;
using Xunit;

namespace Recipes.Tests
{
    public class IngredientTest
    {
        [Fact]
        public void IngredientShouldHaveAName()
        {
            var name = "name";
            var ingredient = new Ingredient(name, String.Empty);
            
            Assert.Equal(name, ingredient.Name);
        }

        [Fact]
        public void IngredientHasAnAmount()
        {
            var amount = "1/2 cup";
            var ingredient = new Ingredient(String.Empty, amount);
            
            Assert.Equal(amount, ingredient.Amount);
        }
    }
}