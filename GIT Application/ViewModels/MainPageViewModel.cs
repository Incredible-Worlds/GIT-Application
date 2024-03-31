using GIT_Application.Localization;
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
            LocalizationStartUp();
        }
    }
}
