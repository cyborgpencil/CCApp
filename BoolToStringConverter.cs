using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace CCApp
{
    public class BoolToStringConverter : IValueConverter
    {
        //object IValueConverter.Convert(object value, Type targetType, object parameter, CultureInfo culture)
        //{
        //    string CheckBoxStatus = "False";

        //    if ((bool)value == true)
        //    {
        //        CheckBoxStatus = "True";
        //    }
        //    else
        //        CheckBoxStatus = "False";

        //    return CheckBoxStatus;
        //}

        //object IValueConverter.ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        //{
        //    bool CheckBoxStatus = false;

        //    if (!string.IsNullOrWhiteSpace(value.ToString()))
        //    {
        //        if (value.ToString() == "True")
        //        {
        //            CheckBoxStatus = true;
        //        }
        //        else
        //            CheckBoxStatus = false;
        //    }

        //    return CheckBoxStatus;
        //}
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            string CheckBoxStatus = "False";

            if ((bool)value == true)
            {
                CheckBoxStatus = "True";
            }
            else
                CheckBoxStatus = "False";

            return CheckBoxStatus;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            bool CheckBoxStatus = false;

            if (!string.IsNullOrWhiteSpace(value.ToString()))
            {
                if (value.ToString() == "True")
                {
                    CheckBoxStatus = true;
                }
                else
                    CheckBoxStatus = false;
            }

            return CheckBoxStatus;
        }
    }
}
