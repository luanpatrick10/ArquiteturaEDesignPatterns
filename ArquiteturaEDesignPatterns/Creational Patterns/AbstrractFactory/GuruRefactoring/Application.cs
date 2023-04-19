namespace ArquiteturaEDesignPatterns.Creational_Patterns.AbstrractFactory.GuruRefactoring
{
    internal class Application
    {
        private IGuiFactory _factory;
        private IButton _button;
        public Application(IGuiFactory factory, IButton button)
        {
            _factory = factory;
            _button = button;
        }

        public void CreateUi()
        {
            _button = _factory.CreateButton();
        }
        public void Paint()
        {
            _button.Paint();
        }

    }
}
