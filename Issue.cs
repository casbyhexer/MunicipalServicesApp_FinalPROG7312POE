using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MunicipalServicesApp
{
    internal class Issue
    {
      
            public string Location { get; set; }
            public string Category { get; set; }
            public string Description { get; set; }
            public string MediaAttachment { get; set; }

            public Issue(string location, string category, string description)
            {
                Location = location;
                Category = category;
                Description = description;
            }
        

    }
}
