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
        readonly log4net.ILog log = log4net.LogManager.GetLogger(typeof(MainWindowViewModel));
        public MainWindowViewModel()
        {
            XmlConfigurator.Configure();
            log.Info("CCApp Started!");
        }

        public void ShowCalendar()
        {
            
            ActivateItem(new CalendarViewModel());
           

        }

        public void ShowHome()
        {
            //MainContent(new object());
        }

        public void EditCompany()
        {
            ActivateItem(new CompanyViewModel());
        }

        public void Print()
        {
            // Show Print preview based on selcted screen

            var aI = ActiveItem.GetType().ToString();
            switch (aI)
            {   
                case "CCApp.ViewModels.CalendarViewModel":
                    ChangeActiveItem(new CalendarPrintViewModel(), false);
                    break;
                default:
                    break;
            }
        }

        public void ShowChildren()
        {
            ActivateItem(new ChildMainViewModel());
        }

        public void ExitApp()
        {
            Application.Current.Shutdown();
        }
    }


}
