using System;
using System.Collections.ObjectModel;

namespace TestApp.ViewModels
{
    public class ThirdTabViewModel : ViewModelBase
    {
        public ObservableCollection<string> Blah { get; set; }
        public ThirdTabViewModel()
        {
            LocalProgress = 25;
            SmcProgress = 100;
            Blah = new ObservableCollection<string>() { "Hello", "Hi", "Bye" };
            RaisePropertyChanged("Blah");
        }

        private double localProgress;
        public double LocalProgress
        {
            get { return localProgress; }
            set { SetProperty(ref localProgress, value); }
        }

        private double smcProgress;
        public double SmcProgress
        {
            get { return smcProgress; }
            set { SetProperty(ref smcProgress, value); }
        }
    }
}
