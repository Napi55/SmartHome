using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Runtime.Remoting;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Channels.Tcp;

namespace SecuritySystem
{
    class MainApp
    {
        static void Main(string[] args)
        {
            TcpChannel channel = new TcpChannel(2001);
            ChannelServices.RegisterChannel(channel);
            RemotingConfiguration.RegisterWellKnownServiceType(typeof(SecuritySystem), "securitySystem", WellKnownObjectMode.Singleton);
            Console.WriteLine("Security System is ready...");
            Console.Read();
        }
    }
}
