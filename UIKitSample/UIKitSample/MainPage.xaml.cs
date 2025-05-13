using UIKitSample.Views.Navigation;

namespace UIKitSample
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void NavigateToMovie(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Movies());
        }

        private async void NavigateToRestaurant(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Restaurant());
        }

        private async void NavigateToPlaylist(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new SongPlayList());
        }
    }
}
