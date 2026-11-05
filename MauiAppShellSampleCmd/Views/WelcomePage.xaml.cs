using ViewModels;
namespace Views;

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

    //private async void OnAboutClicked(object sender, EventArgs e)
    //{
    //    // נווט לדף אודות
    //    await Shell.Current.GoToAsync("AboutPage");

    //}

    //private async void OnHomeClicked(object sender, EventArgs e)
    //{
    //    await Shell.Current.GoToAsync("MainPage");
    //}
}