using softwaredesignpatterns.consoleapp.Patterns.Behavioral.CommandPattern;
using softwaredesignpatterns.consoleapp.Patterns.Behavioral.MediatorPattern;

namespace softwaredesignpatterns.consoleapp
{
    public class BehavioralPatternSamples
    {
        public BehavioralPatternSamples()
        {
            PerformCommandPattern();

            PerformMediatorPattern();
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
    }
}