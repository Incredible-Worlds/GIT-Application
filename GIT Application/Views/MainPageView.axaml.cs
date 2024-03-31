using Avalonia.Controls;

namespace GIT_Application.Views
{
    public partial class MainPageView : UserControl
    {
        public MainPageView()
        {
            InitializeComponent();
        }

        private void Window_PointerPressed(object? sender, Avalonia.Input.PointerPressedEventArgs e)
        {
            BeginMoveDrag(e);
        }
    }
}
