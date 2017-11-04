﻿using Aurora.Music.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Controls;

namespace Aurora.Music.Pages
{
    public sealed partial class SettingsPage : Page
    {
        public SettingsPage()
        {
            this.InitializeComponent();
            LoactionFrame.Navigate(typeof(AddFoldersView));
            MainPageViewModel.Current.Title = "Settings";
            MainPageViewModel.Current.NeedShowTitle = true;
            MainPageViewModel.Current.IsLeftTopDark = false;
        }
    }
}