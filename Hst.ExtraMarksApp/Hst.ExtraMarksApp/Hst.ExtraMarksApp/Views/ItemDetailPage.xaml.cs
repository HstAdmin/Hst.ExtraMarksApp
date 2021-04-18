using Hst.ExtraMarksApp.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace Hst.ExtraMarksApp.Views
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