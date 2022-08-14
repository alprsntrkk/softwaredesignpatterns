using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using softwaredesignpatterns.consoleapp.Patterns.Behavioral.CommandPattern;
using Assert = Xunit.Assert;

namespace softwaredesignpatterns.test.Behavioral.CommandPattern
{
    public class CommandPatternTests
    {
        [Fact]
        public void TestCommandPattern()
        {
            Invoker invoker = new Invoker();
            invoker.setCommand(new SayHiCommand("Alper"));
            invoker.buttonPressed();
        }
    }
}