﻿using System;
using System.Windows;
using System.Windows.Input;
using System.Windows.Controls;
using Zhichkin.Metadata.Model;

namespace Zhichkin.Metadata.UI
{
    public partial class SelectDataTypeDialogView : UserControl
    {
        private readonly SelectDataTypeDialogViewModel ViewModel;
        public SelectDataTypeDialogView()
        {
            InitializeComponent();
            this.DataContext = ViewModel = new SelectDataTypeDialogViewModel();
        }
        private void TreeView_SelectedItemChanged(object sender, RoutedPropertyChangedEventArgs<object> e)
        {
            ViewModel.SelectedEntity = e.NewValue as Entity;
        }
        private void TreeView_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            if (ViewModel.SelectedEntity == null) return;
            if (!(ViewModel.SelectedEntity is Entity)) return;
            ViewModel.Confirm();
        }
    }
}
