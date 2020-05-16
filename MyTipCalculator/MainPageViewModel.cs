using System;
using System.ComponentModel;

namespace MyTipCalculator
{
    public class MainPageViewModel
    {
        public event PropertyChangedEventHandler PropertyChanged;

        double total = 0.00;
        public double Total
        {
            get => total;
            set
            {
                if (total == value)
                    return;
                bill = value;
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
                tip = value;
                OnPropertyChanged(nameof(Split));
            }
        }

        public MainPageViewModel()
        {
        }

        void OnPropertyChanged(string name)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
    }
}
