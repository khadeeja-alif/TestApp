using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.Linq;
using Prism.Commands;
using Prism.Navigation;

namespace TestApp.ViewModels
{
    public class NewPageViewModel : ViewModelBase
    {
        readonly INavigationService _navigationService;
        public NewPageViewModel(INavigationService navigationService)
        {
            _navigationService = navigationService;
            SelectedWeekItems = new ObservableCollection<object>();
            WeekDays = new Dictionary<string, string>();
            WeekList = new Dictionary<string, string>();
            WeekList = BulkConstants.WeekList;
            SelectedWeekItems.CollectionChanged += SelectedWeekDays_CollectionChanged;
        }

        private void SelectedWeekDays_CollectionChanged(object sender, NotifyCollectionChangedEventArgs e)
        {
            WeekDays?.Clear();

            foreach (var x in SelectedWeekItems)
            {
                var y = (KeyValuePair<string, string>)x;
                WeekDays.Add(y.Key, y.Value);
            }
        }


        public DelegateCommand ShowPopUp => new DelegateCommand(() =>
        {
            ShowWeekView = true;
        });

        public DelegateCommand ClearWeek => new DelegateCommand(() =>
        {
            SelectedWeekItems?.Clear();
        });

        public DelegateCommand<string> PasteCommand => new DelegateCommand<string>((x) =>
        {

        });

        public DelegateCommand HideWeekView => new DelegateCommand(() =>
        {
            SelectedWeekItems?.Clear();
            ShowWeekView = false;
        });

        private string copyWeekDay;
        public string CopyWeekDay
        {
            get { return copyWeekDay; }
            set { SetProperty(ref copyWeekDay, value); }
        }

        private bool showWeekView;
        public bool ShowWeekView
        {
            get { return showWeekView; }
            set { SetProperty(ref showWeekView, value); }
        }

        private Dictionary<string, string> weekDays;
        public Dictionary<string, string> WeekDays
        {
            get { return weekDays; }
            set { SetProperty(ref weekDays, value); }
        }

        private Dictionary<string, string> weekList;
        public Dictionary<string, string> WeekList
        {
            get { return weekList; }
            set { SetProperty(ref weekList, value); }
        }

        private ObservableCollection<object> selectedWeekItems;
        public ObservableCollection<object> SelectedWeekItems
        {
            get { return selectedWeekItems; }
            set
            {
                if (value != null)
                {
                    SetProperty(ref selectedWeekItems, value);
                }
            }
        }
    }
}
