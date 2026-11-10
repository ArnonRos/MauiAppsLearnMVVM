using System;
using Microsoft.Maui.Controls;

namespace Views
{
    public partial class CalculatorPage : ContentPage
    {
        public CalculatorPage()
        {
            InitializeComponent();
        }

        // פעולת חיבור (+)
        private async void OnAddClicked(object sender, EventArgs e)
        {
            var (isValid, num1, num2) = await TryGetInputs();
            if (isValid)
            {
                double result = num1 + num2;
                ResultLabel.Text = result.ToString();
            }
        }

        // פעולת חיסור (-)
        private async void OnSubtractClicked(object sender, EventArgs e)
        {
            var (isValid, num1, num2) = await TryGetInputs();
            if (isValid)
            {
                double result = num1 - num2;
                ResultLabel.Text = result.ToString();
            }
        }

        // פעולת כפל (*)
        private async void OnMultiplyClicked(object sender, EventArgs e)
        {
            var (isValid, num1, num2) = await TryGetInputs();
            if (isValid)
            {
                double result = num1 * num2;
                ResultLabel.Text = result.ToString();
            }
        }

        // פעולת חילוק (/)
        private async void OnDivideClicked(object sender, EventArgs e)
        {
            var (isValid, num1, num2) = await TryGetInputs();
            if (isValid)
            {
                // הגנה מפני חלוקה באפס
                if (num2 == 0)
                {
                    await DisplayAlertAsync("שגיאה", "לא ניתן לחלק באפס!", "אישור");
                    ResultLabel.Text = "שגיאה";
                    return;
                }

                double result = num1 / num2;
                ResultLabel.Text = result.ToString();
            }
        }

        // פונקציית עזר אסינכרונית לקריאת הנתונים מהמסך ובדיקת תקינותם (שימוש ב-Tuple)
        private async Task<(bool isValid, double num1, double num2)> TryGetInputs()
        {
            bool isNum1Valid = double.TryParse(Number1Entry.Text, out double num1);
            bool isNum2Valid = double.TryParse(Number2Entry.Text, out double num2);

            if (!isNum1Valid || !isNum2Valid)
            {
                await DisplayAlertAsync("קלט לא תקין", "אנא הכנס מספרים תקינים בשתי התיבות", "אישור");
                return (false, 0, 0);
            }

            return (true, num1, num2);
        }
    }
}



