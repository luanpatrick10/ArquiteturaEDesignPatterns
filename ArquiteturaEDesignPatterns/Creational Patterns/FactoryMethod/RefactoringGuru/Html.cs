namespace ArquiteturaEDesignPatterns.Creational_Patterns.FactoryMethod.RefactoringGuru
{
    internal class HtmlButton : IButton
    {
        public void OnClick()
        {
            Console.Write($"Botão {nameof(HtmlButton)} clicado.");
        }

        public void Render()
        {
            Console.Write($"Botão {nameof(HtmlButton)} renderizado.");
        }
    }
}
