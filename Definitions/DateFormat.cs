﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Globalization;

namespace Definitions
{
    public class DateFormat
    {
        public string ThaiFormatDate(DateTime date)
        {
            //*** Thai Format
            System.Globalization.CultureInfo _cultureTHInfo = new System.Globalization.CultureInfo("th-TH");
            DateTime dateThai = Convert.ToDateTime(date, _cultureTHInfo);
            return dateThai.ToString("dd MMM yyyy", _cultureTHInfo);
        }

        public string EngFormatDate(DateTime date)
        {
            //*** Eng Format
            System.Globalization.CultureInfo _cultureEnInfo = new System.Globalization.CultureInfo("en-US");
            DateTime dateEng = Convert.ToDateTime(date, _cultureEnInfo);
            return dateEng.ToString("dd MMM yyyy", _cultureEnInfo);
        }

        public string ThaiFormatDateTime(DateTime dateTime)
        {
            //*** Thai Format
            System.Globalization.CultureInfo _cultureTHInfo = new System.Globalization.CultureInfo("th-TH");
            DateTime dateThai = Convert.ToDateTime(dateTime, _cultureTHInfo);
            return dateThai.ToString("dd MMM yyyy HH:mm:ss", _cultureTHInfo);
        }

        public string ThaiFormatTime(DateTime dateTime)
        {
            //*** Thai Format
            System.Globalization.CultureInfo _cultureTHInfo = new System.Globalization.CultureInfo("th-TH");
            DateTime dateThai = Convert.ToDateTime(dateTime, _cultureTHInfo);
            return dateThai.ToString("HH:mm:ss", _cultureTHInfo);
        }

        public string EngFormatDateTime(DateTime dateTime)
        {
            //*** Eng Format
            System.Globalization.CultureInfo _cultureEnInfo = new System.Globalization.CultureInfo("en-US");
            DateTime dateEng = Convert.ToDateTime(dateTime, _cultureEnInfo);
            return dateEng.ToString("MM/dd/yyyy HH:mm:ss", _cultureEnInfo);
        }

        public DateTime EngFormatAddTimeUCT_7(DateTime dateTime)
        {
            //*** Eng Format
            System.Globalization.CultureInfo _cultureEnInfo = new System.Globalization.CultureInfo("en-US");
            DateTime dateEng = Convert.ToDateTime(dateTime, _cultureEnInfo);

            TimeSpan time = new TimeSpan(0, 7, 0, 0);
            DateTime dateEngAddTime = dateEng.Add(time);

            return DateTime.Parse(dateEngAddTime.ToString("MM/dd/yyyy HH:mm:ss", _cultureEnInfo));
        }

        public DateTime EngFormatDateToSQL(DateTime dateTime)
        {
            //***Convert to Eng format
            DateTime dateEng = DateTime.Parse(dateTime.ToString(), new CultureInfo("en-US"));
            return dateEng;
        }
    }
}