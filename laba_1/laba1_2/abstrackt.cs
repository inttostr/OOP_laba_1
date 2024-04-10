using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba1_2
{
    // Абстрактный декоратор
    public abstract class DateTimeDecorator : IDateTimeFormatter
    {
        protected IDateTimeFormatter formatter;

        public DateTimeDecorator(IDateTimeFormatter formatter)
        {
            this.formatter = formatter;
        }

        public abstract string FormatDateTime();
    }

    // Конкретный декоратор, добавляющий символы
    public class SymbolDateTimeDecorator : DateTimeDecorator
    {
        private string symbol;

        public SymbolDateTimeDecorator(IDateTimeFormatter formatter, string symbol)
            : base(formatter)
        {
            this.symbol = symbol;
        }

        public override string FormatDateTime()
        {
            var dateStr = formatter.FormatDateTime();
            var sb = new StringBuilder(dateStr);
            sb.Insert(0, symbol);
            sb.Append(symbol);
            return sb.ToString();
        }
    }
}
