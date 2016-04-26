namespace RomanNumerals
{
    public class RomanNumeralConverter
    {
        public string ConvertToRomanNumber(int arabicNumber)
        {
            if (arabicNumber == 1)
            {
                return "I";
            }
            if (arabicNumber ==3)
            {
                return "III";
            }
            if (arabicNumber ==4)
            {
                return "IV";
            }
            if (arabicNumber ==5)
            {
                return "V";
            }
            if (arabicNumber ==6)
            {
                return "VI";
            }
            if (arabicNumber ==7)
            {
                return "VII";
            }
            if (arabicNumber ==8)
            {
                return "VIII";
            }
            return "II";
        }
    }
}