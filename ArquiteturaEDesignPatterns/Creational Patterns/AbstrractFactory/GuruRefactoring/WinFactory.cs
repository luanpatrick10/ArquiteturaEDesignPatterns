namespace ArquiteturaEDesignPatterns.Creational_Patterns.AbstrractFactory.GuruRefactoring
{
    internal class WinFactory : IGuiFactory
    {
        public IButton CreateButton()
        {
            return new WinButton();
        }

        public ICheckBox CreateCheckBox()
        {
            return new WinCheckbox();
        }
    }
}
