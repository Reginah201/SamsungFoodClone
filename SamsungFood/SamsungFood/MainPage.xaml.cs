

using SamsungFood.View;

namespace SamsungFood
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }
        private async void OnMealSelected(object sender, SelectionChangedEventArgs e)
        {
            if (e.CurrentSelection.Count > 0)
            {
                string selectedMeal = e.CurrentSelection[0] as string;
                await Navigation.PushAsync(new MealDetailPage(selectedMeal));
            }
        }


        
    }

}
