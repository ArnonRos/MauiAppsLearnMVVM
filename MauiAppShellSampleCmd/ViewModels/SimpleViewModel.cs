using System;
using System.Collections.Generic;
using System.Text;

namespace ViewModels
{
    public class SimpleViewModel:BaseViewModel
    {
        // מאפיין לדוגמה שתרצה להציג ב-XAML
        public string MyCustomProperty { get; set; } = "שלום מהקוד מאחור!";

        public SimpleViewModel()
        {
            Title = "דף פשוט";
        }
    }
}
