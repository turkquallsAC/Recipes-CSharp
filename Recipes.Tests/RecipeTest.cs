using Xunit;

namespace Recipes.Tests
{
    public class RecipeTest
    {
        [Fact]
        public void RecipeShouldHaveAName()
        {
            var name = "name";
            var recipe = new RecipeTest(name);
            
            Assert.Equal(name, recipe.Name);
        }
    }
}