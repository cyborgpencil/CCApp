
using System;
using System.Collections.Generic;
using System.Windows;
using Caliburn.Micro;
using CCApp.ViewModels;

namespace CCApp
{
    public class Bootstrapper : BootstrapperBase
    {
        private readonly SimpleContainer _container = new SimpleContainer();
        public Bootstrapper()
        {
            Initialize();
        }

        protected override void Configure()
        {
            base.Configure();


            _container.Singleton<IEventAggregator, EventAggregator>()
            .Singleton<IWindowManager, WindowManager>()
            .Singleton<MainWindowViewModel>();
        }

        protected override void OnStartup(object sender, StartupEventArgs e)
        {
           DisplayRootViewFor<MainWindowViewModel>();
        }
        protected override object GetInstance(Type service, string key)
        {
            return _container.GetInstance(service, key);
        }

        protected override IEnumerable<object> GetAllInstances(Type service)
        {
            return _container.GetAllInstances(service);
        }

        protected override void BuildUp(object instance)
        {
            _container.BuildUp(instance);
        }



    }
}
