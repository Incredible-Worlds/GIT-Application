using GIT_Application.Localization;

namespace GIT_Application.ViewModels
{
    public partial class MainWindowViewModel : ViewModelBase
    {
        private Lang? Language;

        public MainWindowViewModel() 
        {
            LocalizationStartUp();
        }
    }
}
