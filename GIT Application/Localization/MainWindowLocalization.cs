using GIT_Application.Localization;

namespace GIT_Application.ViewModels
{
    public partial class MainPageViewModel : ViewModelBase
    {
        public string GreetingLangS { get; set; }
        public string GreetingAddRepoS { get; set; }
        public string CloneRepoS { get; set; }
        public string CreateRepoS { get; set; }
        public string NameRepoS { get; set; }
        public string DescriptionS { get; set; }
        public string LocalPathS { get; set; }
        public string GitIgnoreS { get; set; }

        private void LocalizationStartUp()
        {
            Language = new ENG_eng();
            GreetingLangS = Language.Greeting;
            GreetingAddRepoS = Language.GreetingSecond;
            CloneRepoS = Language.CloneRepo;
            CreateRepoS = Language.CreateRepo;
            NameRepoS = Language.NameRepo;
            DescriptionS = Language.DescriptionRepo;
            LocalPathS = Language.LocalPath;
            GitIgnoreS = Language.GitIgnore;
        }
    }
}
