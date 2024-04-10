using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba1_2
{
    class Program
    {
        static void Main(string[] args)
        {
            IDateTimeFormatter dateTimeFormatter;

            // Выбор стиля
            dateTimeFormatter = new EuropeanDateTimeFormatter();
           // dateTimeFormatter = new AmericanDateTimeFormatter();

            // Добавляем декораторы
            dateTimeFormatter = new SymbolDateTimeDecorator(dateTimeFormatter, "Кир");
            dateTimeFormatter = new SymbolDateTimeDecorator(dateTimeFormatter, "Чин");
            dateTimeFormatter = new SymbolDateTimeDecorator(dateTimeFormatter, "Чин");

            Console.WriteLine(dateTimeFormatter.FormatDateTime());
        }
    }
}
