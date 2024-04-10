using System;
using System.Globalization;
using System.Text;

namespace laba1_2 { 

// Базовый интерфейс для форматирования даты и времени
public interface IDateTimeFormatter
{
    string FormatDateTime();
}

    public class EuropeanDateTimeFormatter : IDateTimeFormatter
    {
        public string FormatDateTime()
        {
            CultureInfo culture = CultureInfo.CreateSpecificCulture("ru-RU");
            return DateTime.Now.ToString(culture);
        }
    }
    public class AmericanDateTimeFormatter : IDateTimeFormatter
    {
        public string FormatDateTime()
        {
            CultureInfo culture = CultureInfo.CreateSpecificCulture("en-US");
            return DateTime.Now.ToString(culture);
        }
    }



}
