using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using SHLibrary;

namespace SecuritySystem
{
    class SecuritySystem: MarshalByRefObject, SecuritySystemServices
    {

        List<Person> authorisedPersons;
        List<Access> accessHistory;
        bool doorLocked;

        void add(Person person)
        {
            authorisedPersons.Add(person);
            Console.WriteLine("Added {0} with id={1} and is now authorised.", person.name, person.id);
        }

        void remove(Person person)
        {
            authorisedPersons.Remove(person);
            Console.WriteLine("Removed {0} with id={1} and is no longer authorised.", person.name, person.id);
        }

        void seeCamera() { /* ??? */ }   // Return type ??

        bool getDoorState()
        {
            return doorLocked;
        }

        List<Access> getAccessHistory()
        {
            return accessHistory;
        }

        public SecuritySystem()
        {
            this.accessHistory = new List<Access>();
            this.authorisedPersons = new List<Person>();
            this.doorLocked = true;
        }
    }
}
