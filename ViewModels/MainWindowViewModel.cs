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
            ActivateItem(new CalendarViewModel());
        }
    }

    
}
