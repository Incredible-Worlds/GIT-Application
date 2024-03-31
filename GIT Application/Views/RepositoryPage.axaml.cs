using Avalonia.Controls;

namespace GIT_Application.Views
{
    public partial class RepositoryPage : Window
    {
        public RepositoryPage()
        {
            this.SystemDecorations = SystemDecorations.None;
            this.ExtendClientAreaToDecorationsHint = true;
            this.ExtendClientAreaTitleBarHeightHint = 30;
            InitializeComponent();
        }

        private void Menu_PointerPressed(object? sender, Avalonia.Input.PointerPressedEventArgs e)
        {
            BeginMoveDrag(e);
        }
    }
}
