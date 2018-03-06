using System;

using FunyJapanese.Uwpui.Models;

using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace FunyJapanese.Uwpui.Views
{
    public sealed partial class MainPageDetailControl : UserControl
    {
        public SampleOrder MasterMenuItem
        {
            get { return GetValue(MasterMenuItemProperty) as SampleOrder; }
            set { SetValue(MasterMenuItemProperty, value); }
        }

        public static readonly DependencyProperty MasterMenuItemProperty = DependencyProperty.Register("MasterMenuItem", typeof(SampleOrder), typeof(MainPageDetailControl), new PropertyMetadata(null, OnMasterMenuItemPropertyChanged));

        public MainPageDetailControl()
        {
            InitializeComponent();
        }

        private static void OnMasterMenuItemPropertyChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            var control = d as MainPageDetailControl;
            control.ForegroundElement.ChangeView(0, 0, 1);
        }
    }
}
