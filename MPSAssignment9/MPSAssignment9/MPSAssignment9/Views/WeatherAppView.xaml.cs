using MPSAssignment9.View_Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MPSAssignment9.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class WeatherAppView : ContentPage
    {
        public WeatherAppView()
        {
            InitializeComponent();

            BindingContext = new WeatherAppViewModel();
        }
    }
}