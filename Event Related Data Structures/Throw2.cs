using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MunicipalServicesApp.Event_Related_Data_Structures
{
    public static class Throw2
    {
        // Validates if the value is null and throws an ArgumentNullException
        public static void IfNull(object value, string parameterName)
        {
            if (value == null)
            {
                throw new ArgumentNullException(parameterName, $"{parameterName} cannot be null.");
            }
        }

        // Validates if the string value is null or empty and throws an ArgumentException
        public static void IfNullOrEmpty(string value, string parameterName)
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentException($"{parameterName} cannot be null or empty.", parameterName);
            }
        }

        // Validates if the value is out of the specified range and throws an ArgumentOutOfRangeException
        public static void IfOutOfRange(int value, int min, int max, string parameterName)
        {
            if (value < min || value > max)
            {
                throw new ArgumentOutOfRangeException(parameterName, $"{parameterName} must be between {min} and {max}.");
            }
        }
    }
}

