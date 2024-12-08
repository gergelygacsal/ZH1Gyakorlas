using Common;

namespace ConsoleApplication
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var recipeBook = new RecipeBook();
            var ingredientSource = new TrivialIngredientSource();

            foreach (var ingredient in ingredientSource.GetIngredients())
            {
                recipeBook.Add(ingredient.Name, ingredient.Count, ingredient.Unit);
            }

            Console.WriteLine("Hozzáadott összetevők:");
            foreach (var ingredient in recipeBook.GetIngredients())
            {
                Console.WriteLine(ingredient.ToString());
            }
            Console.ReadKey();
        }
    }
}
