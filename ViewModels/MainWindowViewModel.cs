using Caliburn.Micro;
using System.Windows;

namespace CCApp.ViewModels
{
    public class MainWindowViewModel : Conductor<object>
    {


        

        public MainWindowViewModel()
        {
            
        }

        public void ShowCalendar()
        {

            // debug*
            ActivateItem(new CalendarPrintViewModel());

           // ActivateItem(new CalendarViewModel());
        }

        public void ShowHome()
        {
            ActivateItem(new object());
        }


    }

    
}
