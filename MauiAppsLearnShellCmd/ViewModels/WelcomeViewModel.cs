using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;

namespace ViewModels
{
    public class WelcomeViewModel: BaseViewModel
    {
        public ICommand NavigateToClickCounterCommand { get; }

        public ICommand NavigateToAboutCommand { get; }

        public WelcomeViewModel()
        {
            //// נווט לדף מונה לחיצות
            //NavigateToClickCounterCommand = new Command(async () => await Shell.Current.GoToAsync("ClickCounterPage"));

            //// נווט לדף אודות
            //NavigateToAboutCommand = new Command(async () => await Shell.Current.GoToAsync("AboutPage"));

            // נווט לדף הבית + שחרור ההמבורגר
            NavigateToClickCounterCommand = new Command(async () =>
            {
                //Shell.Current.FlyoutBehavior = FlyoutBehavior.Flyout; // 1. משחרר את החסימה
                await Shell.Current.GoToAsync("//ClickCounterPage");          // 2. ניווט מוחלט (Absolute)
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
