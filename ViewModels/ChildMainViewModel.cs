using Caliburn.Micro;
using CCApp.Data;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CCApp.ViewModels
{
    public class ChildMainViewModel : Conductor<object>
    {
        public string ChildSelectedItem { get; set; }
        public ObservableCollection<Child> Children { get; set; }
        public ObservableCollection<Child> ChildList { get; set; }
        public ChildMainViewModel()
        {
            // Load Children

            ShowHome();
        }
        public void ShowHome()
        {
            ActivateItem(new ChildListViewModel());
        }

        public void ShowGeneralChildInfo(string child)
        {
            child = ChildSelectedItem;
        }

        public void ShowCreateChild()
        {
            ActivateItem(new ChildCreateViewModel());
        }
    }
}
