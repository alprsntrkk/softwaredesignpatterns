using softwaredesignpatterns.consoleapp.Patterns.CommandPattern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace softwaredesignpatterns.consoleapp
{
    public class PatternSamples
    {
        public PatternSamples()
        {
            Invoker invoker = new Invoker();
            invoker.setCommand(new SayHiCommand("Alper"));
            invoker.buttonPressed();
        }
    }
}
