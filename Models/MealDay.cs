using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CCApp.Models
{
    public class MealDay
    {
        public int ID { get; set; }
        public string[] MealTimes { get; set; }
        public DateTime Date { get; set; }
    }
}
