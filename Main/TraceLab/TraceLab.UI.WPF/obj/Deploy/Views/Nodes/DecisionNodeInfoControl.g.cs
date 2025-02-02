﻿#pragma checksum "..\..\..\..\Views\Nodes\DecisionNodeInfoControl.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "0CC14E1401916D5F2CEF81277F08574F"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18444
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

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
using TraceLab.Core.Components;
using TraceLab.UI.WPF.Commands;
using TraceLab.UI.WPF.Controls;
using TraceLab.UI.WPF.Converters;
using TraceLab.UI.WPF.Selectors;
using TraceLab.UI.WPF.Views;
using TraceLab.UI.WPF.Views.Nodes;
using WPFExtensions.AttachedBehaviours;
using WPG;


namespace TraceLab.UI.WPF.Views.Nodes {
    
    
    /// <summary>
    /// DecisionNodeInfoControl
    /// </summary>
    public partial class DecisionNodeInfoControl : TraceLab.UI.WPF.Views.Nodes.DecisionInfoControlBase, System.Windows.Markup.IComponentConnector {
        
        
        #line 105 "..\..\..\..\Views\Nodes\DecisionNodeInfoControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal TraceLab.UI.WPF.Controls.RichTextBoxWithIntellisense decisionCodeRichTextBox;
        
        #line default
        #line hidden
        
        
        #line 121 "..\..\..\..\Views\Nodes\DecisionNodeInfoControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button CompileButton;
        
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
            System.Uri resourceLocater = new System.Uri("/TraceLab.UI.WPF;component/views/nodes/decisionnodeinfocontrol.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\Views\Nodes\DecisionNodeInfoControl.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal System.Delegate _CreateDelegate(System.Type delegateType, string handler) {
            return System.Delegate.CreateDelegate(delegateType, this, handler);
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
            
            #line 40 "..\..\..\..\Views\Nodes\DecisionNodeInfoControl.xaml"
            ((System.Windows.Input.CommandBinding)(target)).Executed += new System.Windows.Input.ExecutedRoutedEventHandler(this.ExecuteAppendCodeToken);
            
            #line default
            #line hidden
            
            #line 41 "..\..\..\..\Views\Nodes\DecisionNodeInfoControl.xaml"
            ((System.Windows.Input.CommandBinding)(target)).CanExecute += new System.Windows.Input.CanExecuteRoutedEventHandler(this.CanExecuteAppendCodeToken);
            
            #line default
            #line hidden
            return;
            case 2:
            
            #line 43 "..\..\..\..\Views\Nodes\DecisionNodeInfoControl.xaml"
            ((System.Windows.Input.CommandBinding)(target)).Executed += new System.Windows.Input.ExecutedRoutedEventHandler(this.ExecuteCompileDecisionModule);
            
            #line default
            #line hidden
            
            #line 44 "..\..\..\..\Views\Nodes\DecisionNodeInfoControl.xaml"
            ((System.Windows.Input.CommandBinding)(target)).CanExecute += new System.Windows.Input.CanExecuteRoutedEventHandler(this.CanExecuteCompileDecisionModule);
            
            #line default
            #line hidden
            return;
            case 3:
            this.decisionCodeRichTextBox = ((TraceLab.UI.WPF.Controls.RichTextBoxWithIntellisense)(target));
            return;
            case 4:
            this.CompileButton = ((System.Windows.Controls.Button)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

