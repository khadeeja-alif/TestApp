using System;
using Prism.Navigation;

namespace TestApp.ViewModels
{
    public class StartPageViewModel : ViewModelBase
    {
        public StartPageViewModel(INavigationService navigationService)
        {
            Title = "Main Page";
        }
    }
}
