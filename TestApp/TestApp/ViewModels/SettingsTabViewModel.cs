using System;
using Prism.Navigation;

namespace TestApp.ViewModels
{
    public class SettingsTabViewModel
    {
        readonly INavigationService _navigationService;

        public SettingsTabViewModel(INavigationService navigationService)
        {
            _navigationService = navigationService;
        }
    }
}
