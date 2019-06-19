﻿using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ShellApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SettingsPage : ContentPage
    {
        public SettingsPage()
        {
            InitializeComponent();
            
        }

        private void Button_OnClicked(object sender, EventArgs e)
        {
            Shell.Current.Navigation.PopAsync(true);
        }
    }
}