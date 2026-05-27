using Microsoft.Extensions.DependencyInjection;

namespace CadastroEventos
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
        }

        protected override Window CreateWindow(IActivationState? activationState)
        {
            var window = new Window(new AppShell());
            window.Width = 400;
            window.Height = 650;
            return window;
        }
    }
}