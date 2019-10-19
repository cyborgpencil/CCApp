using Caliburn.Micro;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CCApp.ViewModels
{
    public class ChildInfoViewModel : Conductor<object>
    {
        public string SelectedChild { get; set; }
        public ChildInfoViewModel(IEventAggregator eventAggregator)
        {
            ActivateItem(new ChildDemograhicsViewModel(eventAggregator));
        }
        public void ShowChildDemographics()
        {
           
        }
    }
}
