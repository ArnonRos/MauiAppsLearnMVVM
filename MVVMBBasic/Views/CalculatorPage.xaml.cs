using ViewModels;

namespace Views
{
    public partial class CalculatorPage : ContentPage
    {
        public CalculatorPage() : this(new CalculatorViewModel())
        {
        }

        public CalculatorPage(CalculatorViewModel viewModel)
        {
            InitializeComponent();
            BindingContext = viewModel;
        }
    }
}
