﻿#pragma checksum "..\..\..\Views\FilePickerDialog.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "A71EE8A088E46A2907541A6415DD59F6"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18444
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Ookii.Dialogs.Wpf;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Effects;
using System.Windows.Media.Imaging;
using System.Windows.Media.Media3D;
using System.Windows.Media.TextFormatting;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Shell;
using TraceLab.UI.WPF.Controls;
using TraceLab.UI.WPF.ViewModels;
using TraceLab.UI.WPF.Views;


namespace TraceLab.UI.WPF.Views {
    
    
    /// <summary>
    /// FilePickerDialog
    /// </summary>
    public partial class FilePickerDialog : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 31 "..\..\..\Views\FilePickerDialog.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal TraceLab.UI.WPF.Views.FilePickerDialog FilePickerTopLevel;
        
        #line default
        #line hidden
        
        
        #line 87 "..\..\..\Views\FilePickerDialog.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Expander DiskExpander;
        
        #line default
        #line hidden
        
        
        #line 91 "..\..\..\Views\FilePickerDialog.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox PathTextBox;
        
        #line default
        #line hidden
        
        
        #line 97 "..\..\..\Views\FilePickerDialog.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Expander PackageExpander;
        
        #line default
        #line hidden
        
        
        #line 99 "..\..\..\Views\FilePickerDialog.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TreeView PackageFileChooser;
        
        #line default
        #line hidden
        
        
        #line 103 "..\..\..\Views\FilePickerDialog.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Data.Binding ReferencesBinding;
        
        #line default
        #line hidden
        
        
        #line 115 "..\..\..\Views\FilePickerDialog.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button SelectButton;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/TraceLab.UI.WPF;component/views/filepickerdialog.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Views\FilePickerDialog.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.FilePickerTopLevel = ((TraceLab.UI.WPF.Views.FilePickerDialog)(target));
            
            #line 33 "..\..\..\Views\FilePickerDialog.xaml"
            this.FilePickerTopLevel.Loaded += new System.Windows.RoutedEventHandler(this.FilePickerLoaded);
            
            #line default
            #line hidden
            return;
            case 2:
            this.DiskExpander = ((System.Windows.Controls.Expander)(target));
            
            #line 88 "..\..\..\Views\FilePickerDialog.xaml"
            this.DiskExpander.Expanded += new System.Windows.RoutedEventHandler(this.DiskExpander_Expanded);
            
            #line default
            #line hidden
            
            #line 88 "..\..\..\Views\FilePickerDialog.xaml"
            this.DiskExpander.Collapsed += new System.Windows.RoutedEventHandler(this.DiskExpander_Collapsed);
            
            #line default
            #line hidden
            return;
            case 3:
            
            #line 90 "..\..\..\Views\FilePickerDialog.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.BrowseButtonClick);
            
            #line default
            #line hidden
            return;
            case 4:
            this.PathTextBox = ((System.Windows.Controls.TextBox)(target));
            
            #line 93 "..\..\..\Views\FilePickerDialog.xaml"
            this.PathTextBox.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.TextBox_TextChanged);
            
            #line default
            #line hidden
            return;
            case 5:
            this.PackageExpander = ((System.Windows.Controls.Expander)(target));
            
            #line 98 "..\..\..\Views\FilePickerDialog.xaml"
            this.PackageExpander.Expanded += new System.Windows.RoutedEventHandler(this.PackageExpander_Expanded);
            
            #line default
            #line hidden
            
            #line 98 "..\..\..\Views\FilePickerDialog.xaml"
            this.PackageExpander.Collapsed += new System.Windows.RoutedEventHandler(this.PackageExpander_Collapsed);
            
            #line default
            #line hidden
            return;
            case 6:
            this.PackageFileChooser = ((System.Windows.Controls.TreeView)(target));
            
            #line 99 "..\..\..\Views\FilePickerDialog.xaml"
            this.PackageFileChooser.IsVisibleChanged += new System.Windows.DependencyPropertyChangedEventHandler(this.TreeView_IsVisibleChanged);
            
            #line default
            #line hidden
            
            #line 100 "..\..\..\Views\FilePickerDialog.xaml"
            this.PackageFileChooser.SelectedItemChanged += new System.Windows.RoutedPropertyChangedEventHandler<object>(this.PkgFileChooser_SelectedItemChanged);
            
            #line default
            #line hidden
            return;
            case 7:
            this.ReferencesBinding = ((System.Windows.Data.Binding)(target));
            return;
            case 8:
            this.SelectButton = ((System.Windows.Controls.Button)(target));
            
            #line 115 "..\..\..\Views\FilePickerDialog.xaml"
            this.SelectButton.Click += new System.Windows.RoutedEventHandler(this.SelectClick);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

