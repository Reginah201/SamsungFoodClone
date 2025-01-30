using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SamsungFood.ViewModels
{
    public class Meal
    {
        public string Title { get; set; }
        public string Date { get; set; }
        public string Image { get; set; }
    }

    public class MainViewModel : BaseViewModel
    {
        public ObservableCollection<Meal> MealPlans { get; set; }

        public MainViewModel()
        {
            MealPlans = new ObservableCollection<Meal>
        {
            new Meal { Title = "Chicken Salad", Date = "Mon 25 Jan", Image = "chicken_salad.jpg" },
            new Meal { Title = "Pasta ", Date = "Tue 26 Jan", Image = "pasta.jpg" },
            new Meal { Title = "Grilled Fish", Date = "Wed 27 Jan", Image = "grilled_fish.jpg" },
             new Meal { Title = "Beef and mashed potatoes", Date = "Thurs 28 Jan", Image = "beef_and_mashpotatoes.jpg" },
            new Meal { Title = "Rice and chicken", Date = "Fri 29 Jan", Image = "rice.jpg" },
            new Meal { Title = "Crispy chicken burrito", Date = "Sat 30 Jan", Image = "burrito.jpg" },
            new Meal { Title = "Chicken enchilada", Date = "Sun 31 Jan", Image = "chicken_enchilada.jpg" }
        };
        }
    }
}
