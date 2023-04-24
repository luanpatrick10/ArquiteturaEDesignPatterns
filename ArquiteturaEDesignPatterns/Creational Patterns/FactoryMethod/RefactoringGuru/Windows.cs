namespace ArquiteturaEDesignPatterns.Creational_Patterns.FactoryMethod.RefactoringGuru
{
    internal class WindowsButton : IButton
    {
        public void OnClick()
        {
            Console.Write($"Botão {nameof(WindowsButton)} clicado.");
        }

        public void Render()
        {
            Console.Write($"Botão {nameof(WindowsButton)} renderizado.");
        }
    }
}
