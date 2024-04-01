using Avalonia.Controls;
using Avalonia.Input;
using System.Windows.Input;

namespace GIT_Application.Views
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            this.SystemDecorations = SystemDecorations.None;
            this.ExtendClientAreaToDecorationsHint = true;
            this.ExtendClientAreaTitleBarHeightHint = 30;
            InitializeComponent();
        }

        private void Window_PointerPressed(object? sender, Avalonia.Input.PointerPressedEventArgs e)
        {
            BeginMoveDrag(e);
        }
    }
}