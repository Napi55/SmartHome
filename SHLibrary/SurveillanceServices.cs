using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SHLibrary
{
    public interface SurveillanceAdminServices
    {
        void enable();
        void disable();
    }

    public interface SurveillancePersonServices
    {
        Ambiance getAmbiance();
    }
}
