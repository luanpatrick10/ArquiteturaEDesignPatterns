namespace ArquiteturaEDesignPatterns.Creational_Patterns.Builder.GuruRefactoring
{
    internal class Director
    {
        internal void ConstructorSportsCar(IBuilder builder)
        {
            builder.Reset();
            builder.SetEngine();
            builder.SetSeats();
            builder.SetTripComputer();
            builder.SetGPS();
        }
    }

}
