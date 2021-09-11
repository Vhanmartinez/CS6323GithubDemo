using System;
using System.Collections.Generic;
using SampleDemoApp.ViewModels;
using SampleDemoApp.Views;
using Xamarin.Forms;

namespace SampleDemoApp
{
    public partial class AppShell : Xamarin.Forms.Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(ItemDetailPage), typeof(ItemDetailPage));
            Routing.RegisterRoute(nameof(NewItemPage), typeof(NewItemPage));
        }

    }
}
