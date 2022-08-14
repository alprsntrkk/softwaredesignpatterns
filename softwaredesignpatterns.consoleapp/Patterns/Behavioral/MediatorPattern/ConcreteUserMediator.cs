using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace softwaredesignpatterns.consoleapp.Patterns.Behavioral.MediatorPattern
{
    public class ConcreteUserMediator : IUserMediator
    {
        private User firstUser;
        private User secondUser;

        public User FirstUser
        {
            set { firstUser = value; }
        }

        public User SecondUser
        {
            set { secondUser = value; }
        }

        public void Send(string message, User user)
        {
            if (user == firstUser)
            {
                secondUser.Notify(message);
            }
            else if (user == secondUser)
            {
                firstUser.Notify(message);
            }
        }
    }
}