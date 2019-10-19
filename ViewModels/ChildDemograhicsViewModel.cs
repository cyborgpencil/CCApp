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
    public class ChildDemograhicsViewModel : Screen, IHandle<string>
    {
        private readonly IEventAggregator _eventAggregator;

        public string ChildFirstName { get; set; }

        public ChildDemograhicsViewModel()
        {
        }

        public ChildDemograhicsViewModel(IEventAggregator eventAggregator)
        {
            _eventAggregator = eventAggregator;
            _eventAggregator.Subscribe(this);
            ChildFirstName = "";

            // get selected child from DB
            //using (var context = new CCAppEntities())
            //{

            //}
            // display child Info
        }


        public void Handle(string message)
        {
            ChildFirstName = message;
        }
    }
}
