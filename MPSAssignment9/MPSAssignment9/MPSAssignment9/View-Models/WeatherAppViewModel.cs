using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using MPSAssignment9.Services;
using MPSAssignment9.Models;
using System.Collections.ObjectModel;
using System.Threading.Tasks;

namespace MPSAssignment9.View_Models
{
    public class WeatherAppViewModel
    {
        private IList<OneCallAPI> _weatherDetails;
        public IList<OneCallAPI> WeatherDetails
        {
            get
            {
                if (_weatherDetails == null)
                    _weatherDetails = new ObservableCollection<OneCallAPI>();
                return _weatherDetails;
            }
            set
            {
                _weatherDetails = value;
            }
        }
      
        private async Task APIAsync()
        {
            var weather = await WeatherAPI.GetOneCallAPIAsync(-33.9249, 18.4241, "metric");
            WeatherDetails.Add(weather);
        }
        public WeatherAppViewModel()
        {
            Task.Run(APIAsync);
        }
    }
}

    


        


