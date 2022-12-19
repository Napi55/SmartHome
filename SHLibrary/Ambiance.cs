using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SHLibrary
{
    public class Ambiance
    {
        public double temperature;
        public double humidity;

        public Ambiance(double temperature, double humidity)
        {
            this.temperature = temperature;
            this.humidity = humidity;
        }
    }
}
