using System;
using Prism.Navigation;
using TestApp.Helpers;

namespace TestApp.ViewModels
{
    public class BluePageViewModel : ViewModelBase
    {
        readonly INavigationService _navigationService;

        public BluePageViewModel(INavigationService navigationService)
        {
            _navigationService = navigationService;
            if (Settings.IsAdminMode)
                switchToggled = true;
            else
                switchToggled = false;
        }

        private bool switchToggled;
        public bool SwitchToggled
        {
            get { return switchToggled; }
            set 
            { 
                SetProperty(ref switchToggled, value);
                var page = _navigationService.GetNavigationUriPath();
                if (value)
                {
                    if (page == "/NavigationPage/MainPage?selectedTab=BluePage")
                    {
                       Settings.IsAdminMode = true;
                        _navigationService.NavigateAsync("TestApp:///NavigationPage/NewTabbedPage?selectedTab=BluePage", null, true, true);
                    }
                }
                else
                {
                    if (page == "/NavigationPage/NewTabbedPage?selectedTab=BluePage")
                    {
                        Settings.IsAdminMode = false;
                        _navigationService.NavigateAsync("TestApp:///NavigationPage/MainPage?selectedTab=BluePage", null, true, true);
                    }
                }
            }
        }
    }
}
