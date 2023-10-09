namespace ArquiteturaEDesignPatterns.Creational_Patterns.FactoryMethod.RefactoringGuru
{
    internal abstract class Dialog
    {
        public abstract IButton CreateButton();
        public void Render()
        {
            IButton okButton = CreateButton();
            okButton.OnClick();
            okButton.Render();
        }
    }
}
