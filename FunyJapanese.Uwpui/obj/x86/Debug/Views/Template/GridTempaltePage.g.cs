﻿#pragma checksum "C:\Users\ThanhTD\OneDrive\UWP\Project\FunyJapanese.Data\FunyJapanese.Uwpui\Views\Template\GridTempaltePage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "56FDE8E0FD012D23875298E6AFF6EF92"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace FunyJapanese.Uwpui.Views
{
    partial class GridTempaltePage : 
        global::Windows.UI.Xaml.Controls.Page, 
        global::Windows.UI.Xaml.Markup.IComponentConnector,
        global::Windows.UI.Xaml.Markup.IComponentConnector2
    {
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.16.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        private static class XamlBindingSetters
        {
            public static void Set_Telerik_UI_Xaml_Controls_Grid_RadDataGrid_ItemsSource(global::Telerik.UI.Xaml.Controls.Grid.RadDataGrid obj, global::System.Object value, string targetNullValue)
            {
                if (value == null && targetNullValue != null)
                {
                    value = (global::System.Object) global::Windows.UI.Xaml.Markup.XamlBindingHelper.ConvertValue(typeof(global::System.Object), targetNullValue);
                }
                obj.ItemsSource = value;
            }
        };

        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.16.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        private class GridTempaltePage_obj1_Bindings :
            global::Windows.UI.Xaml.Markup.IComponentConnector,
            IGridTempaltePage_Bindings
        {
            private global::FunyJapanese.Uwpui.Views.GridTempaltePage dataRoot;
            private bool initialized = false;
            private const int NOT_PHASED = (1 << 31);
            private const int DATA_CHANGED = (1 << 30);

            // Fields for each control that has bindings.
            private global::Telerik.UI.Xaml.Controls.Grid.RadDataGrid obj5;

            public GridTempaltePage_obj1_Bindings()
            {
            }

            // IComponentConnector

            public void Connect(int connectionId, global::System.Object target)
            {
                switch(connectionId)
                {
                    case 5: // Views\Template\GridTempaltePage.xaml line 30
                        this.obj5 = (global::Telerik.UI.Xaml.Controls.Grid.RadDataGrid)target;
                        break;
                    default:
                        break;
                }
            }

            // IGridTempaltePage_Bindings

            public void Initialize()
            {
                if (!this.initialized)
                {
                    this.Update();
                }
            }
            
            public void Update()
            {
                this.Update_(this.dataRoot, NOT_PHASED);
                this.initialized = true;
            }

            public void StopTracking()
            {
            }

            public void DisconnectUnloadedObject(int connectionId)
            {
                throw new global::System.ArgumentException("No unloadable elements to disconnect.");
            }

            public bool SetDataRoot(global::System.Object newDataRoot)
            {
                if (newDataRoot != null)
                {
                    this.dataRoot = (global::FunyJapanese.Uwpui.Views.GridTempaltePage)newDataRoot;
                    return true;
                }
                return false;
            }

            public void Loading(global::Windows.UI.Xaml.FrameworkElement src, object data)
            {
                this.Initialize();
            }

            // Update methods for each path node used in binding steps.
            private void Update_(global::FunyJapanese.Uwpui.Views.GridTempaltePage obj, int phase)
            {
                if (obj != null)
                {
                    if ((phase & (NOT_PHASED | (1 << 0))) != 0)
                    {
                        this.Update_ViewModel(obj.ViewModel, phase);
                    }
                }
            }
            private void Update_ViewModel(global::FunyJapanese.Uwpui.ViewModels.GridTempalteViewModel obj, int phase)
            {
                if (obj != null)
                {
                    if ((phase & (NOT_PHASED | (1 << 0))) != 0)
                    {
                        this.Update_ViewModel_Source(obj.Source, phase);
                    }
                }
            }
            private void Update_ViewModel_Source(global::System.Collections.ObjectModel.ObservableCollection<global::FunyJapanese.Uwpui.Models.SampleOrder> obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED )) != 0)
                {
                    // Views\Template\GridTempaltePage.xaml line 30
                    XamlBindingSetters.Set_Telerik_UI_Xaml_Controls_Grid_RadDataGrid_ItemsSource(this.obj5, obj, null);
                }
            }
        }
        /// <summary>
        /// Connect()
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.16.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void Connect(int connectionId, object target)
        {
            switch(connectionId)
            {
            case 2: // Views\Template\GridTempaltePage.xaml line 13
                {
                    this.ContentArea = (global::Windows.UI.Xaml.Controls.Grid)(target);
                }
                break;
            case 3: // Views\Template\GridTempaltePage.xaml line 18
                {
                    this.TitleRow = (global::Windows.UI.Xaml.Controls.RowDefinition)(target);
                }
                break;
            case 4: // Views\Template\GridTempaltePage.xaml line 22
                {
                    this.TitlePage = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 5: // Views\Template\GridTempaltePage.xaml line 30
                {
                    this.grid = (global::Telerik.UI.Xaml.Controls.Grid.RadDataGrid)(target);
                }
                break;
            case 6: // Views\Template\GridTempaltePage.xaml line 34
                {
                    this.WindowStates = (global::Windows.UI.Xaml.VisualStateGroup)(target);
                }
                break;
            case 7: // Views\Template\GridTempaltePage.xaml line 35
                {
                    this.WideState = (global::Windows.UI.Xaml.VisualState)(target);
                }
                break;
            case 8: // Views\Template\GridTempaltePage.xaml line 40
                {
                    this.NarrowState = (global::Windows.UI.Xaml.VisualState)(target);
                }
                break;
            default:
                break;
            }
            this._contentLoaded = true;
        }

        /// <summary>
        /// GetBindingConnector(int connectionId, object target)
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.16.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::Windows.UI.Xaml.Markup.IComponentConnector GetBindingConnector(int connectionId, object target)
        {
            global::Windows.UI.Xaml.Markup.IComponentConnector returnValue = null;
            switch(connectionId)
            {
            case 1: // Views\Template\GridTempaltePage.xaml line 1
                {                    
                    global::Windows.UI.Xaml.Controls.Page element1 = (global::Windows.UI.Xaml.Controls.Page)target;
                    GridTempaltePage_obj1_Bindings bindings = new GridTempaltePage_obj1_Bindings();
                    returnValue = bindings;
                    bindings.SetDataRoot(this);
                    this.Bindings = bindings;
                    element1.Loading += bindings.Loading;
                }
                break;
            }
            return returnValue;
        }
    }
}
