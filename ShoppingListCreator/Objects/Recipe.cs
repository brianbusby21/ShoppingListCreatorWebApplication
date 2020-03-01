using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingListCreator.Objects
{
    public class Recipe
    {
        //private readonly Dictionary<string, Ingredient> _recipeList;
        private readonly List<Ingredient> _recipeList;

        public string Name { get; private set; }

        public Recipe(string name)
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                throw new ArgumentNullException("You must provide a name for this recipe");
            }

            _recipeList = new List<Ingredient>();
            this.Name = name;
        }

        public IEnumerable<Ingredient> GetAllIngredients()
        {
            return _recipeList;
        }

        public bool AddIngredient(Ingredient ingredient)
        {
            if (ingredient != null)
            {
                _recipeList.Add(ingredient);
                return true;
            }
            //No ingredient object
            return false;

        }

        public void ModifyIngredient(Ingredient ingredient)
        {

        }

        public bool RemoveIngredient(string ingredient)
        {
            if (!string.IsNullOrWhiteSpace(ingredient))
            {
                foreach (var item in _recipeList)
                {
                    if (item.Name.ToLower() == ingredient)
                    {
                        _recipeList.Remove(item);
                    }
                }
            }
            //no ingredient passed or does not exist in recipe
            return false;
        }

        public void DisplayRecipe()
        {
            foreach (var ingredient in _recipeList)
            {
                Console.WriteLine($"{ingredient.Amount} {ingredient.Unit} {ingredient.Name}");
            }
        }
    }
}
