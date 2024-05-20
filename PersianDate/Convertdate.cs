using System;
using System.Collections.Generic;
using System.Text;

namespace PersianDate
{
  public  class Convertdate
    {
      
      public FreeControls.PersianDate GetdDateStringToValue(string date)
      {

          int year = int.Parse(date.Substring(0, 4));
          int month = int.Parse(date.Substring(5, 2));
          int day = int.Parse(date.Substring(8, 2));

          System.Globalization.PersianCalendar persiancal = new System.Globalization.PersianCalendar();
          DateTime dt = persiancal.ToDateTime(year, month, day, 0, 0, 0, 0, 0);
          FreeControls.PersianDate rowDate = FreeControls.PersianDate.Parse(dt);

          return rowDate;
      }
    }
}
