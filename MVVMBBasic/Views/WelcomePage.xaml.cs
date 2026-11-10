using ViewModels;

namespace Views
{
    public partial class WelcomePage : ContentPage
    {
        public WelcomePage() : this(new WelcomeViewModel())
        {
        }

        public WelcomePage(WelcomeViewModel viewModel)
        {
            InitializeComponent();
            BindingContext = viewModel;
        }
    }
}
