using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using MPSAssignment9.Services;
using MPSAssignment9.Models;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace MPSAssignment9.View_Models
{
    public class WeatherAppViewModel
    {
        private IList<CurrentAPI> WeatherDetails;
        public IList<CurrentAPI> _weatherDetails
        {
            get
            {
                if (WeatherDetails == null)
                    WeatherDetails = new ObservableCollection<CurrentAPI>();
                return WeatherDetails;
            }
            set
            {
                WeatherDetails = value;
            }
        }
      
        private async Task CurrentAPIAsync()
        {
            var weather = await WeatherAPI.GetCurrentAPIAsync(-33.9249, 18.4241, "metric");
            WeatherDetails.Add(weather);
        }
        public WeatherAppViewModel()
        {
            Task.Run(CurrentAPIAsync);
        }
    }
}

    


        


