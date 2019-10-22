using Caliburn.Micro;
using CCApp.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CCApp.ViewModels
{
    public class ChildInfoViewModel : Conductor<IScreen>.Collection.OneActive, IHandle<string>
    {
        private IEventAggregator _eventAggregator;
        public string SelectedChild { get; set; }

        public int SelectedIndex { get; set; }
        public Child SelectedChildInfo { get; set; }
        public string ChildFirstName { get; set; }
        public string ChildMiddleName { get; set; }
        public string ChildLastName { get; set; }
        public string ChildBirthDate { get; set; }


        public ChildInfoViewModel(IEventAggregator eventAggregator, Child selectedChild)
        {
            SelectedChildInfo = selectedChild;
            _eventAggregator = eventAggregator;
            _eventAggregator.Subscribe(this);

            ChildFirstName = SelectedChildInfo.ChildFirstName;
            ChildMiddleName = SelectedChildInfo.ChildMiddleName;
            ChildLastName = SelectedChildInfo.ChildLastName;
            ChildBirthDate = SelectedChildInfo.ChildBirthDate;
        }
        public void ShowChildDemographics()
        {
            
        }

        //public void Selected()
        //{
        //    ActivateItem(new ChildDemograhicsViewModel(_eventAggregator, ChildFN));
        //}

        public void Handle(string message)
        {
            //ChildFN = message;
        }
    }
}
