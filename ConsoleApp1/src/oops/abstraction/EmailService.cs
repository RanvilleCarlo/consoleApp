//abstarction

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConsoleApp1.src.oops.abstraction
{
    public class EmailService
    {
        public void SendEmail()
        {
            connect();
            authenticate();
            System.Console.WriteLine("Sending email.....");
            Disconnect();
        }

        private void connect()
        {
            Console.WriteLine("Connecting to email server.....");
        }

        private void authenticate()
        {
            Console.WriteLine("Authenticating.....");
        }

        private void Disconnect()
        {
            Console.WriteLine("Disconnecting.....");
        }

        


    }
}