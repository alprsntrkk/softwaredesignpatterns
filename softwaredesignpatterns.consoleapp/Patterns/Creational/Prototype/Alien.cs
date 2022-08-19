using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace softwaredesignpatterns.consoleapp.Patterns.Creational.Prototype
{
    public class Alien : Clonable<Alien>
    {
        public Alien(int id, string name)
        {
            Id = id;
            Name = name;
        }

        private int Id { get; set; }
        private string Name { get; set; }
    }
}