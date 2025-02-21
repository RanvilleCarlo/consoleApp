using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConsoleApp1.src.oops.coupling
{
    public class EmailSender
    {
        public void SendEmail(string message)
        {
            Console.WriteLine("Email sent: " + message);
        }
    }
}