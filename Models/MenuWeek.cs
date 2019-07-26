using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CCApp.Models
{
    public class MenuWeek
    {
        public int ID { get; set; }
        public DateTime SundayStartDate { get; set; }

        // Menu days have the list of food for meal time
        public List< Dictionary<string, List<string>> > MenuDay { get; set; }
    }
}
