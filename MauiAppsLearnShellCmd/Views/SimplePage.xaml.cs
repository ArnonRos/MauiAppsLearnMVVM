using ViewModels;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace Views;

public partial class SimplePage : ContentPage, INotifyPropertyChanged
//public partial class SimplePage : ContentPage
{

    // מאפיין לדוגמה שתרצה להציג ב-XAML
    private string _myCustomProperty = "שלום מהקוד מאחור!";

    public string MyCustomProperty
    {
        get => _myCustomProperty;
        set
        {
            if (_myCustomProperty != value)
            {
                _myCustomProperty = value;
                // שולח התראה ל-XAML שהערך השתנה
                OnPropertyChanged();
            }
        }
    }

    public SimplePage()
    {
        InitializeComponent();
        //BindingContext = this;
        //MyCustomProperty = "שלום עדכון מהקוד מאחור Binding MyCustomProperty!";
        //MyLabel.Text = "x:name שלום עדכון מהקוד מאחור!";
    }


    //   public SimplePage() : this(new SimpleViewModel())
    //   {


    //   }
    //   public SimplePage(SimpleViewModel viewModel)
    //{
    //	InitializeComponent();
    //       // הגדרת הדף הנוכחי כמקור המידע עבור ה-XAML
    //       BindingContext = this;
    //       //BindingContext = viewModel;
    //   }
}