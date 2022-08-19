using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace softwaredesignpatterns.consoleapp.Patterns.Creational.Prototype
{
    public class Clonable<T> where T : class
    {
        public T? Clone()
        {
            return this.MemberwiseClone() as T;
        }
    }
}