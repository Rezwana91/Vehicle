using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VechicleAppPractice2
{
     public class Vehicle
    {
        public string VehicleName { set; get; }
        public string RegNo { set; get; }
       // public List<double> Speed { set; get; }

        public double MinSpeed(List<double> Speed)
        {
            double minSpeed = Speed.Min();
            return minSpeed;
        }

        public double MaxSpeed(List<double> Speed)
        {
            double maxSpeed = Speed.Max();
            return maxSpeed;
        }

        public double AverageSpeed(List<double> Speed)
        {
            double averageSpeed = Speed.Average();
            return averageSpeed;
        }

    }
}
