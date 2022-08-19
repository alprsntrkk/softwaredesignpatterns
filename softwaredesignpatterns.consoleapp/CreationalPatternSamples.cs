using softwaredesignpatterns.consoleapp.Patterns.Creational.Singleton;

namespace softwaredesignpatterns.consoleapp
{
    public class CreationalPatternSamples
    {
        public CreationalPatternSamples()
        {
            PerformSingletonPattern();
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