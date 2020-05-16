using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace MyTipCalculator
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        void Button_Clicked(System.Object sender, System.EventArgs e)
        {
            var billValue = int.Parse(bill.Text);
            var tipPercentage = 200;
            var splitValue = int.Parse(split.Text);

            totalPerPerson.Text = CalculateTotalIncludingTip(billValue, tipPercentage).ToString();
            bill.Text = billInput.ToString();
            tip.Text = CalculateTip(billValue, tipPercentage).ToString();
        }

        int CalculateTotalIncludingTip(int billTotal, int tipPercentage)
        {
            var trueTipPercentage = tipPercentage / 100;
            return billTotal * (1 + trueTipPercentage);
        }

        double CalculateTip(int billTotal, int tipPercentage)
        {
            var trueTipPercentage = tipPercentage / 100;
            return billTotal * trueTipPercentage;
        }

    }
}
