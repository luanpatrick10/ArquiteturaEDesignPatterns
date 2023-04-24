namespace ArquiteturaEDesignPatterns.Creational_Patterns.FactoryMethod.RefactoringGuru
{
    internal class WindowsDialog : Dialog
    {
        public override IButton CreateButton()
        {
            return new WindowsButton();
        }
    }
}
