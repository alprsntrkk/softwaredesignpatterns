using softwaredesignpatterns.consoleapp.Patterns.Creational.Prototype;
using softwaredesignpatterns.consoleapp.Patterns.Creational.Singleton;

namespace softwaredesignpatterns.consoleapp
{
    public class CreationalPatternSamples
    {
        public CreationalPatternSamples()
        {
            PerformSingletonPattern();

            PerformPrototypePattern();
        }

        private void PerformSingletonPattern()
        {
            Singleton firstInstance = Singleton.GetInstance();
            Singleton secondInstance = Singleton.GetInstance();

            if (firstInstance == secondInstance)
                Console.WriteLine("Singleton: These instances are same!");
        }

        private void PerformPrototypePattern()
        {
            Alien alien = new Alien(1, "Alper Şentürk");
            var copiedAlien = alien.Clone();

            if (!alien.Equals(copiedAlien))
                Console.WriteLine("Prototype: These aliens have ability to clone!!");
        }
    }
}