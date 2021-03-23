﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using MPSAssignment9.View_Models;
using Xamarin.Forms.Xaml;

namespace MPSAssignment9
{ 

  [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            this.BindingContext = new WeatherAppViewModel();

        }
    }
}
