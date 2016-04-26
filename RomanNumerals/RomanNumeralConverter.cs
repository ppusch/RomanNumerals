using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RomanNumerals
{
    public class RomanNumeralConverter
    {
        Dictionary<int, string> romanSymbols = new Dictionary<int,string>
            {
                {1,"I"}, {4,"IV"}, {5,"V"}
            };
        public string ConvertToRomanNumber(int arabicNumber)
        {
            StringBuilder resultBuilder = new StringBuilder();
            while (arabicNumber > 0)
            {
                var arabicValue = romanSymbols.Keys.Where(value => value <= arabicNumber).Max();
                resultBuilder.Append(romanSymbols[arabicValue]);
                arabicNumber = arabicNumber - arabicValue;
            }
            return resultBuilder.ToString();
        }
    }
}