﻿#pragma checksum "..\..\..\Views\MetadataTreeView.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "E04F5DF3E38B9450C985383A58E19950206E2830"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
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
using System.Windows.Interactivity;
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
using Zhichkin.Metadata.Model;
using Zhichkin.Metadata.UI;
using Zhichkin.Metadata.Views;
using Zhichkin.Shell;


namespace Zhichkin.Metadata.Views {
    
    
    /// <summary>
    /// MetadataTreeView
    /// </summary>
    public partial class MetadataTreeView : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector, System.Windows.Markup.IStyleConnector {
        
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
            System.Uri resourceLocater = new System.Uri("/Zhichkin.Metadata.Module;component/views/metadatatreeview.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Views\MetadataTreeView.xaml"
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
            
            #line 95 "..\..\..\Views\MetadataTreeView.xaml"
            ((System.Windows.Controls.TreeView)(target)).MouseMove += new System.Windows.Input.MouseEventHandler(this.TreeView_MouseMove);
            
            #line default
            #line hidden
            
            #line 96 "..\..\..\Views\MetadataTreeView.xaml"
            ((System.Windows.Controls.TreeView)(target)).PreviewMouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.TreeView_PreviewMouseLeftButtonDown);
            
            #line default
            #line hidden
            
            #line 97 "..\..\..\Views\MetadataTreeView.xaml"
            ((System.Windows.Controls.TreeView)(target)).PreviewMouseRightButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.TreeViewItem_PreviewMouseRightButtonDown);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        void System.Windows.Markup.IStyleConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 2:
            
            #line 104 "..\..\..\Views\MetadataTreeView.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.OpenInfoBaseView_Clicked);
            
            #line default
            #line hidden
            break;
            case 3:
            
            #line 109 "..\..\..\Views\MetadataTreeView.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.KillInfoBase_Clicked);
            
            #line default
            #line hidden
            break;
            case 4:
            
            #line 119 "..\..\..\Views\MetadataTreeView.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.CreateNamespace_Click);
            
            #line default
            #line hidden
            break;
            case 5:
            
            #line 158 "..\..\..\Views\MetadataTreeView.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.OpenNamespaceView_Clicked);
            
            #line default
            #line hidden
            break;
            case 6:
            
            #line 163 "..\..\..\Views\MetadataTreeView.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.KillNamespace_Clicked);
            
            #line default
            #line hidden
            break;
            case 7:
            
            #line 173 "..\..\..\Views\MetadataTreeView.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.CreateNamespace_Click);
            
            #line default
            #line hidden
            break;
            case 8:
            
            #line 178 "..\..\..\Views\MetadataTreeView.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.CreateEntity_Click);
            
            #line default
            #line hidden
            break;
            case 9:
            
            #line 231 "..\..\..\Views\MetadataTreeView.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.OpenEntityView_Clicked);
            
            #line default
            #line hidden
            break;
            case 10:
            
            #line 240 "..\..\..\Views\MetadataTreeView.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.CreateNewProperty_Click);
            
            #line default
            #line hidden
            break;
            case 11:
            
            #line 245 "..\..\..\Views\MetadataTreeView.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.CreateNestedEntity_Click);
            
            #line default
            #line hidden
            break;
            case 12:
            
            #line 251 "..\..\..\Views\MetadataTreeView.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.KillEntity_Clicked);
            
            #line default
            #line hidden
            break;
            case 13:
            
            #line 257 "..\..\..\Views\MetadataTreeView.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.ShowProperties_Clicked);
            
            #line default
            #line hidden
            break;
            case 14:
            
            #line 262 "..\..\..\Views\MetadataTreeView.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.OpenEntityForm_Clicked);
            
            #line default
            #line hidden
            break;
            case 15:
            
            #line 317 "..\..\..\Views\MetadataTreeView.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.OpenPropertyForm_Clicked);
            
            #line default
            #line hidden
            break;
            case 16:
            
            #line 322 "..\..\..\Views\MetadataTreeView.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.KillProperty_Clicked);
            
            #line default
            #line hidden
            break;
            case 17:
            
            #line 328 "..\..\..\Views\MetadataTreeView.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.ShowProperties_Clicked);
            
            #line default
            #line hidden
            break;
            }
        }
    }
}

