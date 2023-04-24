namespace ArquiteturaEDesignPatterns.Creational_Patterns.FactoryMethod.RefactoringGuru
{
    public static class ApplicationConfigurator
    {
        private static List<Type> _applicationDialogs = new List<Type>()
        {
            typeof(WindowsDialog),
            typeof(WebDialog)
        };
        private static Dictionary<int, string> applicationDictionaryOptions = GenerateApplicationDialogsOptions();
        public static void StartApplicationFactoryMethod()
        {
            ShowApplicationDialogs();
            Dialog dialogCreator = GenerateDialogByType(applicationDictionaryOptions[Convert.ToInt32(Console.ReadLine())]);
            dialogCreator.Render();
        }
        private static void ShowApplicationDialogs()
        {
            for (int applicattionDialogsOptions = 0; applicattionDialogsOptions < applicationDictionaryOptions.Count; applicattionDialogsOptions++)
            {
                Console.WriteLine("Selecione:{0} para escolher o dialogo:{1}", applicationDictionaryOptions.Keys.ElementAt(applicattionDialogsOptions), GenerateApplicationDialogsOptions().Values.ElementAt(applicattionDialogsOptions));
            }
        }
        private static Dictionary<int, string> GenerateApplicationDialogsOptions()
        {
            Dictionary<int, string> keyValueApplicationDialogs = new Dictionary<int, string>();
            for (int applicationDialogIndex = 0; applicationDialogIndex < _applicationDialogs.Count; applicationDialogIndex++)
            {
                keyValueApplicationDialogs.Add(applicationDialogIndex, _applicationDialogs[applicationDialogIndex].Name.ToString());
            }
            return keyValueApplicationDialogs;
        }
        private static Dialog GenerateDialogByType(string key)
        {
            return (Dialog)Activator.CreateInstance(_applicationDialogs.Find(type => type.Name == key));
        }
    }
}
