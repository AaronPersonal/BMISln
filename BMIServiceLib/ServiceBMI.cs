using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace BMIServiceLib
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in both code and config file together.
    public class ServiceBMI : IServiceBMI
    {
        public double GetBMI(double height, double weight)
        {
            return weight / (height * height);
        }

        public string GetCategory(double BMI)
        {
            if (BMI < 18.5)
            {
                return "Underweight";
            }
            else if (BMI < 24.9)
            {
                return "normal";
            }
            else if (BMI < 29.9)
            {
                return "overweight";
            }
            else 
            {
                return "obese";
            }
        }

    }
}
