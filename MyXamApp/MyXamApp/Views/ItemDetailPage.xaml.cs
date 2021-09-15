using MyXamApp.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace MyXamApp.Views
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