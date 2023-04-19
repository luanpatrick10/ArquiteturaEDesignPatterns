namespace ArquiteturaEDesignPatterns.Creational_Patterns.AbstrractFactory.GuruRefactoring
{
    internal interface IGuiFactory
    {
        IButton CreateButton();
        ICheckBox CreateCheckBox();
    }
}
