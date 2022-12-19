using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SHLibrary
{
    public class Access
    {
        public Person person;
        public DateTime date;
        public bool authorised;

        public Access(Person person, bool authorised)
        {
            this.person = person;
            this.date = DateTime.Now;
            this.authorised = authorised;
        }
    }
}
