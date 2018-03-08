using System;

using FunyJapanese.Uwpui.ViewModels;
using Windows.ApplicationModel.Core;
using Windows.UI.Xaml.Controls;

namespace FunyJapanese.Uwpui.Views
{
    public sealed partial class MainPage : Page
    {
        private MainViewModel ViewModel
        {
            get { return DataContext as MainViewModel; }
        }

        public MainPage()
        {
            InitializeComponent();
        }
    }
}
