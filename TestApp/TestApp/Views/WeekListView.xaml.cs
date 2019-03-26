using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Prism.Commands;
using Xamarin.Forms;

namespace TestApp.Views
{
    public partial class WeekListView : ContentView
    {
        public WeekListView()
        {
            InitializeComponent();
        }

        public static BindableProperty SelectedWeekItemsProperty =
        BindableProperty.Create(
        nameof(SelectedWeekItems),
        typeof(ObservableCollection<object>),
        typeof(WeekListView),
        new ObservableCollection<object>(),
        BindingMode.TwoWay
        );

        public ObservableCollection<object> SelectedWeekItems
        {
            get => (ObservableCollection<object>)GetValue(SelectedWeekItemsProperty);
            set => SetValue(SelectedWeekItemsProperty, value);
        }

        public static BindableProperty WeekListProperty =
       BindableProperty.Create(
       nameof(WeekList),
       typeof(Dictionary<string, string>),
       typeof(WeekListView),
       new Dictionary<string, string>(),
       BindingMode.TwoWay
       );

        public Dictionary<string, string> WeekList
        {
            get => (Dictionary<string, string>)GetValue(WeekListProperty);
            set => SetValue(WeekListProperty, value);
        }

        public static BindableProperty WeekDayProperty =
        BindableProperty.Create(
        nameof(WeekDay),
        typeof(string),
        typeof(WeekListView),
        "",
        BindingMode.TwoWay
        );

        public string WeekDay
        {
            get => (string)GetValue(WeekDayProperty);
            set => SetValue(WeekDayProperty, value);
        }

        public static BindableProperty CloseCommandProperty =
       BindableProperty.Create(nameof(CloseCommand), typeof(DelegateCommand), typeof(WeekListView), null);

        public DelegateCommand CloseCommand
        {
            get => (DelegateCommand)GetValue(CloseCommandProperty);
            set => SetValue(CloseCommandProperty, value);
        }

        public static BindableProperty PasteCommandProperty =
      BindableProperty.Create(nameof(PasteCommand), typeof(DelegateCommand<string>), typeof(WeekListView), null);

        public DelegateCommand<string> PasteCommand
        {
            get => (DelegateCommand<string>)GetValue(PasteCommandProperty);
            set => SetValue(PasteCommandProperty, value);
        }

        public static BindableProperty ClearAllCommandProperty =
       BindableProperty.Create(nameof(ClearAllCommand), typeof(DelegateCommand), typeof(WeekListView), null);

        public DelegateCommand ClearAllCommand
        {
            get => (DelegateCommand)GetValue(ClearAllCommandProperty);
            set => SetValue(ClearAllCommandProperty, value);
        }
    }
}
