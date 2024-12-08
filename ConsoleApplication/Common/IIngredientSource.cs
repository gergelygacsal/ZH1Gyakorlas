using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    public interface IIngredientSource
    {
        IEnumerable<Ingredient> GetIngredients();
    }

    public class TrivialIngredientSource : IIngredientSource
    {
        public IEnumerable<Ingredient> GetIngredients()
        {
            var ingredients = new List<Ingredient>();
            for (int i = 0; i < 8; i++)
            {
                ingredients.Add(Ingredient.GetRandom());
            }
            return ingredients;
        }
    }
}
