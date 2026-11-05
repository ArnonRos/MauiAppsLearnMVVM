using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;

namespace ViewModels
{
    public class WelcomeViewModel
    {
        public ICommand NavigateToHomeCommand { get; }

        public ICommand NavigateToAboutCommand { get; }

        public WelcomeViewModel()
        {
            // נווט לדף הבית
            NavigateToHomeCommand = new Command(async () => await Shell.Current.GoToAsync("//MainPage"));

            // נווט לדף אודות
            NavigateToAboutCommand = new Command(async () => await Shell.Current.GoToAsync("//AboutPage"));

        }
    }
}
