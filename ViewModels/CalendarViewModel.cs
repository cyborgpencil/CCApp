using Caliburn.Micro;
using CCApp.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Windows;

namespace CCApp.ViewModels
{
    public class CalendarViewModel : Screen
    {
        public MenuWeek MenuWeek { get; set; }


        private bool _editEnable;
        public bool EditEnable
        {
            get {return _editEnable; }

            set {_editEnable = value;
                NotifyOfPropertyChange(()=> EditEnable);
            }
        }

        public CalendarViewModel()
        {
            //setup MenuWeek
            EditEnable = false;
        }

        protected override void OnActivate()
        {
          
        }

        public void Sun_Bf()
        {
            // enable Edit button
            EditEnable = true;
        }
    }
}
