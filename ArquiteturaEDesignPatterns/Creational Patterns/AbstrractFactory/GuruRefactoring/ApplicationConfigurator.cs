namespace ArquiteturaEDesignPatterns.Creational_Patterns.AbstrractFactory.GuruRefactoring
{
    public static class ApplicationConfigurator
    {
        //Ignore this implamentation
        public static void StartApplicationAbstractFactoryGuru()
        {
            IGuiFactory factory;
            Console.WriteLine("Digite um sistema operacional");
            string os = Console.ReadLine();
            if (os == "Windows")
                factory = new WinFactory();
            else if (os == "Mac")
                factory = new MacFactory();
            else
                throw new Exception("This os not exist");
            factory.CreateButton().Paint();
            factory.CreateCheckBox().Paint();


        }
    }
}
