using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MunicipalServicesApp.Advanced_Data_Structures
{
    public static class Throw
    {
        // Throws ArgumentNullException if the value is null
        public static void IfNull(object obj, string paramName)
        {
            if (obj == null)
            {
                throw new ArgumentNullException(paramName, $"{paramName} cannot be null.");
            }
        }

        // Throws ArgumentOutOfRangeException if the value is out of the specified range
        public static void IfOutOfRange(int value, int min, int max, string paramName)
        {
            if (value < min || value > max)
            {
                throw new ArgumentOutOfRangeException(paramName, $"Value must be between {min} and {max}. Given: {value}");
            }
        }

        // Throws InvalidOperationException if the condition is false
        public static void IfFalse(bool condition, string message)
        {
            if (!condition)
            {
                throw new InvalidOperationException(message);
            }
        }

        // Throws ArgumentException if the value is invalid
        public static void IfInvalid(bool condition, string paramName, string message)
        {
            if (condition)
            {
                throw new ArgumentException(message, paramName);
            }
        }

        /*public void Add(ServiceRequest request)
        {
            // Ensure the request is not null before adding
            Throw.IfNull(request, nameof(request));

            // Check if the request already exists in the tree
            if (Search(request.RequestId) != null)
            {
                throw new InvalidOperationException($"Request with ID {request.RequestId} already exists.");
            }

            root = AddNode(root, request);
        }*/

    }

}
