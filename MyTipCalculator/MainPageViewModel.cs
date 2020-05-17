using System;
using System.ComponentModel;
using System.Windows.Input;
using Xamarin.Forms;

namespace MyTipCalculator
{
    public class MainPageViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public ICommand CalculateCommand => new Command(Calculate);

        double total = 0.00;
        public double Total
        {
            get => total;
            set
            {
                if (total == value)
                    return;
                total = value;
                OnPropertyChanged(nameof(Total));
            }
        }

        double bill = 0.00;
        public double Bill
        {
            get => bill;
            set
            {
                if (bill == value)
                    return;
                bill = value;
                OnPropertyChanged(nameof(Bill));
            }
        }

        double billEntry = 0.00;
        public double BillEntry
        {
            get => billEntry;
            set
            {
                if (billEntry == value)
                    return;
                billEntry = value;
                OnPropertyChanged(nameof(BillEntry));
            }
        }

        double tip = 0.00;
        public double Tip
        {
            get => tip;
            set
            {
                if (tip == value)
                    return;
                tip = value;
                OnPropertyChanged(nameof(Tip));
            }
        }

        int split = 1;
        public int Split
        {
            get => split;
            set
            {
                if (split == value)
                    return;
                split = value;
                OnPropertyChanged(nameof(Split));
            }
        }

        public MainPageViewModel()
        {

        }

        public void Calculate()
        {
            var split = Split;
            var billEntry = BillEntry;
            var tipPercentage = 15.0 / 100.0;

            Total = GetTip(billEntry, split, tipPercentage) + GetBill(billEntry, split);
            Tip = GetTip(billEntry, split, tipPercentage);
            Bill = GetBill(billEntry, split);
        }

        double GetBill(double billEntry, int split)
        {
            return billEntry / split;
        }

        double GetTip(double billEntry, int split, double tipPercentage)
        {
            return (billEntry * tipPercentage) / split;
        }

        void OnPropertyChanged(string name)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
    }
}
