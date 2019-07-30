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
        public MealDay SUNDAY { get; set; }
        public MealDay MONDAY { get; set; }
        public MealDay TUESDAY { get; set; }
        public MealDay WEDNESDAY { get; set; }

        public MealDay THURSDAY { get; set; }
        public MealDay FRIDAY { get; set; }
        public MealDay SATURDAY { get; set; }


        // SUNDAY PROP
        private string _sun_BF_Text;
        public string Sun_BF_Text
        {
            get { return _sun_BF_Text; }

            set
            {
                _sun_BF_Text = value;
                NotifyOfPropertyChange(() => Sun_BF_Text);
            }
        }

        private bool _editEnable;
        public bool EditEnable
        {
            get {return _editEnable; }

            set {_editEnable = value;
                NotifyOfPropertyChange(()=> EditEnable);
            }
        }

        private DateTime _calendarWeekSunday;
        public DateTime CalendarWeekSunday
        {
            get { return _calendarWeekSunday; }

            set
            {
                _calendarWeekSunday = value;
                NotifyOfPropertyChange(() => CalendarWeekSunday);
            }
        }

        public CalendarViewModel()
        {
            //setup MenuWeek
            EditEnable = false;
        }


        protected override void OnActivate()
        {
            SUNDAY = new MealDay
            {
                MealTimes = new string[5]
            };

            for (int i = 0; i < SUNDAY.MealTimes.Length; i++)
            {
                SUNDAY.MealTimes[i] = "Test, Test Test";

            }

            Sun_BF_Text = SUNDAY.MealTimes[0];

        }

        /* private DateTime GetWeekSundayDate(DateTime date)
        {
            switch (date.DayOfWeek)
            {

                case DayOfWeek.Monday:
                  date.
                break;
              default: // SUNDAY
                    break;
            }

            return date;
        }*/

        // Enabled 
        public void Sun_Bf()
        {
            // enable Edit button
            EditEnable = true;
        }
    }
}
