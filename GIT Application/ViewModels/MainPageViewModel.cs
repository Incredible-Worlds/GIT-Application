using GIT_Application.Localization;
using ReactiveUI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GIT_Application.ViewModels
{
    public partial class MainPageViewModel : ViewModelBase
    {
        private Lang? Language;

        public MainPageViewModel() 
        {
            ContentLoad = new LoadingPopUpViewModel();
            LocalizationStartUp();
        }

        public ViewModelBase ContentLoad
        {
            get => content;
            private set => this.RaiseAndSetIfChanged(ref content, value);
        }
        ViewModelBase content;
    }
}
