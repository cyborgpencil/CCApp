using Caliburn.Micro;
using CCApp.Data;
using System.Linq;
using System.Diagnostics;
using System.Windows;
using log4net;
using log4net.Config;

namespace CCApp.ViewModels
{
    public class MainWindowViewModel : Conductor<object>
    {
        private IWindowManager _winderManager;
        private IEventAggregator _eventAggregator;

        readonly log4net.ILog log = log4net.LogManager.GetLogger(typeof(MainWindowViewModel));
        public MainWindowViewModel()
        {

        }
        public MainWindowViewModel(IWindowManager windowManager, IEventAggregator eventAggregator)
        {
            _winderManager = windowManager;
            _eventAggregator = eventAggregator;
            XmlConfigurator.Configure();
        }

        public void ShowCalendar()
        {
            ActivateItem(new CalendarViewModel());

        }

        public void ShowHome()
        {
        }

        public void EditCompany()
        {
            ActivateItem(new CompanyViewModel());
        }

        public void Print()
        {
            //Show Print preview based on selcted screen

           //var aI = ActiveItem.GetType().ToString();
           // switch (aI)
           // {
           //     case "CCApp.ViewModels.CalendarViewModel":
           //         ChangeActiveItem(new CalendarPrintViewModel(), false);
           //         break;
           //     default:
           //         break;
           // }
        }

        public void ShowChildren()
        {
            ActivateItem(new ChildMainViewModel(_eventAggregator));
        }

        public void ExitApp()
        {
            Application.Current.Shutdown();
        }
    }


}
