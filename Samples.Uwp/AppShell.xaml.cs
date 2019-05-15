﻿using Common.Uwp.Services;
using Samples.Uwp.Constants;
using Samples.Uwp.Models;
using System.Collections.ObjectModel;
using Windows.UI.Xaml.Controls;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace Samples.Uwp
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class AppShell : Page
    {
        private ObservableCollection<MenuItem> MenuCollection = new ObservableCollection<MenuItem>(Menu.MenuCollection);

        public AppShell()
        {
            this.InitializeComponent();
        }

        private void MenuTree_ItemInvoked(TreeView sender, TreeViewItemInvokedEventArgs args)
        {
            if (args.InvokedItem is MenuItem item)
                NavigationService.NavigateToPage(item.Tag);
        }
    }
}
