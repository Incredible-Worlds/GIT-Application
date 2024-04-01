using GIT_Application.Localization;
using GIT_Application.Views;
using ReactiveUI;
using System.Collections.Generic;

namespace GIT_Application.ViewModels
{
    public partial class MainWindowViewModel : ViewModelBase
    {
        public MainWindowViewModel() 
        {
            Content = StartUpPage = new MainPageViewModel();
        }

        public ViewModelBase Content
        {
            get => content;
            private set => this.RaiseAndSetIfChanged(ref content, value);
        }
        ViewModelBase content;

        public MainPageViewModel StartUpPage { get; }

        public void Foo()
        {
            
        }
    }
}
