using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;

namespace ViewModels
{
    public class MainViewModel : BaseViewModel
    {
        public ICommand CalculateAgeCommand { get; }
        public MainViewModel()
        {
            Title = "דף הבית";
            CalculateAgeCommand = new Command(CalculateAge);
        }
        private string _yearOfBirth = string.Empty;
        private string _result = string.Empty;
        public string YearOfBirth
        {
            get => _yearOfBirth;
            set
            {
                if (_yearOfBirth != value)
                {
                    _yearOfBirth = value;
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
        public void CalculateAge()
        {
            if (int.TryParse(YearOfBirth, out int birthYear))
            {
                int currentYear = DateTime.Now.Year;
                int age = currentYear - birthYear;
                Result = $"הגיל שלך הוא: {age}";
            }
            else
            {
                Result = "נא להכניס שנה תקינה במספרים.";
            }
        }
    }

}
