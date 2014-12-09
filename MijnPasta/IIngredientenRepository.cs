using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MijnPasta
{
    public interface IIngredientenRepository
    {
        IEnumerable<Ingredient> GetAllIngredienten();
    }
}
