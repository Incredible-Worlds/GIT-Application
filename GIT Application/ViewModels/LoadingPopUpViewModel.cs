using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GIT_Application.ViewModels
{
    public class LoadingPopUpViewModel : ViewModelBase
    {
        public string aaab;

        public LoadingPopUpViewModel()
        {
            aaab = "Cloning {Repository name}\r\ninto {UpperFolder name}";
        }
    }
}
