using System;
using System.Collections.Generic;
using System.Text;

namespace Definitions
{
    public class TimeFormat
    {
        public class minute
        {
            public string values { get; set; }
        }

        public class hour
        {
            public string values { get; set; }
        }

        public List<minute> GenMinutes()
        {
            List<minute> minutes = new List<minute>();
            for (int i = 0;i < 60;i++)
            {
                if (i<10)
                {
                    minutes.Add(new minute
                    {
                        values = 0 + i.ToString()
                    });
                }
                else
                {
                    minutes.Add(new minute
                    {
                        values = i.ToString()
                    });
                }
            }
            return minutes;
        }
        
        public List<hour> GenHour()
        {
            List<hour> hours = new List<hour>();
            for (int i = 0; i < 12; i++)
            {
                if (i<10)
                {
                    hours.Add(new hour
                    {
                        values = 0+i.ToString()
                    });
                }
                else
                {
                    hours.Add(new hour
                    {
                        values = i.ToString()
                    });
                }
            }
            return hours;
        }

        public DateTime PlusTime(DateTime oldTime, Int32 plusMinute)
        {
           return oldTime.AddMinutes(plusMinute);
        }

        public DateTime ConvertDataToTime(String hour, String minute, String unit)
        {
            return DateTime.ParseExact(hour +":"+minute+":00 "+unit, "hh:mm:ss tt", System.Globalization.CultureInfo.CurrentCulture);
        }
    }
}
