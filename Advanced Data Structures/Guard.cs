using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MunicipalServicesApp.Advanced_Data_Structures
{
    public static class Guard
    {
        // Guard against null values
        public static void AgainstNull(object obj, string paramName)
        {
            if (obj == null)
            {
                throw new ArgumentNullException(paramName, $"{paramName} cannot be null.");
            }
        }

        // Guard against empty or whitespace strings
        public static void AgainstEmptyOrWhitespace(string value, string paramName)
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentException("Argument cannot be empty or whitespace.", paramName);
            }
        }

        // Guard against invalid range
        public static void AgainstOutOfRange(int value, int min, int max, string paramName)
        {
            if (value < min || value > max)
            {
                throw new ArgumentOutOfRangeException(paramName, $"Value must be between {min} and {max}. Given: {value}");
            }
        }

        // Guard against negative values
        public static void AgainstNegative(int value, string paramName)
        {
            if (value < 0)
            {
                throw new ArgumentOutOfRangeException(paramName, "Value cannot be negative.");
            }
        }
        /*public ServiceRequest Search(int requestId)
        {
            // Guard against invalid RequestId
            Guard.AgainstNegative(requestId, nameof(requestId));

            return SearchNode(root, requestId);
        }*/

    }

}
