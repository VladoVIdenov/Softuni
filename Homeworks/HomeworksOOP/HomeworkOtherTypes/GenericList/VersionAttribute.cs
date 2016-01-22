using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericList
{
    public class VersionAttribute : Attribute
    {
        public double Version { get; set; }

        

        public VersionAttribute(double Version)
        {
            this.Version = Version;
        }
    }
}
