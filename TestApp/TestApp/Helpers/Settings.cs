using System;
using Xamarin.Essentials;

namespace TestApp.Helpers
{
    public static class Settings
    {
        public static bool IsAdminMode
        {
            get => Preferences.Get(nameof(IsAdminMode), false);
            set => Preferences.Set(nameof(IsAdminMode), value);
        }
    }
}
