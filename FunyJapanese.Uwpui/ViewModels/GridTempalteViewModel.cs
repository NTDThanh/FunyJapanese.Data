using System;
using System.Collections.ObjectModel;

using FunyJapanese.Uwpui.Models;
using FunyJapanese.Uwpui.Services;

using GalaSoft.MvvmLight;

namespace FunyJapanese.Uwpui.ViewModels
{
    public class GridTempalteViewModel : ViewModelBase
    {
        public ObservableCollection<SampleOrder> Source
        {
            get
            {
                // TODO WTS: Replace this with your actual data
                return SampleDataService.GetGridSampleData();
            }
        }
    }
}
