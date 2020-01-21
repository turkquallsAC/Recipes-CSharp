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
    }
}