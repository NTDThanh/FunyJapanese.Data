using System;

using FunyJapanese.Uwpui.ViewModels;

using Windows.UI.Xaml.Controls;

namespace FunyJapanese.Uwpui.Views
{
    public sealed partial class TabbedTemplatePage : Page
    {
        private TabbedTemplateViewModel ViewModel
        {
            get { return DataContext as TabbedTemplateViewModel; }
        }

        public TabbedTemplatePage()
        {
            InitializeComponent();
        }
    }
}
