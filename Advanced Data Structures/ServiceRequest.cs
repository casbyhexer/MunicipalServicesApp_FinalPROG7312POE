using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MunicipalServicesApp.Advanced_Data_Structures
{
    public class ServiceRequest : IComparable<ServiceRequest>
    {
        public int RequestId { get; set; }
        public string Status { get; set; }
        public int Priority { get; set; }

        // Implement CompareTo for sorting by RequestId (or Priority if needed)
        public int CompareTo(ServiceRequest other)
        {
            if (other == null) return 1;
            return this.RequestId.CompareTo(other.RequestId); // Change to Priority if needed
        }
    }

}
