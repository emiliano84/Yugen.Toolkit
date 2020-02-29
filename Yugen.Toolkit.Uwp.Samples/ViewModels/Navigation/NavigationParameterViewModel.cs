﻿// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

using System.Collections.Generic;
using Windows.UI.Xaml.Navigation;
using Yugen.Toolkit.Uwp.ViewModels;

namespace Yugen.Toolkit.Uwp.Samples.ViewModels.Navigation
{
    public class NavigationParameterViewModel : BaseViewModel
    {
        //private string _parameter;

        private string _text;
        public string Text
        {
            get { return _text; }
            set { Set(ref _text, value); }
        }

        public override void OnNavigatedTo(object parameter, NavigationMode mode, IDictionary<string, object> state)
        {
            Text = parameter as string ?? string.Empty;
        }

        public void Page_Loaded(object _1, Windows.UI.Xaml.RoutedEventArgs _2)
        {
            //Text = _parameter;
        }

        public void Button_Tapped(object _1, Windows.UI.Xaml.Input.TappedRoutedEventArgs _2)
        {
            Text = "aaa";
        }
    }
}
