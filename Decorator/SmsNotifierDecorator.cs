using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    public class SmsNotifierDecorator : NotifierDecorator
    {
        public SmsNotifierDecorator(INotifier decoratedNotifier) : base(decoratedNotifier) { }

        public override void Send(string message)
        {
            Console.WriteLine($"Sending SMS: {message}");
            base.Send(message);
        }
    }
}
