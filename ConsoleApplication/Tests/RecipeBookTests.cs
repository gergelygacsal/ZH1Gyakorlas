using Common;
using Xunit;

namespace Tests
{
    public class RecipeBookTests
    {
        [Fact]
        public void Add_ValidIngredient_ShouldSucceed()
        {
            var book = new RecipeBook();
            book.Add("Liszt", 500, "gramm");

            Assert.Single(book.GetIngredients());
        }

        [Fact]
        public void Add_InvalidName_ShouldThrowException()
        {
            var book = new RecipeBook();

            Assert.Throws<ArgumentException>(() => book.Add("123", 500, "gramm"));
        }
    }
}
