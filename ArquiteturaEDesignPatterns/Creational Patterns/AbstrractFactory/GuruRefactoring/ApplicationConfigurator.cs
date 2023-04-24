namespace ArquiteturaEDesignPatterns.Creational_Patterns.AbstrractFactory.GuruRefactoring
{
    public static class ApplicationConfigurator
    {
        //Ignore this implamentation
        public static void StartApplicationAbstractFactoryGuru()
        {
            IGuiFactory windowsFactoy = new WinFactory();
            IGuiFactory macFactory = new MacFactory();
            windowsFactoy.CreateButton().Paint();
            macFactory.CreateButton().Paint();
        }
        public static void StartApplicationAbstractFactoryGuruWithOutAbstractFactory()
        {

        }
    }
}
