using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace softwaredesignpatterns.consoleapp.Patterns.CommandPattern
{
    public class SayHiCommand : ICommand
    {
        public string userName { get; set; }

        public SayHiCommand(string _userName)
        {
            userName = _userName;
        }
        public void Execute()
        {
            Console.WriteLine(String.Format("Hi {0}!",userName ));
        }
    }
}
