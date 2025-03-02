public static class RomanNumeralExtension
{
    public static string ToRoman(this int value)
    {
        //throw new NotImplementedException("You need to implement this method.");

        // switch on value being greater than 1000? and descending to value being < 5, with a special case for 4. For every time a letter is created, subtract its value from whatever the og value var is

        // is there a modulo in c#? Second iteration should try using modulo

        int decreasingValue = value;
        string solution = "";
        do
        {
            if(decreasingValue >= 1000)
            {
                decreasingValue -= 1000;
                solution += "M";
            } else if (decreasingValue >= 900)
            {
                decreasingValue -= 900;
                solution += "CM";
            }
            else if (decreasingValue >= 500)
            {
                decreasingValue -= 500;
                solution += "D";
            } else if (decreasingValue >= 400)
            {
                decreasingValue -= 400;
                solution += "CD";
            } else if (decreasingValue >= 100)
            {
                decreasingValue -= 100;
                solution += "C";
            }
            else if (decreasingValue >= 90)
            {
                decreasingValue -= 90;
                solution += "XC";
            }
            else if (decreasingValue >= 50)
            {
                decreasingValue -= 50;
                solution += "L";
            }
            else if (decreasingValue >= 40)
            {
                decreasingValue -= 40;
                solution += "XL";
            }
            else if (decreasingValue >= 10)
            {
                decreasingValue -= 10;
                solution += "X";
            } else if (decreasingValue >= 9)
            {
                decreasingValue -= 9;
                solution += "IX";
            }
            else if (decreasingValue >= 5)
            {
                decreasingValue -= 5;
                solution += "V";
            } else if (decreasingValue == 4)
            {
                decreasingValue -= 4;
                solution += "IV";
            } else
            {
                decreasingValue -= 1;
                solution += "I";
            }  
        } while (decreasingValue > 0);

        return solution;
    }
}