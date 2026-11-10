using System.Windows.Input;

namespace ViewModels
{
    public class WelcomeViewModel : BaseViewModel
    {
        public ICommand NavigateToCalcAgeCommand { get; }
        public ICommand NavigateToCalculatorCommand { get; }

        public WelcomeViewModel()
        {
            Title = "ברוכים הבאים";

            // ניווט מוחלט (//) - הנתיבים מוגדרים ב-Route של AppShell.xaml
            NavigateToCalcAgeCommand = new Command(async () =>
                await Shell.Current.GoToAsync("//CalcAge"));

            NavigateToCalculatorCommand = new Command(async () =>
                await Shell.Current.GoToAsync("//CalculatorPage"));
        }
    }
}
