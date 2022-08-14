using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace softwaredesignpatterns.consoleapp.Patterns.Behavioral.MediatorPattern
{
    public abstract class User
    {
        protected IUserMediator _mediator;

        public User(IUserMediator mediator)
        {
            _mediator = mediator;
        }

        public abstract void Send(string message);

        public abstract void Notify(string message);
    }
}