using System;
using Prism.Commands;
using Prism.Navigation;

namespace TestApp.ViewModels
{
    public class FirstTabViewModel : ViewModelBase
    {
        readonly INavigationService _navigationService;
        public FirstTabViewModel(INavigationService navigationService)
        {
            _navigationService = navigationService;
        }

        public DelegateCommand GoToList => new DelegateCommand(() =>
        {
            _navigationService.NavigateAsync("NewPage");
        });
    }
}
