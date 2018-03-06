using System;

using FunyJapanese.Uwpui.ViewModels;

using Windows.UI.Xaml.Controls;

namespace FunyJapanese.Uwpui.Views
{
    public sealed partial class ChartTempaltePage : Page
    {
        private ChartTempalteViewModel ViewModel
        {
            get { return DataContext as ChartTempalteViewModel; }
        }

        // TODO WTS: Change the chart as appropriate to your app.
        // For help see http://docs.telerik.com/windows-universal/controls/radchart/getting-started
        public ChartTempaltePage()
        {
            InitializeComponent();
        }
    }
}
