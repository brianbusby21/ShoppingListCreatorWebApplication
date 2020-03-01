using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingListCreator.Objects
{
    public class ShoppingList
    {

        private readonly List<Ingredient> _shoppingList;
        private readonly List<Recipe> _recipeCollection;

        public ShoppingList(string name)
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                throw new ArgumentNullException("You must provide a name for this Shopping List");
            }

            _shoppingList = new List<Ingredient>();
            _recipeCollection = new List<Recipe>();
            this.Name = name;
        }

        public string Name { get; private set; }

        public bool AddRecipe(Recipe recipe)
        {
            if (recipe != null)
            {
                _recipeCollection.Add(recipe);
                return true;
            }
            //No ingredient object
            return false;
        }

        public void ModifyRecipe(Recipe recipe)
        {

        }

        public bool RemoveRecipe(string recipe)
        {
            if (!string.IsNullOrWhiteSpace(recipe))
            {
                foreach (var item in _recipeCollection)
                {
                    if (item.Name.ToLower() == recipe)
                    {
                        _recipeCollection.Remove(item);
                    }
                }
            }
            //no ingredient passed or does not exist in recipe
            return false;
        }

        public void CreateShoppingtList()
        {
            foreach (var recipe in _recipeCollection)
            {
                var tempList = recipe.GetAllIngredients();

                foreach (var ingredient in tempList)
                {
                    _shoppingList.Add(ingredient);
                }
            }

            Console.WriteLine("Shopping List Created");
        }

        public void DisplayShoppingList()
        {
            foreach (var ingredient in _shoppingList)
            {
                Console.WriteLine($"{ingredient.Amount} {ingredient.Unit} {ingredient.Name}");
            }
        }
    }
}
