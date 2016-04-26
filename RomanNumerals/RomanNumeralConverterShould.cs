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
        [Test]
        public void return_I_when_Arabic_Number_Is_1()
        {
            var romanNumeralConverter = new RomanNumeralConverter();

            Check.That(romanNumeralConverter.ConvertToRomanNumber(1)).Equals("I");
        }

        [Test]
        public void return_II_when_Arabic_Number_Is_2()
        {
            var romanNumeralConverter = new RomanNumeralConverter();

            Check.That(romanNumeralConverter.ConvertToRomanNumber(2)).Equals("II");
        }

        [Test]
        public void return_III_when_Arabic_Number_Is_3()
        {
            var romanNumeralConverter = new RomanNumeralConverter();

            Check.That(romanNumeralConverter.ConvertToRomanNumber(3)).Equals("III");
        }

        [Test]
        public void return_IV_when_Arabic_Number_Is_4()
        {
            var romanNumeralConverter = new RomanNumeralConverter();

            Check.That(romanNumeralConverter.ConvertToRomanNumber(4)).Equals("IV");
        }

        [Test]
        public void return_V_when_Arabic_Number_Is_5()
        {
            var romanNumeralConverter = new RomanNumeralConverter();

            Check.That(romanNumeralConverter.ConvertToRomanNumber(5)).Equals("V");
        }

        [Test]
        public void return_VI_when_Arabic_Number_Is_6()
        {
            var romanNumeralConverter = new RomanNumeralConverter();

            Check.That(romanNumeralConverter.ConvertToRomanNumber(6)).Equals("VI");
        }

        [Test]
        public void return_VII_when_Arabic_Number_Is_7()
        {
            var romanNumeralConverter = new RomanNumeralConverter();

            Check.That(romanNumeralConverter.ConvertToRomanNumber(7)).Equals("VII");
        }

        [Test]
        public void return_VIII_when_Arabic_Number_Is_8()
        {
            var romanNumeralConverter = new RomanNumeralConverter();

            Check.That(romanNumeralConverter.ConvertToRomanNumber(8)).Equals("VIII");
        }


    }
}
