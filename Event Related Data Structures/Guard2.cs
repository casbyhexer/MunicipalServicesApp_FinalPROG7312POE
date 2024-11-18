using MunicipalServicesApp.Advanced_Data_Structures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MunicipalServicesApp.Event_Related_Data_Structures
{
    public static class Guard2
    {
        public static void AgainstNull(object value, string parameterName)
        {
            Throw.IfNull(value, parameterName);
        }

        /*public static void AgainstNullOrEmpty(string value, string parameterName)
        {
            Throw.IfNullOrEmpty(value, parameterName);
        }*/

        public static void AgainstOutOfRange(int value, int min, int max, string parameterName)
        {
            Throw.IfOutOfRange(value, min, max, parameterName);
        }
    }
}
