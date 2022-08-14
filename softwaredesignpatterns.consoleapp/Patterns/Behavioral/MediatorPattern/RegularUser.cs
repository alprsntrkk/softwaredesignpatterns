using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace softwaredesignpatterns.consoleapp.Patterns.Behavioral.MediatorPattern
{
    public class RegularUser : User
    {
        public RegularUser(IUserMediator mediator) : base(mediator)
        {
        }

        public override void Notify(string message)
        {
            Console.WriteLine("Regular user gets message: " + message);
        }

        public override void Send(string message)
        {
            _mediator.Send("Hi admin!", this);
        }
    }
}