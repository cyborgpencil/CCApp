using Caliburn.Micro;
using CCApp.Data;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CCApp.ViewModels
{
    public class ChildDemograhicsViewModel : Conductor<object>
    {
        private readonly IEventAggregator _eventAggregator;

        public string ChildFirstName { get; set; }

        public ChildDemograhicsViewModel()
        {
        }

        public ChildDemograhicsViewModel(IEventAggregator eventAggregator, string childFirstname)
        {
            _eventAggregator = eventAggregator;
            ChildFirstName = childFirstname;


            
        }

        public void LoadChildDemographics()
        {

            //get selected child from DB
            using (var context = new CCAppEntities())
            {
                var selectedChild = from c in context.Child
                                    where c.ChildFirstName == ChildFirstName.TrimEnd()
                                    select c;

                //display child Info
                Child child = new Child();
                child = (Child)selectedChild;
                ChildFirstName = child.ChildFirstName;
            }

        }




    }
}
