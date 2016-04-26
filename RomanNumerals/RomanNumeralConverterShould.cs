using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NFluent;
using NUnit.Framework;

namespace RomanNumerals
{
    public class RomanNumeralConverterShould
    {
        [TestCase(1,"I")]
        [TestCase(2,"II")]
        [TestCase(3,"III")]
        [TestCase(4,"IV")]
        [TestCase(5,"V")]
        [TestCase(6,"VI")]
        [TestCase(7,"VII")]
        [TestCase(8,"VIII")]
        [TestCase(9,"IX")]
        [TestCase(10,"X")]
        public void convert_to_roman_number(int arabicNumber, string expectedRomanNumber)
        {
            var romanNumeralConverter = new RomanNumeralConverter();

            Check.That(romanNumeralConverter.ConvertToRomanNumber(arabicNumber)).Equals(expectedRomanNumber);
        }


    }
}
