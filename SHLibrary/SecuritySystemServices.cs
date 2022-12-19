using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SHLibrary
{
    public interface SecuritySystemServices
    {
        void add(Person person);
        void remove(Person person);
        void seeCamera();   // Return type ??
        bool getDoorState();
        List<Access> getAccessHistory();
    }
}
