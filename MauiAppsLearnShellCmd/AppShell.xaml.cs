using Views;

namespace MauiAppShellSampleCmd
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute("InternalPageNotInFlyout", typeof(InternalPageNotInFlyout));
            Routing.RegisterRoute("SimplePage", typeof(SimplePage));
        }
    }
}
