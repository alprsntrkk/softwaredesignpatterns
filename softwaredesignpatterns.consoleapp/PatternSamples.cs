using softwaredesignpatterns.consoleapp.Patterns.Behavioral.MediatorPattern;
using softwaredesignpatterns.consoleapp.Patterns.Behavioral.CommandPattern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using softwaredesignpatterns.consoleapp.Patterns.Creational.Singleton;

namespace softwaredesignpatterns.consoleapp
{
    public class PatternSamples
    {
        public PatternSamples()
        {
            PerformCommandPattern();

            PerformMediatorPattern();

            PerformSingletonPattern();
        }

        private void PerformCommandPattern()
        {
            Invoker invoker = new Invoker();
            invoker.setCommand(new SayHiCommand("Alper"));
            invoker.buttonPressed();
        }

        private void PerformMediatorPattern()
        {
            ConcreteUserMediator concreteUserMediator = new ConcreteUserMediator();

            AdminUser adminUser = new AdminUser(concreteUserMediator);
            RegularUser regularUser = new RegularUser(concreteUserMediator);

            concreteUserMediator.FirstUser = adminUser;
            concreteUserMediator.SecondUser = regularUser;

            adminUser.Send("Hi regular user!");
            regularUser.Send("Hi admin!");
        }

        private void PerformSingletonPattern()
        {
            Singleton firstInstance = Singleton.GetInstance();
            Singleton secondInstance = Singleton.GetInstance();

            if (firstInstance == secondInstance)
                Console.WriteLine("Singleton: These instances are same!");
        }
    }
}