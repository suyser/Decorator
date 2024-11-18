using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    public class FacebookNotifierDecorator : NotifierDecorator
    {
        public FacebookNotifierDecorator(INotifier decoratedNotifier) : base(decoratedNotifier) { }

        public override void Send(string message)
        {
            Console.WriteLine($"Sending Facebook message: {message}");
            base.Send(message);
        }
    }
}