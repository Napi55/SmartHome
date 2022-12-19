using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using SHLibrary;

namespace SurveillanceSystem
{
    class SurveillanceSystem: MarshalByRefObject, SHLibrary.SurveillancePersonServices {
        Ambiance ambiance = new Ambiance(35, 21);
        public Ambiance getAmbiance()
        {
            return this.ambiance;
        }
    }
}
