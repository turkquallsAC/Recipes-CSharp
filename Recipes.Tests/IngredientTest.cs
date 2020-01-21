using Xunit;

namespace Recipes.Tests
{
    public class IngredientTest
    {
        private const string IngredientName = "name";
        private const string IngredientAmount = "amount";
        private readonly Ingredient _ingredient;

        public IngredientTest()
        {
            _ingredient = new Ingredient(IngredientName, IngredientAmount);
        }

        [Fact]
        public void IngredientShouldHaveAName()
        {
            Assert.Equal(IngredientName, _ingredient.Name);
        }

        [Fact]
        public void IngredientHasAnAmount()
        {
            Assert.Equal(IngredientAmount, _ingredient.Amount);
        }
    }
}