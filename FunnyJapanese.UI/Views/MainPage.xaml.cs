using System;

using FunnyJapanese.UI.ViewModels;

using Windows.UI.Xaml.Controls;

namespace FunnyJapanese.UI.Views
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
