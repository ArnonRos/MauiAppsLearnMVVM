using System.Windows.Input;

namespace ViewModels
{
    public class CalculatorViewModel : BaseViewModel
    {
        private string _number1 = string.Empty;
        private string _number2 = string.Empty;
        private string _result = "0";

        public ICommand AddCommand { get; }
        public ICommand SubtractCommand { get; }
        public ICommand MultiplyCommand { get; }
        public ICommand DivideCommand { get; }

        public CalculatorViewModel()
        {
            Title = "מחשבון";

            AddCommand = new Command(async () => await CalculateAsync((a, b) => a + b));
            SubtractCommand = new Command(async () => await CalculateAsync((a, b) => a - b));
            MultiplyCommand = new Command(async () => await CalculateAsync((a, b) => a * b));
            DivideCommand = new Command(async () => await DivideAsync());
        }

        public string Number1
        {
            get => _number1;
            set
            {
                if (_number1 != value)
                {
                    _number1 = value;
                    OnPropertyChanged();
                }
            }
        }

        public string Number2
        {
            get => _number2;
            set
            {
                if (_number2 != value)
                {
                    _number2 = value;
                    OnPropertyChanged();
                }
            }
        }

        public string Result
        {
            get => _result;
            set
            {
                if (_result != value)
                {
                    _result = value;
                    OnPropertyChanged();
                }
            }
        }

        // חיבור / חיסור / כפל - אותה לוגיקה, רק הפעולה משתנה
        private async Task CalculateAsync(Func<double, double, double> operation)
        {
            var (isValid, num1, num2) = await TryGetInputsAsync();
            if (isValid)
            {
                Result = operation(num1, num2).ToString();
            }
        }

        private async Task DivideAsync()
        {
            var (isValid, num1, num2) = await TryGetInputsAsync();
            if (!isValid)
                return;

            // הגנה מפני חלוקה באפס
            if (num2 == 0)
            {
                await ShowAlertAsync("שגיאה", "לא ניתן לחלק באפס!", "אישור");
                Result = "שגיאה";
                return;
            }

            Result = (num1 / num2).ToString();
        }

        // קריאת הקלט מתוך המאפיינים (ולא מתוך Entry) ובדיקת תקינות
        private async Task<(bool isValid, double num1, double num2)> TryGetInputsAsync()
        {
            bool isNum1Valid = double.TryParse(Number1, out double num1);
            bool isNum2Valid = double.TryParse(Number2, out double num2);

            if (!isNum1Valid || !isNum2Valid)
            {
                await ShowAlertAsync("קלט לא תקין", "אנא הכנס מספרים תקינים בשתי התיבות", "אישור");
                return (false, 0, 0);
            }

            return (true, num1, num2);
        }
    }
}
