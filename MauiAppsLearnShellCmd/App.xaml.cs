using Microsoft.Extensions.DependencyInjection;

namespace MauiAppShellSampleCmd
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
        }

        protected override Window CreateWindow(IActivationState? activationState)
        {
            var window = new Window(new AppShell());

            #if WINDOWS
                // קביעת רוחב וגובה קבועים שמתאימים לעיצוב הצר שלך
                window.Width = 450; 
                window.Height = 1000;

                // אופציונלי: מניעת האפשרות של המשתמש לשנות את גודל החלון
                // window.MinimumWidth = 450;
                // window.MaximumWidth = 450;
            #endif

            return window;
        }


    }
}