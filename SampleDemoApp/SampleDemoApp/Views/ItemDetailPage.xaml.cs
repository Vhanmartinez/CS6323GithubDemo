using System.ComponentModel;
using Xamarin.Forms;
using SampleDemoApp.ViewModels;

namespace SampleDemoApp.Views
{
    public partial class ItemDetailPage : ContentPage
    {
        public ItemDetailPage()
        {
            InitializeComponent();
            BindingContext = new ItemDetailViewModel();
        }
    }
}
