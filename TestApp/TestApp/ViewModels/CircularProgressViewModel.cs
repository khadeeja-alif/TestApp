using System;
using System.Collections.ObjectModel;
using Prism.Navigation;

namespace TestApp.ViewModels
{
    public class CircularProgressViewModel : ViewModelBase
    {
        readonly INavigationService _navigationService;

        public ObservableCollection<string> Blah { get; set; }
        public CircularProgressViewModel(INavigationService navigationService)
        {
            _navigationService = navigationService;
            showList = true;
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
