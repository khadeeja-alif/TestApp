using System;
using System.Collections.ObjectModel;
using Prism.Navigation;

namespace TestApp.ViewModels
{
    public class SecondTabViewModel : ViewModelBase
    {
        readonly INavigationService _navigationService;

        public ObservableCollection<string> Blah { get; set; }
        public int Label1 { get; set; }
        public int Label2 { get; set; }
        public int Label3 { get; set; }
        public SecondTabViewModel(INavigationService navigationService)
        {
            _navigationService = navigationService;
            showList = true;
            Label1 = 2;
            Label2 = 4;
            Label3 = 2;
            Blah = new ObservableCollection<string>() { "Hello", "Hi", "Bye" };
            RaisePropertyChanged("Blah");
        }

        public override void OnNavigatedTo(INavigationParameters parameters)
        {
            base.OnNavigatedTo(parameters);
        }

        private bool showList;
        public bool ShowList
        {
            get { return showList; }
            set { SetProperty(ref showList, value); }
        }
    }
}
