﻿using CommunityToolkit.Mvvm.ComponentModel;
using System.Collections.ObjectModel;
using WK23012_Main.Views.ModuleViews;
using System.Windows.Controls;

namespace WK23012_Main.ViewModels.Module
{
    class TabControlModuleVM : ObservableObject
    {
        public ObservableCollection<TabItem> TabItems { get; } = new ObservableCollection<TabItem>();

        public TabControlModuleVM()
        {
            AddTab("Main Frame", new MainFrame());
            AddTab("Clip Reel", new ClipReel());
            AddTab("OVI", new OVI());
            AddTab("AMS BF", new AMS_BF());
            AddTab("OVEN", new OVEN());
            AddTab("MO", new MO());
        }

        private void AddTab(string header, UserControl content)
        {
            TabItems.Add(new TabItem { Header = header, Content = content });
        }
    }
}
