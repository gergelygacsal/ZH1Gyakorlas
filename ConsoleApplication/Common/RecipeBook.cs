using System.Text.RegularExpressions;

namespace Common
{
    public class RecipeBook : IIngredientSource
    {
        private List<Ingredient> _ingredients = new List<Ingredient>();

        public void Add(string name, int count, string unit)
        {
            if (!Regex.IsMatch(name, @"^[A-Za-záéíóöőúüűÁÉÍÓÖŐÚÜŰ\s]+$"))
            {
                throw new ArgumentException("Hibás névformátum!");
            }

            _ingredients.Add(new Ingredient(name, count, unit));
        }

        public IEnumerable<Ingredient> GetIngredients()
        {
            return _ingredients;
        }
    }
}
