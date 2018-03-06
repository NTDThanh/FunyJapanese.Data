using System;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;

using FunyJapanese.Uwpui.Helpers;
using FunyJapanese.Uwpui.Models;
using FunyJapanese.Uwpui.Services;

using GalaSoft.MvvmLight;

using Windows.Storage;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Media.Animation;

namespace FunyJapanese.Uwpui.ViewModels
{
    public class ImageGalleryTemplagteDetailViewModel : ViewModelBase
    {
        private static UIElement _image;
        private object _selectedImage;
        private ObservableCollection<SampleImage> _source;

        public object SelectedImage
        {
            get => _selectedImage;
            set
            {
                Set(ref _selectedImage, value);
                ApplicationData.Current.LocalSettings.SaveString(ImageGalleryTemplagteViewModel.ImageGalleryTemplagteSelectedIdKey, ((SampleImage)SelectedImage).ID);
            }
        }

        public ObservableCollection<SampleImage> Source
        {
            get => _source;
            set => Set(ref _source, value);
        }

        public ImageGalleryTemplagteDetailViewModel()
        {
            // TODO WTS: Replace this with your actual data
            Source = SampleDataService.GetGallerySampleData();
        }

        public void SetImage(UIElement image) => _image = image;

        public void Initialize(SampleImage sampleImage)
        {
            SelectedImage = Source.FirstOrDefault(i => i.ID == sampleImage.ID);
            var animation = ConnectedAnimationService.GetForCurrentView().GetAnimation(ImageGalleryTemplagteViewModel.ImageGalleryTemplagteAnimationOpen);
            animation?.TryStart(_image);
        }

        public void SetAnimation()
        {
            ConnectedAnimationService.GetForCurrentView()?.PrepareToAnimate(ImageGalleryTemplagteViewModel.ImageGalleryTemplagteAnimationClose, _image);
        }
    }
}
