using System.ComponentModel;
using System.Windows.Input;

namespace SevillaDotNet
{
    public class Demo3ViewModel : INotifyPropertyChanged
    {
        private int result;
        private int firstOperator;
        private int secondOperator;
        private readonly IAlertDialogService alertDialogService;
        private readonly INavigationService navigationService;

        public Demo3ViewModel(IAlertDialogService alertDialogService, INavigationService navigationService)
        {
            this.alertDialogService = alertDialogService;
            this.navigationService = navigationService;

            SayHelloCommand = new Command(SayHello);
            AddCommand = new Command(Add);
            MultiplyCommand = new Command(Multiply);
            NavigateCommand = new Command(Navigate);
        }

        public event PropertyChangedEventHandler PropertyChanged;
        public int Result
        {
            get => result;
            private set
            {
                result = value;
                OnPropertyChanged(nameof(Result));
            }
        }

        public int FirstOperator
        {
            get => firstOperator;
            set
            {
                firstOperator = value;
                OnPropertyChanged(nameof(FirstOperator));
            }
        }

        public int SecondOperator
        {
            get => secondOperator;
            set
            {
                secondOperator = value;
                OnPropertyChanged(nameof(SecondOperator));
            }
        }

        public ICommand SayHelloCommand { get; set; }
        public ICommand NavigateCommand { get; set; }
        public ICommand AddCommand { get; set; }
        public ICommand MultiplyCommand { get; set; }

        private void SayHello(object obj)
        {
            alertDialogService.ShowDialog("Sevilla dotNet", "Hello everyone!!");
        }

        private void Add(object obj)
        {
            Result = FirstOperator + SecondOperator;
        }

        private void Multiply(object obj)
        {
            Result = FirstOperator * SecondOperator;
        }

        private void Navigate(object obj)
        {
            navigationService.NavigateToPage1();
        }


        protected void OnPropertyChanged(string propertyName)
        {
            var handler = PropertyChanged;
            if (handler != null)
                handler(this, new PropertyChangedEventArgs(propertyName));
        }


    }
}
