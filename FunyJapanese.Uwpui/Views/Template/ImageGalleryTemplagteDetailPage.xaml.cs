using System;

using FunyJapanese.Uwpui.Models;
using FunyJapanese.Uwpui.ViewModels;

using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Navigation;

namespace FunyJapanese.Uwpui.Views
{
    public sealed partial class ImageGalleryTemplagteDetailPage : Page
    {
        private ImageGalleryTemplagteDetailViewModel ViewModel
        {
            get { return DataContext as ImageGalleryTemplagteDetailViewModel; }
        }

        public ImageGalleryTemplagteDetailPage()
        {
            InitializeComponent();
            ViewModel.SetImage(previewImage);
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            base.OnNavigatedTo(e);
            ViewModel.Initialize(e.Parameter as SampleImage);
            showFlipView.Begin();
        }

        protected override void OnNavigatingFrom(NavigatingCancelEventArgs e)
        {
            base.OnNavigatingFrom(e);
            if (e.NavigationMode == NavigationMode.Back)
            {
                previewImage.Visibility = Visibility.Visible;
                ViewModel.SetAnimation();
            }
        }
    }
}
