using GIT_Application.Localization;

namespace GIT_Application.ViewModels
{
    public partial class MainWindowViewModel : ViewModelBase
    {
        public string GreetingLangS { get; set; }
        public string GreetingAddRepoS { get; set; }

        private void LocalizationStartUp()
        {
            Language = new ENG_eng();
            GreetingLangS = Language.Greeting;
            GreetingAddRepoS = Language.GreetingSecond;
        }
    }
}
