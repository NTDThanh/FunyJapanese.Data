using System;

using FunyJapanese.Uwpui.ViewModels;

using Windows.UI.Xaml.Controls;

namespace FunyJapanese.Uwpui.Views
{
    public sealed partial class WebViewTemplatePage : Page
    {
        private WebViewTemplateViewModel ViewModel
        {
            get { return DataContext as WebViewTemplateViewModel; }
        }

        public WebViewTemplatePage()
        {
            InitializeComponent();
            ViewModel.Initialize(webView);
        }
    }
}
