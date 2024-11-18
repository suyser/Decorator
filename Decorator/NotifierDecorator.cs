using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    public abstract class NotifierDecorator : INotifier
    {
        protected INotifier _decoratedNotifier;

        public NotifierDecorator(INotifier decoratedNotifier)
        {
            _decoratedNotifier = decoratedNotifier;
        }

        public virtual void Send(string message)
        {
            _decoratedNotifier.Send(message);
        }
    }
}
