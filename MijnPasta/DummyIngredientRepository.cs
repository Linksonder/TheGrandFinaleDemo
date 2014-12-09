using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MijnPasta
{
    class DummyIngredientRepository : IIngredientenRepository
    {
        public IEnumerable<Ingredient> GetAllIngredienten()
        {
            return new List<Ingredient>()
            {
                new Ingredient{Naam = "Kip", Aantal = 3},
                new Ingredient{Naam = "Kip bouten", Aantal = 2},
                new Ingredient{ Naam = "knoflook", Aantal = 10},
            };
        }

    }
}
