namespace MauiAppLogin
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new AppShell();
        }
        protected override Window CreateWindow(IActivationState activationState)
        {
            var window = base.CreateWindow(activationState);

            return window;
            window.Width = 100;
            window.Height = 400;
            
        }
    } //FECHA CLASSE
} // FECHA NAMESPACE
