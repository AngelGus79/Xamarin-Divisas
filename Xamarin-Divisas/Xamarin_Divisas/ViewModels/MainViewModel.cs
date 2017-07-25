using GalaSoft.MvvmLight.Command;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Xamarin_Divisas.ViewModels
{

    public class MainViewModel : INotifyPropertyChanged
    {
        private decimal euros;
        private decimal pesos;
        private decimal dolares;
        private decimal yenes;

        public Decimal Pesos
        {
            get
            {
                return pesos;
            }
            set
            {
                if (pesos != value)
                {
                    pesos = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Pesos"));
                }
            }
        }

        public Decimal Dolares
        {
            set
            {
                if (dolares != value)
                {
                    dolares = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Dolares"));
                }
            }
            get
            {
                return dolares;
            }
        }
        public Decimal Euros {
            set
            {
                if (euros != value)
                {
                    euros = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Euros"));
                }
            }
            get
            {
                return euros;
            }
        }
        public Decimal Yenes {
            set
            {
                if (yenes != value)
                {
                    yenes = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Yenes"));
                }

            } get
            {
                return yenes;
            }
        }
        public ICommand ConvertCommand { get { return new RelayCommand(ConvertMoney); } }

        public event PropertyChangedEventHandler PropertyChanged;

        public MainViewModel()
        {
            euros = 0;
            dolares = 0;
            pesos = 0;
            yenes = 0;
        }
        private async void ConvertMoney()
        {
            if (Pesos <= 0)
            {
                await App.Current.MainPage.DisplayAlert("Error","Escriba una cantidad mayor que cero","Aceptar");
                return;
            }
            Dolares = Pesos / 20;
            Euros = Pesos / 30;
            Yenes = Pesos / 40;
        }
    }
}
