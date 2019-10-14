using Caliburn.Micro;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CCApp.ViewModels
{
    public class ChildMainViewModel : Conductor<object>
    {
        public ChildMainViewModel()
        {
            ShowHome();
        }
        public void ShowHome()
        {
            ActivateItem(new ChildListViewModel());
        }
    }
}
