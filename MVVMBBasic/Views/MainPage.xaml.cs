using ViewModels;

namespace Views
{
    public partial class MainPage : ContentPage
    {


        public MainPage() : this(new MainViewModel())
        {
        }

        // קבלת ה-ViewModel ישירות דרך Dependency Injection וחיבור ה-Binding Context
        public MainPage(MainViewModel viewModel)
        {
            InitializeComponent();
            BindingContext = viewModel;
        }



        //// פונקציית האירוע (Event Handler)
        //private void OnCalculateAgeClicked(object sender, EventArgs e)
        //{
        //    // 1. קריאה ישירה מרכיב ה-XAML
        //    if (int.TryParse(YearEntry.Text, out int birthYear))
        //    {
        //        int currentYear = DateTime.Now.Year;
        //        int age = currentYear - birthYear;

        //        // 2. כתיבה והזרקה ישירה לרכיב ה-XAML
        //        ResultLabel.Text = $"הגיל שלך הוא: {age}";
        //    }
        //    else
        //    {
        //        ResultLabel.Text = "נא להכניס שנה תקינה במספרים.";
        //    }
        //}
    }
}
