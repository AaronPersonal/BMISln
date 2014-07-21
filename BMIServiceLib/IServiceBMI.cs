using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace BMIServiceLib
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IServiceBMI
    {
        [OperationContract]
        double GetBMI(double height, double weight);

        [OperationContract]
        string GetCategory(double BMI);

        int slap = 0;
    }
}
