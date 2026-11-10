using ViewModels;

namespace Views;

public partial class SimplePage : ContentPage
{
    // מאפיין לדוגמה שתרצה להציג ב-XAML
    //public string MyCustomProperty { get; set; } = "שלום מהקוד מאחור!";

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

    public SimplePage()
    {
        InitializeComponent();
        //BindingContext = this;
        MyLabel.Text = "שלום מהקוד מאחור!";
    }
}