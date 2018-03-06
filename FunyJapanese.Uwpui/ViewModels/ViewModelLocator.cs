using System;
using FunyJapanese.Uwpui.Services;
using FunyJapanese.Uwpui.Views;
using GalaSoft.MvvmLight.Ioc;
using Microsoft.Practices.ServiceLocation;

namespace FunyJapanese.Uwpui.ViewModels
{
    public class ViewModelLocator
    {
        public ViewModelLocator()
        {
            ServiceLocator.SetLocatorProvider(() => SimpleIoc.Default);

            SimpleIoc.Default.Register(() => new NavigationServiceEx());
            SimpleIoc.Default.Register<ShellViewModel>();
            Register<MainViewModel, MainPage>();
            Register<Page1ViewModel, Page1Page>();
            Register<WebViewTemplateViewModel, WebViewTemplatePage>();
            Register<TemplateViewModel, TemplatePage>();
            Register<GridTempalteViewModel, GridTempaltePage>();
            Register<ChartTempalteViewModel, ChartTempaltePage>();
            Register<TabbedTemplateViewModel, TabbedTemplatePage>();
            Register<ImageGalleryTemplagteViewModel, ImageGalleryTemplagtePage>();
            Register<ImageGalleryTemplagteDetailViewModel, ImageGalleryTemplagteDetailPage>();
            Register<SettingsViewModel, SettingsPage>();
        }

        public SettingsViewModel SettingsViewModel => ServiceLocator.Current.GetInstance<SettingsViewModel>();

        public ImageGalleryTemplagteDetailViewModel ImageGalleryTemplagteDetailViewModel => ServiceLocator.Current.GetInstance<ImageGalleryTemplagteDetailViewModel>();

        public ImageGalleryTemplagteViewModel ImageGalleryTemplagteViewModel => ServiceLocator.Current.GetInstance<ImageGalleryTemplagteViewModel>();

        public TabbedTemplateViewModel TabbedTemplateViewModel => ServiceLocator.Current.GetInstance<TabbedTemplateViewModel>();

        public ChartTempalteViewModel ChartTempalteViewModel => ServiceLocator.Current.GetInstance<ChartTempalteViewModel>();

        public GridTempalteViewModel GridTempalteViewModel => ServiceLocator.Current.GetInstance<GridTempalteViewModel>();

        public MainPageViewModel MainPageViewModel => ServiceLocator.Current.GetInstance<MainPageViewModel>();

        // A Guid is generated as a unique key for each instance as reusing the same VM instance in multiple MediaPlayerElement instances can cause playback errors
        public TemplateViewModel TemplateViewModel => ServiceLocator.Current.GetInstance<TemplateViewModel>(Guid.NewGuid().ToString());

        public WebViewTemplateViewModel WebViewTemplateViewModel => ServiceLocator.Current.GetInstance<WebViewTemplateViewModel>();

        public Page1ViewModel Page1ViewModel => ServiceLocator.Current.GetInstance<Page1ViewModel>();

        public MainViewModel MainViewModel => ServiceLocator.Current.GetInstance<MainViewModel>();

        public ShellViewModel ShellViewModel => ServiceLocator.Current.GetInstance<ShellViewModel>();

        public NavigationServiceEx NavigationService => ServiceLocator.Current.GetInstance<NavigationServiceEx>();

        public void Register<VM, V>()
            where VM : class
        {
            SimpleIoc.Default.Register<VM>();

            NavigationService.Configure(typeof(VM).FullName, typeof(V));
        }
    }
}
