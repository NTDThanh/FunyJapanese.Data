using System;

using FunyJapanese.Uwpui.ViewModels;

using Windows.UI.Xaml.Controls;

namespace FunyJapanese.Uwpui.Views
{
    public sealed partial class GridTempaltePage : Page
    {
        private GridTempalteViewModel ViewModel
        {
            get { return DataContext as GridTempalteViewModel; }
        }

        // TODO WTS: Change the grid as appropriate to your app.
        // For help see http://docs.telerik.com/windows-universal/controls/raddatagrid/gettingstarted
        // You may also want to extend the grid to work with the RadDataForm http://docs.telerik.com/windows-universal/controls/raddataform/dataform-gettingstarted
        public GridTempaltePage()
        {
            InitializeComponent();
        }
    }
}
