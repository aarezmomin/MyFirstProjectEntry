using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MyFirstProject.ViewViewModel.Controls.DateAndTimePicker
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DateAndTimePickerControlsView : ContentPage
    {
        public DateAndTimePickerControlsView()
        {
            InitializeComponent();

            BindingContext = new DateAndTimePickerControlsViewModel();
        }
    }
}