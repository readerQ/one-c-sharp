﻿#pragma checksum "..\..\..\Article\ArticlesListView.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "DC13E20E4BB7FA6374F2A59C577BE346C6761BB2"
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
using Zhichkin.DXM.Model;
using Zhichkin.Metadata.Model;


namespace Zhichkin.DXM.Module {
    
    
    /// <summary>
    /// ArticlesListView
    /// </summary>
    public partial class ArticlesListView : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 39 "..\..\..\Article\ArticlesListView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TreeView ArticlesTreeView;
        
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
            System.Uri resourceLocater = new System.Uri("/Zhichkin.DXM.Module;component/article/articleslistview.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Article\ArticlesListView.xaml"
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
            
            #line 10 "..\..\..\Article\ArticlesListView.xaml"
            ((Zhichkin.DXM.Module.ArticlesListView)(target)).DragEnter += new System.Windows.DragEventHandler(this.ArticlesListView_DragEnter);
            
            #line default
            #line hidden
            
            #line 11 "..\..\..\Article\ArticlesListView.xaml"
            ((Zhichkin.DXM.Module.ArticlesListView)(target)).DragLeave += new System.Windows.DragEventHandler(this.ArticlesListView_DragLeave);
            
            #line default
            #line hidden
            
            #line 12 "..\..\..\Article\ArticlesListView.xaml"
            ((Zhichkin.DXM.Module.ArticlesListView)(target)).Drop += new System.Windows.DragEventHandler(this.ArticlesListView_Drop);
            
            #line default
            #line hidden
            return;
            case 2:
            this.ArticlesTreeView = ((System.Windows.Controls.TreeView)(target));
            
            #line 40 "..\..\..\Article\ArticlesListView.xaml"
            this.ArticlesTreeView.MouseMove += new System.Windows.Input.MouseEventHandler(this.ArticlesTreeView_MouseMove);
            
            #line default
            #line hidden
            
            #line 41 "..\..\..\Article\ArticlesListView.xaml"
            this.ArticlesTreeView.PreviewMouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.ArticlesTreeView_PreviewMouseLeftButtonDown);
            
            #line default
            #line hidden
            
            #line 42 "..\..\..\Article\ArticlesListView.xaml"
            this.ArticlesTreeView.SelectedItemChanged += new System.Windows.RoutedPropertyChangedEventHandler<object>(this.ArticlesTreeView_SelectedItemChanged);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

