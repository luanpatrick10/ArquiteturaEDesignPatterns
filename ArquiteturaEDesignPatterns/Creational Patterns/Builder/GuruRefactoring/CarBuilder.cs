namespace ArquiteturaEDesignPatterns.Creational_Patterns.Builder.GuruRefactoring
{
    internal class CarBuilder : IBuilder
    {
        public void Reset()
        {
            Console.WriteLine("CarBuilder:Reset");
        }

        public void SetEngine()
        {
            Console.WriteLine("CarBuilder:SetEngine");
        }

        public void SetGPS()
        {
            Console.WriteLine("CarBuilder:SetGPS");
        }

        public void SetSeats()
        {
            Console.WriteLine("CarBuilder:SetSeats");
        }

        public void SetTripComputer()
        {
            Console.WriteLine("CarBuilder:SetTripComputer");
        }
    }

}
