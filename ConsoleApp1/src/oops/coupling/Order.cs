using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConsoleApp1.src.oops.coupling
{
    public class Order
    {
        public void placeOrder()
        {
           
            EmailSender emailSender = new EmailSender();
            emailSender.SendEmail("Order placed sucessfully");
        }
    }
}
