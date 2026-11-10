using ViewModels;
namespace Views
{

    public partial class WelcomePage : ContentPage
    {
        public WelcomePage() : this(new WelcomeViewModel())
        {
        }

        // קבלת ה-ViewModel ישירות דרך Dependency Injection וחיבור ה-Binding Context
        public WelcomePage(WelcomeViewModel viewModel)
        {
            InitializeComponent();
            BindingContext = viewModel;
        }

        private async void OnContactClicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync("ContactPage");
        }

        private async void OnInternalClicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync("InternalPageNotInFlyout");

        }

        private void OnSimplePageClicked(object sender, EventArgs e)
        {
                        // נווט לדף פשוט מאפיין בקוד אחורי
            Shell.Current.GoToAsync("SimplePage");
        }

        //private async void OnAboutClicked(object sender, EventArgs e)
        //{
        //    // נווט לדף אודות
        //    await Shell.Current.GoToAsync("AboutPage");

        //}

        //private async void OnHomeClicked(object sender, EventArgs e)
        //{
        //    await Shell.Current.GoToAsync("ClickCounterPage");
        //}
    }
}