using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace softwaredesignpatterns.consoleapp.Patterns.Behavioral.MediatorPattern
{
    public interface IUserMediator
    {
        void Send(string message, User user);
    }
}