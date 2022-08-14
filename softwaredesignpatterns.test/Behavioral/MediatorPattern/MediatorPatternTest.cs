using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using softwaredesignpatterns.consoleapp.Patterns.Behavioral.MediatorPattern;

namespace softwaredesignpatterns.test.Behavioral.MediatorPattern
{
    public class MediatorPatternTest
    {
        [Fact]
        public void TestMediatorPattern()
        {
            ConcreteUserMediator concreteUserMediator = new ConcreteUserMediator();

            RegularUser regularUser = new RegularUser(concreteUserMediator);
            AdminUser adminUser = new AdminUser(concreteUserMediator);

            concreteUserMediator.FirstUser = regularUser;
            concreteUserMediator.SecondUser = adminUser;

            regularUser.Send("test");
            adminUser.Send("admin test");
        }
    }
}