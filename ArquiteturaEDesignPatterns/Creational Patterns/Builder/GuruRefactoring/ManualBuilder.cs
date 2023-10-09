namespace ArquiteturaEDesignPatterns.Creational_Patterns.Builder.GuruRefactoring
{
    internal class ManualBuilder : IBuilder
    {
        public void Reset()
        {
            Console.WriteLine("ManualBuilder:Reset");
        }

        public void SetEngine()
        {
            Console.WriteLine("ManualBuilder:SetEngine");
        }

        public void SetGPS()
        {
            Console.WriteLine("ManualBuilder:SetGPS");
        }

        public void SetSeats()
        {
            Console.WriteLine("ManualBuilder:SetSeats");
        }

        public void SetTripComputer()
        {
            Console.WriteLine("ManualBuilder:SetTripComputer");
        }
    }

}
