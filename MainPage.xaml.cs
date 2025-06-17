namespace BugWindowsFocus
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void OnOpenModalClicked(object sender, EventArgs e)
        {
            await this.Navigation.PushModalAsync(new NavigationPage(new ModalPage()), true);
        }
    }
}
