using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;

namespace ViewModels
{
    public class WelcomeViewModel: BaseViewModel
    {
        public ICommand NavigateToHomeCommand { get; }

        public ICommand NavigateToAboutCommand { get; }

        public WelcomeViewModel()
        {
            //// נווט לדף הבית
            //NavigateToHomeCommand = new Command(async () => await Shell.Current.GoToAsync("MainPage"));

            //// נווט לדף אודות
            //NavigateToAboutCommand = new Command(async () => await Shell.Current.GoToAsync("AboutPage"));

            // נווט לדף הבית + שחרור ההמבורגר
            NavigateToHomeCommand = new Command(async () =>
            {
                //Shell.Current.FlyoutBehavior = FlyoutBehavior.Flyout; // 1. משחרר את החסימה
                await Shell.Current.GoToAsync("//MainPage");          // 2. ניווט מוחלט (Absolute)
            });

            // נווט לדף אודות + שחרור ההמבורגר
            NavigateToAboutCommand = new Command(async () =>
            {
                //Shell.Current.FlyoutBehavior = FlyoutBehavior.Flyout; // 1. משחרר את החסימה
                await Shell.Current.GoToAsync("//AboutPage");         // 2. ניווט מוחלט (Absolute)
            });


            Title = "Welcome Page";
        }

    }
}
