namespace ArquiteturaEDesignPatterns.Creational_Patterns.AbstrractFactory.GuruRefactoring
{
    internal class MacFactory : IGuiFactory
    {
        public IButton CreateButton()
        {
            return new MacButton();
        }

        public ICheckBox CreateCheckBox()
        {
            return new MacCheckbox();
        }
    }
}
