using Common;
using Xunit;

namespace Tests
{
    public class TrivialIngredientSourceTests
    {
        [Fact]
        public void TestCount()
        {
            var source = new TrivialIngredientSource();
            var ingredients = source.GetIngredients();

            Assert.Equal(8, ingredients.Count());
        }
    }
}
