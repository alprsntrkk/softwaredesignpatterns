using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace softwaredesignpatterns.consoleapp.Patterns.Behavioral.CommandPattern
{
    public class Invoker
    {
        private ICommand? command;

        public void setCommand(ICommand _command)
        { command = _command; }

        public void buttonPressed()
        { command?.Execute(); }
    }
}