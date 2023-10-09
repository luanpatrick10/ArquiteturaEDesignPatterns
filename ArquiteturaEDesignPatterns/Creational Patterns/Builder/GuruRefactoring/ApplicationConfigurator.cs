namespace ArquiteturaEDesignPatterns.Creational_Patterns.Builder.GuruRefactoring
{
    internal static class ApplicationConfigurator
    {
        public static void StartApplicationBuilder()
        {
            var director = new Director();
            var carBuilder = new CarBuilder();
            var manualBuilder = new ManualBuilder();

            director.ConstructorSportsCar(carBuilder);

            Console.WriteLine();
            Console.WriteLine();

            director.ConstructorSportsCar(manualBuilder);
        }
    }
}
