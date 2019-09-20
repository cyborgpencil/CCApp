using System.Windows;
using Caliburn.Micro;
using CCApp.ViewModels;

namespace CCApp
{
    public class Bootstrapper : BootstrapperBase
    {
        private readonly SimpleContainer _container = new SimpleContainer();

        protected override void Configure()
        {
            // Add Event Aggregator
            _container.Singleton<IEventAggregator, EventAggregator>();
        }

        public Bootstrapper()
        {
            Initialize();
        }

        protected override void OnStartup(object sender, StartupEventArgs e)
        {
            DisplayRootViewFor<MainWindowViewModel>();
        }

        
    }
}
