using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace softwaredesignpatterns.consoleapp.Patterns.CommandPattern
{
    public class Invoker
    {
        ICommand? command;

        public void setCommand(ICommand _command) { command = _command; }
        public void buttonPressed() { command?.Execute(); }
    }
}
