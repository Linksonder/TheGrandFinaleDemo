using GalaSoft.MvvmLight;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MijnPasta
{
    public class ReceptViewModel : ViewModelBase
    {

        public ObservableCollection<Ingredient> Ingredienten { get; set; }

        public ReceptViewModel(IIngredientenRepository repo)
        {
            Ingredienten = new ObservableCollection<Ingredient>(repo.GetAllIngredienten());
        }
    }


}
