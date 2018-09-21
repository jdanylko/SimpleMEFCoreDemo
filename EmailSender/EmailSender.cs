using System;
using System.Composition;
using MEFCore;

namespace EmailSender
{
    [Export(typeof(IMessageSender))]
    public class EmailSender : IMessageSender
    {
        public void Send(string message)
        {
            Console.WriteLine(message);
            Console.ReadKey();
        }
    }
}

