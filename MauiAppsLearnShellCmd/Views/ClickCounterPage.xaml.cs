
using ViewModels;

namespace Views
{
    public partial class ClickCounterPage : ContentPage
    {
        int count = 0;

        public ClickCounterPage() : this(new ClickCounterViewModel())
        {

        }
        public ClickCounterPage(ClickCounterViewModel viewModel)
        {
            InitializeComponent();
            BindingContext = viewModel;
        }

        private void OnCounterClicked(object? sender, EventArgs e)
        {
            count++;

            if (count == 1)
                CounterBtn.Text = $"Clicked {count} time";
            else
                CounterBtn.Text = $"Clicked {count} times";

            SemanticScreenReader.Announce(CounterBtn.Text);
        }

    }
}
