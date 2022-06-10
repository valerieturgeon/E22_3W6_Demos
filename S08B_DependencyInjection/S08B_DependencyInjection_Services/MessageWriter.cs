using S08B_DependencyInjection_Services.Interfaces;
using System;

namespace S08B_DependencyInjection_Services
{
    public class MessageWriter : IMessageWriter
    {
        public void Write(string message)
        {
            Console.WriteLine("MessageWriter dit: " + message);
        }
    }
}
