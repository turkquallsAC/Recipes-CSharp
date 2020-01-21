using Xunit;

namespace Recipes.Tests
{
    public class IngredientTest
    {
        [Fact]
        public void IngredientShouldHaveAName()
        {
            var ingredientName = "name";
            var ingredient = new Ingredient(ingredientName);
            
            Assert.Equal(ingredientName, ingredient.Name);
        }

        [Fact]
        public void IngredientHasAnAmount()
        {
            var ingredientAmount = "1/2 cup";
            var ingredient = new Ingredient("name", ingredientAmount);
            
            Assert.Equal(ingredientAmount, ingredient.Amount);
        }
    }
}