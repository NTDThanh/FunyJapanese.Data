using System;

using FunyJapanese.Uwpui.ViewModels;

using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace FunyJapanese.Uwpui.Views
{
    public sealed partial class ImageGalleryTemplagtePage : Page
    {
        private ImageGalleryTemplagteViewModel ViewModel
        {
            get { return DataContext as ImageGalleryTemplagteViewModel; }
        }

        public ImageGalleryTemplagtePage()
        {
            InitializeComponent();
        }

        private async void GridView_Loaded(object sender, RoutedEventArgs e)
        {
            var gridView = sender as GridView;
            await ViewModel.LoadAnimationAsync(gridView);
        }
    }
}
